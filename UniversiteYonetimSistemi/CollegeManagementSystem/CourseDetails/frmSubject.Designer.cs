namespace CollegeManagementSystem.CourseDetails
{
    partial class frmSubject
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
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataSubjectDetails = new System.Windows.Forms.DataGridView();
            this.SId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSubjectDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCredits);
            this.groupBox1.Controls.Add(this.txtSubjectName);
            this.groupBox1.Controls.Add(this.cmbSemester);
            this.groupBox1.Controls.Add(this.cmbCourse);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(837, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Detayları";
            // 
            // txtCredits
            // 
            this.txtCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCredits.Location = new System.Drawing.Point(539, 68);
            this.txtCredits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(103, 24);
            this.txtCredits.TabIndex = 4;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubjectName.Location = new System.Drawing.Point(151, 68);
            this.txtSubjectName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(278, 24);
            this.txtSubjectName.TabIndex = 3;
            // 
            // cmbSemester
            // 
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.Enabled = false;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(539, 32);
            this.cmbSemester.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(277, 26);
            this.cmbSemester.TabIndex = 2;
            this.cmbSemester.SelectedIndexChanged += new System.EventHandler(this.cmbSemester_SelectedIndexChanged);
            // 
            // cmbCourse
            // 
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(151, 32);
            this.cmbCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(277, 26);
            this.cmbCourse.TabIndex = 1;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kredi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ders İsmi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sömestr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm İsmi";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(288, 135);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 36);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(392, 135);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(496, 135);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Kapa";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataSubjectDetails
            // 
            this.dataSubjectDetails.AllowUserToAddRows = false;
            this.dataSubjectDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSubjectDetails.BackgroundColor = System.Drawing.Color.White;
            this.dataSubjectDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataSubjectDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSubjectDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SId,
            this.CourseName,
            this.Semester,
            this.SubjectName,
            this.Credits,
            this.CourseId});
            this.dataSubjectDetails.Location = new System.Drawing.Point(16, 191);
            this.dataSubjectDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataSubjectDetails.Name = "dataSubjectDetails";
            this.dataSubjectDetails.ReadOnly = true;
            this.dataSubjectDetails.RowHeadersVisible = false;
            this.dataSubjectDetails.RowHeadersWidth = 51;
            this.dataSubjectDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSubjectDetails.Size = new System.Drawing.Size(837, 351);
            this.dataSubjectDetails.TabIndex = 4;
            this.dataSubjectDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSubjectDetails_CellClick);
            // 
            // SId
            // 
            this.SId.HeaderText = "SId";
            this.SId.MinimumWidth = 6;
            this.SId.Name = "SId";
            this.SId.ReadOnly = true;
            this.SId.Visible = false;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Bölüm İsmi";
            this.CourseName.MinimumWidth = 6;
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // Semester
            // 
            this.Semester.HeaderText = "Sömestr";
            this.Semester.MinimumWidth = 6;
            this.Semester.Name = "Semester";
            this.Semester.ReadOnly = true;
            // 
            // SubjectName
            // 
            this.SubjectName.HeaderText = "Ders İsmi";
            this.SubjectName.MinimumWidth = 6;
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // Credits
            // 
            this.Credits.HeaderText = "Kredi";
            this.Credits.MinimumWidth = 6;
            this.Credits.Name = "Credits";
            this.Credits.ReadOnly = true;
            // 
            // CourseId
            // 
            this.CourseId.HeaderText = "Course Id";
            this.CourseId.MinimumWidth = 6;
            this.CourseId.Name = "CourseId";
            this.CourseId.ReadOnly = true;
            this.CourseId.Visible = false;
            // 
            // frmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 556);
            this.Controls.Add(this.dataSubjectDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSubject";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Detay";
            this.Load += new System.EventHandler(this.frmSubject_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSubject_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSubjectDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataSubjectDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn SId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credits;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseId;
    }
}