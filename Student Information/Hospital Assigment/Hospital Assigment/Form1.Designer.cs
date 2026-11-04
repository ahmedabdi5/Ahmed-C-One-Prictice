namespace Hospital_Assigment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpateintid = new System.Windows.Forms.TextBox();
            this.txtpateintname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.btnregestration = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.btncount = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pateint Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pateint ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pateint Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender:";
            // 
            // txtpateintid
            // 
            this.txtpateintid.Location = new System.Drawing.Point(205, 79);
            this.txtpateintid.Name = "txtpateintid";
            this.txtpateintid.Size = new System.Drawing.Size(196, 26);
            this.txtpateintid.TabIndex = 5;
            // 
            // txtpateintname
            // 
            this.txtpateintname.Location = new System.Drawing.Point(205, 124);
            this.txtpateintname.Name = "txtpateintname";
            this.txtpateintname.Size = new System.Drawing.Size(196, 26);
            this.txtpateintname.TabIndex = 6;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(205, 167);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(196, 26);
            this.txtage.TabIndex = 7;
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Location = new System.Drawing.Point(172, 258);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(68, 24);
            this.rdomale.TabIndex = 8;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "male";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Location = new System.Drawing.Point(271, 258);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(82, 24);
            this.rdofemale.TabIndex = 9;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "female";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // btnregestration
            // 
            this.btnregestration.Location = new System.Drawing.Point(37, 359);
            this.btnregestration.Name = "btnregestration";
            this.btnregestration.Size = new System.Drawing.Size(146, 59);
            this.btnregestration.TabIndex = 10;
            this.btnregestration.Text = "Regetration Pateint";
            this.btnregestration.UseVisualStyleBackColor = true;
            this.btnregestration.Click += new System.EventHandler(this.btnregestration_Click);
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(233, 359);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(146, 59);
            this.btnview.TabIndex = 11;
            this.btnview.Text = "View From File";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btncount
            // 
            this.btncount.Location = new System.Drawing.Point(37, 473);
            this.btncount.Name = "btncount";
            this.btncount.Size = new System.Drawing.Size(146, 47);
            this.btncount.TabIndex = 12;
            this.btncount.Text = "count Pateint";
            this.btncount.UseVisualStyleBackColor = true;
            this.btncount.Click += new System.EventHandler(this.btncount_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(233, 473);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(146, 47);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(424, 473);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(146, 47);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(424, 359);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(146, 59);
            this.btnremove.TabIndex = 15;
            this.btnremove.Text = "Removed select";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // result
            // 
            this.result.FormattingEnabled = true;
            this.result.ItemHeight = 20;
            this.result.Location = new System.Drawing.Point(614, 47);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(333, 484);
            this.result.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 615);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncount);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnregestration);
            this.Controls.Add(this.rdofemale);
            this.Controls.Add(this.rdomale);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtpateintname);
            this.Controls.Add(this.txtpateintid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpateintid;
        private System.Windows.Forms.TextBox txtpateintname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.RadioButton rdomale;
        private System.Windows.Forms.RadioButton rdofemale;
        private System.Windows.Forms.Button btnregestration;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btncount;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.ListBox result;
    }
}

