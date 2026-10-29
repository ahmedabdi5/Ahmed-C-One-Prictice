using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double weight;
                double height;

                // Validate weight
                if (!double.TryParse(txtWeight.Text, out weight) || weight <= 0)
                {
                    MessageBox.Show("Please enter a valid weight in kg.");
                    
                   
                }

                // Validate height
                if (!double.TryParse(txtHeight.Text, out height) || height <= 0)
                {
                    MessageBox.Show("Please enter a valid height in meters.");
                   
                   
                }

                // Calculate height squared using if-else
                double HSquared;

                if (height > 0)
                {
                    HSquared = height * height;
                }
                else
                {
                    MessageBox.Show("Height must be greater than zero");
                    return;
                }

                // Calculation bmi
                double bmi = weight / HSquared;

                //display results
                lblResult.Text = bmi.ToString("F2");

                
                if (bmi < 18.5)
                {
                    lblCategory.Text = "Underweight";
                }
                else if (bmi < 25)
                {
                    lblCategory.Text = "Optimal weight";
                }
                else if (bmi < 30)
                {
                    lblCategory.Text = "Overweight";
                }
                else
                {
                    lblCategory.Text = "Obesity";
                }
            }
            catch (Exception ex) {
                MessageBox.Show("pls hold the erorr");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing height
            txtWeight.Clear();
            txtHeight.Clear();

            //clearing the labels
            lblResult.Text = " ";
            lblCategory.Text = " ";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
