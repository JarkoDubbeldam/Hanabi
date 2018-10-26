namespace LoginUI.Controls {
  partial class GameLobbyControl {
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
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.StartGameButton = new System.Windows.Forms.Button();
      this.GameInformationLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.AutoSize = true;
      this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 86);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(237, 172);
      this.flowLayoutPanel1.TabIndex = 0;
      // 
      // StartGameButton
      // 
      this.StartGameButton.Location = new System.Drawing.Point(20, 57);
      this.StartGameButton.Name = "StartGameButton";
      this.StartGameButton.Size = new System.Drawing.Size(237, 23);
      this.StartGameButton.TabIndex = 1;
      this.StartGameButton.Text = "Start game";
      this.StartGameButton.UseVisualStyleBackColor = true;
      this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
      // 
      // GameInformationLabel
      // 
      this.GameInformationLabel.AutoSize = true;
      this.GameInformationLabel.Location = new System.Drawing.Point(20, 4);
      this.GameInformationLabel.Name = "GameInformationLabel";
      this.GameInformationLabel.Size = new System.Drawing.Size(0, 13);
      this.GameInformationLabel.TabIndex = 2;
      // 
      // GameLobbyControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.Controls.Add(this.GameInformationLabel);
      this.Controls.Add(this.StartGameButton);
      this.Controls.Add(this.flowLayoutPanel1);
      this.Name = "GameLobbyControl";
      this.Size = new System.Drawing.Size(280, 271);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.Button StartGameButton;
    private System.Windows.Forms.Label GameInformationLabel;
  }
}
