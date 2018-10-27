using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginUI.GameService;
namespace LoginUI.Controls {
  public partial class GameLobbyControl : UserControl {
    public Guid GameID { get; }
    public int JoinCode { get; }
    public string Gamename { get; }

    public GameLobbyControl() {
      InitializeComponent();
    }

    public GameLobbyControl(string gamename, Guid gameID, int joinCode) {
      Gamename = gamename;
      GameID = gameID;
      JoinCode = joinCode;

      InitializeComponent();

      GameInformationLabel.Text = $"Game: {gamename}{Environment.NewLine}Joincode: {joinCode}";
    }

    public GameLobbyControl(string gamename, Guid gameID, int joinCode, string ownerName, string username, IEnumerable<Player> players) 
      : this(gamename, gameID, joinCode) {
      var isOwner = string.Compare(username, ownerName, true) == 0;
      StartGameButton.Visible = isOwner;
      foreach(var player in players) {
        var isSelf = string.Compare(username, player.Username, true) == 0;
        var control = new PlayerLobbyControl(player.Username, isOwner, isSelf);
        control.RemovePlayerAction += OnPlayerRemove;
        PlayersPanel.Controls.Add(control);
      }
    }

    public event EventHandler GameStartAction;
    public event EventHandler<RemovePlayerEventArgs> RemovePlayer;

    private void StartGameButton_Click(object sender, EventArgs e) {
      GameStartAction?.Invoke(this, null);
    }

    private void OnPlayerRemove(object sender, EventArgs e) {
      var playerSender = (PlayerLobbyControl)sender;
      var args = new RemovePlayerEventArgs {
        GameID = GameID,
        RemovedPlayerName = playerSender.Username
      };

      RemovePlayer?.Invoke(this, args);
    }
  }
}
