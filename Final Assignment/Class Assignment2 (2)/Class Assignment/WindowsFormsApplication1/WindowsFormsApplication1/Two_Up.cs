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
    public partial class Two_Up : Form {
        int counter = 0;
        public Two_Up() {
            InitializeComponent();
            Two_Up_Game.SetUpGame();
            againButton.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            label5.Visible = false;
        }

        // an Again button will be implemented, where after pressing again, 
        // the coins will be thrwn again, and the again button will be be no longer visible
        // until the coins have finished flipping

        private void againButton_Click(object sender, EventArgs e) {
            againButton.Visible = false;
            throwButton.Enabled = true;
        }

        // An updatepicturebox will be created, where after the coins have flipped
        // the image will change into a heads or tails

        private void UpdatePictureBoxImage(PictureBox whichPB, bool isHeads) {
            whichPB.Image = Images.GetCoinImage(isHeads);
        }// end UpdatePictureBoxImage


        // A throw button will be implemented where a timer will start (where multiple coins faces
        // will be seen before the outcome happens)

        private void throwButton_Click(object sender, EventArgs e) {
            counter = 0;

            timer1.Start();

            if (Two_Up_Game.TossOutcome() == "Heads" 
                || Two_Up_Game.TossOutcome() == "Tails") {
                throwButton.Enabled = false;
                againButton.Visible = true;
            }

        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        // a timer click will be implemented, where during the throw button, the coin will 
        // siphon through either heads or tails until after a certain time, it will then land and choose
        // either heads or tails

        private void timer1_Tick(object sender, EventArgs e) {
            counter += 1;
            Two_Up_Game.TossCoin();
            UpdatePictureBoxImage(pictureBox1, Two_Up_Game.IsHeads(0));
            UpdatePictureBoxImage(pictureBox2, Two_Up_Game.IsHeads(1));
            label5.Visible = true;
            label5.Text = Two_Up_Game.TossOutcome();
            throwButton.Enabled = false;
            if (counter == 10) {
                timer1.Stop();
                if (Two_Up_Game.TossOutcome() == "Odd") {
                    throwButton.Enabled = true;
                }
                playernumberLabel.Text = Convert.ToString(Two_Up_Game.GetPlayersScore());
                computernumberLabel.Text = Convert.ToString(Two_Up_Game.GetComputersScore());
            }
        }

        private void Two_Up_Load(object sender,EventArgs e) {

        }
    }
}
