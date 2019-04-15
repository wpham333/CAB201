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
    public partial class Which_Card_Game : Form {
        public Which_Card_Game() {
            InitializeComponent();
        }

        private void cardComboBox_SelectedIndexChanged(object sender, EventArgs e) {

            string nameGame = cardComboBox.SelectedItem.ToString();

            if (nameGame == "Twenty One") {
                Form Which_Card_Game = new Twenty_one();
                Which_Card_Game.Show();
            }
            if (nameGame == "Crazy Eight") {
                Form Which_Card_Game = new Crazy_Eight();
                Which_Card_Game.Show();
            }
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
    }
}
