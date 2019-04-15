using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class Game : Form {

        enum GameButton {Coin, Dice, Card};
        GameButton whichOptions;

        public Game() {
            InitializeComponent();
            startButton.Enabled = false;
        }


        // A if and else if statement will be created to then allow
        // the options of 3 categories of games ( two up, dice game, card games)

        private void button1_Click(object sender, EventArgs e) {
            if (coinRadioButton.Checked) {
                whichOptions = GameButton.Coin;
                Form Form1 = new Two_Up();
                Form1.Show();
            } else if (diceRadioButton.Checked) {
                whichOptions = GameButton.Dice;
                Form Form1 = new Which_Dice_Game();
                Form1.Show();
            } else if (cardRadioButton.Checked) {
                whichOptions = GameButton.Card;
                Form Form1 = new Which_Card_Game();
                Form1.Show();
            }


        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void threeButton_CheckedChanged(object sender, EventArgs e) {
            startButton.Enabled = true;
        }

        private void Game_Load(object sender,EventArgs e) {

        }
    }
}
