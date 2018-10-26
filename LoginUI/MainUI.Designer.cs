namespace LoginUI {
  partial class MainUI {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.loginControl1 = new LoginUI.LoginControl();
      this.joinGameControl1 = new LoginUI.JoinGameControl();
      this.createGameControl1 = new LoginUI.CreateGameControl();
      this.gameLobbyControl1 = new LoginUI.Controls.GameLobbyControl();
      this.SuspendLayout();
      // 
      // loginControl1
      // 
      this.loginControl1.Location = new System.Drawing.Point(474, 12);
      this.loginControl1.Name = "loginControl1";
      this.loginControl1.Size = new System.Drawing.Size(188, 153);
      this.loginControl1.TabIndex = 4;
      // 
      // joinGameControl1
      // 
      this.joinGameControl1.Location = new System.Drawing.Point(530, 171);
      this.joinGameControl1.Name = "joinGameControl1";
      this.joinGameControl1.Size = new System.Drawing.Size(132, 111);
      this.joinGameControl1.TabIndex = 3;
      // 
      // createGameControl1
      // 
      this.createGameControl1.Location = new System.Drawing.Point(516, 288);
      this.createGameControl1.Name = "createGameControl1";
      this.createGameControl1.Size = new System.Drawing.Size(146, 109);
      this.createGameControl1.TabIndex = 2;
      // 
      // gameLobbyControl1
      // 
      this.gameLobbyControl1.AutoScroll = true;
      this.gameLobbyControl1.Location = new System.Drawing.Point(12, 12);
      this.gameLobbyControl1.Name = "gameLobbyControl1";
      this.gameLobbyControl1.Size = new System.Drawing.Size(396, 385);
      this.gameLobbyControl1.TabIndex = 5;
      // 
      // MainUI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(674, 405);
      this.Controls.Add(this.gameLobbyControl1);
      this.Controls.Add(this.loginControl1);
      this.Controls.Add(this.joinGameControl1);
      this.Controls.Add(this.createGameControl1);
      this.Name = "MainUI";
      this.Text = "MainUI";
      this.ResumeLayout(false);

    }

    #endregion
    private CreateGameControl createGameControl1;
    private JoinGameControl joinGameControl1;
    private LoginControl loginControl1;
    private Controls.GameLobbyControl gameLobbyControl1;
  }
}