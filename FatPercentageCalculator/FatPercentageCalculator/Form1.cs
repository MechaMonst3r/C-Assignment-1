using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FatPercentageCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        
        //Performs proper actions when the calculate buttons is pressed.
        private void Calculate_Click(object sender, EventArgs e)
        {
            //Variables to store input and results.
            double calories;
            double grams;
            double calFromFat;
            double percent;

            //If the input of the Calories and Grams of Fat input boxes are valid numbers, then stored in grams/calories variables
            if (double.TryParse(userCalories.Text, out calories) && double.TryParse(userFat.Text, out grams))
            {
                //Checks to see if calories and grams are equal to or greater then 0 and grams isnt greater then calories.
                if ((calories >= 0 || grams >= 0) && grams <= calories)
                {
                    //Calculates the amount of calories there are in a set amount of grams of fat.
                    calFromFat = grams * 9;

                    //Calculates the percentage of calories that come from fat
                    percent = (calFromFat / calories) * 100;

                    //If user the checks the Low Fat check box
                    if (chkLowFat.Checked)
                    {
                        //Checks to see if the percentage of calories from fat is less then 30%
                        if (percent < 30)
                        {
                            //If it's less then 30%, displays the appropriate message
                            Result3.Text = "Yes";
                        }

                        else
                            Result3.Text = "No";
                    }

                    //Displays results from calculations
                    Result1.Text = calFromFat.ToString();
                    Result2.Text = percent.ToString() + "%";
                }

                //If calories or grams are less then 0 and grams is greater then calories, it throws an error.
                else
                    MessageBox.Show("Either calories or fat was entered incorrectly.");
            }

            //If user input are not numbers, it throws an error.
            else
                MessageBox.Show("Invalid entry. All input MUST be numbers.");
        }

        //Closes the application when clicked
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
