namespace Test_Score_Average
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
            this.lbltest = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblscore2 = new System.Windows.Forms.Label();
            this.lblscore3 = new System.Windows.Forms.Label();
            this.lblAvarege = new System.Windows.Forms.Label();
            this.lbloutputAverage = new System.Windows.Forms.Label();
            this.txtscore1 = new System.Windows.Forms.TextBox();
            this.txtscore2 = new System.Windows.Forms.TextBox();
            this.txtscore3 = new System.Windows.Forms.TextBox();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Location = new System.Drawing.Point(51, 54);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(182, 20);
            this.lbltest.TabIndex = 0;
            this.lbltest.Text = "Enter Three Test Scores";
            this.lbltest.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Location = new System.Drawing.Point(159, 93);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(108, 20);
            this.lblScore1.TabIndex = 1;
            this.lblScore1.Text = "Test Score #1";
            // 
            // lblscore2
            // 
            this.lblscore2.AutoSize = true;
            this.lblscore2.Location = new System.Drawing.Point(159, 133);
            this.lblscore2.Name = "lblscore2";
            this.lblscore2.Size = new System.Drawing.Size(108, 20);
            this.lblscore2.TabIndex = 2;
            this.lblscore2.Text = "Test Score #2";
            // 
            // lblscore3
            // 
            this.lblscore3.AutoSize = true;
            this.lblscore3.Location = new System.Drawing.Point(159, 178);
            this.lblscore3.Name = "lblscore3";
            this.lblscore3.Size = new System.Drawing.Size(108, 20);
            this.lblscore3.TabIndex = 3;
            this.lblscore3.Text = "Test Score #3";
            // 
            // lblAvarege
            // 
            this.lblAvarege.AutoSize = true;
            this.lblAvarege.Location = new System.Drawing.Point(222, 237);
            this.lblAvarege.Name = "lblAvarege";
            this.lblAvarege.Size = new System.Drawing.Size(68, 20);
            this.lblAvarege.TabIndex = 4;
            this.lblAvarege.Text = "Average";
            // 
            // lbloutputAverage
            // 
            this.lbloutputAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutputAverage.Location = new System.Drawing.Point(300, 227);
            this.lbloutputAverage.Name = "lbloutputAverage";
            this.lbloutputAverage.Size = new System.Drawing.Size(149, 34);
            this.lbloutputAverage.TabIndex = 5;
            // 
            // txtscore1
            // 
            this.txtscore1.Location = new System.Drawing.Point(285, 90);
            this.txtscore1.Name = "txtscore1";
            this.txtscore1.Size = new System.Drawing.Size(164, 26);
            this.txtscore1.TabIndex = 6;
            // 
            // txtscore2
            // 
            this.txtscore2.Location = new System.Drawing.Point(285, 133);
            this.txtscore2.Name = "txtscore2";
            this.txtscore2.Size = new System.Drawing.Size(164, 26);
            this.txtscore2.TabIndex = 7;
            // 
            // txtscore3
            // 
            this.txtscore3.Location = new System.Drawing.Point(285, 175);
            this.txtscore3.Name = "txtscore3";
            this.txtscore3.Size = new System.Drawing.Size(164, 26);
            this.txtscore3.TabIndex = 8;
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(214, 296);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(114, 61);
            this.btnAverage.TabIndex = 9;
            this.btnAverage.Text = "Calculate Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(353, 296);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(108, 29);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(353, 331);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(108, 29);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 580);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.txtscore3);
            this.Controls.Add(this.txtscore2);
            this.Controls.Add(this.txtscore1);
            this.Controls.Add(this.lbloutputAverage);
            this.Controls.Add(this.lblAvarege);
            this.Controls.Add(this.lblscore3);
            this.Controls.Add(this.lblscore2);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.lbltest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltest;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblscore2;
        private System.Windows.Forms.Label lblscore3;
        private System.Windows.Forms.Label lblAvarege;
        private System.Windows.Forms.Label lbloutputAverage;
        private System.Windows.Forms.TextBox txtscore1;
        private System.Windows.Forms.TextBox txtscore2;
        private System.Windows.Forms.TextBox txtscore3;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

