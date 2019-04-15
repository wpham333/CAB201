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
    public partial class Which_Dice_Game : Form {
        public Which_Dice_Game() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Do you really want to quit?", //The question.
                                                        "Quit?", // The MessageBox's caption.
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);
            // If the user clicked the Yes button
            if (result == DialogResult.Yes) {
                this.Close();
            } else {
                //nothing
            }

        }

        private void diceComboBox_SelectedIndexChanged(object sender, EventArgs e) {

            string nameGame = diceComboBox.SelectedItem.ToString();

            if (nameGame == "Snake Eyes") {
                Form Which_Dice_Game = new Snake_Eyes();
                Which_Dice_Game.Show();
            }
            if (nameGame == "Ship Captain Crew") {
                Form Which_Dice_Game = new Ship_Captain_Crew();
                Which_Dice_Game.Show();
            }

        }
    }
}
