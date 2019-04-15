using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Games_Logic_Library;
using Low_Level_Objects_Library;

namespace WindowsFormsApplication1 {
    public partial class Twenty_one : Form {
        int second_turn = 1;
        const int FIRST_PLAYER = 0;
        const int COMPUTER = 1;
        public Twenty_one() {
            InitializeComponent();
            Twenty_One_Game.SetUpGame();
            hitButton.Enabled = false;
            testButton.Enabled = false;
            standButton.Enabled = false;
            dealerBustedLabel.Visible = false;
            playerbustedLabel.Visible = false;
        }

        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel) {
            tableLayoutPanel.Controls.Clear(); // Remove any cards already being shown.
            foreach (Card card in hand) {
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Tell the PictureBox to use all the space inside its square.
                pictureBox.Dock = DockStyle.Fill;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Images.GetCardImage(card);
                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add(pictureBox);
            }
        }// End DisplayGuiHand

        private void testButton_Click(object sender, EventArgs e) {
            const int testNumOfCardsForDealer = 2;
            const int testNumOfCardsForPlayer = 8;

            CardPile testCardPile = new CardPile(true);
            testCardPile.Shuffle();

            Hand testHandForDealer = new Hand(testCardPile.DealCards(testNumOfCardsForDealer));
            Hand testHandForPlayer = new Hand(testCardPile.DealCards(testNumOfCardsForPlayer));

            DisplayGuiHand(testHandForDealer, topTableLayoutPanel);
            DisplayGuiHand(testHandForPlayer, bottomTableLayoutPanel);
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void dealButton_Click(object sender, EventArgs e) {
            Twenty_One_Game.SetUpGame();
            dealerBustedLabel.Visible = false;
            playerbustedLabel.Visible = false;
            second_turn = 1;
            Twenty_One_Game.DealOneCardTo(FIRST_PLAYER);
            if (Twenty_One_Game.GetHand(FIRST_PLAYER).GetCard(0).GetFaceValue() == FaceValue.Ace) {
                DialogResult result = MessageBox.Show("Do you want Ace to be a 1?", //The question.
                                "Ace", // The MessageBox's caption.
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    Twenty_One_Game.IncrementNumOfUserAcesWithValueOne();
                } else {
                    //nothing
                }
            }

            Twenty_One_Game.DealOneCardTo(FIRST_PLAYER);
            if (Twenty_One_Game.GetHand(FIRST_PLAYER).GetCard(1).GetFaceValue() == FaceValue.Ace) {
                DialogResult result = MessageBox.Show("Do you want Ace to be a 1?", //The question.
                                "Ace", // The MessageBox's caption.
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    Twenty_One_Game.IncrementNumOfUserAcesWithValueOne();
                } else {
                    //nothing
                }
            }

            Twenty_One_Game.DealOneCardTo(COMPUTER);
            Twenty_One_Game.DealOneCardTo(COMPUTER);

            DisplayGuiHand(Twenty_One_Game.GetHand(COMPUTER), topTableLayoutPanel);
            DisplayGuiHand(Twenty_One_Game.GetHand(FIRST_PLAYER), bottomTableLayoutPanel);

            Twenty_One_Game.CalculateHandTotal(FIRST_PLAYER);
            Twenty_One_Game.CalculateHandTotal(COMPUTER);

            ace_NumberLabel.Text = Twenty_One_Game.GetNumOfUserAcesWithValueOne().ToString();
            pointDealerLabel.Text = Twenty_One_Game.GetTotalPoints(COMPUTER).ToString();
            pointPlayerLabel.Text = Twenty_One_Game.GetTotalPoints(FIRST_PLAYER).ToString();

            dealButton.Enabled = false;
            hitButton.Enabled = true;
            standButton.Enabled = true;
        }

        private void hitButton_Click(object sender, EventArgs e) {
            second_turn += 1;
            Twenty_One_Game.DealOneCardTo(FIRST_PLAYER);
            Twenty_One_Game.ResetTotals();
            if (Twenty_One_Game.GetHand(FIRST_PLAYER).GetCard(second_turn).GetFaceValue() == FaceValue.Ace) {
                DialogResult result = MessageBox.Show("Do you want Ace to be a 1?", //The question.
                                "Ace", // The MessageBox's caption.
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    Twenty_One_Game.IncrementNumOfUserAcesWithValueOne();
                } else {
                    //nothing
                }
            }
            ace_NumberLabel.Text = Twenty_One_Game.GetNumOfUserAcesWithValueOne().ToString();
            Twenty_One_Game.CalculateHandTotal(FIRST_PLAYER);

            DisplayGuiHand(Twenty_One_Game.GetHand(FIRST_PLAYER), bottomTableLayoutPanel);
            pointPlayerLabel.Text = Twenty_One_Game.GetTotalPoints(FIRST_PLAYER).ToString();

            if(Twenty_One_Game.GetTotalPoints(FIRST_PLAYER) > 21) {
                playerbustedLabel.Visible = true;
                numberDealerLabel.Text = Twenty_One_Game.GetNumOfGamesWon(COMPUTER).ToString();
                hitButton.Enabled = false;
                standButton.Enabled = false;
                dealButton.Enabled = true;
            }
            else if(Twenty_One_Game.GetTotalPoints(COMPUTER) > 21) {
                dealerBustedLabel.Visible = true;
                numberPlayerLabel.Text = Twenty_One_Game.GetNumOfGamesWon(FIRST_PLAYER).ToString();
                hitButton.Enabled = false;
                standButton.Enabled = false;
                dealButton.Enabled = true;
            }
        }

        private void standButton_Click(object sender, EventArgs e) {
            //Twenty_One_Game.ResetTotals();
            hitButton.Enabled = false;
            standButton.Enabled = false;
            dealButton.Enabled = true;
            while (Twenty_One_Game.GetTotalPoints(FIRST_PLAYER) > Twenty_One_Game.GetTotalPoints(COMPUTER)) {
                Twenty_One_Game.PlayForDeal();
                DisplayGuiHand(Twenty_One_Game.GetHand(COMPUTER), topTableLayoutPanel);
                Twenty_One_Game.CalculateHandTotal(COMPUTER);
            }
            pointDealerLabel.Text = Twenty_One_Game.GetTotalPoints(COMPUTER).ToString();
            if (Twenty_One_Game.GetTotalPoints(COMPUTER) > 21
                || Twenty_One_Game.GetTotalPoints(COMPUTER) < Twenty_One_Game.GetTotalPoints(FIRST_PLAYER)) {
                dealerBustedLabel.Visible = true;
                numberPlayerLabel.Text = Twenty_One_Game.GetNumOfGamesWon(FIRST_PLAYER).ToString();
                hitButton.Enabled = false;
                standButton.Enabled = false;
                dealButton.Enabled = true;
            }
            else if (Twenty_One_Game.GetTotalPoints(FIRST_PLAYER) > 21
                || Twenty_One_Game.GetTotalPoints(FIRST_PLAYER) < Twenty_One_Game.GetTotalPoints(COMPUTER)) {
                playerbustedLabel.Visible = true;
                numberDealerLabel.Text = Twenty_One_Game.GetNumOfGamesWon(COMPUTER).ToString();
                hitButton.Enabled = false;
                standButton.Enabled = false;
                dealButton.Enabled = true;
            }
        }

        private void Twenty_one_Load(object sender, EventArgs e) {

        }
    }
}
