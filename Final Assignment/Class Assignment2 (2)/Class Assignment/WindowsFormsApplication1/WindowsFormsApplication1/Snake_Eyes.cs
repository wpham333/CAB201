using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Games_Logic_Library;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class Snake_Eyes : Form {
        bool first = true;
        public Snake_Eyes() {

            //First must set up snake eyes where the game is initated            

            InitializeComponent();
            first = true;
            Snake_Eyes_Game.SetUpGame();
            dummyLabel.Visible = false;
            label1.Visible = true;
            rollPictureBox1.Visible = false;
            rollPictureBox2.Visible = false;
            playagainButton.Enabled = false;
        }

        // First must create a method that prints a die value on the image

        private void UpdatePictureBoxImage(PictureBox whichPB, int faceValue) {
            whichPB.Image = Images.GetDieImage(faceValue);
        }// end UpdatePictureBoxImage

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        //The click button now must be created to have an if statement within it to make sure
        // that if certain numbers are rolled at the first roll, it will then ask to play again

        private void button1_Click(object sender, EventArgs e) {
            if (first) {
                Snake_Eyes_Game.FirstRoll();
                switch (Snake_Eyes_Game.GetRollTotal()) {
                    case 2:
                        button1.Enabled = false;
                        break;
                    case 3:
                        button1.Enabled = false;
                        break;
                    case 7:
                        button1.Enabled = false;
                        break;
                    case 11:
                        button1.Enabled = false;
                        break;
                    case 12:
                        button1.Enabled = false;
                        break;
                }
                rollPictureBox1.Visible = true;
                rollPictureBox2.Visible = true;
                first = false;
            } else {
                Snake_Eyes_Game.AnotherRoll();
            }
            dummyLabel.Visible = true;
            playagainButton.Enabled = true;
            UpdatePictureBoxImage(rollPictureBox1, Snake_Eyes_Game.GetDiceFacevalue(0));
            UpdatePictureBoxImage(rollPictureBox2, Snake_Eyes_Game.GetDiceFacevalue(1));
            playerscoreLabel.Text = Snake_Eyes_Game.GetPlayerPoints().ToString();
            housescoreLabel.Text = Snake_Eyes_Game.GetHousePoints().ToString();
            dummyLabel.Text = Snake_Eyes_Game.GetPossiblePoints().ToString();
            label1.Text = Snake_Eyes_Game.GetRollOutcome().ToString();
        }

        private void playagainButton_Click(object sender, EventArgs e) {
            first = true;
            button1.Enabled = true;
        }

        private void Snake_Eyes_Load(object sender, EventArgs e) {

        }

        private void Snake_Eyes_Load_1(object sender,EventArgs e) {

        }
    }
}
