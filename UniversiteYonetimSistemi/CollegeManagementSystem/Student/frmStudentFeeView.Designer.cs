namespace CollegeManagementSystem
{
    partial class frmStudentFeeView
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
            this.txtSearchbyStuName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataStudentFeeView = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudentFeeView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci İsmine göre Ara";
            // 
            // txtSearchbyStuName
            // 
            this.txtSearchbyStuName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchbyStuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchbyStuName.Location = new System.Drawing.Point(264, 14);
            this.txtSearchbyStuName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchbyStuName.Name = "txtSearchbyStuName";
            this.txtSearchbyStuName.Size = new System.Drawing.Size(417, 26);
            this.txtSearchbyStuName.TabIndex = 1;
            this.txtSearchbyStuName.TextChanged += new System.EventHandler(this.txtSearchbyStuName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSearchbyStuName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 57);
            this.panel1.TabIndex = 0;
            // 
            // dataStudentFeeView
            // 
            this.dataStudentFeeView.AllowUserToAddRows = false;
            this.dataStudentFeeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudentFeeView.Location = new System.Drawing.Point(16, 80);
            this.dataStudentFeeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataStudentFeeView.Name = "dataStudentFeeView";
            this.dataStudentFeeView.ReadOnly = true;
            this.dataStudentFeeView.RowHeadersWidth = 51;
            this.dataStudentFeeView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataStudentFeeView.Size = new System.Drawing.Size(873, 316);
            this.dataStudentFeeView.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(727, 17);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(163, 49);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Kapa";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmStudentFeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 407);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataStudentFeeView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentFeeView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Borç Göster";
            this.Load += new System.EventHandler(this.frmStudentFeeView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudentFeeView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchbyStuName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataStudentFeeView;
        private System.Windows.Forms.Button btnClose;
    }
}