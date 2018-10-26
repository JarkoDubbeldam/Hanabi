using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginUI.GameService;
using System.ServiceModel;
namespace LoginUI {
  [CallbackBehavior(UseSynchronizationContext = false)]
  public class GameServiceCallbackHandler : IGameServiceCallback {
    public void PushGameCreationState(GameCreationState gameCreationState) {
      var players = gameCreationState.Players;
      var args = new GameCreationStateChangedEventArgs {
        Players = players,
        OwnerID = gameCreationState.Owner.PlayerID
      };

      GameCreationStateChanged?.Invoke(this, args);
    }

    public event EventHandler<GameCreationStateChangedEventArgs> GameCreationStateChanged;

    public class GameCreationStateChangedEventArgs : EventArgs {
      public Guid OwnerID;
      public Player[] Players;
    }
  }
}
