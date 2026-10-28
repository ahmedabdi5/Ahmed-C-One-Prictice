using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1_and_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnaddcourse_Click(object sender, EventArgs e)
        {


            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            try
            {
                // variables
                string name;
                int age;
                string id;
                double course_price = 0;

                if (int.TryParse(txtage.Text, out age))
                {
                    name = txtname.Text;
                    age = int.Parse(txtage.Text);
                    id = txtid.Text;
                    string course_status = "";
                    int number_of_course = int.Parse(txtnumberofcourse.Text);

                    double basic_regestration_fee = 0;
                    double final_total = 0;

                    //int index_num = 1;


                    if (age >= 16 && age <= 60)
                    {
                        if (id != "")
                        {
                            if (number_of_course > 0)
                            {
                                // course price
                                course_price = double.Parse(txtcourseprice.Text);

                                course_status = "Approved";
                                basic_regestration_fee = course_price * number_of_course;

                                
                               
                                double discount = 0;

                                if (number_of_course > 1 && number_of_course <= 2)
                                {
                                    discount = basic_regestration_fee * 0.05;
                                }
                                else if (number_of_course >= 3 && number_of_course <= 4)
                                {
                                    discount = basic_regestration_fee * 0.1;
                                }
                                else if (number_of_course == 5)
                                {
                                    discount = basic_regestration_fee * 0.15;
                                }

                                final_total = basic_regestration_fee - discount;

                                lsresult.Items.Add("student name: " + name);
                                lsresult.Items.Add("student age: " + age);
                                lsresult.Items.Add("student id: " + id);
                                lsresult.Items.Add("Number of courses: " + number_of_course);
                                lsresult.Items.Add("--------------------------");
                                lsresult.Items.Add("Basic Regestration fee: " + basic_regestration_fee);
                                lsresult.Items.Add("course discount: " + discount);
                                lsresult.Items.Add("--------------------------");
                                lsresult.Items.Add("Final Regestration fee: " + final_total);
                                lsresult.Items.Add("Registration status: " + course_status);



                            }
                            else
                            {
                                course_status = "Rejected";
                                MessageBox.Show("at least one course must be regestared");
                                lsresult.Items.Add("student name: " + name);
                                lsresult.Items.Add("student age: " + age);
                                lsresult.Items.Add("student id: " + id);
                                lsresult.Items.Add("--------------------------");
                                lsresult.Items.Add("Registration status: " + course_status);
                            }
                        } else
                        {
                            MessageBox.Show("id can not be empty");
                        }
                    }
                    else
                    {

                        MessageBox.Show("Student age must be between 16 - 60");

                    }


                }
                else
                {
                    MessageBox.Show("Only accepts numeric values");
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btncourseremove_Click(object sender, EventArgs e)
        {
            // removing item using the remove

            lscourses.Items.Clear();

            


            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // variables
            string course_Name;
            decimal course_price;
            int number_of_courses;


            if (decimal.TryParse(txtcourseprice.Text, out course_price))
            {
                course_Name = txtcoursename.Text;
                course_price = decimal.Parse(txtcourseprice.Text);
                number_of_courses = int.Parse(txtnumberofcourse.Text);


                if (course_price > 0)
                {

                   

                    if (number_of_courses > 5)
                    {
                        MessageBox.Show("Only accepts upto 5 courses");

                    }
                    else
                    {
                        lscourses.Items.Add("course name: " + course_Name);
                        lscourses.Items.Add("course price: " + course_price);
                    }


                        lblnumberofcourse.Text = number_of_courses.ToString();

                    // clear course name and course price inputs after adding
                    //txtcoursename.Clear();
                    //txtcourseprice.Clear();



                }

                else
                {
                    MessageBox.Show("Course price must be graater than 0");
                }

                
            } else
            {
                MessageBox.Show("price only accpets numeric value");
            }



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // clear course name and course price inputs after adding

            lscourses.Items.Clear();
            lsresult.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



