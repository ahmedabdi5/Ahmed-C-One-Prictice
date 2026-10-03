using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
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

        private void btnAverage_Click(object sender, EventArgs e)
        {
            // Declaring variables to store three test scores
            double score1, score2, score3, average;

            try
            {
                // Convert the text entered in the TextBoxes
                // into double numbers.
                score1 = Convert.ToDouble(txtscore1.Text);
                score2 = Convert.ToDouble(txtscore2.Text);
                score3 = Convert.ToDouble(txtscore3.Text);

                // Check if Score #1 is between 0 and 100.
                if (score1 < 0 || score1 > 100)
                {
                    MessageBox.Show("Score #1 must be between 0 and 100.");
                }

                // Check if Score #2 is between 0 and 100.
                else if (score2 < 0 || score2 > 100)
                {
                    MessageBox.Show("Score #2 must be between 0 and 100.");
                }

                // Check if Score #3 is between 0 and 100.
                else if (score3 < 0 || score3 > 100)
                {
                    MessageBox.Show("Score #3 must be between 0 and 100.");
                }

                // If all scores are valid, calculate the average.
                else
                {
                    // Add the three scores and divide by 3.
                    average = (score1 + score2 + score3) / 3;

                    // Display the average with one decimal place.
                    lbloutputAverage.Text = average.ToString("F1");
                }
            }
            catch (Exception ex)
            {
                // This runs if the user enters letters
                // or invalid text instead of a number.
                MessageBox.Show("Please enter valid numbers for all test scores.");
            }


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing text box ouputs
            txtscore1.Clear();
            txtscore2.Clear();
            txtscore3.Clear();

            //clearing label output
            lbloutputAverage.Text = " ";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //closing the window
            this.Close();
        }
    }
}
