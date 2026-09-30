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
            this.food1 = new System.Windows.Forms.Label();
            this.price1 = new System.Windows.Forms.Label();
            this.food2 = new System.Windows.Forms.Label();
            this.price2 = new System.Windows.Forms.Label();
            this.txtfood1 = new System.Windows.Forms.TextBox();
            this.txtprice1 = new System.Windows.Forms.TextBox();
            this.txtfood2 = new System.Windows.Forms.TextBox();
            this.txtprice2 = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // food1
            // 
            this.food1.AutoSize = true;
            this.food1.Location = new System.Drawing.Point(90, 56);
            this.food1.Name = "food1";
            this.food1.Size = new System.Drawing.Size(115, 20);
            this.food1.TabIndex = 0;
            this.food1.Text = "Enter food one";
            // 
            // price1
            // 
            this.price1.AutoSize = true;
            this.price1.Location = new System.Drawing.Point(90, 97);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(99, 20);
            this.price1.TabIndex = 1;
            this.price1.Text = "Enter price 1";
            // 
            // food2
            // 
            this.food2.AutoSize = true;
            this.food2.Location = new System.Drawing.Point(90, 141);
            this.food2.Name = "food2";
            this.food2.Size = new System.Drawing.Size(113, 20);
            this.food2.TabIndex = 2;
            this.food2.Text = "Enter food two";
            // 
            // price2
            // 
            this.price2.AutoSize = true;
            this.price2.Location = new System.Drawing.Point(90, 181);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(99, 20);
            this.price2.TabIndex = 3;
            this.price2.Text = "Enter price 2";
            // 
            // txtfood1
            // 
            this.txtfood1.Location = new System.Drawing.Point(231, 56);
            this.txtfood1.Name = "txtfood1";
            this.txtfood1.Size = new System.Drawing.Size(223, 26);
            this.txtfood1.TabIndex = 4;
            // 
            // txtprice1
            // 
            this.txtprice1.Location = new System.Drawing.Point(231, 97);
            this.txtprice1.Name = "txtprice1";
            this.txtprice1.Size = new System.Drawing.Size(223, 26);
            this.txtprice1.TabIndex = 5;
            // 
            // txtfood2
            // 
            this.txtfood2.Location = new System.Drawing.Point(231, 141);
            this.txtfood2.Name = "txtfood2";
            this.txtfood2.Size = new System.Drawing.Size(223, 26);
            this.txtfood2.TabIndex = 6;
            // 
            // txtprice2
            // 
            this.txtprice2.Location = new System.Drawing.Point(231, 181);
            this.txtprice2.Name = "txtprice2";
            this.txtprice2.Size = new System.Drawing.Size(223, 26);
            this.txtprice2.TabIndex = 7;
            // 
            // lblresult
            // 
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblresult.Location = new System.Drawing.Point(44, 244);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(370, 58);
            this.lblresult.TabIndex = 8;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(489, 270);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(119, 48);
            this.btncalculate.TabIndex = 9;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txtprice2);
            this.Controls.Add(this.txtfood2);
            this.Controls.Add(this.txtprice1);
            this.Controls.Add(this.txtfood1);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.food2);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.food1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label food1;
        private System.Windows.Forms.Label price1;
        private System.Windows.Forms.Label food2;
        private System.Windows.Forms.Label price2;
        private System.Windows.Forms.TextBox txtfood1;
        private System.Windows.Forms.TextBox txtprice1;
        private System.Windows.Forms.TextBox txtfood2;
        private System.Windows.Forms.TextBox txtprice2;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btncalculate;
    }
}

