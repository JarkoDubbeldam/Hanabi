using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginUI.GameService;
using System.ServiceModel;
using LoginUI.Controls;
namespace LoginUI {
  public partial class MainUI : Form {
    private IGameService GameService;
    private GameServiceCallbackHandler callback;

    public Guid? PlayerID;

    public MainUI() {
      callback = new GameServiceCallbackHandler();
      callback.GameCreationStateChanged += OnGameCreationStateChanged;

      var site = new InstanceContext(callback);
      GameService = new GameServiceClient(site, "WSDualHttpBinding_IGameService");


      InitializeComponent();
      gameLobbyControl1.Visible = false;
      createGameControl1.Visible = false;
      joinGameControl1.Visible = false;

      loginControl1.LoggedInStateChanged += OnLoggedInStateChanged;
      createGameControl1.CreateGameAction += OnCreateGameAction;
      joinGameControl1.JoinGameAction += OnJoinGameAction;
    }

    private void OnLoggedInStateChanged(object sender, LoginControl.LoggedInStateChangedEventArgs args) {
      gameLobbyControl1.Visible &= args.LoggedIn;
      createGameControl1.Visible = args.LoggedIn;
      joinGameControl1.Visible = args.LoggedIn;
      PlayerID = args.UserID;
    }

    private void OnGameCreationStateChanged(object sender, GameServiceCallbackHandler.GameCreationStateChangedEventArgs args) {
      gameLobbyControl1.Visible = true;
      var owner = PlayerID == args.OwnerID;
      var players = args.Players;
      foreach(var player in players) {
        var playerControl = new PlayerLobbyControl(player.Username, owner);
        gameLobbyControl1.AddPlayer(playerControl);
      }
    }

    private async void OnCreateGameAction(object sender, CreateGameControl.CreateGameEventArgs args) {
      if (PlayerID.HasValue) {

        var request = new CreateGameRequest {
          PlayerId = PlayerID.Value,
          Gamename = args.GameName
        };

        var result = await GameService.CreateGameAsync(request);
        if (result != null) {
          gameLobbyControl1.AddGameInformation(result.GameName, result.JoinCode);
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
  }
}
