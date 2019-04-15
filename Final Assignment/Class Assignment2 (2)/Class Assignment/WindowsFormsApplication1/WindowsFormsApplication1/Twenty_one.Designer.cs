namespace WindowsFormsApplication1 {
    partial class Twenty_one {
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
            this.dealerBustedLabel = new System.Windows.Forms.Label();
            this.dealerLabel = new System.Windows.Forms.Label();
            this.dealergamewonLabel = new System.Windows.Forms.Label();
            this.pointDealerLabel = new System.Windows.Forms.Label();
            this.numberDealerLabel = new System.Windows.Forms.Label();
            this.hitButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.dealButton = new System.Windows.Forms.Button();
            this.numberPlayerLabel = new System.Windows.Forms.Label();
            this.playergamewonLabel = new System.Windows.Forms.Label();
            this.pointPlayerLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerbustedLabel = new System.Windows.Forms.Label();
            this.topTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bottomTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ace_NumberLabel = new System.Windows.Forms.Label();
            this.acevalueoneLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dealerBustedLabel
            // 
            this.dealerBustedLabel.AutoSize = true;
            this.dealerBustedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerBustedLabel.ForeColor = System.Drawing.Color.Red;
            this.dealerBustedLabel.Location = new System.Drawing.Point(100, 29);
            this.dealerBustedLabel.Name = "dealerBustedLabel";
            this.dealerBustedLabel.Size = new System.Drawing.Size(99, 25);
            this.dealerBustedLabel.TabIndex = 0;
            this.dealerBustedLabel.Text = "BUSTED";
            // 
            // dealerLabel
            // 
            this.dealerLabel.AutoSize = true;
            this.dealerLabel.Location = new System.Drawing.Point(205, 34);
            this.dealerLabel.Name = "dealerLabel";
            this.dealerLabel.Size = new System.Drawing.Size(56, 20);
            this.dealerLabel.TabIndex = 1;
            this.dealerLabel.Text = "Dealer";
            // 
            // dealergamewonLabel
            // 
            this.dealergamewonLabel.AutoSize = true;
            this.dealergamewonLabel.Location = new System.Drawing.Point(375, 34);
            this.dealergamewonLabel.Name = "dealergamewonLabel";
            this.dealergamewonLabel.Size = new System.Drawing.Size(94, 20);
            this.dealergamewonLabel.TabIndex = 3;
            this.dealergamewonLabel.Text = "Games won";
            // 
            // pointDealerLabel
            // 
            this.pointDealerLabel.AutoSize = true;
            this.pointDealerLabel.Location = new System.Drawing.Point(283, 34);
            this.pointDealerLabel.Name = "pointDealerLabel";
            this.pointDealerLabel.Size = new System.Drawing.Size(67, 20);
            this.pointDealerLabel.TabIndex = 2;
            this.pointDealerLabel.Text = "POINTS";
            // 
            // numberDealerLabel
            // 
            this.numberDealerLabel.AutoSize = true;
            this.numberDealerLabel.BackColor = System.Drawing.Color.White;
            this.numberDealerLabel.Location = new System.Drawing.Point(486, 34);
            this.numberDealerLabel.Name = "numberDealerLabel";
            this.numberDealerLabel.Size = new System.Drawing.Size(18, 20);
            this.numberDealerLabel.TabIndex = 4;
            this.numberDealerLabel.Text = "0";
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(133, 344);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(75, 33);
            this.hitButton.TabIndex = 12;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(511, 324);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 33);
            this.testButton.TabIndex = 13;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(348, 344);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 33);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // standButton
            // 
            this.standButton.Location = new System.Drawing.Point(235, 344);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(75, 33);
            this.standButton.TabIndex = 15;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(29, 344);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(75, 33);
            this.dealButton.TabIndex = 16;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // numberPlayerLabel
            // 
            this.numberPlayerLabel.AutoSize = true;
            this.numberPlayerLabel.BackColor = System.Drawing.Color.White;
            this.numberPlayerLabel.Location = new System.Drawing.Point(486, 282);
            this.numberPlayerLabel.Name = "numberPlayerLabel";
            this.numberPlayerLabel.Size = new System.Drawing.Size(18, 20);
            this.numberPlayerLabel.TabIndex = 21;
            this.numberPlayerLabel.Text = "0";
            // 
            // playergamewonLabel
            // 
            this.playergamewonLabel.AutoSize = true;
            this.playergamewonLabel.Location = new System.Drawing.Point(375, 282);
            this.playergamewonLabel.Name = "playergamewonLabel";
            this.playergamewonLabel.Size = new System.Drawing.Size(94, 20);
            this.playergamewonLabel.TabIndex = 20;
            this.playergamewonLabel.Text = "Games won";
            // 
            // pointPlayerLabel
            // 
            this.pointPlayerLabel.AutoSize = true;
            this.pointPlayerLabel.Location = new System.Drawing.Point(283, 282);
            this.pointPlayerLabel.Name = "pointPlayerLabel";
            this.pointPlayerLabel.Size = new System.Drawing.Size(67, 20);
            this.pointPlayerLabel.TabIndex = 19;
            this.pointPlayerLabel.Text = "POINTS";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(205, 282);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(52, 20);
            this.playerLabel.TabIndex = 18;
            this.playerLabel.Text = "Player";
            // 
            // playerbustedLabel
            // 
            this.playerbustedLabel.AutoSize = true;
            this.playerbustedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerbustedLabel.ForeColor = System.Drawing.Color.Red;
            this.playerbustedLabel.Location = new System.Drawing.Point(100, 282);
            this.playerbustedLabel.Name = "playerbustedLabel";
            this.playerbustedLabel.Size = new System.Drawing.Size(99, 25);
            this.playerbustedLabel.TabIndex = 17;
            this.playerbustedLabel.Text = "BUSTED";
            // 
            // topTableLayoutPanel
            // 
            this.topTableLayoutPanel.ColumnCount = 8;
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.topTableLayoutPanel.Location = new System.Drawing.Point(10, 71);
            this.topTableLayoutPanel.Name = "topTableLayoutPanel";
            this.topTableLayoutPanel.RowCount = 1;
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topTableLayoutPanel.Size = new System.Drawing.Size(576, 95);
            this.topTableLayoutPanel.TabIndex = 22;
            // 
            // bottomTableLayoutPanel
            // 
            this.bottomTableLayoutPanel.ColumnCount = 8;
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.bottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.bottomTableLayoutPanel.Location = new System.Drawing.Point(10, 172);
            this.bottomTableLayoutPanel.Name = "bottomTableLayoutPanel";
            this.bottomTableLayoutPanel.RowCount = 1;
            this.bottomTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomTableLayoutPanel.Size = new System.Drawing.Size(576, 95);
            this.bottomTableLayoutPanel.TabIndex = 23;
            // 
            // ace_NumberLabel
            // 
            this.ace_NumberLabel.AutoSize = true;
            this.ace_NumberLabel.BackColor = System.Drawing.Color.White;
            this.ace_NumberLabel.Location = new System.Drawing.Point(210, 311);
            this.ace_NumberLabel.Name = "ace_NumberLabel";
            this.ace_NumberLabel.Size = new System.Drawing.Size(18, 20);
            this.ace_NumberLabel.TabIndex = 24;
            this.ace_NumberLabel.Text = "0";
            // 
            // acevalueoneLabel
            // 
            this.acevalueoneLabel.AutoSize = true;
            this.acevalueoneLabel.Location = new System.Drawing.Point(234, 311);
            this.acevalueoneLabel.Name = "acevalueoneLabel";
            this.acevalueoneLabel.Size = new System.Drawing.Size(131, 20);
            this.acevalueoneLabel.TabIndex = 25;
            this.acevalueoneLabel.Text = "Aces with value 1";
            // 
            // Twenty_one
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 398);
            this.Controls.Add(this.acevalueoneLabel);
            this.Controls.Add(this.ace_NumberLabel);
            this.Controls.Add(this.bottomTableLayoutPanel);
            this.Controls.Add(this.topTableLayoutPanel);
            this.Controls.Add(this.numberPlayerLabel);
            this.Controls.Add(this.playergamewonLabel);
            this.Controls.Add(this.pointPlayerLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.playerbustedLabel);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.numberDealerLabel);
            this.Controls.Add(this.dealergamewonLabel);
            this.Controls.Add(this.pointDealerLabel);
            this.Controls.Add(this.dealerLabel);
            this.Controls.Add(this.dealerBustedLabel);
            this.Name = "Twenty_one";
            this.Text = "Twenty_one";
            this.Load += new System.EventHandler(this.Twenty_one_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dealerBustedLabel;
        private System.Windows.Forms.Label dealerLabel;
        private System.Windows.Forms.Label dealergamewonLabel;
        private System.Windows.Forms.Label pointDealerLabel;
        private System.Windows.Forms.Label numberDealerLabel;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Label numberPlayerLabel;
        private System.Windows.Forms.Label playergamewonLabel;
        private System.Windows.Forms.Label pointPlayerLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label playerbustedLabel;
        private System.Windows.Forms.TableLayoutPanel topTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel bottomTableLayoutPanel;
        private System.Windows.Forms.Label ace_NumberLabel;
        private System.Windows.Forms.Label acevalueoneLabel;
    }
}