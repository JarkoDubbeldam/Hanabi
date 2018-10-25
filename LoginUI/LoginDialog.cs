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
  public partial class LoginDialog : Form {

    public LoginDialog() {
      InitializeComponent();
      this.AcceptButton = Loginbutton;
    }

    private async void Loginbutton_Click(object sender, EventArgs e) {
      var username = UsernameTextbox.Text;
      var pass = PasswordTextbox.Text;


      var request = AuthenticatorService.GetCredentials(UsernameTextbox.Text, PasswordTextbox.Text);

      var result = await AuthenticatorService.Service.AuthenticateUserAsync(request);
      if (result.UserID != null) {
        MessageBox.Show("Success!");
      } else {
        MessageBox.Show($"Failure: {result.FailureReason}");
      }
    }

    private void RegisterButton_Click(object sender, EventArgs e) {
      this.Hide();
      var registrator = new RegistrationDialog(this);
      registrator.Show();
    }
  }
}
