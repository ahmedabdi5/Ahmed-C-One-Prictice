namespace Assignment_1_and_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnumberofcourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcourseprice = new System.Windows.Forms.TextBox();
            this.lblcourseprice = new System.Windows.Forms.Label();
            this.txtcoursename = new System.Windows.Forms.TextBox();
            this.lblcoursename = new System.Windows.Forms.Label();
            this.btncourseremove = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lsresult = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblnumberofcourse = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lscourses = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(202, 148);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(354, 35);
            this.txtid.TabIndex = 146;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(22, 154);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(130, 29);
            this.lblid.TabIndex = 145;
            this.lblid.Text = "Student ID:";
            // 
            // txtage
            // 
            this.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(202, 89);
            this.txtage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(354, 35);
            this.txtage.TabIndex = 144;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(22, 94);
            this.lblage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(148, 29);
            this.lblage.TabIndex = 143;
            this.lblage.Text = "Student age:";
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(202, 32);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(354, 35);
            this.txtname.TabIndex = 142;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(22, 35);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(167, 29);
            this.lblname.TabIndex = 141;
            this.lblname.Text = "Student name:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.lblage);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Location = new System.Drawing.Point(34, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(584, 212);
            this.groupBox1.TabIndex = 147;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.txtnumberofcourse);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtcourseprice);
            this.groupBox2.Controls.Add(this.lblcourseprice);
            this.groupBox2.Controls.Add(this.txtcoursename);
            this.groupBox2.Controls.Add(this.lblcoursename);
            this.groupBox2.Location = new System.Drawing.Point(34, 252);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(584, 214);
            this.groupBox2.TabIndex = 148;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtnumberofcourse
            // 
            this.txtnumberofcourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumberofcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumberofcourse.Location = new System.Drawing.Point(220, 152);
            this.txtnumberofcourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnumberofcourse.Name = "txtnumberofcourse";
            this.txtnumberofcourse.Size = new System.Drawing.Size(335, 35);
            this.txtnumberofcourse.TabIndex = 146;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 145;
            this.label1.Text = "number courses:";
            // 
            // txtcourseprice
            // 
            this.txtcourseprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcourseprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcourseprice.Location = new System.Drawing.Point(202, 89);
            this.txtcourseprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcourseprice.Name = "txtcourseprice";
            this.txtcourseprice.Size = new System.Drawing.Size(354, 35);
            this.txtcourseprice.TabIndex = 144;
            // 
            // lblcourseprice
            // 
            this.lblcourseprice.AutoSize = true;
            this.lblcourseprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcourseprice.Location = new System.Drawing.Point(22, 94);
            this.lblcourseprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcourseprice.Name = "lblcourseprice";
            this.lblcourseprice.Size = new System.Drawing.Size(159, 29);
            this.lblcourseprice.TabIndex = 143;
            this.lblcourseprice.Text = "Course Price:";
            // 
            // txtcoursename
            // 
            this.txtcoursename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcoursename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcoursename.Location = new System.Drawing.Point(202, 32);
            this.txtcoursename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcoursename.Name = "txtcoursename";
            this.txtcoursename.Size = new System.Drawing.Size(354, 35);
            this.txtcoursename.TabIndex = 142;
            // 
            // lblcoursename
            // 
            this.lblcoursename.AutoSize = true;
            this.lblcoursename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoursename.Location = new System.Drawing.Point(22, 35);
            this.lblcoursename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcoursename.Name = "lblcoursename";
            this.lblcoursename.Size = new System.Drawing.Size(163, 29);
            this.lblcoursename.TabIndex = 141;
            this.lblcoursename.Text = "Course name:";
            // 
            // btncourseremove
            // 
            this.btncourseremove.BackColor = System.Drawing.Color.Red;
            this.btncourseremove.ForeColor = System.Drawing.Color.White;
            this.btncourseremove.Location = new System.Drawing.Point(340, 476);
            this.btncourseremove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncourseremove.Name = "btncourseremove";
            this.btncourseremove.Size = new System.Drawing.Size(278, 54);
            this.btncourseremove.TabIndex = 150;
            this.btncourseremove.Text = "Remove Course";
            this.btncourseremove.UseVisualStyleBackColor = false;
            this.btncourseremove.Click += new System.EventHandler(this.btncourseremove_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox6.Controls.Add(this.lsresult);
            this.groupBox6.Location = new System.Drawing.Point(656, 108);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(584, 711);
            this.groupBox6.TabIndex = 154;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Course Information";
            // 
            // lsresult
            // 
            this.lsresult.FormattingEnabled = true;
            this.lsresult.ItemHeight = 20;
            this.lsresult.Location = new System.Drawing.Point(27, 40);
            this.lsresult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsresult.Name = "lsresult";
            this.lsresult.Size = new System.Drawing.Size(528, 644);
            this.lsresult.TabIndex = 151;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(864, 845);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 74);
            this.button1.TabIndex = 156;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(656, 845);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 74);
            this.button2.TabIndex = 155;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1066, 845);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 74);
            this.button3.TabIndex = 157;
            this.button3.Text = "Exist";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(34, 476);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(278, 54);
            this.button4.TabIndex = 158;
            this.button4.Text = "Add Course";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox5.Controls.Add(this.lblnumberofcourse);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.lscourses);
            this.groupBox5.Location = new System.Drawing.Point(26, 567);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(584, 168);
            this.groupBox5.TabIndex = 149;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Course Information";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // lblnumberofcourse
            // 
            this.lblnumberofcourse.BackColor = System.Drawing.Color.Gainsboro;
            this.lblnumberofcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumberofcourse.Location = new System.Drawing.Point(368, 266);
            this.lblnumberofcourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnumberofcourse.Name = "lblnumberofcourse";
            this.lblnumberofcourse.Size = new System.Drawing.Size(189, 31);
            this.lblnumberofcourse.TabIndex = 153;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 266);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 29);
            this.label6.TabIndex = 152;
            this.label6.Text = "Number of regestared corses:";
            // 
            // lscourses
            // 
            this.lscourses.FormattingEnabled = true;
            this.lscourses.ItemHeight = 20;
            this.lscourses.Location = new System.Drawing.Point(29, 34);
            this.lscourses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lscourses.Name = "lscourses";
            this.lscourses.Size = new System.Drawing.Size(528, 124);
            this.lscourses.TabIndex = 151;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 1002);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btncourseremove);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtcourseprice;
        private System.Windows.Forms.Label lblcourseprice;
        private System.Windows.Forms.TextBox txtcoursename;
        private System.Windows.Forms.Label lblcoursename;
        private System.Windows.Forms.Button btncourseremove;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lsresult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblnumberofcourse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lscourses;
        private System.Windows.Forms.TextBox txtnumberofcourse;
        private System.Windows.Forms.Label label1;
    }
}

