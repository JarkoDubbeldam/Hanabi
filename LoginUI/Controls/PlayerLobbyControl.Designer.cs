namespace LoginUI.Controls {
  partial class PlayerLobbyControl {
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.RemovePlayerButton = new System.Windows.Forms.Button();
      this.PlayerName = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.RemovePlayerButton);
      this.groupBox1.Controls.Add(this.PlayerName);
      this.groupBox1.Location = new System.Drawing.Point(4, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(216, 49);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
      // 
      // RemovePlayerButton
      // 
      this.RemovePlayerButton.Location = new System.Drawing.Point(150, 15);
      this.RemovePlayerButton.Name = "RemovePlayerButton";
      this.RemovePlayerButton.Size = new System.Drawing.Size(60, 23);
      this.RemovePlayerButton.TabIndex = 1;
      this.RemovePlayerButton.Text = "Kick";
      this.RemovePlayerButton.UseVisualStyleBackColor = true;
      this.RemovePlayerButton.Click += new System.EventHandler(this.RemovePlayerButtonOnClick);
      // 
      // PlayerName
      // 
      this.PlayerName.AutoSize = true;
      this.PlayerName.Location = new System.Drawing.Point(7, 20);
      this.PlayerName.Name = "PlayerName";
      this.PlayerName.Size = new System.Drawing.Size(0, 13);
      this.PlayerName.TabIndex = 0;
      // 
      // PlayerLobbyControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.groupBox1);
      this.Name = "PlayerLobbyControl";
      this.Size = new System.Drawing.Size(231, 63);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label PlayerName;
    private System.Windows.Forms.Button RemovePlayerButton;
  }
}
