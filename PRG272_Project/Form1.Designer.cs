namespace PRG272_Project
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.Course_textBox = new System.Windows.Forms.TextBox();
            this.Age_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.StudentID_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.Search_by_studentID = new System.Windows.Forms.Button();
            this.Delete_student = new System.Windows.Forms.Button();
            this.Update_Student_Details = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCourse);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblStudentID);
            this.groupBox1.Controls.Add(this.Course_textBox);
            this.groupBox1.Controls.Add(this.Age_textBox);
            this.groupBox1.Controls.Add(this.Name_textBox);
            this.groupBox1.Controls.Add(this.StudentID_textBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(209, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add student";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(18, 148);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(40, 13);
            this.lblCourse.TabIndex = 7;
            this.lblCourse.Text = "Course";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(16, 111);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 67);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(11, 28);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(55, 13);
            this.lblStudentID.TabIndex = 4;
            this.lblStudentID.Text = "StudentID";
            // 
            // Course_textBox
            // 
            this.Course_textBox.Location = new System.Drawing.Point(112, 148);
            this.Course_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Course_textBox.Name = "Course_textBox";
            this.Course_textBox.Size = new System.Drawing.Size(76, 20);
            this.Course_textBox.TabIndex = 3;
            // 
            // Age_textBox
            // 
            this.Age_textBox.Location = new System.Drawing.Point(112, 107);
            this.Age_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Age_textBox.Name = "Age_textBox";
            this.Age_textBox.Size = new System.Drawing.Size(76, 20);
            this.Age_textBox.TabIndex = 2;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(112, 67);
            this.Name_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(76, 20);
            this.Name_textBox.TabIndex = 1;
            // 
            // StudentID_textBox
            // 
            this.StudentID_textBox.Location = new System.Drawing.Point(112, 24);
            this.StudentID_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentID_textBox.Name = "StudentID_textBox";
            this.StudentID_textBox.Size = new System.Drawing.Size(76, 20);
            this.StudentID_textBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Belgium Campus Student Management Form";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 115);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(368, 267);
            this.dataGridView1.TabIndex = 3;
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Location = new System.Drawing.Point(399, 72);
            this.Search_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(259, 20);
            this.Search_TextBox.TabIndex = 4;
            // 
            // Search_by_studentID
            // 
            this.Search_by_studentID.Location = new System.Drawing.Point(267, 72);
            this.Search_by_studentID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Search_by_studentID.Name = "Search_by_studentID";
            this.Search_by_studentID.Size = new System.Drawing.Size(117, 19);
            this.Search_by_studentID.TabIndex = 5;
            this.Search_by_studentID.Text = "Search";
            this.Search_by_studentID.UseVisualStyleBackColor = true;
            // 
            // Delete_student
            // 
            this.Delete_student.Location = new System.Drawing.Point(22, 328);
            this.Delete_student.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Delete_student.Name = "Delete_student";
            this.Delete_student.Size = new System.Drawing.Size(63, 19);
            this.Delete_student.TabIndex = 6;
            this.Delete_student.Text = "Delete";
            this.Delete_student.UseVisualStyleBackColor = true;
            this.Delete_student.Click += new System.EventHandler(this.Delete_student_Click);
            // 
            // Update_Student_Details
            // 
            this.Update_Student_Details.Location = new System.Drawing.Point(121, 328);
            this.Update_Student_Details.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Update_Student_Details.Name = "Update_Student_Details";
            this.Update_Student_Details.Size = new System.Drawing.Size(76, 19);
            this.Update_Student_Details.TabIndex = 7;
            this.Update_Student_Details.Text = "Update";
            this.Update_Student_Details.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 419);
            this.Controls.Add(this.Update_Student_Details);
            this.Controls.Add(this.Delete_student);
            this.Controls.Add(this.Search_by_studentID);
            this.Controls.Add(this.Search_TextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox Course_textBox;
        private System.Windows.Forms.TextBox Age_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox StudentID_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.Button Search_by_studentID;
        private System.Windows.Forms.Button Delete_student;
        private System.Windows.Forms.Button Update_Student_Details;
    }
}

