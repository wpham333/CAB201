using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Designing a windows form application that will simulate an online form for ordering a pizza
 * from the company called "Beagle Boy".
 * The window form application will consist of 7 Labels, 1 Text Box, 1 Button , 1 Combo Box, 2 Group Boxes
 * The first group box contains 3 Radio Buttons and the second group box contains 16 check boxes.
 * Once the program start the only thing that is enable is the Text Box. But once the users continue
 * typing his name and progress through the online form. The other components(event handlers) will
 * begin to enable them self for the progression of the simulation of the online form for ordering.
 * 
 * Author William Pham, 9702474
 * Date: September 2016
 *
 */

namespace AssignmentThree {
    public partial class Form1 : Form {
        // Setting up constant integer MIN as 4 since the minimum number of topping is 4.
        const int MIN = 4;
        // Setting up a constant interger ZERO as 0 since magic number aren't allow.
        const int ZERO = 0;
        // Setting up a constant interger BASEPRICE as 10 since the pizza base costs $10
        const int BASEPRICE = 10;
        // Setting up a constant interget GLUTENFEE as 2 since if the user picks the gluten
        // free base. They will be charged extra $2.
        const int GLUTENFEE = 2;
        // String name is a variable stored from the event handler nameTextBox.
        // String sauce is a variable which will be used to show the selected sauce
        string name, sauce;
        // Declaring number as the number of check box being checked.
        int number = ZERO;
        // Declaring money as the cost of the pizza depending on the users choice.
        int money = BASEPRICE;
        // Setting up enumeration for the three sauces, named Thin, Thick, GlutenFree
        enum CrustOptions {Thin, Thick, Gluten_Free}
        // The whichOptions is a number that will determine the users choice.
        // if whichOptions = 0 then the crust is Thin
        // if whichOptions = 1 then the crust is Thick
        // if whichOptions = 2 then the crust is Gluten_free
        CrustOptions whichOptions;

        // Form1 acts almost like a main in the console application.
        public Form1() {
            // Initializing the design of the Graphical User Interface
            InitializeComponent();
            // Must have both group box, combo box and done button disabled at start
            crustGroupBox.Enabled = false;
            toppingGroupBox.Enabled = false;
            sauceComboBox.Enabled = false;
            doneButton.Visible = false;
        }

        // A private method for result which takes the calculation of the pizza and checks
        // whether the user have inputted the correct requirement.
        // For example, no name?, no topping?
        private void result() {
            // If the users uncheck all the box and click on done.
            // The user is asked to try again
            if (number == ZERO) {
                MessageBox.Show("Sorry, you require at least 1 topping to complete the order."
                    + "\n\nRemember up to 4 toppings are free");
            }
            // However, if the user doesn't have a name.
            // Message box show up asking for the user's name
            else if (name == "") {
                MessageBox.Show("You don't have a name?");
            }
            // If the topping is not 0 and their base option is Gluten_free
            // The calculation is worked out but the GLUTENFEE is applied.
            // Therefore, $2 is charged for having a gluten free base.
            else if (number != ZERO && whichOptions == CrustOptions.Gluten_Free) {
                money += GLUTENFEE;
                MessageBox.Show("Thank you for your order " + name + ", \n"
                    + "of a Gluten Free pizza base with " + sauce + " sauce and "
                    + number + " toppings. \n\n"
                    + "The cost of the pizza is " + "$" + money);

                MessageBox.Show("The Pizza is a lie");
                this.Close();
            } 
            // If topping is not zero and the users doesn't choose gluten free.
            // Calculation is calculated
            else if (number != ZERO) {
                MessageBox.Show("Thank you for your order " + name + ", \n"
                    + "of a " + whichOptions + " pizza base with " + sauce + " sauce and "
                    + number + " toppings. \n\n"
                    + "The cost of the pizza is " + "$" + money);

                MessageBox.Show("The Pizza is a lie");
                this.Close();
            }
        }

        // Event handler for the Done button. Once the button is clicked.
        // It runs the result method.
        private void doneButton_Click(object sender, EventArgs e) {
            result();
        }

        // Event handler for the Sauce Combo Box. Once the selected index changed.
        // The users selection will be stored in the string variable labelled as "sauce".
        // This event handler also enable the Topping Group Box.
        private void sauceComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            sauce = sauceComboBox.SelectedItem.ToString();
            toppingGroupBox.Enabled = true;
        }

        // Event handler for the Name Text Box. Once the text are added to the text box.
        // The Crust Group Box is enabled.
        // It also stores the user's input into the string variable "name".
        private void nameTextBox_TextChanged(object sender, EventArgs e) {
            crustGroupBox.Enabled = true;
            name = nameTextBox.Text;
        }

        // Event handler for the three Radio Buttons. Once a radio button is checked.
        // It will run a if statment checking which of the option that the user have
        // selected as their crust. The user's input is then stored into a
        // variable called whichOptions as its enumeration is appended to the list.
        // This event handler also enable the Sauce Combo Box to be activated. 
        private void CrustRadioButton_CheckedChanged(object sender, EventArgs e) {
            sauceComboBox.Enabled = true;
            if (thinRadioButton.Checked) {
                whichOptions = CrustOptions.Thin;
            } else if (thickRadioButton.Checked) {
                whichOptions = CrustOptions.Thick;
            } else if (glutenRadioButton.Checked) {
                whichOptions = CrustOptions.Gluten_Free;
            }
        }

        // Event handler for the 16 checkboxes. Once a checkbox is checked,
        // it will increment the number of topping and the money once it is greater
        // then the MIN constant which is 4.
        // Made an nested if statment. If checkbox is checked then increase the number.
        // and also if the number(toppings) is GREATER THAN minimum(4) then add the money.
        // However, else if checkbox is not checked. Then decrease the number of toppings.
        // also if the number(toppings) is LESS THAN minimum(4) perform nothing,
        // and else decreases the money.
        // This event handler also makes the done button appear.  
        private void toppingCheckBox1_Click(object sender, EventArgs e) {
            CheckBox check = (CheckBox)sender;
            if (check.Checked) {
                number++;
                if (number > MIN) {
                    money ++;
                }
            }else{
                number--;
                if(number < MIN){
                    //do nothing
                }else{
                    money--;
                }
            }
            doneButton.Visible = true;
        }
    }
}