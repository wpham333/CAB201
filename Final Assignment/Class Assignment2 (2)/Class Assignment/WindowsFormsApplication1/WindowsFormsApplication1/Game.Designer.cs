namespace WindowsFormsApplication1 {
    partial class Game {
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
            this.game_worldLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cardRadioButton = new System.Windows.Forms.RadioButton();
            this.diceRadioButton = new System.Windows.Forms.RadioButton();
            this.coinRadioButton = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // game_worldLabel
            // 
            this.game_worldLabel.AutoSize = true;
            this.game_worldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_worldLabel.Location = new System.Drawing.Point(78, 22);
            this.game_worldLabel.Name = "game_worldLabel";
            this.game_worldLabel.Size = new System.Drawing.Size(145, 26);
            this.game_worldLabel.TabIndex = 0;
            this.game_worldLabel.Text = "Game World";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cardRadioButton);
            this.groupBox1.Controls.Add(this.diceRadioButton);
            this.groupBox1.Controls.Add(this.coinRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(61, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Game Type";
            // 
            // cardRadioButton
            // 
            this.cardRadioButton.AutoSize = true;
            this.cardRadioButton.Location = new System.Drawing.Point(41, 69);
            this.cardRadioButton.Name = "cardRadioButton";
            this.cardRadioButton.Size = new System.Drawing.Size(78, 17);
            this.cardRadioButton.TabIndex = 2;
            this.cardRadioButton.Text = "Card Game";
            this.cardRadioButton.UseVisualStyleBackColor = true;
            this.cardRadioButton.CheckedChanged += new System.EventHandler(this.threeButton_CheckedChanged);
            // 
            // diceRadioButton
            // 
            this.diceRadioButton.AutoSize = true;
            this.diceRadioButton.Location = new System.Drawing.Point(41, 46);
            this.diceRadioButton.Name = "diceRadioButton";
            this.diceRadioButton.Size = new System.Drawing.Size(78, 17);
            this.diceRadioButton.TabIndex = 1;
            this.diceRadioButton.Text = "Dice Game";
            this.diceRadioButton.UseVisualStyleBackColor = true;
            this.diceRadioButton.CheckedChanged += new System.EventHandler(this.threeButton_CheckedChanged);
            // 
            // coinRadioButton
            // 
            this.coinRadioButton.AutoSize = true;
            this.coinRadioButton.Location = new System.Drawing.Point(41, 22);
            this.coinRadioButton.Name = "coinRadioButton";
            this.coinRadioButton.Size = new System.Drawing.Size(77, 17);
            this.coinRadioButton.TabIndex = 0;
            this.coinRadioButton.Text = "Coin Game";
            this.coinRadioButton.UseVisualStyleBackColor = true;
            this.coinRadioButton.CheckedChanged += new System.EventHandler(this.threeButton_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(102, 189);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(102, 237);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 303);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.game_worldLabel);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label game_worldLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cardRadioButton;
        private System.Windows.Forms.RadioButton diceRadioButton;
        private System.Windows.Forms.RadioButton coinRadioButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
    }
}

