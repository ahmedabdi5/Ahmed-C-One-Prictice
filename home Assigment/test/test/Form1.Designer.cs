namespace test
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
            this.lbldayoftheweak = new System.Windows.Forms.Label();
            this.lblmonth = new System.Windows.Forms.Label();
            this.lblnumeric = new System.Windows.Forms.Label();
            this.lblyear = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.txtweak = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtnumeric = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.btnshowdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldayoftheweak
            // 
            this.lbldayoftheweak.AutoSize = true;
            this.lbldayoftheweak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldayoftheweak.Location = new System.Drawing.Point(66, 32);
            this.lbldayoftheweak.Name = "lbldayoftheweak";
            this.lbldayoftheweak.Size = new System.Drawing.Size(223, 20);
            this.lbldayoftheweak.TabIndex = 0;
            this.lbldayoftheweak.Text = "Enter The day of The weak";
            // 
            // lblmonth
            // 
            this.lblmonth.AutoSize = true;
            this.lblmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonth.Location = new System.Drawing.Point(66, 75);
            this.lblmonth.Name = "lblmonth";
            this.lblmonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblmonth.Size = new System.Drawing.Size(214, 20);
            this.lblmonth.TabIndex = 1;
            this.lblmonth.Text = "Enter Name Of the month";
            this.lblmonth.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblnumeric
            // 
            this.lblnumeric.AutoSize = true;
            this.lblnumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumeric.Location = new System.Drawing.Point(66, 123);
            this.lblnumeric.Name = "lblnumeric";
            this.lblnumeric.Size = new System.Drawing.Size(233, 20);
            this.lblnumeric.TabIndex = 2;
            this.lblnumeric.Text = "Enter Numeric Of the month";
            this.lblnumeric.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(66, 167);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(131, 20);
            this.lblyear.TabIndex = 3;
            this.lblyear.Text = "Enter The Year";
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(134, 228);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(488, 45);
            this.lbloutput.TabIndex = 4;
            // 
            // txtweak
            // 
            this.txtweak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtweak.Location = new System.Drawing.Point(327, 32);
            this.txtweak.Name = "txtweak";
            this.txtweak.Size = new System.Drawing.Size(254, 35);
            this.txtweak.TabIndex = 5;
            // 
            // txtmonth
            // 
            this.txtmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonth.Location = new System.Drawing.Point(327, 75);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(254, 35);
            this.txtmonth.TabIndex = 6;
            // 
            // txtnumeric
            // 
            this.txtnumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumeric.Location = new System.Drawing.Point(327, 120);
            this.txtnumeric.Name = "txtnumeric";
            this.txtnumeric.Size = new System.Drawing.Size(254, 35);
            this.txtnumeric.TabIndex = 7;
            // 
            // txtyear
            // 
            this.txtyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyear.Location = new System.Drawing.Point(327, 161);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(254, 35);
            this.txtyear.TabIndex = 8;
            // 
            // btnshowdate
            // 
            this.btnshowdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowdate.Location = new System.Drawing.Point(122, 319);
            this.btnshowdate.Name = "btnshowdate";
            this.btnshowdate.Size = new System.Drawing.Size(117, 57);
            this.btnshowdate.TabIndex = 9;
            this.btnshowdate.Text = "Show Date";
            this.btnshowdate.UseVisualStyleBackColor = true;
            this.btnshowdate.Click += new System.EventHandler(this.btnshowdate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(308, 339);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(126, 57);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(503, 322);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(108, 50);
            this.btnclose.TabIndex = 11;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowdate);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtnumeric);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtweak);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.lblnumeric);
            this.Controls.Add(this.lblmonth);
            this.Controls.Add(this.lbldayoftheweak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldayoftheweak;
        private System.Windows.Forms.Label lblmonth;
        private System.Windows.Forms.Label lblnumeric;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.TextBox txtweak;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtnumeric;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Button btnshowdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
    }
}

