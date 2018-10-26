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
  public partial class CreateGameControl : UserControl {
    public CreateGameControl() {
      InitializeComponent();
    }

    public class CreateGameEventArgs : EventArgs {
      public string GameName { get; set; }
    }

    public event EventHandler<CreateGameEventArgs> CreateGameAction;

    private void CreateGameButton_Click(object sender, EventArgs e) {
      if(CreateGameAction != null) {
        var args = new CreateGameEventArgs { GameName = GameNameBox.Text };
        CreateGameAction(this, args);
      }
    }
  }
}
