using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Hospital_Assigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnregestration_Click(object sender, EventArgs e)
        {
            int id , age;
            String name, gender, ;
            try
            {
                if (int.TryParse(txtpateintid.Text,out id) && int.TryParse(txtage.Text, out age))
                {
                    if (id > 0)
                    {
                        if (age > 0) {
                            if (gender.checked== male){

                                }
                        }
                            else
                            {
                                MessageBox.Show("age must be possative");
                            }
                        }
                        else
                        {
                            MessageBox.Show("ID must be postive");
                        }
                    }
                    else
                    {
                        MessageBox.Show("only accept numeric values");
                    }
                }
            }
            catch {
                MessageBox.Show("pls handle the error");
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            StreamWriter writer;
            writer = File.CreateText("test.txt");
            writer.WriteLine("kusoo dhawaaw ca242 class.");
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            result.Items.Clear();
        }

        private void btncount_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtage.Clear();
            txtpateintid.Clear();
            txtpateintname.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //exit the window
            this.Close();
        }
    }
}
