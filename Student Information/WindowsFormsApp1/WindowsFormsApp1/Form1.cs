using System;
using System.IO;
using System.Windows.Forms;

namespace StudentInformationSystem
{
    public partial class Form1 : Form
    {
        string filePath = @"\C:\\Users\\pc\\Desktop\\test\";

        public Form1()
        {
            InitializeComponent();
        }

        // 1. Save Student Information
        private void btnsave_Click(object sender, EventArgs e)
        {
            int studentID;
            double marks;

            bool validName = true;
            bool validDepartment = true;

            // Student ID Validation
            if (!int.TryParse(txtstudentid.Text, out studentID))
            {
                MessageBox.Show("Student ID must contain numbers only.");
            }
            else if (txtstudentname.Text == "")
            {
                MessageBox.Show("Please enter student name.");
            }
            else if (txtdepartment.Text == "")
            {
                MessageBox.Show("Please enter department.");
            }
            else if (txtmarks.Text == "")
            {
                MessageBox.Show("Please enter marks.");
            }
            else
            {
                // Student Name Validation
                for (int i = 0; i < txtstudentname.Text.Length; i++)
                {
                    char c = txtstudentname.Text[i];

                    if (!char.IsLetter(c) && c != ' ')
                    {
                        validName = false;
                    }
                }

                if (!validName)
                {
                    MessageBox.Show("Name must contain letters only.");
                }
                else
                {
                    // Department Validation
                    for (int i = 0; i < txtdepartment.Text.Length; i++)
                    {
                        char c = txtdepartment.Text[i];

                        if (!char.IsLetter(c) && c != ' ')
                        {
                            validDepartment = false;
                        }
                    }

                    if (!validDepartment)
                    {
                        MessageBox.Show("Department must contain letters only.");
                    }
                    else
                    {
                        // Marks Validation
                        if (!double.TryParse(txtmarks.Text, out marks))
                        {
                            MessageBox.Show("Marks must be a valid double number.");
                        }
                        else if (marks < 0)
                        {
                            MessageBox.Show("Marks cannot be negative.");
                        }
                        else if (!rdoundergraduate.Checked &&
                                 !rdopostgraduate.Checked)
                        {
                            MessageBox.Show("Please select student type.");
                        }
                        else
                        {
                            string studentType = "";

                            if (rdoundergraduate.Checked)
                            {
                                studentType = "Undergraduate";
                            }
                            else
                            {
                                studentType = "Postgraduate";
                            }

                            // Save File Dialog
                            SaveFileDialog saveFile = new SaveFileDialog();

                            saveFile.Title = "Save Student Information";
                            saveFile.Filter = "Text Files (*.txt)|*.txt";
                            saveFile.FileName = txtstudentname.Text + ".txt";

                            if (saveFile.ShowDialog() == DialogResult.OK)
                            {
                                filePath = saveFile.FileName;

                                using (StreamWriter writer =
                                       new StreamWriter(filePath, true))
                                {
                                    writer.WriteLine(
                                        studentID + " | " +
                                        txtstudentname.Text + " | " +
                                        txtdepartment.Text + " | " +
                                        marks + " | " +
                                        studentType
                                    );
                                }

                                MessageBox.Show(
                                    "Student information saved successfully.");
                            }

                            saveFile.Dispose();
                        }
                    }
                }
            }
        }

        // 2. Read Student Information
        private void btnread_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Title = "Select Student Information File";
            openFile.Filter = "Text Files (*.txt)|*.txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filePath = openFile.FileName;

                result.Items.Clear();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        result.Items.Add(line);
                    }
                }

                MessageBox.Show("Student information read successfully.");
            }

            openFile.Dispose();
        }

        // 3. Clear Form
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtstudentid.Clear();
            txtstudentname.Clear();
            txtdepartment.Clear();
            txtmarks.Clear();

            rdoundergraduate.Checked = false;
            rdopostgraduate.Checked = false;

            result.Items.Clear();
        }

        // 4. Exit Application
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}