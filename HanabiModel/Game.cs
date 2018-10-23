using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanabi.Model {
  public class Game {
    private readonly int numberOfPlayers;

    public Deck Deck { get; } = new Deck();
    public Board Board { get; } = new Board();
    public DiscardPile DiscardPile { get; } = new DiscardPile();

    public List<Player> Players { get; }
    public Hints Hints { get; private set; } = new Hints();
    public Errors Errors { get; private set; } = new Errors();

    public int Round { get; private set; } = 0;

    public int? GameEndsAt { get; private set; } = null;

    private IEnumerator<Player> CurrentPlayerIterator;
    public Player CurrentPlayer => CurrentPlayerIterator.Current;

    public Game(int numberOfPlayers) {
      Players = new List<Player>(numberOfPlayers);
      var numberOfCards = NumberOfCardsInAHand(numberOfPlayers);
      for (var i = 0; i < numberOfPlayers; i++) {
        var hand = new Hand(Deck.DrawMany(numberOfCards));
        var player = new Player(new Guid(), hand);
        Players.Add(player);
      }
      CurrentPlayerIterator = Players.InfiniteLoop().GetEnumerator();
      CurrentPlayerIterator.MoveNext();

      Deck.DeckIsEmpty += OnDeckIsEmpty;
      Errors.MaxErrorsReached += OnMaxErrorsReached;
      this.numberOfPlayers = numberOfPlayers;
    }

    private void OnMaxErrorsReached(object sender, EventArgs args) {
      OnGameEndTriggered(0);
    }

    private void OnDeckIsEmpty(object sender, EventArgs args) {
      OnGameEndTriggered(numberOfPlayers);
      Deck.DeckIsEmpty -= OnDeckIsEmpty; // Only want the notification the first time.
    }

    private void OnGameEndTriggered(int roundsLeft) {
      GameEndsAt = Round + roundsLeft;
    } 

    public static int NumberOfCardsInAHand(int numberOfPlayers) {
      switch (numberOfPlayers) {
        case 2:
        case 3:
          return 5;
        case 4:
        case 5:
          return 4;
        default:
          throw new ArgumentException("Invalid number of players, must be between 2 and 5");
      }
    }

    public void PlayCard(Player player, Guid cardID) {
      if (ValidatePlayerTurn(player)) {
        if (player.Hand.HasCard(cardID)) {
          var card = player.Hand.GetCard(cardID);

          Playcard(card.Card);
          DealCard(player);
          TurnEnd();
        }

      }
    }

    private void Playcard(Card card) {
      if (!Board.Play(card)) {
        DiscardPile.Discard(card);
        Errors++;
      } else {
        if (card.Value == Value.Five) {
          Hints++;
        }
      }
    }

    private void DealCard(Player player) {
      if (Deck.TryDraw(out Card? newcard)) {
        player.Hand.Add(newcard.Value);
      }
      
    }

    public void DiscardCard(Player player, Card card){
      if (ValidatePlayerTurn(player)) {
        DiscardPile.Discard(card);
        DealCard(player);
        Hints++;
        TurnEnd();
      }
    }

    public void GiveHint(Player sendingPlayer, Player receivingPlayer, object hint) {
      var validMove = true;
      validMove &= ValidatePlayerTurn(sendingPlayer);
      validMove &= sendingPlayer.PlayerID == receivingPlayer.PlayerID;
      validMove &= Hints.CanHint;
      if (validMove) {
        receivingPlayer.ReceiveHint(hint);
        Hints--;
        TurnEnd();
      }
    }

    private bool ValidatePlayerTurn(Player player) {
      return player.PlayerID == CurrentPlayer.PlayerID;
    }

    private void TurnEnd() {
      CurrentPlayerIterator.MoveNext();
      Round++;
      if(GameEndsAt.HasValue && Round >= GameEndsAt.Value) {
        GameEnd();
      }
    }

    private void GameEnd() {
      throw new NotImplementedException();
    }
  }
}
