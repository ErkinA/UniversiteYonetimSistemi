﻿namespace CollegeManagementSystem.DatabaseBackup
{
    partial class frmDatabaseBackup
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnFolderBrowse = new System.Windows.Forms.Button();
            this.txtSelectFolder = new System.Windows.Forms.TextBox();
            this.cmbDatabaseName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.grpBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSelectPath = new System.Windows.Forms.TextBox();
            this.btnPathBrowse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdRestore = new System.Windows.Forms.RadioButton();
            this.rdBackup = new System.Windows.Forms.RadioButton();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.grpBox1.SuspendLayout();
            this.grpBox2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtLogin);
            this.groupBox1.Controls.Add(this.txtServerName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(547, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Connection Detayları";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(147, 103);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(322, 22);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.White;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Location = new System.Drawing.Point(147, 66);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ReadOnly = true;
            this.txtLogin.Size = new System.Drawing.Size(322, 22);
            this.txtLogin.TabIndex = 7;
            // 
            // txtServerName
            // 
            this.txtServerName.BackColor = System.Drawing.Color.White;
            this.txtServerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServerName.Location = new System.Drawing.Point(147, 30);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.ReadOnly = true;
            this.txtServerName.Size = new System.Drawing.Size(322, 22);
            this.txtServerName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server İsmi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dosya Seçimi";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(463, 486);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "İptal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(349, 486);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(100, 30);
            this.btnBackup.TabIndex = 12;
            this.btnBackup.Text = "Yedekle";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnFolderBrowse
            // 
            this.btnFolderBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolderBrowse.Location = new System.Drawing.Point(427, 64);
            this.btnFolderBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFolderBrowse.Name = "btnFolderBrowse";
            this.btnFolderBrowse.Size = new System.Drawing.Size(51, 27);
            this.btnFolderBrowse.TabIndex = 11;
            this.btnFolderBrowse.Text = "....";
            this.btnFolderBrowse.UseVisualStyleBackColor = true;
            this.btnFolderBrowse.Click += new System.EventHandler(this.btnFolderBrowse_Click);
            // 
            // txtSelectFolder
            // 
            this.txtSelectFolder.BackColor = System.Drawing.Color.White;
            this.txtSelectFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectFolder.Location = new System.Drawing.Point(145, 65);
            this.txtSelectFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSelectFolder.Name = "txtSelectFolder";
            this.txtSelectFolder.ReadOnly = true;
            this.txtSelectFolder.Size = new System.Drawing.Size(275, 23);
            this.txtSelectFolder.TabIndex = 10;
            // 
            // cmbDatabaseName
            // 
            this.cmbDatabaseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatabaseName.FormattingEnabled = true;
            this.cmbDatabaseName.Location = new System.Drawing.Point(145, 27);
            this.cmbDatabaseName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDatabaseName.Name = "cmbDatabaseName";
            this.cmbDatabaseName.Size = new System.Drawing.Size(275, 25);
            this.cmbDatabaseName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Database Seçimi";
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.label5);
            this.grpBox1.Controls.Add(this.cmbDatabaseName);
            this.grpBox1.Controls.Add(this.label6);
            this.grpBox1.Controls.Add(this.txtSelectFolder);
            this.grpBox1.Controls.Add(this.btnFolderBrowse);
            this.grpBox1.Enabled = false;
            this.grpBox1.Location = new System.Drawing.Point(15, 59);
            this.grpBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBox1.Size = new System.Drawing.Size(497, 108);
            this.grpBox1.TabIndex = 14;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "Yedek";
            // 
            // grpBox2
            // 
            this.grpBox2.Controls.Add(this.label7);
            this.grpBox2.Controls.Add(this.txtDatabaseName);
            this.grpBox2.Controls.Add(this.label4);
            this.grpBox2.Controls.Add(this.txtSelectPath);
            this.grpBox2.Controls.Add(this.btnPathBrowse);
            this.grpBox2.Enabled = false;
            this.grpBox2.Location = new System.Drawing.Point(15, 177);
            this.grpBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBox2.Name = "grpBox2";
            this.grpBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBox2.Size = new System.Drawing.Size(497, 102);
            this.grpBox2.TabIndex = 15;
            this.grpBox2.TabStop = false;
            this.grpBox2.Text = "Restore";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Path Seçimi";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatabaseName.Location = new System.Drawing.Point(145, 25);
            this.txtDatabaseName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(275, 22);
            this.txtDatabaseName.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Database Seçimi";
            // 
            // txtSelectPath
            // 
            this.txtSelectPath.BackColor = System.Drawing.Color.White;
            this.txtSelectPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSelectPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectPath.Location = new System.Drawing.Point(145, 63);
            this.txtSelectPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSelectPath.Name = "txtSelectPath";
            this.txtSelectPath.ReadOnly = true;
            this.txtSelectPath.Size = new System.Drawing.Size(275, 23);
            this.txtSelectPath.TabIndex = 13;
            // 
            // btnPathBrowse
            // 
            this.btnPathBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPathBrowse.Location = new System.Drawing.Point(427, 62);
            this.btnPathBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPathBrowse.Name = "btnPathBrowse";
            this.btnPathBrowse.Size = new System.Drawing.Size(51, 27);
            this.btnPathBrowse.TabIndex = 14;
            this.btnPathBrowse.Text = "....";
            this.btnPathBrowse.UseVisualStyleBackColor = true;
            this.btnPathBrowse.Click += new System.EventHandler(this.btnPathBrowse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdRestore);
            this.groupBox2.Controls.Add(this.rdBackup);
            this.groupBox2.Controls.Add(this.grpBox1);
            this.groupBox2.Controls.Add(this.grpBox2);
            this.groupBox2.Location = new System.Drawing.Point(16, 169);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(547, 298);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yedek ve Restore Ayarları";
            // 
            // rdRestore
            // 
            this.rdRestore.AutoSize = true;
            this.rdRestore.Location = new System.Drawing.Point(115, 27);
            this.rdRestore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdRestore.Name = "rdRestore";
            this.rdRestore.Size = new System.Drawing.Size(76, 20);
            this.rdRestore.TabIndex = 17;
            this.rdRestore.TabStop = true;
            this.rdRestore.Text = "Restore";
            this.rdRestore.UseVisualStyleBackColor = true;
            this.rdRestore.CheckedChanged += new System.EventHandler(this.rdRestore_CheckedChanged);
            // 
            // rdBackup
            // 
            this.rdBackup.AutoSize = true;
            this.rdBackup.Location = new System.Drawing.Point(24, 27);
            this.rdBackup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdBackup.Name = "rdBackup";
            this.rdBackup.Size = new System.Drawing.Size(68, 20);
            this.rdBackup.TabIndex = 16;
            this.rdBackup.TabStop = true;
            this.rdBackup.Text = "Yedek";
            this.rdBackup.UseVisualStyleBackColor = true;
            this.rdBackup.CheckedChanged += new System.EventHandler(this.rdBackup_CheckedChanged);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // frmDatabaseBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 528);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDatabaseBackup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Yedek";
            this.Load += new System.EventHandler(this.frmDatabaseBackup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.grpBox2.ResumeLayout(false);
            this.grpBox2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnFolderBrowse;
        private System.Windows.Forms.TextBox txtSelectFolder;
        private System.Windows.Forms.ComboBox cmbDatabaseName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.GroupBox grpBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdRestore;
        private System.Windows.Forms.RadioButton rdBackup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSelectPath;
        private System.Windows.Forms.Button btnPathBrowse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.OpenFileDialog openFile;

    }
}