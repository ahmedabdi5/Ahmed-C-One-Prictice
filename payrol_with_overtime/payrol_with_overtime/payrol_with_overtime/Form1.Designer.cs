namespace payrol_with_overtime
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
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hourse Worked:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hourly pay rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gross pay:";
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(239, 45);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(177, 26);
            this.hoursWorkedTextBox.TabIndex = 3;
            // 
            // hourlyPayRateTextBox
            // 
            this.hourlyPayRateTextBox.Location = new System.Drawing.Point(239, 87);
            this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            this.hourlyPayRateTextBox.Size = new System.Drawing.Size(177, 26);
            this.hourlyPayRateTextBox.TabIndex = 4;
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grossPayLabel.Location = new System.Drawing.Point(239, 125);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(145, 34);
            this.grossPayLabel.TabIndex = 5;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(104, 188);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(102, 51);
            this.btncalculate.TabIndex = 6;
            this.btncalculate.Text = "Calculate Gross Pay";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(228, 188);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(107, 51);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(354, 188);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(107, 51);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 479);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.hourlyPayRateTextBox);
            this.Controls.Add(this.hoursWorkedTextBox);
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
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.TextBox hourlyPayRateTextBox;
        private System.Windows.Forms.Label grossPayLabel;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

