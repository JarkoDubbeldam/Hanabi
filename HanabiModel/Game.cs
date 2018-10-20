using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanabi.Model {
  class Game {
    public Deck Deck { get; } = new Deck();
    public Board Board { get; } = new Board();
    public DiscardPile DiscardPile { get; } = new DiscardPile();

    public List<Player> Players { get; }
    public Hints Hints { get; } = new Hints();



    public Game(int numberOfPlayers) {
      Players = new List<Player>(numberOfPlayers);
      var numberOfCards = NumberOfCardsInAHand(numberOfPlayers);
      for (var i = 0; i < numberOfPlayers; i++) {
        var hand = new Hand(Deck.DrawMany(numberOfCards));
        var player = new Player(i, hand);
        Players.Add(player);
      }

      Deck.DeckIsEmpty += OnDeckIsEmpty;
    }

    private void OnDeckIsEmpty(object sender, EventArgs args) {
      throw new NotImplementedException();
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
  }
}
