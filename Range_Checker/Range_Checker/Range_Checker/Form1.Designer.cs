namespace Range_Checker
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
            this.lblchecker = new System.Windows.Forms.Label();
            this.lblrange = new System.Windows.Forms.Label();
            this.lbldiscision = new System.Windows.Forms.Label();
            this.lblRangeDecision = new System.Windows.Forms.Label();
            this.btncheck = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblchecker
            // 
            this.lblchecker.AutoSize = true;
            this.lblchecker.Location = new System.Drawing.Point(124, 42);
            this.lblchecker.Name = "lblchecker";
            this.lblchecker.Size = new System.Drawing.Size(200, 20);
            this.lblchecker.TabIndex = 0;
            this.lblchecker.Text = "Range Checker appliaction";
            // 
            // lblrange
            // 
            this.lblrange.AutoSize = true;
            this.lblrange.Location = new System.Drawing.Point(124, 73);
            this.lblrange.Name = "lblrange";
            this.lblrange.Size = new System.Drawing.Size(328, 20);
            this.lblrange.TabIndex = 1;
            this.lblrange.Text = "Enter an integer in the range of 1 throught 10";
            // 
            // lbldiscision
            // 
            this.lbldiscision.AutoSize = true;
            this.lbldiscision.Location = new System.Drawing.Point(189, 145);
            this.lbldiscision.Name = "lbldiscision";
            this.lbldiscision.Size = new System.Drawing.Size(122, 20);
            this.lbldiscision.TabIndex = 2;
            this.lbldiscision.Text = "Range Decision";
            // 
            // lblRangeDecision
            // 
            this.lblRangeDecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRangeDecision.Location = new System.Drawing.Point(117, 183);
            this.lblRangeDecision.Name = "lblRangeDecision";
            this.lblRangeDecision.Size = new System.Drawing.Size(335, 33);
            this.lblRangeDecision.TabIndex = 3;
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(117, 257);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(135, 72);
            this.btncheck.TabIndex = 4;
            this.btncheck.Text = "Check Qualification";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(299, 258);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(101, 32);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(299, 297);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(101, 32);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(169, 98);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(171, 26);
            this.numberTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.lblRangeDecision);
            this.Controls.Add(this.lbldiscision);
            this.Controls.Add(this.lblrange);
            this.Controls.Add(this.lblchecker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblchecker;
        private System.Windows.Forms.Label lblrange;
        private System.Windows.Forms.Label lbldiscision;
        private System.Windows.Forms.Label lblRangeDecision;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox numberTextBox;
    }
}

