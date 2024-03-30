namespace EduNet
{
    partial class StudentForm
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
            this.components = new System.ComponentModel.Container();
            this.scheduleStudent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nameStudent = new System.Windows.Forms.Button();
            this.studentLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exams = new System.Windows.Forms.Button();
            this.performance = new System.Windows.Forms.Button();
            this.schedulePanel = new System.Windows.Forms.Panel();
            this.dataSchedule = new System.Windows.Forms.DataGridView();
            this.performancePanel = new System.Windows.Forms.Panel();
            this.examPanel = new System.Windows.Forms.Panel();
            this.dataExam = new System.Windows.Forms.DataGridView();
            this.dataPerformance = new System.Windows.Forms.DataGridView();
            this.editStudent = new System.Windows.Forms.Panel();
            this.saveChanges = new System.Windows.Forms.Button();
            this.editProfile = new System.Windows.Forms.Label();
            this.editEmail = new System.Windows.Forms.TextBox();
            this.editPatronomyc = new System.Windows.Forms.TextBox();
            this.editName = new System.Windows.Forms.TextBox();
            this.editSurname = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.schedulePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSchedule)).BeginInit();
            this.performancePanel.SuspendLayout();
            this.examPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPerformance)).BeginInit();
            this.editStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleStudent
            // 
            this.scheduleStudent.BackColor = System.Drawing.Color.Pink;
            this.scheduleStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scheduleStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.scheduleStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.scheduleStudent.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleStudent.Location = new System.Drawing.Point(11, 52);
            this.scheduleStudent.Name = "scheduleStudent";
            this.scheduleStudent.Size = new System.Drawing.Size(166, 40);
            this.scheduleStudent.TabIndex = 0;
            this.scheduleStudent.Text = "Расписание";
            this.scheduleStudent.UseVisualStyleBackColor = false;
            this.scheduleStudent.Click += new System.EventHandler(this.ScheduleStudent_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.nameStudent);
            this.panel1.Controls.Add(this.studentLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 45);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(11, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 33);
            this.panel3.TabIndex = 7;
            // 
            // nameStudent
            // 
            this.nameStudent.BackColor = System.Drawing.Color.Pink;
            this.nameStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.nameStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.nameStudent.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameStudent.Location = new System.Drawing.Point(67, 8);
            this.nameStudent.Name = "nameStudent";
            this.nameStudent.Size = new System.Drawing.Size(181, 32);
            this.nameStudent.TabIndex = 4;
            this.nameStudent.Text = "...";
            this.nameStudent.UseVisualStyleBackColor = false;
            this.nameStudent.Click += new System.EventHandler(this.nameStudent_Click);
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.BackColor = System.Drawing.Color.Pink;
            this.studentLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentLabel.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLabel.Location = new System.Drawing.Point(843, 8);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(73, 27);
            this.studentLabel.TabIndex = 3;
            this.studentLabel.Text = "student";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.exams);
            this.panel2.Controls.Add(this.performance);
            this.panel2.Controls.Add(this.scheduleStudent);
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 520);
            this.panel2.TabIndex = 2;
            // 
            // exams
            // 
            this.exams.BackColor = System.Drawing.Color.Pink;
            this.exams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exams.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.exams.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.exams.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exams.Location = new System.Drawing.Point(11, 200);
            this.exams.Name = "exams";
            this.exams.Size = new System.Drawing.Size(166, 40);
            this.exams.TabIndex = 3;
            this.exams.Text = "Экзамены";
            this.exams.UseVisualStyleBackColor = false;
            this.exams.Click += new System.EventHandler(this.exams_Click);
            // 
            // performance
            // 
            this.performance.BackColor = System.Drawing.Color.Pink;
            this.performance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.performance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.performance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.performance.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performance.Location = new System.Drawing.Point(11, 126);
            this.performance.Name = "performance";
            this.performance.Size = new System.Drawing.Size(166, 40);
            this.performance.TabIndex = 4;
            this.performance.Text = "Успеваемость";
            this.performance.UseVisualStyleBackColor = false;
            this.performance.Click += new System.EventHandler(this.performance_Click);
            // 
            // schedulePanel
            // 
            this.schedulePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.schedulePanel.Controls.Add(this.dataSchedule);
            this.schedulePanel.Location = new System.Drawing.Point(234, 84);
            this.schedulePanel.Name = "schedulePanel";
            this.schedulePanel.Size = new System.Drawing.Size(719, 471);
            this.schedulePanel.TabIndex = 3;
            this.schedulePanel.Visible = false;
            // 
            // dataSchedule
            // 
            this.dataSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSchedule.Location = new System.Drawing.Point(31, 36);
            this.dataSchedule.Name = "dataSchedule";
            this.dataSchedule.RowHeadersWidth = 51;
            this.dataSchedule.RowTemplate.Height = 24;
            this.dataSchedule.Size = new System.Drawing.Size(652, 395);
            this.dataSchedule.TabIndex = 0;
            this.dataSchedule.Visible = false;
            // 
            // performancePanel
            // 
            this.performancePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.performancePanel.Controls.Add(this.examPanel);
            this.performancePanel.Controls.Add(this.dataPerformance);
            this.performancePanel.Location = new System.Drawing.Point(227, 84);
            this.performancePanel.Name = "performancePanel";
            this.performancePanel.Size = new System.Drawing.Size(726, 471);
            this.performancePanel.TabIndex = 1;
            this.performancePanel.Visible = false;
            // 
            // examPanel
            // 
            this.examPanel.Controls.Add(this.dataExam);
            this.examPanel.Location = new System.Drawing.Point(0, 0);
            this.examPanel.Name = "examPanel";
            this.examPanel.Size = new System.Drawing.Size(726, 474);
            this.examPanel.TabIndex = 1;
            // 
            // dataExam
            // 
            this.dataExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataExam.Location = new System.Drawing.Point(38, 20);
            this.dataExam.Name = "dataExam";
            this.dataExam.RowHeadersWidth = 51;
            this.dataExam.RowTemplate.Height = 24;
            this.dataExam.Size = new System.Drawing.Size(652, 424);
            this.dataExam.TabIndex = 0;
            // 
            // dataPerformance
            // 
            this.dataPerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPerformance.Location = new System.Drawing.Point(38, 36);
            this.dataPerformance.Name = "dataPerformance";
            this.dataPerformance.RowHeadersWidth = 51;
            this.dataPerformance.RowTemplate.Height = 24;
            this.dataPerformance.Size = new System.Drawing.Size(652, 395);
            this.dataPerformance.TabIndex = 0;
            this.dataPerformance.Visible = false;
            // 
            // editStudent
            // 
            this.editStudent.Controls.Add(this.saveChanges);
            this.editStudent.Controls.Add(this.editProfile);
            this.editStudent.Controls.Add(this.editEmail);
            this.editStudent.Controls.Add(this.editPatronomyc);
            this.editStudent.Controls.Add(this.editName);
            this.editStudent.Controls.Add(this.editSurname);
            this.editStudent.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStudent.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.editStudent.Location = new System.Drawing.Point(227, 67);
            this.editStudent.Name = "editStudent";
            this.editStudent.Size = new System.Drawing.Size(732, 491);
            this.editStudent.TabIndex = 9;
            this.editStudent.Visible = false;
            // 
            // saveChanges
            // 
            this.saveChanges.BackColor = System.Drawing.Color.Red;
            this.saveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveChanges.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChanges.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.saveChanges.Location = new System.Drawing.Point(211, 376);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(235, 50);
            this.saveChanges.TabIndex = 5;
            this.saveChanges.Text = "Сохранить изменения";
            this.saveChanges.UseVisualStyleBackColor = false;
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
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(975, 578);
            this.Controls.Add(this.editStudent);
            this.Controls.Add(this.performancePanel);
            this.Controls.Add(this.schedulePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentForm";
            this.Text = "Студент";
            this.Click += new System.EventHandler(this.ScheduleStudent_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.schedulePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSchedule)).EndInit();
            this.performancePanel.ResumeLayout(false);
            this.examPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPerformance)).EndInit();
            this.editStudent.ResumeLayout(false);
            this.editStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button scheduleStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button performance;
        private System.Windows.Forms.Button exams;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Button nameStudent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel schedulePanel;
        private System.Windows.Forms.Panel performancePanel;
        private System.Windows.Forms.DataGridView dataSchedule;
        private System.Windows.Forms.DataGridView dataPerformance;
        private System.Windows.Forms.Panel editStudent;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Label editProfile;
        private System.Windows.Forms.TextBox editEmail;
        private System.Windows.Forms.TextBox editPatronomyc;
        private System.Windows.Forms.TextBox editName;
        private System.Windows.Forms.TextBox editSurname;
        private System.Windows.Forms.Panel examPanel;
        private System.Windows.Forms.DataGridView dataExam;
    }
}