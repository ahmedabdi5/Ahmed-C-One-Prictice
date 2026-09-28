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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            String name=txtname.Text;
            String studentId=txtstudentid.Text;
            String department=txtdepartment.Text;
            String semester=txtsemester.Text;
            String result = name + " " + studentId + " " + department + " " + semester;
            lbloutput.Text = result;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
