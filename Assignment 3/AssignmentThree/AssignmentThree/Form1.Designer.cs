namespace AssignmentThree {
    partial class Form1 {
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.onlineLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.baseLabel = new System.Windows.Forms.Label();
            this.crustGroupBox = new System.Windows.Forms.GroupBox();
            this.crust_incursLabel = new System.Windows.Forms.Label();
            this.glutenRadioButton = new System.Windows.Forms.RadioButton();
            this.thickRadioButton = new System.Windows.Forms.RadioButton();
            this.thinRadioButton = new System.Windows.Forms.RadioButton();
            this.toppingGroupBox = new System.Windows.Forms.GroupBox();
            this.topping_incurLabel = new System.Windows.Forms.Label();
            this.toppingCheckBox13 = new System.Windows.Forms.CheckBox();
            this.toppingCheckBox9 = new System.Windows.Forms.CheckBox();
            this.toppingCheckBox5 = new System.Windows.Forms.CheckBox();
            this.toppingCheckBox14 = new System.Windows.Forms.CheckBox();
            this.toppingCheckBox6 = new System.Windows.Forms.CheckBox();
            this.toppingCheckBox10 = new System.Windows.Forms.CheckBox();
            this.toppingCheckBox15 = new System.Windows.Forms.CheckBox();
            this.toppingCheckBox16 = new System.Windows.Forms.CheckBox();
            this.toppingCheckBox7 = new System.Windows.Forms.CheckBox();
            this.toppingCheckBox8 = new System.Windows.Forms.CheckBox();
            this.toppingCheckBox11 = new System.Windows.Forms.CheckBox();
            this.toppingCheckBox12 = new System.Windows.Forms.CheckBox();
            this.toppingCheckBox3 = new System.Windows.Forms.CheckBox();
            this.toppingCheckBox4 = new System.Windows.Forms.CheckBox();
            this.toppingCheckBox2 = new System.Windows.Forms.CheckBox();
            this.toppingCheckBox1 = new System.Windows.Forms.CheckBox();
            this.sauceLabel = new System.Windows.Forms.Label();
            this.sauceComboBox = new System.Windows.Forms.ComboBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.crustGroupBox.SuspendLayout();
            this.toppingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(79, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(331, 32);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Beagle Boys";
            // 
            // onlineLabel
            // 
            this.onlineLabel.AutoSize = true;
            this.onlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineLabel.Location = new System.Drawing.Point(80, 51);
            this.onlineLabel.Name = "onlineLabel";
            this.onlineLabel.Size = new System.Drawing.Size(228, 30);
            this.onlineLabel.TabIndex = 1;
            this.onlineLabel.Text = "Online Order Form";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(51, 90);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(257, 20);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Please enter a name for your order:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Location = new System.Drawing.Point(324, 87);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(122, 121);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(137, 20);
            this.baseLabel.TabIndex = 4;
            this.baseLabel.Text = "Base price $10.00";
            // 
            // crustGroupBox
            // 
            this.crustGroupBox.AutoSize = true;
            this.crustGroupBox.Controls.Add(this.crust_incursLabel);
            this.crustGroupBox.Controls.Add(this.glutenRadioButton);
            this.crustGroupBox.Controls.Add(this.thickRadioButton);
            this.crustGroupBox.Controls.Add(this.thinRadioButton);
            this.crustGroupBox.Location = new System.Drawing.Point(12, 153);
            this.crustGroupBox.Name = "crustGroupBox";
            this.crustGroupBox.Size = new System.Drawing.Size(355, 105);
            this.crustGroupBox.TabIndex = 5;
            this.crustGroupBox.TabStop = false;
            this.crustGroupBox.Text = "Crust";
            // 
            // crust_incursLabel
            // 
            this.crust_incursLabel.AutoSize = true;
            this.crust_incursLabel.Location = new System.Drawing.Point(87, 62);
            this.crust_incursLabel.Name = "crust_incursLabel";
            this.crust_incursLabel.Size = new System.Drawing.Size(160, 20);
            this.crust_incursLabel.TabIndex = 3;
            this.crust_incursLabel.Text = "* Incurs $2 surcharge";
            // 
            // glutenRadioButton
            // 
            this.glutenRadioButton.AutoSize = true;
            this.glutenRadioButton.BackColor = System.Drawing.Color.Firebrick;
            this.glutenRadioButton.Location = new System.Drawing.Point(225, 26);
            this.glutenRadioButton.Name = "glutenRadioButton";
            this.glutenRadioButton.Size = new System.Drawing.Size(124, 24);
            this.glutenRadioButton.TabIndex = 2;
            this.glutenRadioButton.TabStop = true;
            this.glutenRadioButton.Text = "Gluten free *";
            this.glutenRadioButton.UseVisualStyleBackColor = false;
            this.glutenRadioButton.CheckedChanged += new System.EventHandler(this.CrustRadioButton_CheckedChanged);
            // 
            // thickRadioButton
            // 
            this.thickRadioButton.AutoSize = true;
            this.thickRadioButton.BackColor = System.Drawing.Color.Firebrick;
            this.thickRadioButton.Location = new System.Drawing.Point(124, 26);
            this.thickRadioButton.Name = "thickRadioButton";
            this.thickRadioButton.Size = new System.Drawing.Size(71, 24);
            this.thickRadioButton.TabIndex = 1;
            this.thickRadioButton.TabStop = true;
            this.thickRadioButton.Text = "Thick";
            this.thickRadioButton.UseVisualStyleBackColor = false;
            this.thickRadioButton.CheckedChanged += new System.EventHandler(this.CrustRadioButton_CheckedChanged);
            // 
            // thinRadioButton
            // 
            this.thinRadioButton.AutoSize = true;
            this.thinRadioButton.BackColor = System.Drawing.Color.Firebrick;
            this.thinRadioButton.Location = new System.Drawing.Point(17, 26);
            this.thinRadioButton.Name = "thinRadioButton";
            this.thinRadioButton.Size = new System.Drawing.Size(64, 24);
            this.thinRadioButton.TabIndex = 0;
            this.thinRadioButton.TabStop = true;
            this.thinRadioButton.Text = "Thin";
            this.thinRadioButton.UseVisualStyleBackColor = false;
            this.thinRadioButton.CheckedChanged += new System.EventHandler(this.CrustRadioButton_CheckedChanged);
            // 
            // toppingGroupBox
            // 
            this.toppingGroupBox.AutoSize = true;
            this.toppingGroupBox.Controls.Add(this.topping_incurLabel);
            this.toppingGroupBox.Controls.Add(this.toppingCheckBox13);
            this.toppingGroupBox.Controls.Add(this.toppingCheckBox9);
            this.toppingGroupBox.Controls.Add(this.toppingCheckBox5);
            this.toppingGroupBox.Controls.Add(this.toppingCheckBox14);
            this.toppingGroupBox.Controls.Add(this.toppingCheckBox6);
            this.toppingGroupBox.Controls.Add(this.toppingCheckBox10);
            this.toppingGroupBox.Controls.Add(this.toppingCheckBox15);
            this.toppingGroupBox.Controls.Add(this.toppingCheckBox16);
            this.toppingGroupBox.Controls.Add(this.toppingCheckBox7);
            this.toppingGroupBox.Controls.Add(this.toppingCheckBox8);
            this.toppingGroupBox.Controls.Add(this.toppingCheckBox11);
            this.toppingGroupBox.Controls.Add(this.toppingCheckBox12);
            this.toppingGroupBox.Controls.Add(this.toppingCheckBox3);
            this.toppingGroupBox.Controls.Add(this.toppingCheckBox4);
            this.toppingGroupBox.Controls.Add(this.toppingCheckBox2);
            this.toppingGroupBox.Controls.Add(this.toppingCheckBox1);
            this.toppingGroupBox.Location = new System.Drawing.Point(13, 273);
            this.toppingGroupBox.Name = "toppingGroupBox";
            this.toppingGroupBox.Size = new System.Drawing.Size(678, 240);
            this.toppingGroupBox.TabIndex = 6;
            this.toppingGroupBox.TabStop = false;
            this.toppingGroupBox.Text = "Toppings";
            // 
            // topping_incurLabel
            // 
            this.topping_incurLabel.AutoSize = true;
            this.topping_incurLabel.Location = new System.Drawing.Point(13, 198);
            this.topping_incurLabel.Name = "topping_incurLabel";
            this.topping_incurLabel.Size = new System.Drawing.Size(647, 20);
            this.topping_incurLabel.TabIndex = 16;
            this.topping_incurLabel.Text = "Choose the toppings for your pizza. Each topping after 4 will incur a $1.00 cost " +
    "per topping.";
            // 
            // toppingCheckBox13
            // 
            this.toppingCheckBox13.AutoSize = true;
            this.toppingCheckBox13.Location = new System.Drawing.Point(517, 153);
            this.toppingCheckBox13.Name = "toppingCheckBox13";
            this.toppingCheckBox13.Size = new System.Drawing.Size(155, 24);
            this.toppingCheckBox13.TabIndex = 15;
            this.toppingCheckBox13.Text = "Cheddar Cheese";
            this.toppingCheckBox13.UseVisualStyleBackColor = true;
            this.toppingCheckBox13.Click += new System.EventHandler(this.toppingCheckBox1_Click);
            // 
            // toppingCheckBox9
            // 
            this.toppingCheckBox9.AutoSize = true;
            this.toppingCheckBox9.Location = new System.Drawing.Point(347, 153);
            this.toppingCheckBox9.Name = "toppingCheckBox9";
            this.toppingCheckBox9.Size = new System.Drawing.Size(127, 24);
            this.toppingCheckBox9.TabIndex = 11;
            this.toppingCheckBox9.Text = "Feta Cheese";
            this.toppingCheckBox9.UseVisualStyleBackColor = true;
            this.toppingCheckBox9.Click += new System.EventHandler(this.toppingCheckBox1_Click);
            // 
            // toppingCheckBox5
            // 
            this.toppingCheckBox5.AutoSize = true;
            this.toppingCheckBox5.Location = new System.Drawing.Point(182, 153);
            this.toppingCheckBox5.Name = "toppingCheckBox5";
            this.toppingCheckBox5.Size = new System.Drawing.Size(162, 24);
            this.toppingCheckBox5.TabIndex = 7;
            this.toppingCheckBox5.Text = "Morazelle Cheese";
            this.toppingCheckBox5.UseVisualStyleBackColor = true;
            this.toppingCheckBox5.Click += new System.EventHandler(this.toppingCheckBox1_Click);
            // 
            // toppingCheckBox14
            // 
            this.toppingCheckBox14.AutoSize = true;
            this.toppingCheckBox14.Location = new System.Drawing.Point(517, 114);
            this.toppingCheckBox14.Name = "toppingCheckBox14";
            this.toppingCheckBox14.Size = new System.Drawing.Size(81, 24);
            this.toppingCheckBox14.TabIndex = 14;
            this.toppingCheckBox14.Text = "Bacon";
            this.toppingCheckBox14.UseVisualStyleBackColor = true;
            this.toppingCheckBox14.Click += new System.EventHandler(this.toppingCheckBox1_Click);
            // 
            // toppingCheckBox6
            // 
            this.toppingCheckBox6.AutoSize = true;
            this.toppingCheckBox6.Location = new System.Drawing.Point(182, 114);
            this.toppingCheckBox6.Name = "toppingCheckBox6";
            this.toppingCheckBox6.Size = new System.Drawing.Size(69, 24);
            this.toppingCheckBox6.TabIndex = 6;
            this.toppingCheckBox6.Text = "Ham";
            this.toppingCheckBox6.UseVisualStyleBackColor = true;
            this.toppingCheckBox6.Click += new System.EventHandler(this.toppingCheckBox1_Click);
            // 
            // toppingCheckBox10
            // 
            this.toppingCheckBox10.AutoSize = true;
            this.toppingCheckBox10.Location = new System.Drawing.Point(347, 114);
            this.toppingCheckBox10.Name = "toppingCheckBox10";
            this.toppingCheckBox10.Size = new System.Drawing.Size(110, 24);
            this.toppingCheckBox10.TabIndex = 10;
            this.toppingCheckBox10.Text = "Mushroom";
            this.toppingCheckBox10.UseVisualStyleBackColor = true;
            this.toppingCheckBox10.Click += new System.EventHandler(this.toppingCheckBox1_Click);
            // 
            // toppingCheckBox15
            // 
            this.toppingCheckBox15.AutoSize = true;
            this.toppingCheckBox15.Location = new System.Drawing.Point(517, 74);
            this.toppingCheckBox15.Name = "toppingCheckBox15";
            this.toppingCheckBox15.Size = new System.Drawing.Size(105, 24);
            this.toppingCheckBox15.TabIndex = 13;
            this.toppingCheckBox15.Text = "Pineapple";
            this.toppingCheckBox15.UseVisualStyleBackColor = true;
            this.toppingCheckBox15.Click += new System.EventHandler(this.toppingCheckBox1_Click);
            // 
            // toppingCheckBox16
            // 
            this.toppingCheckBox16.AutoSize = true;
            this.toppingCheckBox16.Location = new System.Drawing.Point(517, 35);
            this.toppingCheckBox16.Name = "toppingCheckBox16";
            this.toppingCheckBox16.Size = new System.Drawing.Size(105, 24);
            this.toppingCheckBox16.TabIndex = 12;
            this.toppingCheckBox16.Text = "Capsicum";
            this.toppingCheckBox16.UseVisualStyleBackColor = true;
            this.toppingCheckBox16.Click += new System.EventHandler(this.toppingCheckBox1_Click);
            // 
            // toppingCheckBox7
            // 
            this.toppingCheckBox7.AutoSize = true;
            this.toppingCheckBox7.Location = new System.Drawing.Point(182, 74);
            this.toppingCheckBox7.Name = "toppingCheckBox7";
            this.toppingCheckBox7.Size = new System.Drawing.Size(127, 24);
            this.toppingCheckBox7.TabIndex = 5;
            this.toppingCheckBox7.Text = "Ground Beef";
            this.toppingCheckBox7.UseVisualStyleBackColor = true;
            this.toppingCheckBox7.Click += new System.EventHandler(this.toppingCheckBox1_Click);
            // 
            // toppingCheckBox8
            // 
            this.toppingCheckBox8.AutoSize = true;
            this.toppingCheckBox8.Location = new System.Drawing.Point(182, 35);
            this.toppingCheckBox8.Name = "toppingCheckBox8";
            this.toppingCheckBox8.Size = new System.Drawing.Size(77, 24);
            this.toppingCheckBox8.TabIndex = 4;
            this.toppingCheckBox8.Text = "Olives";
            this.toppingCheckBox8.UseVisualStyleBackColor = true;
            this.toppingCheckBox8.Click += new System.EventHandler(this.toppingCheckBox1_Click);
            // 
            // toppingCheckBox11
            // 
            this.toppingCheckBox11.AutoSize = true;
            this.toppingCheckBox11.Location = new System.Drawing.Point(347, 74);
            this.toppingCheckBox11.Name = "toppingCheckBox11";
            this.toppingCheckBox11.Size = new System.Drawing.Size(93, 24);
            this.toppingCheckBox11.TabIndex = 9;
            this.toppingCheckBox11.Text = "Spinach";
            this.toppingCheckBox11.UseVisualStyleBackColor = true;
            this.toppingCheckBox11.Click += new System.EventHandler(this.toppingCheckBox1_Click);
            // 
            // toppingCheckBox12
            // 
            this.toppingCheckBox12.AutoSize = true;
            this.toppingCheckBox12.Location = new System.Drawing.Point(347, 35);
            this.toppingCheckBox12.Name = "toppingCheckBox12";
            this.toppingCheckBox12.Size = new System.Drawing.Size(107, 24);
            this.toppingCheckBox12.TabIndex = 8;
            this.toppingCheckBox12.Text = "Pepperoni";
            this.toppingCheckBox12.UseVisualStyleBackColor = true;
            this.toppingCheckBox12.Click += new System.EventHandler(this.toppingCheckBox1_Click);
            // 
            // toppingCheckBox3
            // 
            this.toppingCheckBox3.AutoSize = true;
            this.toppingCheckBox3.Location = new System.Drawing.Point(28, 153);
            this.toppingCheckBox3.Name = "toppingCheckBox3";
            this.toppingCheckBox3.Size = new System.Drawing.Size(79, 24);
            this.toppingCheckBox3.TabIndex = 3;
            this.toppingCheckBox3.Text = "Prawn";
            this.toppingCheckBox3.UseVisualStyleBackColor = true;
            this.toppingCheckBox3.Click += new System.EventHandler(this.toppingCheckBox1_Click);
            // 
            // toppingCheckBox4
            // 
            this.toppingCheckBox4.AutoSize = true;
            this.toppingCheckBox4.Location = new System.Drawing.Point(28, 114);
            this.toppingCheckBox4.Name = "toppingCheckBox4";
            this.toppingCheckBox4.Size = new System.Drawing.Size(92, 24);
            this.toppingCheckBox4.TabIndex = 2;
            this.toppingCheckBox4.Text = "Chicken";
            this.toppingCheckBox4.UseVisualStyleBackColor = true;
            this.toppingCheckBox4.Click += new System.EventHandler(this.toppingCheckBox1_Click);
            // 
            // toppingCheckBox2
            // 
            this.toppingCheckBox2.AutoSize = true;
            this.toppingCheckBox2.Location = new System.Drawing.Point(28, 74);
            this.toppingCheckBox2.Name = "toppingCheckBox2";
            this.toppingCheckBox2.Size = new System.Drawing.Size(100, 24);
            this.toppingCheckBox2.TabIndex = 1;
            this.toppingCheckBox2.Text = "Jalapeno";
            this.toppingCheckBox2.UseVisualStyleBackColor = true;
            this.toppingCheckBox2.Click += new System.EventHandler(this.toppingCheckBox1_Click);
            // 
            // toppingCheckBox1
            // 
            this.toppingCheckBox1.AutoSize = true;
            this.toppingCheckBox1.Location = new System.Drawing.Point(28, 35);
            this.toppingCheckBox1.Name = "toppingCheckBox1";
            this.toppingCheckBox1.Size = new System.Drawing.Size(106, 24);
            this.toppingCheckBox1.TabIndex = 0;
            this.toppingCheckBox1.Text = "Tomatoes";
            this.toppingCheckBox1.UseVisualStyleBackColor = true;
            this.toppingCheckBox1.Click += new System.EventHandler(this.toppingCheckBox1_Click);
            // 
            // sauceLabel
            // 
            this.sauceLabel.AutoSize = true;
            this.sauceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sauceLabel.Location = new System.Drawing.Point(419, 166);
            this.sauceLabel.Name = "sauceLabel";
            this.sauceLabel.Size = new System.Drawing.Size(302, 26);
            this.sauceLabel.TabIndex = 7;
            this.sauceLabel.Text = "Select the sauce for you pizza";
            // 
            // sauceComboBox
            // 
            this.sauceComboBox.FormattingEnabled = true;
            this.sauceComboBox.Items.AddRange(new object[] {
            "Tomato",
            "Barbecue"});
            this.sauceComboBox.Location = new System.Drawing.Point(424, 207);
            this.sauceComboBox.Name = "sauceComboBox";
            this.sauceComboBox.Size = new System.Drawing.Size(190, 28);
            this.sauceComboBox.TabIndex = 8;
            this.sauceComboBox.SelectedIndexChanged += new System.EventHandler(this.sauceComboBox_SelectedIndexChanged);
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.doneButton.Location = new System.Drawing.Point(292, 519);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(118, 64);
            this.doneButton.TabIndex = 9;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(766, 595);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.sauceComboBox);
            this.Controls.Add(this.sauceLabel);
            this.Controls.Add(this.toppingGroupBox);
            this.Controls.Add(this.crustGroupBox);
            this.Controls.Add(this.baseLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.onlineLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Beagle Boys";
            this.crustGroupBox.ResumeLayout(false);
            this.crustGroupBox.PerformLayout();
            this.toppingGroupBox.ResumeLayout(false);
            this.toppingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label onlineLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.GroupBox crustGroupBox;
        private System.Windows.Forms.Label crust_incursLabel;
        private System.Windows.Forms.RadioButton glutenRadioButton;
        private System.Windows.Forms.RadioButton thickRadioButton;
        private System.Windows.Forms.RadioButton thinRadioButton;
        private System.Windows.Forms.GroupBox toppingGroupBox;
        private System.Windows.Forms.CheckBox toppingCheckBox2;
        private System.Windows.Forms.CheckBox toppingCheckBox1;
        private System.Windows.Forms.CheckBox toppingCheckBox13;
        private System.Windows.Forms.CheckBox toppingCheckBox9;
        private System.Windows.Forms.CheckBox toppingCheckBox5;
        private System.Windows.Forms.CheckBox toppingCheckBox14;
        private System.Windows.Forms.CheckBox toppingCheckBox6;
        private System.Windows.Forms.CheckBox toppingCheckBox10;
        private System.Windows.Forms.CheckBox toppingCheckBox15;
        private System.Windows.Forms.CheckBox toppingCheckBox16;
        private System.Windows.Forms.CheckBox toppingCheckBox7;
        private System.Windows.Forms.CheckBox toppingCheckBox8;
        private System.Windows.Forms.CheckBox toppingCheckBox11;
        private System.Windows.Forms.CheckBox toppingCheckBox12;
        private System.Windows.Forms.CheckBox toppingCheckBox3;
        private System.Windows.Forms.CheckBox toppingCheckBox4;
        private System.Windows.Forms.Label topping_incurLabel;
        private System.Windows.Forms.Label sauceLabel;
        private System.Windows.Forms.ComboBox sauceComboBox;
        private System.Windows.Forms.Button doneButton;
    }
}

