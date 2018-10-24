namespace LoginUI {
  partial class LoginDialog {
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
      this.label1 = new System.Windows.Forms.Label();
      this.UsernameTextbox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.PasswordTextbox = new System.Windows.Forms.TextBox();
      this.Loginbutton = new System.Windows.Forms.Button();
      this.RegisterButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Username";
      // 
      // UsernameTextbox
      // 
      this.UsernameTextbox.Location = new System.Drawing.Point(12, 25);
      this.UsernameTextbox.Name = "UsernameTextbox";
      this.UsernameTextbox.Size = new System.Drawing.Size(163, 20);
      this.UsernameTextbox.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 52);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Password";
      // 
      // PasswordTextbox
      // 
      this.PasswordTextbox.Location = new System.Drawing.Point(12, 69);
      this.PasswordTextbox.Name = "PasswordTextbox";
      this.PasswordTextbox.PasswordChar = '*';
      this.PasswordTextbox.Size = new System.Drawing.Size(163, 20);
      this.PasswordTextbox.TabIndex = 3;
      // 
      // Loginbutton
      // 
      this.Loginbutton.Location = new System.Drawing.Point(108, 109);
      this.Loginbutton.Name = "Loginbutton";
      this.Loginbutton.Size = new System.Drawing.Size(67, 23);
      this.Loginbutton.TabIndex = 4;
      this.Loginbutton.Text = "Login";
      this.Loginbutton.UseVisualStyleBackColor = true;
      this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
      // 
      // RegisterButton
      // 
      this.RegisterButton.Location = new System.Drawing.Point(12, 109);
      this.RegisterButton.Name = "RegisterButton";
      this.RegisterButton.Size = new System.Drawing.Size(66, 23);
      this.RegisterButton.TabIndex = 5;
      this.RegisterButton.Text = "Register";
      this.RegisterButton.UseVisualStyleBackColor = true;
      this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
      // 
      // LoginDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(196, 150);
      this.Controls.Add(this.RegisterButton);
      this.Controls.Add(this.Loginbutton);
      this.Controls.Add(this.PasswordTextbox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.UsernameTextbox);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "LoginDialog";
      this.Text = "LoginDialog";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox UsernameTextbox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox PasswordTextbox;
    private System.Windows.Forms.Button Loginbutton;
    private System.Windows.Forms.Button RegisterButton;
  }
}