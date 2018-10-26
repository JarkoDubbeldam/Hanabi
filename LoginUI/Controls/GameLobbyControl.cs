using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginUI.Controls {
  public partial class GameLobbyControl : UserControl {
    public GameLobbyControl() {
      InitializeComponent();
    }


    public void AddPlayer(PlayerLobbyControl player) {
      flowLayoutPanel1.Controls.Add(player);
    }

    public event EventHandler GameStartAction;

    private void StartGameButton_Click(object sender, EventArgs e) {
      GameStartAction?.Invoke(this, null);
    }

    public void AddGameInformation(string gameName, int joinCode) {
      GameInformationLabel.Text = $"Game: {gameName}{Environment.NewLine}Joincode: {joinCode}";
    }
  }
}
