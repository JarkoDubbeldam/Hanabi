namespace LoginUI {
  partial class RegistrationDialog {
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
      this.PasswordTextbox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.UsernameTextbox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.RepeatPasswordBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.SubmitButton = new System.Windows.Forms.Button();
      this.cancelbutton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // PasswordTextbox
      // 
      this.PasswordTextbox.Location = new System.Drawing.Point(12, 69);
      this.PasswordTextbox.Name = "PasswordTextbox";
      this.PasswordTextbox.PasswordChar = '*';
      this.PasswordTextbox.Size = new System.Drawing.Size(163, 20);
      this.PasswordTextbox.TabIndex = 7;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 52);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Password";
      // 
      // UsernameTextbox
      // 
      this.UsernameTextbox.Location = new System.Drawing.Point(12, 25);
      this.UsernameTextbox.Name = "UsernameTextbox";
      this.UsernameTextbox.Size = new System.Drawing.Size(163, 20);
      this.UsernameTextbox.TabIndex = 5;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Username";
      // 
      // RepeatPasswordBox
      // 
      this.RepeatPasswordBox.Location = new System.Drawing.Point(12, 108);
      this.RepeatPasswordBox.Name = "RepeatPasswordBox";
      this.RepeatPasswordBox.PasswordChar = '*';
      this.RepeatPasswordBox.Size = new System.Drawing.Size(163, 20);
      this.RepeatPasswordBox.TabIndex = 9;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 92);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(90, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Repeat password";
      // 
      // SubmitButton
      // 
      this.SubmitButton.Location = new System.Drawing.Point(101, 134);
      this.SubmitButton.Name = "SubmitButton";
      this.SubmitButton.Size = new System.Drawing.Size(74, 23);
      this.SubmitButton.TabIndex = 10;
      this.SubmitButton.Text = "Submit";
      this.SubmitButton.UseVisualStyleBackColor = true;
      this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
      // 
      // cancelbutton
      // 
      this.cancelbutton.Location = new System.Drawing.Point(12, 134);
      this.cancelbutton.Name = "cancelbutton";
      this.cancelbutton.Size = new System.Drawing.Size(75, 23);
      this.cancelbutton.TabIndex = 11;
      this.cancelbutton.Text = "Cancel";
      this.cancelbutton.UseVisualStyleBackColor = true;
      this.cancelbutton.Click += new System.EventHandler(this.CancelButton_Click);
      // 
      // RegistrationDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(193, 177);
      this.Controls.Add(this.cancelbutton);
      this.Controls.Add(this.SubmitButton);
      this.Controls.Add(this.RepeatPasswordBox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.PasswordTextbox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.UsernameTextbox);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "RegistrationDialog";
      this.Text = "RegistrationDialog";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox PasswordTextbox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox UsernameTextbox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox RepeatPasswordBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button SubmitButton;
    private System.Windows.Forms.Button cancelbutton;
  }
}