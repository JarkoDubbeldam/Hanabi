using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using GameService.Contract;
using GameService.Model;
namespace GameService {
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GameService" in code, svc and config file together.
  // NOTE: In order to launch WCF Test Client for testing this service, please select GameService.svc or GameService.svc.cs at the Solution Explorer and start debugging.
  public class GameService : IGameService {
    IGameServiceCallback callback = null;
    public GameService() {
      callback = OperationContext.Current.GetCallbackChannel<IGameServiceCallback>();
    }

    public CreateGameResponse CreateGame(CreateGameRequest request) {
      var player = Connections.LoggedInPlayers.SingleOrDefault(x => x.PlayerID == request.PlayerId);
      if(player == null) {
        return null;
      }
      player.callbackChannel = callback;

      var newGame = new GameBuilder().Initialise(player, request.Gamename);
      GamesCollection.GamesUnderConstruction.Add(newGame.JoinID, newGame);
      
      return new CreateGameResponse {
        GameName = request.Gamename,
        JoinCode = newGame.JoinID
      };
    }

    public void JoinGame(JoinGameRequest request) {
      var player = Connections.LoggedInPlayers.SingleOrDefault(x => x.PlayerID == request.PlayerID);
      if (player == null) {
        return;
      }
      player.callbackChannel = callback;

      if (!GamesCollection.GamesUnderConstruction.TryGetValue(request.GameJoinCode, out GameBuilder game)) {
        return;
      }
      game.AddPlayer(player);

      var gamestate = new GameCreationState {
        GameID = game.GameID,
        Owner = game.Owner,
        Players = game.Players.ToList()
      };
      callback.PushGameCreationState(gamestate);
      //NotifyPlayers(game);
      return;
    }

    private void NotifyPlayers(GameBuilder game) {
      var gamestate = new GameCreationState {
        GameID = game.GameID,
        Owner = game.Owner,
        Players = game.Players.ToList()
      };
      foreach (var participant in game.Players) {
        participant.callbackChannel.PushGameCreationState(gamestate);
      }
    }

    public KickFromGameResponse KickFromGame(KickFromGameRequest request) {
      throw new NotImplementedException();
    }

    public StartGameResponse StartGame(StartGameRequest request) {
      throw new NotImplementedException();
    }
  }
}
