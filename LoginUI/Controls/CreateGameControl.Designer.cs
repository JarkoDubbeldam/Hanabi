namespace LoginUI {
  partial class CreateGameControl {
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
      this.label1 = new System.Windows.Forms.Label();
      this.GameNameBox = new System.Windows.Forms.TextBox();
      this.CreateGameButton = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.CreateGameButton);
      this.groupBox1.Controls.Add(this.GameNameBox);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(3, 3);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(136, 100);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Create game";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(64, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Game name";
      // 
      // GameNameBox
      // 
      this.GameNameBox.Location = new System.Drawing.Point(7, 37);
      this.GameNameBox.Name = "GameNameBox";
      this.GameNameBox.Size = new System.Drawing.Size(123, 20);
      this.GameNameBox.TabIndex = 1;
      // 
      // CreateGameButton
      // 
      this.CreateGameButton.Location = new System.Drawing.Point(6, 63);
      this.CreateGameButton.Name = "CreateGameButton";
      this.CreateGameButton.Size = new System.Drawing.Size(124, 23);
      this.CreateGameButton.TabIndex = 2;
      this.CreateGameButton.Text = "Create game";
      this.CreateGameButton.UseVisualStyleBackColor = true;
      this.CreateGameButton.Click += new System.EventHandler(this.CreateGameButton_Click);
      // 
      // CreateGameControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.groupBox1);
      this.Name = "CreateGameControl";
      this.Size = new System.Drawing.Size(146, 109);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button CreateGameButton;
    private System.Windows.Forms.TextBox GameNameBox;
    private System.Windows.Forms.Label label1;
  }
}
