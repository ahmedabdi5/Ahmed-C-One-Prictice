using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtweak.Clear();
            txtmonth.Text = " ";
            txtnumeric.Text = " ";
            txtyear.Text = " ";


            lbloutput.Text = " ";
        }



        private void btnshowdate_Click(object sender, EventArgs e)
        {
            //creating variables
            String day, month, full_date;
            int numeric, year;

            //intial variable
            day = txtweak.Text;
            month = txtmonth.Text;
            numeric =int.Parse (txtnumeric.Text);
            year = int.Parse (txtyear.Text);
            
            //stage process concantanation of full date
            full_date=day+","+month+","+numeric+","+year;

            //stage three
            lbloutput.Text = full_date;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
