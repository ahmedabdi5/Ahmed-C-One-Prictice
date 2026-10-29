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

namespace FilesAssignments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        // 1. Create File
        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            StreamWriter outputfile;
            outputfile = File.CreateText("Home.doc");

            outputfile.WriteLine("Hello from C#!");
            outputfile.WriteLine("This is my text file.");
            outputfile.Close();

            MessageBox.Show("File created.");
        } 

        
            private void btnReadLines_Click(object sender, EventArgs e)

        {
            // 2. Read File using ReadLines()

            if (!File.Exists("Home.doc"))
            {
                MessageBox.Show("Create the file first.");
                return;
            }

            lstFileContents.Items.Clear();

            foreach (string line in File.ReadLines("Home.doc"))
            {
                lstFileContents.Items.Add(line);
            }

        }

        
            // 3. Delete File
        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists("Home.doc"))
            {
                MessageBox.Show("File not found.");
                return;
            }

            File.Delete("Home.doc");
            lstFileContents.Items.Clear();

            MessageBox.Show("File deleted.");
        }

        
            // 4. Clear File Contents
        private void btnClearContents_Click(object sender, EventArgs e)
        {
            if (!File.Exists("Home.doc"))
            {
                MessageBox.Show("File not found.");
                return;
            }

            File.WriteAllText("Home.doc", string.Empty);
            lstFileContents.Items.Clear();

            MessageBox.Show("File contents cleared.");
        }
    }
    
    
    
}
