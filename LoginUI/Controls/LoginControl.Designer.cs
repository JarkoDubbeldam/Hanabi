namespace LoginUI {
  partial class LoginControl {
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.RegisterButton = new System.Windows.Forms.Button();
      this.Loginbutton = new System.Windows.Forms.Button();
      this.PasswordTextbox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.UsernameTextbox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.Usernamelabel = new System.Windows.Forms.Label();
      this.LogoutButton = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // RegisterButton
      // 
      this.RegisterButton.Location = new System.Drawing.Point(6, 116);
      this.RegisterButton.Name = "RegisterButton";
      this.RegisterButton.Size = new System.Drawing.Size(66, 23);
      this.RegisterButton.TabIndex = 11;
      this.RegisterButton.Text = "Register";
      this.RegisterButton.UseVisualStyleBackColor = true;
      this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
      // 
      // Loginbutton
      // 
      this.Loginbutton.Location = new System.Drawing.Point(102, 116);
      this.Loginbutton.Name = "Loginbutton";
      this.Loginbutton.Size = new System.Drawing.Size(67, 23);
      this.Loginbutton.TabIndex = 10;
      this.Loginbutton.Text = "Login";
      this.Loginbutton.UseVisualStyleBackColor = true;
      this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
      // 
      // PasswordTextbox
      // 
      this.PasswordTextbox.Location = new System.Drawing.Point(6, 76);
      this.PasswordTextbox.Name = "PasswordTextbox";
      this.PasswordTextbox.PasswordChar = '*';
      this.PasswordTextbox.Size = new System.Drawing.Size(163, 20);
      this.PasswordTextbox.TabIndex = 9;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 59);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "Password";
      // 
      // UsernameTextbox
      // 
      this.UsernameTextbox.Location = new System.Drawing.Point(6, 32);
      this.UsernameTextbox.Name = "UsernameTextbox";
      this.UsernameTextbox.Size = new System.Drawing.Size(163, 20);
      this.UsernameTextbox.TabIndex = 7;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Username";
      // 
      // Usernamelabel
      // 
      this.Usernamelabel.AutoSize = true;
      this.Usernamelabel.Location = new System.Drawing.Point(43, 55);
      this.Usernamelabel.Name = "Usernamelabel";
      this.Usernamelabel.Size = new System.Drawing.Size(0, 13);
      this.Usernamelabel.TabIndex = 12;
      this.Usernamelabel.Visible = false;
      // 
      // LogoutButton
      // 
      this.LogoutButton.Location = new System.Drawing.Point(46, 87);
      this.LogoutButton.Name = "LogoutButton";
      this.LogoutButton.Size = new System.Drawing.Size(75, 23);
      this.LogoutButton.TabIndex = 13;
      this.LogoutButton.Text = "Logout";
      this.LogoutButton.UseVisualStyleBackColor = true;
      this.LogoutButton.Visible = false;
      this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.LogoutButton);
      this.groupBox1.Controls.Add(this.UsernameTextbox);
      this.groupBox1.Controls.Add(this.Usernamelabel);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.RegisterButton);
      this.groupBox1.Controls.Add(this.PasswordTextbox);
      this.groupBox1.Controls.Add(this.Loginbutton);
      this.groupBox1.Location = new System.Drawing.Point(3, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(179, 147);
      this.groupBox1.TabIndex = 14;
      this.groupBox1.TabStop = false;
      // 
      // LoginControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.groupBox1);
      this.Name = "LoginControl";
      this.Size = new System.Drawing.Size(188, 153);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button RegisterButton;
    private System.Windows.Forms.Button Loginbutton;
    private System.Windows.Forms.TextBox PasswordTextbox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox UsernameTextbox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label Usernamelabel;
    private System.Windows.Forms.Button LogoutButton;
    private System.Windows.Forms.GroupBox groupBox1;
  }
}
