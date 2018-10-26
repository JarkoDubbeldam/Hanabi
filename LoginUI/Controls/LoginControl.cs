using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LoginUI.LoginService;

namespace LoginUI {
  public partial class LoginControl : UserControl {
    public LoginControl() {
      InitializeComponent();
      Application.ApplicationExit += OnExit;
      ToggleVisiblity(false, null);
    }


    public class LoggedInStateChangedEventArgs : EventArgs {
      public bool LoggedIn { get; set; }
      public Guid? UserID { get; set; }
    }

    public event EventHandler<LoggedInStateChangedEventArgs> LoggedInStateChanged;

    private async void Loginbutton_Click(object sender, EventArgs e) {
      var username = UsernameTextbox.Text;
      var pass = PasswordTextbox.Text;


      var request = AuthenticatorService.GetCredentials(UsernameTextbox.Text, PasswordTextbox.Text);

      var result = await AuthenticatorService.Service.AuthenticateUserAsync(request);
      if (result.UserID != null) {
        ToggleVisiblity(true, result.UserID);
        Usernamelabel.Text = $"Logged in as {username}.";
      } else {
        MessageBox.Show($"Failure: {result.FailureReason}");
      }
    }

    private void RegisterButton_Click(object sender, EventArgs e) {
      var registrator = new RegistrationDialog();
      registrator.Show();
    }

    private async void OnExit(object sender, EventArgs e) {
      await LogOut();
    }

    private async Task LogOut() {
      await AuthenticatorService.Service.LogOffAsync();
    }

    private void ToggleVisiblity(bool loggedIn, Guid? userID) {
      var args = new LoggedInStateChangedEventArgs { LoggedIn = loggedIn, UserID = userID };
      LoggedInStateChanged?.Invoke(this, args);

      Usernamelabel.Visible = loggedIn;
      LogoutButton.Visible = loggedIn;
      label1.Visible = !loggedIn;
      label2.Visible = !loggedIn;
      RegisterButton.Visible = !loggedIn;
      Loginbutton.Visible = !loggedIn;
      UsernameTextbox.Visible = !loggedIn;
      PasswordTextbox.Visible = !loggedIn;
    }

    private async void LogoutButton_Click(object sender, EventArgs e) {
      ToggleVisiblity(false, null);
      await LogOut();
    }
  }
}
