using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hanabi.Model;

namespace Hanabi.Controller {
  public class Controller : IHanabi {
    public static Controller Instance { get; }
    private Dictionary<Guid, Game> games;

    static Controller() {
      Instance = new Controller();
    }
    
    private Controller() {
      games = new Dictionary<Guid, Game>();
    }


    

    public Guid CreateGame(int numberOfPlayers) {
      var id = new Guid();
      games.Add(id, new Game(numberOfPlayers));
      return id;
    }

    public GameStateResponse GetGameState(Guid gameID, Guid playerID) {
      if(!games.TryGetValue(gameID, out Game game)) {
        return null;
      }
      var player = game.Players.SingleOrDefault(x => x.PlayerID == playerID);
      if(player == null) {
        return null;
      }
      var hiddenCards = player.Hand.Cards.Select(x => x.Key).ToList();
      var visibleCards = game.Players
        .Where(x => x.PlayerID != playerID)
        .Select(x => new { ID = x.PlayerID, Cards = (IReadOnlyList<Card>)x.Hand.Cards.Select(y => y.Value.Card).ToList() })
        .ToDictionary(key => key.ID, value => value.Cards);

      var response = new GameStateResponse {
        GameID = gameID,
        CurrentPlayerId = game.CurrentPlayer.PlayerID,
        Players = game.Players.Select(x => x.PlayerID).ToList(),
        RoundNumber = game.Round,
        Score = game.Board.GetScore(),
        Errors = game.Errors.NumberOfErrors,
        Hints = game.Hints.NumberOfHints,
        BoardCards = game.Board.Cards,
        DiscardPile = game.DiscardPile.Cards,
        NumberOfCardsLeft = game.Deck.NumberOfCards,
        HiddenCards = hiddenCards,
        VisibleCards = visibleCards
      };
      return response;
    }

    public GameStateResponse MakeMove(MoveRequest request) {
      throw new NotImplementedException();
    }
  }
}
