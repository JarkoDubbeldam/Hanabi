using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginUI {
  public partial class JoinGameControl : UserControl {
    public JoinGameControl() {
      InitializeComponent();
      GameIDNumBox.Maximum = int.MaxValue;
    }

    public event EventHandler<JoinEventArgs> JoinGameAction;

    public class JoinEventArgs : EventArgs {
      public int JoinID { get; set; }
    }

    private void JoinButton_Click(object sender, EventArgs e) {
      if(JoinGameAction != null) {
        var args = new JoinEventArgs { JoinID = (int)GameIDNumBox.Value };
        JoinGameAction(this, args);
      }
    }
  }
}
