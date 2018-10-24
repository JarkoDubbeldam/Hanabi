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
      if (!await CheckUsernameAvailability()) {
        MessageBox.Show("Username already taken.");
        return;
      }
      if (!ValidatePasswords()) {
        MessageBox.Show("Passwords don't match.");
        return;
      }
      var request = new PlayerCredentials {
        PlayerNickname = UsernameTextbox.Text,
        Password = PasswordTextbox.Text
      };

      await AuthenticatorService.Service.RegisterPlayerAsync(request);
      this.Close();
      this.sender.Show();
    }

    private bool ValidatePasswords() {
      return PasswordTextbox.Text == RepeatPasswordBox.Text;
    }
    private async Task<bool> CheckUsernameAvailability() {
      return await AuthenticatorService.Service.UsernameAvailableAsync(UsernameTextbox.Text);
    }

    private void CancelButton_Click(object sender, EventArgs e) {
      this.Close();
      this.sender.Show();
    }
  }
}
