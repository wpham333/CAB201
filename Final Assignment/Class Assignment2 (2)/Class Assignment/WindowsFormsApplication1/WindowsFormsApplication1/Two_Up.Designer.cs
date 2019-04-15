namespace WindowsFormsApplication1 {
    partial class Two_Up {
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.playerscoreLabel = new System.Windows.Forms.Label();
            this.playernumberLabel = new System.Windows.Forms.Label();
            this.computerscoreLabel = new System.Windows.Forms.Label();
            this.computernumberLabel = new System.Windows.Forms.Label();
            this.throwButton = new System.Windows.Forms.Button();
            this.againButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(155, 32);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // playerscoreLabel
            // 
            this.playerscoreLabel.AutoSize = true;
            this.playerscoreLabel.Location = new System.Drawing.Point(23, 147);
            this.playerscoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerscoreLabel.Name = "playerscoreLabel";
            this.playerscoreLabel.Size = new System.Drawing.Size(74, 13);
            this.playerscoreLabel.TabIndex = 2;
            this.playerscoreLabel.Text = "Player\'s Score";
            // 
            // playernumberLabel
            // 
            this.playernumberLabel.AutoSize = true;
            this.playernumberLabel.BackColor = System.Drawing.Color.White;
            this.playernumberLabel.Location = new System.Drawing.Point(99, 147);
            this.playernumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playernumberLabel.Name = "playernumberLabel";
            this.playernumberLabel.Size = new System.Drawing.Size(13, 13);
            this.playernumberLabel.TabIndex = 3;
            this.playernumberLabel.Text = "0";
            // 
            // computerscoreLabel
            // 
            this.computerscoreLabel.AutoSize = true;
            this.computerscoreLabel.Location = new System.Drawing.Point(152, 147);
            this.computerscoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.computerscoreLabel.Name = "computerscoreLabel";
            this.computerscoreLabel.Size = new System.Drawing.Size(90, 13);
            this.computerscoreLabel.TabIndex = 4;
            this.computerscoreLabel.Text = "Computer\'s Score";
            // 
            // computernumberLabel
            // 
            this.computernumberLabel.AutoSize = true;
            this.computernumberLabel.BackColor = System.Drawing.Color.White;
            this.computernumberLabel.Location = new System.Drawing.Point(247, 147);
            this.computernumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.computernumberLabel.Name = "computernumberLabel";
            this.computernumberLabel.Size = new System.Drawing.Size(13, 13);
            this.computernumberLabel.TabIndex = 5;
            this.computernumberLabel.Text = "0";
            // 
            // throwButton
            // 
            this.throwButton.AutoSize = true;
            this.throwButton.Location = new System.Drawing.Point(25, 198);
            this.throwButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.throwButton.Name = "throwButton";
            this.throwButton.Size = new System.Drawing.Size(76, 23);
            this.throwButton.TabIndex = 6;
            this.throwButton.Text = "Throw Coins";
            this.throwButton.UseVisualStyleBackColor = true;
            this.throwButton.Click += new System.EventHandler(this.throwButton_Click);
            // 
            // againButton
            // 
            this.againButton.AutoSize = true;
            this.againButton.Location = new System.Drawing.Point(118, 198);
            this.againButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.againButton.Name = "againButton";
            this.againButton.Size = new System.Drawing.Size(67, 23);
            this.againButton.TabIndex = 7;
            this.againButton.Text = "Play Again";
            this.againButton.UseVisualStyleBackColor = true;
            this.againButton.Click += new System.EventHandler(this.againButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Location = new System.Drawing.Point(205, 198);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(81, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel Game";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Two_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 243);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.againButton);
            this.Controls.Add(this.throwButton);
            this.Controls.Add(this.computernumberLabel);
            this.Controls.Add(this.computerscoreLabel);
            this.Controls.Add(this.playernumberLabel);
            this.Controls.Add(this.playerscoreLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Two_Up";
            this.Text = "Two_Up";
            this.Load += new System.EventHandler(this.Two_Up_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label playerscoreLabel;
        private System.Windows.Forms.Label playernumberLabel;
        private System.Windows.Forms.Label computerscoreLabel;
        private System.Windows.Forms.Label computernumberLabel;
        private System.Windows.Forms.Button throwButton;
        private System.Windows.Forms.Button againButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}