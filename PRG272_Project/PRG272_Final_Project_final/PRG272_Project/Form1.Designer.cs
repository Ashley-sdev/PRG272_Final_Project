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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
<<<<<<< HEAD
            this.CmbCourse = new System.Windows.Forms.ComboBox();
=======
>>>>>>> bf6b253a044ace275c92d4aefc9075fefa39c54d
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
<<<<<<< HEAD
=======
            this.Course_textBox = new System.Windows.Forms.TextBox();
>>>>>>> bf6b253a044ace275c92d4aefc9075fefa39c54d
            this.Age_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.StudentID_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.Search_by_studentID = new System.Windows.Forms.Button();
            this.Delete_student = new System.Windows.Forms.Button();
            this.Update_Student_Details = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Summary = new System.Windows.Forms.Button();
            this.btn_All_Students = new System.Windows.Forms.Button();
            this.btn_Add_Student = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
=======
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
>>>>>>> bf6b253a044ace275c92d4aefc9075fefa39c54d
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
            this.groupBox1.Controls.Add(this.CmbCourse);
            this.groupBox1.Controls.Add(this.lblCourse);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblStudentID);
            this.groupBox1.Controls.Add(this.Age_textBox);
            this.groupBox1.Controls.Add(this.Name_textBox);
            this.groupBox1.Controls.Add(this.StudentID_textBox);
<<<<<<< HEAD
            this.groupBox1.Location = new System.Drawing.Point(12, 187);
=======
            this.groupBox1.Location = new System.Drawing.Point(9, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> bf6b253a044ace275c92d4aefc9075fefa39c54d
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(209, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add student";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
<<<<<<< HEAD
            // CmbCourse
            // 
            this.CmbCourse.FormattingEnabled = true;
            this.CmbCourse.Location = new System.Drawing.Point(149, 179);
            this.CmbCourse.Name = "CmbCourse";
            this.CmbCourse.Size = new System.Drawing.Size(100, 24);
            this.CmbCourse.TabIndex = 8;
            this.CmbCourse.SelectedIndexChanged += new System.EventHandler(this.CmbCourse_SelectedIndexChanged);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(24, 182);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(50, 16);
=======
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(18, 148);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(40, 13);
>>>>>>> bf6b253a044ace275c92d4aefc9075fefa39c54d
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
<<<<<<< HEAD
            this.lblName.Location = new System.Drawing.Point(18, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
=======
            this.lblName.Location = new System.Drawing.Point(14, 67);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
>>>>>>> bf6b253a044ace275c92d4aefc9075fefa39c54d
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
<<<<<<< HEAD
            this.lblStudentID.Location = new System.Drawing.Point(15, 35);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(65, 16);
            this.lblStudentID.TabIndex = 4;
            this.lblStudentID.Text = "StudentID";
            // 
            // Age_textBox
            // 
            this.Age_textBox.Location = new System.Drawing.Point(149, 132);
            this.Age_textBox.Name = "Age_textBox";
            this.Age_textBox.Size = new System.Drawing.Size(100, 22);
=======
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
>>>>>>> bf6b253a044ace275c92d4aefc9075fefa39c54d
            this.Age_textBox.TabIndex = 2;
            // 
            // Name_textBox
            // 
<<<<<<< HEAD
            this.Name_textBox.Location = new System.Drawing.Point(149, 82);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(100, 22);
=======
            this.Name_textBox.Location = new System.Drawing.Point(112, 67);
            this.Name_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(76, 20);
>>>>>>> bf6b253a044ace275c92d4aefc9075fefa39c54d
            this.Name_textBox.TabIndex = 1;
            // 
            // StudentID_textBox
            // 
<<<<<<< HEAD
            this.StudentID_textBox.Location = new System.Drawing.Point(149, 30);
            this.StudentID_textBox.Name = "StudentID_textBox";
            this.StudentID_textBox.Size = new System.Drawing.Size(100, 22);
=======
            this.StudentID_textBox.Location = new System.Drawing.Point(112, 24);
            this.StudentID_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentID_textBox.Name = "StudentID_textBox";
            this.StudentID_textBox.Size = new System.Drawing.Size(76, 20);
>>>>>>> bf6b253a044ace275c92d4aefc9075fefa39c54d
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
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Search_TextBox
            // 
<<<<<<< HEAD
            this.Search_TextBox.Location = new System.Drawing.Point(468, 89);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(332, 22);
            this.Search_TextBox.TabIndex = 4;
            this.Search_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Search_TextBox.TextChanged += new System.EventHandler(this.Search_TextBox_TextChanged);
=======
            this.Search_TextBox.Location = new System.Drawing.Point(399, 72);
            this.Search_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(259, 20);
            this.Search_TextBox.TabIndex = 4;
>>>>>>> bf6b253a044ace275c92d4aefc9075fefa39c54d
            // 
            // Search_by_studentID
            // 
            this.Search_by_studentID.Location = new System.Drawing.Point(267, 72);
            this.Search_by_studentID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Search_by_studentID.Name = "Search_by_studentID";
<<<<<<< HEAD
            this.Search_by_studentID.Size = new System.Drawing.Size(152, 23);
=======
            this.Search_by_studentID.Size = new System.Drawing.Size(117, 19);
>>>>>>> bf6b253a044ace275c92d4aefc9075fefa39c54d
            this.Search_by_studentID.TabIndex = 5;
            this.Search_by_studentID.Text = "Search by StudentID";
            this.Search_by_studentID.UseVisualStyleBackColor = true;
            this.Search_by_studentID.Click += new System.EventHandler(this.Search_by_studentID_Click);
            // 
            // Delete_student
            // 
<<<<<<< HEAD
            this.Delete_student.Location = new System.Drawing.Point(60, 503);
            this.Delete_student.Name = "Delete_student";
            this.Delete_student.Size = new System.Drawing.Size(145, 23);
=======
            this.Delete_student.Location = new System.Drawing.Point(22, 328);
            this.Delete_student.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Delete_student.Name = "Delete_student";
            this.Delete_student.Size = new System.Drawing.Size(63, 19);
>>>>>>> bf6b253a044ace275c92d4aefc9075fefa39c54d
            this.Delete_student.TabIndex = 6;
            this.Delete_student.Text = "Delete Student";
            this.Delete_student.UseVisualStyleBackColor = true;
            this.Delete_student.Click += new System.EventHandler(this.Delete_student_Click);
            // 
            // Update_Student_Details
            // 
<<<<<<< HEAD
            this.Update_Student_Details.Location = new System.Drawing.Point(171, 448);
=======
            this.Update_Student_Details.Location = new System.Drawing.Point(121, 328);
            this.Update_Student_Details.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> bf6b253a044ace275c92d4aefc9075fefa39c54d
            this.Update_Student_Details.Name = "Update_Student_Details";
            this.Update_Student_Details.Size = new System.Drawing.Size(76, 19);
            this.Update_Student_Details.TabIndex = 7;
            this.Update_Student_Details.Text = "Update";
            this.Update_Student_Details.UseVisualStyleBackColor = true;
            this.Update_Student_Details.Click += new System.EventHandler(this.Update_Student_Details_Click);
            // 
<<<<<<< HEAD
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Summary);
            this.groupBox2.Controls.Add(this.btn_All_Students);
            this.groupBox2.Location = new System.Drawing.Point(844, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 164);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View";
            // 
            // Summary
            // 
            this.Summary.Location = new System.Drawing.Point(38, 98);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(134, 23);
            this.Summary.TabIndex = 9;
            this.Summary.Text = "Summary";
            this.Summary.UseVisualStyleBackColor = true;
            this.Summary.Click += new System.EventHandler(this.Summary_Click);
            // 
            // btn_All_Students
            // 
            this.btn_All_Students.Location = new System.Drawing.Point(38, 45);
            this.btn_All_Students.Name = "btn_All_Students";
            this.btn_All_Students.Size = new System.Drawing.Size(134, 23);
            this.btn_All_Students.TabIndex = 0;
            this.btn_All_Students.Text = "All Students";
            this.btn_All_Students.UseVisualStyleBackColor = true;
            this.btn_All_Students.Click += new System.EventHandler(this.btn_All_Students_Click);
            // 
            // btn_Add_Student
            // 
            this.btn_Add_Student.Location = new System.Drawing.Point(30, 448);
            this.btn_Add_Student.Name = "btn_Add_Student";
            this.btn_Add_Student.Size = new System.Drawing.Size(101, 23);
            this.btn_Add_Student.TabIndex = 9;
            this.btn_Add_Student.Text = "Add Student";
            this.btn_Add_Student.UseVisualStyleBackColor = true;
            this.btn_Add_Student.Click += new System.EventHandler(this.btn_Add_Student_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(916, 404);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 169);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
=======
>>>>>>> bf6b253a044ace275c92d4aefc9075fefa39c54d
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1185, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btn_Add_Student);
            this.Controls.Add(this.groupBox2);
=======
            this.ClientSize = new System.Drawing.Size(783, 419);
>>>>>>> bf6b253a044ace275c92d4aefc9075fefa39c54d
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
<<<<<<< HEAD
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
=======
>>>>>>> bf6b253a044ace275c92d4aefc9075fefa39c54d
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
        private System.Windows.Forms.TextBox Age_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox StudentID_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.Button Search_by_studentID;
        private System.Windows.Forms.Button Delete_student;
        private System.Windows.Forms.Button Update_Student_Details;
<<<<<<< HEAD
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_All_Students;
        private System.Windows.Forms.Button Summary;
        private System.Windows.Forms.ComboBox CmbCourse;
        private System.Windows.Forms.Button btn_Add_Student;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
=======
>>>>>>> bf6b253a044ace275c92d4aefc9075fefa39c54d
    }
}

