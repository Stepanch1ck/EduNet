namespace EduNet
{
    partial class TeacherForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.editTeacherProfile = new System.Windows.Forms.Button();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.performanceJournal = new System.Windows.Forms.Button();
            this.scheduleTeacher = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.schedulePanel = new System.Windows.Forms.Panel();
            this.mondayPanel = new System.Windows.Forms.Panel();
            this.tableScheduleAdmin = new System.Windows.Forms.DataGridView();
            this.performancePanel = new System.Windows.Forms.Panel();
            this.studentListPanel = new System.Windows.Forms.Panel();
            this.dataStudentList = new System.Windows.Forms.DataGridView();
            this.performanceeJournal = new System.Windows.Forms.DataGridView();
            this.editTeacher = new System.Windows.Forms.Panel();
            this.saveChanges = new System.Windows.Forms.Button();
            this.editProfile = new System.Windows.Forms.Label();
            this.editEmail = new System.Windows.Forms.TextBox();
            this.editPatronomyc = new System.Windows.Forms.TextBox();
            this.editName = new System.Windows.Forms.TextBox();
            this.editSurname = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.schedulePanel.SuspendLayout();
            this.mondayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableScheduleAdmin)).BeginInit();
            this.performancePanel.SuspendLayout();
            this.studentListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceeJournal)).BeginInit();
            this.editTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.editTeacherProfile);
            this.panel1.Controls.Add(this.AdminLabel);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 45);
            this.panel1.TabIndex = 0;
            // 
            // editTeacherProfile
            // 
            this.editTeacherProfile.BackColor = System.Drawing.Color.Pink;
            this.editTeacherProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editTeacherProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.editTeacherProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.editTeacherProfile.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTeacherProfile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editTeacherProfile.Location = new System.Drawing.Point(129, 2);
            this.editTeacherProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editTeacherProfile.Name = "editTeacherProfile";
            this.editTeacherProfile.Size = new System.Drawing.Size(179, 37);
            this.editTeacherProfile.TabIndex = 6;
            this.editTeacherProfile.Text = "...";
            this.editTeacherProfile.UseVisualStyleBackColor = false;
            this.editTeacherProfile.Click += new System.EventHandler(this.editTeacherProfile_Click);
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.BackColor = System.Drawing.Color.Pink;
            this.AdminLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminLabel.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabel.Location = new System.Drawing.Point(845, 7);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(64, 27);
            this.AdminLabel.TabIndex = 6;
            this.AdminLabel.Text = "admin";
            // 
            // performanceJournal
            // 
            this.performanceJournal.BackColor = System.Drawing.Color.Pink;
            this.performanceJournal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.performanceJournal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.performanceJournal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.performanceJournal.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performanceJournal.Location = new System.Drawing.Point(9, 144);
            this.performanceJournal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.performanceJournal.Name = "performanceJournal";
            this.performanceJournal.Size = new System.Drawing.Size(179, 74);
            this.performanceJournal.TabIndex = 3;
            this.performanceJournal.Text = "Журнал успеваемости";
            this.performanceJournal.UseVisualStyleBackColor = false;
            this.performanceJournal.Click += new System.EventHandler(this.performanceJournal_Click);
            // 
            // scheduleTeacher
            // 
            this.scheduleTeacher.BackColor = System.Drawing.Color.Pink;
            this.scheduleTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scheduleTeacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.scheduleTeacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.scheduleTeacher.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleTeacher.Location = new System.Drawing.Point(9, 39);
            this.scheduleTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scheduleTeacher.Name = "scheduleTeacher";
            this.scheduleTeacher.Size = new System.Drawing.Size(179, 74);
            this.scheduleTeacher.TabIndex = 4;
            this.scheduleTeacher.Text = "Расписание";
            this.scheduleTeacher.UseVisualStyleBackColor = false;
            this.scheduleTeacher.Click += new System.EventHandler(this.scheduleTeacher_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.scheduleTeacher);
            this.panel2.Controls.Add(this.performanceJournal);
            this.panel2.Location = new System.Drawing.Point(3, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 524);
            this.panel2.TabIndex = 5;
            // 
            // schedulePanel
            // 
            this.schedulePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.schedulePanel.Controls.Add(this.mondayPanel);
            this.schedulePanel.Location = new System.Drawing.Point(223, 72);
            this.schedulePanel.Name = "schedulePanel";
            this.schedulePanel.Size = new System.Drawing.Size(717, 479);
            this.schedulePanel.TabIndex = 6;
            this.schedulePanel.Visible = false;
            // 
            // mondayPanel
            // 
            this.mondayPanel.Controls.Add(this.tableScheduleAdmin);
            this.mondayPanel.Location = new System.Drawing.Point(20, 17);
            this.mondayPanel.Name = "mondayPanel";
            this.mondayPanel.Size = new System.Drawing.Size(677, 446);
            this.mondayPanel.TabIndex = 10;
            // 
            // tableScheduleAdmin
            // 
            this.tableScheduleAdmin.AllowUserToAddRows = false;
            this.tableScheduleAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableScheduleAdmin.Location = new System.Drawing.Point(0, 0);
            this.tableScheduleAdmin.Name = "tableScheduleAdmin";
            this.tableScheduleAdmin.RowHeadersWidth = 51;
            this.tableScheduleAdmin.RowTemplate.Height = 24;
            this.tableScheduleAdmin.Size = new System.Drawing.Size(677, 446);
            this.tableScheduleAdmin.TabIndex = 0;
            this.tableScheduleAdmin.Visible = false;
            // 
            // performancePanel
            // 
            this.performancePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.performancePanel.Controls.Add(this.studentListPanel);
            this.performancePanel.Controls.Add(this.performanceeJournal);
            this.performancePanel.Location = new System.Drawing.Point(223, 72);
            this.performancePanel.Name = "performancePanel";
            this.performancePanel.Size = new System.Drawing.Size(717, 479);
            this.performancePanel.TabIndex = 7;
            this.performancePanel.Visible = false;
            // 
            // studentListPanel
            // 
            this.studentListPanel.Controls.Add(this.dataStudentList);
            this.studentListPanel.Location = new System.Drawing.Point(0, 0);
            this.studentListPanel.Name = "studentListPanel";
            this.studentListPanel.Size = new System.Drawing.Size(717, 479);
            this.studentListPanel.TabIndex = 4;
            this.studentListPanel.Visible = false;
            // 
            // dataStudentList
            // 
            this.dataStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudentList.Location = new System.Drawing.Point(23, 20);
            this.dataStudentList.Name = "dataStudentList";
            this.dataStudentList.RowHeadersWidth = 51;
            this.dataStudentList.RowTemplate.Height = 24;
            this.dataStudentList.Size = new System.Drawing.Size(667, 431);
            this.dataStudentList.TabIndex = 0;
            this.dataStudentList.Visible = false;
            // 
            // performanceeJournal
            // 
            this.performanceeJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.performanceeJournal.Location = new System.Drawing.Point(17, 17);
            this.performanceeJournal.Name = "performanceeJournal";
            this.performanceeJournal.RowHeadersWidth = 51;
            this.performanceeJournal.RowTemplate.Height = 24;
            this.performanceeJournal.Size = new System.Drawing.Size(677, 443);
            this.performanceeJournal.TabIndex = 3;
            this.performanceeJournal.Visible = false;
            // 
            // editTeacher
            // 
            this.editTeacher.Controls.Add(this.saveChanges);
            this.editTeacher.Controls.Add(this.editProfile);
            this.editTeacher.Controls.Add(this.editEmail);
            this.editTeacher.Controls.Add(this.editPatronomyc);
            this.editTeacher.Controls.Add(this.editName);
            this.editTeacher.Controls.Add(this.editSurname);
            this.editTeacher.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTeacher.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.editTeacher.Location = new System.Drawing.Point(223, 72);
            this.editTeacher.Name = "editTeacher";
            this.editTeacher.Size = new System.Drawing.Size(732, 491);
            this.editTeacher.TabIndex = 8;
            this.editTeacher.Visible = false;
            // 
            // saveChanges
            // 
            this.saveChanges.BackColor = System.Drawing.Color.Red;
            this.saveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveChanges.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChanges.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.saveChanges.Location = new System.Drawing.Point(211, 390);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(235, 50);
            this.saveChanges.TabIndex = 5;
            this.saveChanges.Text = "Сохранить изменения";
            this.saveChanges.UseVisualStyleBackColor = false;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // editProfile
            // 
            this.editProfile.AutoSize = true;
            this.editProfile.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfile.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.editProfile.Location = new System.Drawing.Point(174, 13);
            this.editProfile.Name = "editProfile";
            this.editProfile.Size = new System.Drawing.Size(320, 28);
            this.editProfile.TabIndex = 4;
            this.editProfile.Text = "Редактировать профиль";
            // 
            // editEmail
            // 
            this.editEmail.BackColor = System.Drawing.Color.Red;
            this.editEmail.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEmail.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.editEmail.Location = new System.Drawing.Point(426, 281);
            this.editEmail.Multiline = true;
            this.editEmail.Name = "editEmail";
            this.editEmail.Size = new System.Drawing.Size(204, 39);
            this.editEmail.TabIndex = 3;
            this.editEmail.Text = "Эл. почта";
            // 
            // editPatronomyc
            // 
            this.editPatronomyc.BackColor = System.Drawing.Color.Red;
            this.editPatronomyc.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPatronomyc.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.editPatronomyc.Location = new System.Drawing.Point(426, 209);
            this.editPatronomyc.Multiline = true;
            this.editPatronomyc.Name = "editPatronomyc";
            this.editPatronomyc.Size = new System.Drawing.Size(204, 39);
            this.editPatronomyc.TabIndex = 2;
            this.editPatronomyc.Text = "Отчество";
            // 
            // editName
            // 
            this.editName.BackColor = System.Drawing.Color.Red;
            this.editName.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.editName.Location = new System.Drawing.Point(426, 141);
            this.editName.Multiline = true;
            this.editName.Name = "editName";
            this.editName.Size = new System.Drawing.Size(204, 39);
            this.editName.TabIndex = 1;
            this.editName.Text = "Имя";
            // 
            // editSurname
            // 
            this.editSurname.BackColor = System.Drawing.Color.Red;
            this.editSurname.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSurname.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.editSurname.Location = new System.Drawing.Point(426, 75);
            this.editSurname.Multiline = true;
            this.editSurname.Name = "editSurname";
            this.editSurname.Size = new System.Drawing.Size(204, 39);
            this.editSurname.TabIndex = 0;
            this.editSurname.Text = "Фамилия";
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(970, 578);
            this.Controls.Add(this.editTeacher);
            this.Controls.Add(this.performancePanel);
            this.Controls.Add(this.schedulePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TeacherForm";
            this.Text = "Учитель";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.schedulePanel.ResumeLayout(false);
            this.mondayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableScheduleAdmin)).EndInit();
            this.performancePanel.ResumeLayout(false);
            this.studentListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceeJournal)).EndInit();
            this.editTeacher.ResumeLayout(false);
            this.editTeacher.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button performanceJournal;
        private System.Windows.Forms.Button scheduleTeacher;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.Button editTeacherProfile;
        private System.Windows.Forms.Panel schedulePanel;
        private System.Windows.Forms.Panel mondayPanel;
        private System.Windows.Forms.DataGridView tableScheduleAdmin;
        private System.Windows.Forms.DataGridView performanceeJournal;
        private System.Windows.Forms.Panel performancePanel;
        private System.Windows.Forms.Panel studentListPanel;
        private System.Windows.Forms.DataGridView dataStudentList;
        private System.Windows.Forms.Panel editTeacher;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Label editProfile;
        private System.Windows.Forms.TextBox editEmail;
        private System.Windows.Forms.TextBox editPatronomyc;
        private System.Windows.Forms.TextBox editName;
        private System.Windows.Forms.TextBox editSurname;
    }
}