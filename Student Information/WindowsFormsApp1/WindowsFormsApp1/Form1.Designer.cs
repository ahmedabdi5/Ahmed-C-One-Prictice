namespace StudentInformationSystem
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdopostgraduate = new System.Windows.Forms.RadioButton();
            this.rdoundergraduate = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtmarks = new System.Windows.Forms.TextBox();
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdepartment);
            this.groupBox1.Controls.Add(this.txtmarks);
            this.groupBox1.Controls.Add(this.txtstudentname);
            this.groupBox1.Controls.Add(this.txtstudentid);
            this.groupBox1.Location = new System.Drawing.Point(40, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 450);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdopostgraduate);
            this.groupBox2.Controls.Add(this.rdoundergraduate);
            this.groupBox2.Location = new System.Drawing.Point(17, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 142);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Type";
            // 
            // rdopostgraduate
            // 
            this.rdopostgraduate.AutoSize = true;
            this.rdopostgraduate.Location = new System.Drawing.Point(35, 81);
            this.rdopostgraduate.Name = "rdopostgraduate";
            this.rdopostgraduate.Size = new System.Drawing.Size(130, 24);
            this.rdopostgraduate.TabIndex = 0;
            this.rdopostgraduate.TabStop = true;
            this.rdopostgraduate.Text = "Postgraduate";
            this.rdopostgraduate.UseVisualStyleBackColor = true;
            // 
            // rdoundergraduate
            // 
            this.rdoundergraduate.AutoSize = true;
            this.rdoundergraduate.Location = new System.Drawing.Point(35, 34);
            this.rdoundergraduate.Name = "rdoundergraduate";
            this.rdoundergraduate.Size = new System.Drawing.Size(142, 24);
            this.rdoundergraduate.TabIndex = 0;
            this.rdoundergraduate.TabStop = true;
            this.rdoundergraduate.Text = "Undergraduate";
            this.rdoundergraduate.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Marks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Student Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student ID:";
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(154, 134);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(206, 26);
            this.txtdepartment.TabIndex = 3;
            // 
            // txtmarks
            // 
            this.txtmarks.Location = new System.Drawing.Point(154, 180);
            this.txtmarks.Name = "txtmarks";
            this.txtmarks.Size = new System.Drawing.Size(206, 26);
            this.txtmarks.TabIndex = 4;
            // 
            // txtstudentname
            // 
            this.txtstudentname.Location = new System.Drawing.Point(154, 88);
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(206, 26);
            this.txtstudentname.TabIndex = 5;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(154, 46);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(206, 26);
            this.txtstudentid.TabIndex = 6;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(70, 506);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(138, 58);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Save to file";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(229, 506);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(138, 58);
            this.btnread.TabIndex = 6;
            this.btnread.Text = "read from file";
            this.btnread.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(412, 506);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(138, 58);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(613, 506);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(138, 58);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.FormattingEnabled = true;
            this.result.ItemHeight = 20;
            this.result.Location = new System.Drawing.Point(637, 25);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(361, 464);
            this.result.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 606);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtmarks;
        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdopostgraduate;
        private System.Windows.Forms.RadioButton rdoundergraduate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox result;
    }
}

