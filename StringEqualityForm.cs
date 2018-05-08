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
 * Created by: Tolu Adebayo
 * Created on: 08-05-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - String Equality
 * This program checks if 2 strings are the same (if you ignore capitals and smalls)
*/
namespace StringEqualityToluA
{
    public partial class frmStringEquality : Form
    {
        public frmStringEquality()
        {
            InitializeComponent();
        }
        // Procedure : StringsAreEqual
        // Input : string stringOne, string stringTwo
        // Output : bool
        // Description : This procedurechecks if 2 strings are the same (if you ignore capitals and smalls),
        //               and returns a boolean "bool" value
        private bool StringsAreEqual (string stringOne, string stringTwo)
        {
            bool isEqual;
            // initialize isEqual to false
            isEqual = false;
            // Assign the strings to the upper variable
            string upperString = stringOne.ToUpper();
            string upperStringTwo = stringTwo.ToUpper();
            // Compare the upper strings 
            if (upperString == upperStringTwo)
            {
                isEqual = true;
                // Show message box
                MessageBox.Show("The two strings are Equal" , "Equal Strings");
            }
            else if (upperString != upperStringTwo)
            {
                isEqual = false;
                // show message box
                MessageBox.Show("The two strings are not Equal" , "Unequal Strings");
            }
            // Return the bool "isEqual"
            return isEqual;
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            // determine the strings and bools 
            bool Equal;
            string userUpperStringOne;
            string userUpperStringTwo;
            // convert the texts in the textbox into strings
            userUpperStringOne = txtStringOne.Text;
            userUpperStringTwo = txtStringTwo.Text;
            // Call the function
            Equal = StringsAreEqual(userUpperStringOne, userUpperStringTwo);
        }
    }
}
