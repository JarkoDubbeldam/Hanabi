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

namespace LoginUI {
  public partial class RegistrationDialog : Form {
    private readonly LoginDialog sender;

    public RegistrationDialog(LoginDialog sender) {
      InitializeComponent();
      this.AcceptButton = SubmitButton;
      this.CancelButton = cancelbutton;
      this.sender = sender;
    }

    private async void SubmitButton_Click(object sender, EventArgs e) {
      if (!ValidatePasswords()) {
        MessageBox.Show("Passwords don't match.");
        return;
      }
      var request = new PlayerCredentials {
        PlayerNickname = UsernameTextbox.Text,
        Password = PasswordTextbox.Text
      };

      var result = await AuthenticatorService.Service.RegisterPlayerAsync(request);
      if(result.PlayerID == null) {
        MessageBox.Show("Username already taken");
        return;
      }
      this.Close();
      this.sender.Show();
    }

    private bool ValidatePasswords() {
      return PasswordTextbox.Text == RepeatPasswordBox.Text;
    }

    private void CancelButton_Click(object sender, EventArgs e) {
      this.Close();
      this.sender.Show();
    }
  }
}
