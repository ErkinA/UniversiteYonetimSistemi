namespace CollegeManagementSystem.Student
{
    partial class frmAttendance
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.rdAbsent = new System.Windows.Forms.RadioButton();
            this.rdPresent = new System.Windows.Forms.RadioButton();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.cmbStudentName = new System.Windows.Forms.ComboBox();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridStudentAttendanceData = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RollNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudentAttendanceData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picStudent);
            this.groupBox1.Controls.Add(this.rdAbsent);
            this.groupBox1.Controls.Add(this.rdPresent);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Controls.Add(this.txtRollNo);
            this.groupBox1.Controls.Add(this.cmbStudentName);
            this.groupBox1.Controls.Add(this.cmbSemester);
            this.groupBox1.Controls.Add(this.cmbCourse);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(967, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Katılım Detayları";
            // 
            // picStudent
            // 
            this.picStudent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picStudent.BackgroundImage = global::CollegeManagementSystem.Properties.Resources.empty_profile;
            this.picStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStudent.Location = new System.Drawing.Point(717, 21);
            this.picStudent.Margin = new System.Windows.Forms.Padding(4);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(231, 205);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStudent.TabIndex = 15;
            this.picStudent.TabStop = false;
            // 
            // rdAbsent
            // 
            this.rdAbsent.AutoSize = true;
            this.rdAbsent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAbsent.Location = new System.Drawing.Point(254, 149);
            this.rdAbsent.Margin = new System.Windows.Forms.Padding(4);
            this.rdAbsent.Name = "rdAbsent";
            this.rdAbsent.Size = new System.Drawing.Size(62, 22);
            this.rdAbsent.TabIndex = 7;
            this.rdAbsent.TabStop = true;
            this.rdAbsent.Text = "Değil";
            this.rdAbsent.UseVisualStyleBackColor = true;
            // 
            // rdPresent
            // 
            this.rdPresent.AutoSize = true;
            this.rdPresent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPresent.Location = new System.Drawing.Point(157, 149);
            this.rdPresent.Margin = new System.Windows.Forms.Padding(4);
            this.rdPresent.Name = "rdPresent";
            this.rdPresent.Size = new System.Drawing.Size(76, 22);
            this.rdPresent.TabIndex = 6;
            this.rdPresent.TabStop = true;
            this.rdPresent.Text = "Burada";
            this.rdPresent.UseVisualStyleBackColor = true;
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(532, 112);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(163, 24);
            this.datePicker.TabIndex = 5;
            // 
            // txtRollNo
            // 
            this.txtRollNo.BackColor = System.Drawing.Color.White;
            this.txtRollNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRollNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRollNo.Location = new System.Drawing.Point(157, 112);
            this.txtRollNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.ReadOnly = true;
            this.txtRollNo.Size = new System.Drawing.Size(305, 24);
            this.txtRollNo.TabIndex = 4;
            // 
            // cmbStudentName
            // 
            this.cmbStudentName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStudentName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudentName.FormattingEnabled = true;
            this.cmbStudentName.Location = new System.Drawing.Point(157, 71);
            this.cmbStudentName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStudentName.Name = "cmbStudentName";
            this.cmbStudentName.Size = new System.Drawing.Size(538, 26);
            this.cmbStudentName.TabIndex = 3;
            this.cmbStudentName.SelectedIndexChanged += new System.EventHandler(this.cmbStudentName_SelectedIndexChanged);
            // 
            // cmbSemester
            // 
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.Enabled = false;
            this.cmbSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSemester.ForeColor = System.Drawing.Color.Black;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(572, 32);
            this.cmbSemester.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(123, 26);
            this.cmbSemester.TabIndex = 2;
            this.cmbSemester.SelectedIndexChanged += new System.EventHandler(this.cmbSemester_SelectedIndexChanged);
            // 
            // cmbCourse
            // 
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourse.ForeColor = System.Drawing.Color.Black;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(157, 31);
            this.cmbCourse.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(305, 26);
            this.cmbCourse.TabIndex = 1;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Katılım";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(480, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Öğrenci Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrenci Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(480, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sömestr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm";
            // 
            // gridStudentAttendanceData
            // 
            this.gridStudentAttendanceData.AllowUserToAddRows = false;
            this.gridStudentAttendanceData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStudentAttendanceData.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.gridStudentAttendanceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudentAttendanceData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Course,
            this.Semester,
            this.StudentName,
            this.RollNo,
            this.AttendanceDate,
            this.Attendance,
            this.StuId,
            this.CId});
            this.gridStudentAttendanceData.Location = new System.Drawing.Point(16, 316);
            this.gridStudentAttendanceData.Margin = new System.Windows.Forms.Padding(4);
            this.gridStudentAttendanceData.Name = "gridStudentAttendanceData";
            this.gridStudentAttendanceData.ReadOnly = true;
            this.gridStudentAttendanceData.RowHeadersVisible = false;
            this.gridStudentAttendanceData.RowHeadersWidth = 51;
            this.gridStudentAttendanceData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStudentAttendanceData.Size = new System.Drawing.Size(967, 315);
            this.gridStudentAttendanceData.TabIndex = 3;
            this.gridStudentAttendanceData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStudentAttendanceData_CellClick);
            this.gridStudentAttendanceData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStudentAttendanceData_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Course
            // 
            this.Course.HeaderText = "Bölüm";
            this.Course.MinimumWidth = 6;
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            // 
            // Semester
            // 
            this.Semester.HeaderText = "Sömestr";
            this.Semester.MinimumWidth = 6;
            this.Semester.Name = "Semester";
            this.Semester.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Öğrenci İsmi";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // RollNo
            // 
            this.RollNo.HeaderText = "Öğrenci Numarası";
            this.RollNo.MinimumWidth = 6;
            this.RollNo.Name = "RollNo";
            this.RollNo.ReadOnly = true;
            // 
            // AttendanceDate
            // 
            this.AttendanceDate.HeaderText = "Katılım Tarihi";
            this.AttendanceDate.MinimumWidth = 6;
            this.AttendanceDate.Name = "AttendanceDate";
            this.AttendanceDate.ReadOnly = true;
            // 
            // Attendance
            // 
            this.Attendance.HeaderText = "Katılım";
            this.Attendance.MinimumWidth = 6;
            this.Attendance.Name = "Attendance";
            this.Attendance.ReadOnly = true;
            // 
            // StuId
            // 
            this.StuId.HeaderText = "StudentId";
            this.StuId.MinimumWidth = 6;
            this.StuId.Name = "StuId";
            this.StuId.ReadOnly = true;
            this.StuId.Visible = false;
            // 
            // CId
            // 
            this.CId.HeaderText = "CourseId";
            this.CId.MinimumWidth = 6;
            this.CId.Name = "CId";
            this.CId.ReadOnly = true;
            this.CId.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(344, 261);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(779, 639);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 36);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Onayla";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(884, 639);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(448, 261);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(999, 684);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridStudentAttendanceData);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAttendance";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Attendance";
            this.Load += new System.EventHandler(this.frmAttendance_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAttendance_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudentAttendanceData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gridStudentAttendanceData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbStudentName;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.RadioButton rdAbsent;
        private System.Windows.Forms.RadioButton rdPresent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CId;
    }
}