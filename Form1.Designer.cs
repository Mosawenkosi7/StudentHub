namespace StudentHub
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentListButton = new System.Windows.Forms.Button();
            this.UpdateStudentbtn = new System.Windows.Forms.Button();
            this.DeleteRecordbtn = new System.Windows.Forms.Button();
            this.ViewReportbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentIdTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AgeUpDown = new System.Windows.Forms.NumericUpDown();
            this.CourseLbl = new System.Windows.Forms.Label();
            this.CoursecomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(14, 415);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(134, 41);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "SUBMIT";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(344, 81);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(520, 342);
            this.dataGridView1.TabIndex = 1;
            // 
            // StudentListButton
            // 
            this.StudentListButton.Location = new System.Drawing.Point(14, 484);
            this.StudentListButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StudentListButton.Name = "StudentListButton";
            this.StudentListButton.Size = new System.Drawing.Size(152, 42);
            this.StudentListButton.TabIndex = 2;
            this.StudentListButton.Text = "View Student List";
            this.StudentListButton.UseVisualStyleBackColor = true;
            // 
            // UpdateStudentbtn
            // 
            this.UpdateStudentbtn.Location = new System.Drawing.Point(222, 476);
            this.UpdateStudentbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateStudentbtn.Name = "UpdateStudentbtn";
            this.UpdateStudentbtn.Size = new System.Drawing.Size(134, 50);
            this.UpdateStudentbtn.TabIndex = 3;
            this.UpdateStudentbtn.Text = "Update Student";
            this.UpdateStudentbtn.UseVisualStyleBackColor = true;
            // 
            // DeleteRecordbtn
            // 
            this.DeleteRecordbtn.Location = new System.Drawing.Point(466, 480);
            this.DeleteRecordbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteRecordbtn.Name = "DeleteRecordbtn";
            this.DeleteRecordbtn.Size = new System.Drawing.Size(135, 50);
            this.DeleteRecordbtn.TabIndex = 4;
            this.DeleteRecordbtn.Text = "Delete Record";
            this.DeleteRecordbtn.UseVisualStyleBackColor = true;
            // 
            // ViewReportbtn
            // 
            this.ViewReportbtn.Location = new System.Drawing.Point(636, 476);
            this.ViewReportbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewReportbtn.Name = "ViewReportbtn";
            this.ViewReportbtn.Size = new System.Drawing.Size(172, 50);
            this.ViewReportbtn.TabIndex = 5;
            this.ViewReportbtn.Text = "View Summary Report";
            this.ViewReportbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student ID";
            // 
            // StudentIdTextBox
            // 
            this.StudentIdTextBox.Location = new System.Drawing.Point(33, 81);
            this.StudentIdTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StudentIdTextBox.Name = "StudentIdTextBox";
            this.StudentIdTextBox.Size = new System.Drawing.Size(210, 26);
            this.StudentIdTextBox.TabIndex = 7;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(33, 134);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(55, 20);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name:";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(36, 158);
            this.NametextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(206, 26);
            this.NametextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Age:";
            // 
            // AgeUpDown
            // 
            this.AgeUpDown.Location = new System.Drawing.Point(36, 248);
            this.AgeUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AgeUpDown.Name = "AgeUpDown";
            this.AgeUpDown.Size = new System.Drawing.Size(207, 26);
            this.AgeUpDown.TabIndex = 12;
            // 
            // CourseLbl
            // 
            this.CourseLbl.AutoSize = true;
            this.CourseLbl.Location = new System.Drawing.Point(36, 300);
            this.CourseLbl.Name = "CourseLbl";
            this.CourseLbl.Size = new System.Drawing.Size(64, 20);
            this.CourseLbl.TabIndex = 13;
            this.CourseLbl.Text = "Course:";
            // 
            // CoursecomboBox
            // 
            this.CoursecomboBox.FormattingEnabled = true;
            this.CoursecomboBox.Items.AddRange(new object[] {
            "Bachelor of Computing",
            "Bachelor of Information Systems",
            "Diploma in Information Systems",
            "Higher Certificate in Information Systems"});
            this.CoursecomboBox.Location = new System.Drawing.Point(33, 324);
            this.CoursecomboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CoursecomboBox.Name = "CoursecomboBox";
            this.CoursecomboBox.Size = new System.Drawing.Size(223, 28);
            this.CoursecomboBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.CoursecomboBox);
            this.Controls.Add(this.CourseLbl);
            this.Controls.Add(this.AgeUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.StudentIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewReportbtn);
            this.Controls.Add(this.DeleteRecordbtn);
            this.Controls.Add(this.UpdateStudentbtn);
            this.Controls.Add(this.StudentListButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SubmitButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button StudentListButton;
        private System.Windows.Forms.Button UpdateStudentbtn;
        private System.Windows.Forms.Button DeleteRecordbtn;
        private System.Windows.Forms.Button ViewReportbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StudentIdTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown AgeUpDown;
        private System.Windows.Forms.Label CourseLbl;
        private System.Windows.Forms.ComboBox CoursecomboBox;
    }
}

