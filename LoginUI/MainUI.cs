using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using LoginUI.GameService;
using System.ServiceModel;
using LoginUI.Controls;
namespace LoginUI {
  [CallbackBehavior(
    ConcurrencyMode = ConcurrencyMode.Single,
    UseSynchronizationContext = false)]
  public partial class MainUI : Form, GameServiceCallback {
    private SynchronizationContext uiSyncContext = null;
    private GameServiceClient GameService = null;
    private Guid? PlayerID;
    private string Username;

    public MainUI() {
      Initialize();
    }

    private void Initialize() {
      InitializeComponent();
      BindEvents();
    }

    private void MainUI_OnLoad(object sender, EventArgs e) {
      

      uiSyncContext = SynchronizationContext.Current;
      GameService = new GameServiceClient(new InstanceContext(this));
      GameService.Open();
    }

    private void BindEvents() {
      gameLobbyControl1.Visible = false;
      createGameControl1.Visible = false;
      joinGameControl1.Visible = false;

      loginControl1.LoggedInStateChanged += OnLoggedInStateChanged;
      createGameControl1.CreateGameAction += OnCreateGameAction;
      joinGameControl1.JoinGameAction += OnJoinGameAction;
      gameLobbyControl1.RemovePlayer += OnPlayerRemovedAction;
    }

    private void MainUI_FormClosing(object sender, EventArgs e) {
      loginControl1.LogOut().Wait();
      GameService.Close();
    }

    private void OnLoggedInStateChanged(object sender, LoginControl.LoggedInStateChangedEventArgs args) {
      gameLobbyControl1.Visible &= args.LoggedIn;
      createGameControl1.Visible = args.LoggedIn;
      joinGameControl1.Visible = args.LoggedIn;
      PlayerID = args.UserID;
      Username = args.Username;
      if (!args.LoggedIn) {
        Initialize();
      }
    }

    private void OnGameCreationStateChanged(object sender, GameCreationStateChangedEventArgs args) {
      Controls.Remove(gameLobbyControl1);
      GameCreationState state = args.GameCreationState;
      var players = state.Players;
      gameLobbyControl1 = new GameLobbyControl(state.GameName, state.GameID, state.JoinCode, state.Owner.Username, Username, players) {
        Visible = true
      };
      this.Controls.Add(gameLobbyControl1);
      gameLobbyControl1.RemovePlayer += OnPlayerRemovedAction;
    }

    private async void OnCreateGameAction(object sender, CreateGameControl.CreateGameEventArgs args) {
      if (PlayerID.HasValue) {

        var request = new CreateGameRequest {
          PlayerId = PlayerID.Value,
          Gamename = args.GameName
        };

        var result = await GameService.CreateGameAsync(request);
        if (result != null) {
          gameLobbyControl1.Visible = true;
        }
      }
    }

    private async void OnJoinGameAction(object sender, JoinGameControl.JoinEventArgs args) {
      if (PlayerID.HasValue) {
        var request = new JoinGameRequest {
          GameJoinCode = args.JoinID,
          PlayerID = PlayerID.Value
        };

        await GameService.JoinGameAsync(request);
      }
    }

    public void PushGameCreationState(GameCreationState gameCreationState) {
      SendOrPostCallback callback =
        delegate (object state) {
          var players = gameCreationState.Players;
          var args = new GameCreationStateChangedEventArgs {
            GameCreationState = gameCreationState
          };
          OnGameCreationStateChanged(this, args);
        };

      uiSyncContext.Post(callback, gameCreationState);
    }

    public void OnRemovedFromGame() {
      SendOrPostCallback callback =
        delegate (object state) {
          Controls.Remove(gameLobbyControl1);
          gameLobbyControl1 = new GameLobbyControl();
          gameLobbyControl1.RemovePlayer += OnPlayerRemovedAction;
        };
      uiSyncContext.Post(callback, this);
    }

    public async void OnPlayerRemovedAction(object sender, RemovePlayerEventArgs args) {
      if (PlayerID.HasValue) {
        var request = new RemoveFromGameRequest {
          GameID = args.GameID,
          ActingPlayerID = PlayerID.Value,
          RemovedPlayerName = args.RemovedPlayerName
        };

        await GameService.RemoveFromGameAsync(request);
      }
    }
  }
}
