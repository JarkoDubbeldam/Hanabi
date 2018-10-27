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
  public partial class PlayerLobbyControl : UserControl {
    public PlayerLobbyControl(string username, bool isOwner, bool isSelf)  {
      InitializeComponent();
      PlayerName.Text = username;
      RemovePlayerButton.Visible = isOwner ^ isSelf;
      RemovePlayerButton.Text = isSelf ? "Leave" : "Kick";
    }

    public string Username => PlayerName.Text;

    public PlayerLobbyControl() {
      InitializeComponent();
    }

    private void groupBox1_Enter(object sender, EventArgs e) {

    }

    public event EventHandler RemovePlayerAction;

    private void RemovePlayerButtonOnClick(object sender, EventArgs e) {
      RemovePlayerAction?.Invoke(this, null);
    }
  }
}
