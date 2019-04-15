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
    public partial class Crazy_Eight : Form {
        public Crazy_Eight() {
            Crazy_Eight_Game.SetUpGame();
            InitializeComponent();
            sortButton.Enabled = false;
            instructionLabel.Text = "Click Deal to start the game.";
            leftPictureBox.Enabled = false;
            UpdatePictureBoxImage(leftPictureBox);
        }

        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel, int who) {
            tableLayoutPanel.Controls.Clear(); // Remove any cards already being shown.
            foreach (Card card in hand) {
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Tell the PictureBox to use all the space inside its square.
                pictureBox.Dock = DockStyle.Fill;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);
                pictureBox.Width = 70;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Images.GetCardImage(card);
                // Allow the user to click on a card in their.
                if (who == 0) {
                    // Set event-handler for Click on this PictureBox.
                    pictureBox.Click += new EventHandler(pictureBox_Click);
                    // Tell the PictureBox which Card object it is a picture of.
                    pictureBox.Tag = card;
                }
                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add(pictureBox);
            }
        }// End DisplayGuiHand

        private void pictureBox_Click(object sender, EventArgs e) {
            // Which card was clicked?
            PictureBox clickedPictureBox = (PictureBox)sender;
            Card clickedCard = (Card)clickedPictureBox.Tag;

            TryToPlayCard(clickedCard);

            //Method for computer//
        }

        private void TryToPlayCard(Card clickedCard) {

            // This MessageBox is for debugging purposes only.
            //MessageBox.Show(clickedCard.ToString(false, true), "Clicked");
            UpdatePictureBoxImageRight(rightPictureBox, Crazy_Eight_Game.Check(clickedCard));
            if(clickedCard.GetFaceValue() == FaceValue.Eight) {
                Form Crazy_Eight = new WhatSuit();
                Crazy_Eight.Show();
            }
            DisplayGuiHand(Crazy_Eight_Game.GetHand(0), bottomTableLayoutPanel, 0);
        }

        private void UpdatePictureBoxImage(PictureBox whichPB) {
            whichPB.Image = Images.GetBackOfCardImage();
        }

        private void UpdatePictureBoxImageRight(PictureBox whichPB, Card card) {
            whichPB.Image = Images.GetCardImage(card);
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void dealButton_Click(object sender, EventArgs e) {
            for (int i = 0; i < 8; i++) {
                Crazy_Eight_Game.DealOneCardTo(1);
                Crazy_Eight_Game.DealOneCardTo(0);
            }
            DisplayGuiHand(Crazy_Eight_Game.GetHand(1), topTableLayoutPanel, 1);
            DisplayGuiHand(Crazy_Eight_Game.GetHand(0), bottomTableLayoutPanel, 0);
            UpdatePictureBoxImageRight(rightPictureBox, Crazy_Eight_Game.DealOneCardToMiddle());
            leftPictureBox.Enabled = true;
            dealButton.Enabled = false;
            sortButton.Enabled = true;
            instructionLabel.Text = "Your turn. Click on one your cards to play.";
        }

        private void sortButton_Click(object sender, EventArgs e) {
            Crazy_Eight_Game.Sort();
            DisplayGuiHand(Crazy_Eight_Game.GetHand(0), bottomTableLayoutPanel, 0);
        }

        private void leftPictureBox_Click(object sender, EventArgs e) {
            Crazy_Eight_Game.Add();
            DisplayGuiHand(Crazy_Eight_Game.GetHand(0), bottomTableLayoutPanel, 0);
        }
    }
}
