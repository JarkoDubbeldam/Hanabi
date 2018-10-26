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
    public PlayerLobbyControl(string username, bool owner) : base() {
      PlayerName.Text = username;
      KickPlayerButton.Visible = owner;
    }

    public string Username => PlayerName.Text;

    public PlayerLobbyControl() {
      InitializeComponent();
    }

    private void groupBox1_Enter(object sender, EventArgs e) {

    }

    public event EventHandler KickPlayerAction;

    private void KickPlayerButton_Click(object sender, EventArgs e) {
      KickPlayerAction?.Invoke(this, null);
    }
  }
}
