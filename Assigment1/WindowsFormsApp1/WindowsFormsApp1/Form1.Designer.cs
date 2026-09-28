namespace WindowsFormsApp1
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(139, 69);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(186, 20);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter The Student Name";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblstudentid
            // 
            this.lblstudentid.AutoSize = true;
            this.lblstudentid.Location = new System.Drawing.Point(139, 119);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(157, 20);
            this.lblstudentid.TabIndex = 1;
            this.lblstudentid.Text = "Enter the Student ID";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Location = new System.Drawing.Point(139, 165);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(168, 20);
            this.lbldepartment.TabIndex = 2;
            this.lbldepartment.Text = "Enter The Department";
            // 
            // lblsemester
            // 
            this.lblsemester.AutoSize = true;
            this.lblsemester.Location = new System.Drawing.Point(139, 204);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(152, 20);
            this.lblsemester.TabIndex = 3;
            this.lblsemester.Text = "Enter The Semester";
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(203, 257);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(420, 57);
            this.lbloutput.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(341, 69);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(223, 26);
            this.txtname.TabIndex = 5;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(341, 119);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(223, 26);
            this.txtstudentid.TabIndex = 6;
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(341, 165);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(223, 26);
            this.txtdepartment.TabIndex = 7;
            // 
            // txtsemester
            // 
            this.txtsemester.Location = new System.Drawing.Point(341, 204);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(223, 26);
            this.txtsemester.TabIndex = 8;
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.Location = new System.Drawing.Point(143, 363);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(182, 53);
            this.btnshowinfo.TabIndex = 9;
            this.btnshowinfo.Text = "show information";
            this.btnshowinfo.UseVisualStyleBackColor = true;
            this.btnshowinfo.Click += new System.EventHandler(this.btnshowinfo_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(385, 373);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 43);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(589, 362);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 44);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 537);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblstudentid);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

