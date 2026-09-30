using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                String food1 = txtfood1.Text;
                int  price1 = int.Parse (txtprice1.Text);
                String food2 = txtfood2.Text;
                int price2 =int.Parse (txtprice2.Text);
                double tax=(price1 + price2)*0.07;
                double total = price1 + price2 + tax;
                lblresult.Text="tax is $: "+tax.ToString("")+ " total is $:" + total.ToString("");

            }
            catch{
                MessageBox.Show("enter valid");
            }
        }
    }
}
