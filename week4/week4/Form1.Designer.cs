namespace week3
{
    partial class lblName
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblAge = new Label();
            lblCity = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtCity = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            lstStudents = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 62);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(52, 99);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(26, 15);
            lblAge.TabIndex = 1;
            lblAge.Text = "age";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(52, 134);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(26, 15);
            lblCity.TabIndex = 2;
            lblCity.Text = "city";
            // 
            // txtName
            // 
            txtName.Location = new Point(176, 62);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(176, 99);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 4;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(176, 134);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(52, 207);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(166, 207);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(269, 207);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 8;
            btnClear.Text = "clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 15;
            lstStudents.Location = new Point(82, 283);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(120, 94);
            lstStudents.TabIndex = 9;
            // 
            // lblName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstStudents);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtCity);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(lblCity);
            Controls.Add(lblAge);
            Controls.Add(label1);
            Name = "lblName";
            Text = "name";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblAge;
        private Label lblCity;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtCity;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnClear;
        private ListBox lstStudents;
    }
}
