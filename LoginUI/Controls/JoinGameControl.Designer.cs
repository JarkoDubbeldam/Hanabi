namespace LoginUI {
  partial class JoinGameControl {
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
      this.JoinButton = new System.Windows.Forms.Button();
      this.GameIDNumBox = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.GameIDNumBox)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.JoinButton);
      this.groupBox1.Controls.Add(this.GameIDNumBox);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(4, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(119, 100);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Join game";
      // 
      // JoinButton
      // 
      this.JoinButton.Location = new System.Drawing.Point(10, 64);
      this.JoinButton.Name = "JoinButton";
      this.JoinButton.Size = new System.Drawing.Size(103, 23);
      this.JoinButton.TabIndex = 2;
      this.JoinButton.Text = "Join";
      this.JoinButton.UseVisualStyleBackColor = true;
      this.JoinButton.Click += new System.EventHandler(this.JoinButton_Click);
      // 
      // GameIDNumBox
      // 
      this.GameIDNumBox.Location = new System.Drawing.Point(10, 37);
      this.GameIDNumBox.Name = "GameIDNumBox";
      this.GameIDNumBox.Size = new System.Drawing.Size(103, 20);
      this.GameIDNumBox.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(40, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Join ID";
      // 
      // JoinGameControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.groupBox1);
      this.Name = "JoinGameControl";
      this.Size = new System.Drawing.Size(132, 111);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.GameIDNumBox)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button JoinButton;
    private System.Windows.Forms.NumericUpDown GameIDNumBox;
    private System.Windows.Forms.Label label1;
  }
}
