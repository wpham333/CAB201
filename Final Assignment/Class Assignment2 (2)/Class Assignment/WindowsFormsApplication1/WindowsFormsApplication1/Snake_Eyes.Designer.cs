namespace WindowsFormsApplication1 {
    partial class Snake_Eyes {
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
            this.first_rollLabel = new System.Windows.Forms.Label();
            this.dummyLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.houseLabel = new System.Windows.Forms.Label();
            this.playerscoreLabel = new System.Windows.Forms.Label();
            this.housescoreLabel = new System.Windows.Forms.Label();
            this.rollPictureBox2 = new System.Windows.Forms.PictureBox();
            this.rollPictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.playagainButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rollPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // first_rollLabel
            // 
            this.first_rollLabel.AutoSize = true;
            this.first_rollLabel.Location = new System.Drawing.Point(102, 16);
            this.first_rollLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.first_rollLabel.Name = "first_rollLabel";
            this.first_rollLabel.Size = new System.Drawing.Size(47, 13);
            this.first_rollLabel.TabIndex = 0;
            this.first_rollLabel.Text = "First Roll";
            // 
            // dummyLabel
            // 
            this.dummyLabel.AutoSize = true;
            this.dummyLabel.Location = new System.Drawing.Point(91, 83);
            this.dummyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dummyLabel.Name = "dummyLabel";
            this.dummyLabel.Size = new System.Drawing.Size(66, 13);
            this.dummyLabel.TabIndex = 1;
            this.dummyLabel.Text = "Dummy Text";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(8, 108);
            this.playerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(74, 13);
            this.playerLabel.TabIndex = 3;
            this.playerLabel.Text = "Player\'s Score";
            // 
            // houseLabel
            // 
            this.houseLabel.AutoSize = true;
            this.houseLabel.Location = new System.Drawing.Point(169, 108);
            this.houseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.houseLabel.Name = "houseLabel";
            this.houseLabel.Size = new System.Drawing.Size(69, 13);
            this.houseLabel.TabIndex = 2;
            this.houseLabel.Text = "House Score";
            // 
            // playerscoreLabel
            // 
            this.playerscoreLabel.AutoSize = true;
            this.playerscoreLabel.BackColor = System.Drawing.Color.White;
            this.playerscoreLabel.Location = new System.Drawing.Point(85, 108);
            this.playerscoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerscoreLabel.Name = "playerscoreLabel";
            this.playerscoreLabel.Size = new System.Drawing.Size(13, 13);
            this.playerscoreLabel.TabIndex = 5;
            this.playerscoreLabel.Text = "0";
            // 
            // housescoreLabel
            // 
            this.housescoreLabel.AutoSize = true;
            this.housescoreLabel.BackColor = System.Drawing.Color.White;
            this.housescoreLabel.Location = new System.Drawing.Point(241, 108);
            this.housescoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.housescoreLabel.Name = "housescoreLabel";
            this.housescoreLabel.Size = new System.Drawing.Size(13, 13);
            this.housescoreLabel.TabIndex = 4;
            this.housescoreLabel.Text = "0";
            // 
            // rollPictureBox2
            // 
            this.rollPictureBox2.Location = new System.Drawing.Point(190, 25);
            this.rollPictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rollPictureBox2.Name = "rollPictureBox2";
            this.rollPictureBox2.Size = new System.Drawing.Size(40, 39);
            this.rollPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rollPictureBox2.TabIndex = 6;
            this.rollPictureBox2.TabStop = false;
            // 
            // rollPictureBox1
            // 
            this.rollPictureBox1.Location = new System.Drawing.Point(21, 25);
            this.rollPictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rollPictureBox1.Name = "rollPictureBox1";
            this.rollPictureBox1.Size = new System.Drawing.Size(40, 39);
            this.rollPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rollPictureBox1.TabIndex = 7;
            this.rollPictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(99, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Roll Dice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 157);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel Game";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // playagainButton
            // 
            this.playagainButton.Location = new System.Drawing.Point(21, 157);
            this.playagainButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playagainButton.Name = "playagainButton";
            this.playagainButton.Size = new System.Drawing.Size(60, 41);
            this.playagainButton.TabIndex = 10;
            this.playagainButton.Text = "Continue Playing";
            this.playagainButton.UseVisualStyleBackColor = true;
            this.playagainButton.Click += new System.EventHandler(this.playagainButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dummy Text";
            // 
            // Snake_Eyes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 218);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playagainButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rollPictureBox1);
            this.Controls.Add(this.rollPictureBox2);
            this.Controls.Add(this.playerscoreLabel);
            this.Controls.Add(this.housescoreLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.houseLabel);
            this.Controls.Add(this.dummyLabel);
            this.Controls.Add(this.first_rollLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Snake_Eyes";
            this.Text = "Snake_Eyes";
            this.Load += new System.EventHandler(this.Snake_Eyes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.rollPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label first_rollLabel;
        private System.Windows.Forms.Label dummyLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label houseLabel;
        private System.Windows.Forms.Label playerscoreLabel;
        private System.Windows.Forms.Label housescoreLabel;
        private System.Windows.Forms.PictureBox rollPictureBox2;
        private System.Windows.Forms.PictureBox rollPictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button playagainButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}