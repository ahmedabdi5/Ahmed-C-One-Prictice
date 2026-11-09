using System.Xml.Linq;

namespace week3
{
    public partial class lblName : Form
    {
        public lblName()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using System;
            using System.Windows.Forms;

namespace Week3
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();

                lststudents.Items.Add("IT");
                cmbDepartment.Items.Add("Networking");
                cmbDepartment.Items.Add("Computer Science");
                cmbDepartment.Items.Add("Business");
            }

            private void btnSave_Click(object sender, EventArgs e)
            {
                string name = txtName.Text;
                string age = txtAge.Text;
                string department = cmbDepartment.Text;

                if (name == "" || age == "" || department == "")
                {
                    MessageBox.Show("Please fill all fields!");
                }
                else
                {
                    lstStudents.Items.Add(
                        name + " | " + age + " | " + department
                    );

                    MessageBox.Show("Student Saved Successfully!");
                }
            }

            private void btnClear_Click(object sender, EventArgs e)
            {
                txtName.Clear();
                txtAge.Clear();
                lst.SelectedIndex = -1;
            }
        }
    }
}
    }
}
