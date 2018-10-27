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
  [ServiceBehavior(
    ConcurrencyMode = ConcurrencyMode.Single,
    InstanceContextMode = InstanceContextMode.PerCall)]
  public class GameService : IGameService {
    public GameService() {
    }

    public CreateGameResponse CreateGame(CreateGameRequest request) {
      var player = Connections.LoggedInPlayers.SingleOrDefault(x => x.PlayerID == request.PlayerId);
      if(player == null) {
        return null;
      }
      IGameServiceCallback callback = OperationContext.Current.GetCallbackChannel<IGameServiceCallback>();
      player.callbackChannel = callback;

      var newGame = new GameBuilder().Initialise(player, request.Gamename);
      GamesCollection.GamesUnderConstruction.Add(newGame.JoinID, newGame);

      NotifyPlayers(newGame);
      
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
      IGameServiceCallback callback = OperationContext.Current.GetCallbackChannel<IGameServiceCallback>();
      player.callbackChannel = callback;

      if (!GamesCollection.GamesUnderConstruction.TryGetValue(request.GameJoinCode, out GameBuilder game)) {
        return;
      }
      game.AddPlayer(player);

      NotifyPlayers(game);
      return;
    }

    private void NotifyPlayers(GameBuilder game) {
      List<Player> players = game.Players.ToList();
      var gamestate = new GameCreationState {
        GameID = game.GameID,
        GameName = game.Gamename,
        JoinCode = game.JoinID,
        Owner = game.Owner,
        Players = players
      };
      players.ForEach(
        delegate (Player player) {
          player.callbackChannel.PushGameCreationState(gamestate);
        });
    }

    public void RemoveFromGame(RemoveFromGameRequest request) {
      var player = Connections.LoggedInPlayers.SingleOrDefault(x => x.PlayerID == request.ActingPlayerID);
      if (player == null) {
        return;
      }
      var game = GamesCollection.GamesUnderConstruction.SingleOrDefault(x => x.Value.GameID == request.GameID).Value;
      if(game == null) {
        return;
      }

      var removedPlayer = game.Players.SingleOrDefault(x => x.Username == request.RemovedPlayerName);

      var canRemove = request.ActingPlayerID == game.Owner.PlayerID || player.Username == removedPlayer.Username;

      var isInGame = removedPlayer != null;
      if(isInGame && canRemove) {
        removedPlayer.callbackChannel.OnRemovedFromGame();
        game.RemovePlayer(removedPlayer);
        NotifyPlayers(game);
      }
    }




    public StartGameResponse StartGame(StartGameRequest request) {
      throw new NotImplementedException();
    }
  }
}
