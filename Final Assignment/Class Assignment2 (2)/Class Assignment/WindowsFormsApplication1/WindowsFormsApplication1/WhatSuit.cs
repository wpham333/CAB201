using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Low_Level_Objects_Library;
using Games_Logic_Library;

namespace WindowsFormsApplication1 {
    public partial class WhatSuit : Form {
        public WhatSuit() {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void allRadioButton_CheckedChanged(object sender, EventArgs e) {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (radioButton1.Checked) {
                Crazy_Eight_Game.GetHand(2).GetCard(0).GetSuit();
            } else if (radioButton2.Checked) {
                //Suit.Diamonds;
            } else if (radioButton3.Checked) {
                //Suit.Hearts;
            } else if (radioButton4.Checked) {
                //Suit.Spades;
            }
            this.Close();
        }
    }
}
