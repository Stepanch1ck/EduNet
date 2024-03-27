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
            this.scheduleStudent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameStudent = new System.Windows.Forms.Button();
            this.studentLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exams = new System.Windows.Forms.Button();
            this.performance = new System.Windows.Forms.Button();
            this.schedulePanel = new System.Windows.Forms.Panel();
            this.mondayPanel = new System.Windows.Forms.Panel();
            this.tableSchedule = new System.Windows.Forms.DataGridView();
            this.friday = new System.Windows.Forms.Button();
            this.thursday = new System.Windows.Forms.Button();
            this.saturday = new System.Windows.Forms.Button();
            this.wednesday = new System.Windows.Forms.Button();
            this.tuesday = new System.Windows.Forms.Button();
            this.monday = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.schedulePanel.SuspendLayout();
            this.mondayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableSchedule)).BeginInit();
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
            this.panel1.Controls.Add(this.nameStudent);
            this.panel1.Controls.Add(this.studentLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 45);
            this.panel1.TabIndex = 1;
            // 
            // nameStudent
            // 
            this.nameStudent.BackColor = System.Drawing.Color.Pink;
            this.nameStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.nameStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.nameStudent.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameStudent.Location = new System.Drawing.Point(123, 8);
            this.nameStudent.Name = "nameStudent";
            this.nameStudent.Size = new System.Drawing.Size(181, 32);
            this.nameStudent.TabIndex = 4;
            this.nameStudent.Text = "...";
            this.nameStudent.UseVisualStyleBackColor = false;
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
            // 
            // schedulePanel
            // 
            this.schedulePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            this.schedulePanel.Controls.Add(this.mondayPanel);
            this.schedulePanel.Controls.Add(this.friday);
            this.schedulePanel.Controls.Add(this.thursday);
            this.schedulePanel.Controls.Add(this.saturday);
            this.schedulePanel.Controls.Add(this.wednesday);
            this.schedulePanel.Controls.Add(this.tuesday);
            this.schedulePanel.Controls.Add(this.monday);
            this.schedulePanel.Location = new System.Drawing.Point(263, 78);
            this.schedulePanel.Name = "schedulePanel";
            this.schedulePanel.Size = new System.Drawing.Size(654, 461);
            this.schedulePanel.TabIndex = 3;
            this.schedulePanel.Visible = false;
            // 
            // mondayPanel
            // 
            this.mondayPanel.Controls.Add(this.tableSchedule);
            this.mondayPanel.Location = new System.Drawing.Point(20, 17);
            this.mondayPanel.Name = "mondayPanel";
            this.mondayPanel.Size = new System.Drawing.Size(424, 426);
            this.mondayPanel.TabIndex = 10;
            // 
            // tableSchedule
            // 
            this.tableSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableSchedule.Location = new System.Drawing.Point(74, 112);
            this.tableSchedule.Name = "tableSchedule";
            this.tableSchedule.RowHeadersWidth = 51;
            this.tableSchedule.RowTemplate.Height = 24;
            this.tableSchedule.Size = new System.Drawing.Size(240, 150);
            this.tableSchedule.TabIndex = 0;
            this.tableSchedule.Visible = false;
            // 
            // friday
            // 
            this.friday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.friday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.friday.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friday.ForeColor = System.Drawing.SystemColors.Control;
            this.friday.Location = new System.Drawing.Point(511, 229);
            this.friday.Name = "friday";
            this.friday.Size = new System.Drawing.Size(130, 35);
            this.friday.TabIndex = 9;
            this.friday.Text = "Пятница";
            this.friday.UseVisualStyleBackColor = false;
            // 
            // thursday
            // 
            this.thursday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.thursday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thursday.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursday.ForeColor = System.Drawing.SystemColors.Control;
            this.thursday.Location = new System.Drawing.Point(511, 174);
            this.thursday.Name = "thursday";
            this.thursday.Size = new System.Drawing.Size(130, 35);
            this.thursday.TabIndex = 8;
            this.thursday.Text = "Четверг";
            this.thursday.UseVisualStyleBackColor = false;
            // 
            // saturday
            // 
            this.saturday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saturday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saturday.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturday.ForeColor = System.Drawing.SystemColors.Control;
            this.saturday.Location = new System.Drawing.Point(511, 286);
            this.saturday.Name = "saturday";
            this.saturday.Size = new System.Drawing.Size(130, 35);
            this.saturday.TabIndex = 7;
            this.saturday.Text = "Суббота";
            this.saturday.UseVisualStyleBackColor = false;
            // 
            // wednesday
            // 
            this.wednesday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wednesday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wednesday.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wednesday.ForeColor = System.Drawing.SystemColors.Control;
            this.wednesday.Location = new System.Drawing.Point(511, 120);
            this.wednesday.Name = "wednesday";
            this.wednesday.Size = new System.Drawing.Size(130, 35);
            this.wednesday.TabIndex = 6;
            this.wednesday.Text = "Среда";
            this.wednesday.UseVisualStyleBackColor = false;
            // 
            // tuesday
            // 
            this.tuesday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tuesday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tuesday.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuesday.ForeColor = System.Drawing.SystemColors.Control;
            this.tuesday.Location = new System.Drawing.Point(511, 68);
            this.tuesday.Name = "tuesday";
            this.tuesday.Size = new System.Drawing.Size(130, 35);
            this.tuesday.TabIndex = 5;
            this.tuesday.Text = "Вторник";
            this.tuesday.UseVisualStyleBackColor = false;
            // 
            // monday
            // 
            this.monday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.monday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monday.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monday.ForeColor = System.Drawing.SystemColors.Control;
            this.monday.Location = new System.Drawing.Point(511, 17);
            this.monday.Name = "monday";
            this.monday.Size = new System.Drawing.Size(130, 35);
            this.monday.TabIndex = 0;
            this.monday.Text = "Понедельник";
            this.monday.UseVisualStyleBackColor = false;
            this.monday.Click += new System.EventHandler(this.monday_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(972, 574);
            this.Controls.Add(this.schedulePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Click += new System.EventHandler(this.ScheduleStudent_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.schedulePanel.ResumeLayout(false);
            this.mondayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableSchedule)).EndInit();
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
        private System.Windows.Forms.Panel schedulePanel;
        private System.Windows.Forms.Button tuesday;
        private System.Windows.Forms.Button monday;
        private System.Windows.Forms.Button friday;
        private System.Windows.Forms.Button thursday;
        private System.Windows.Forms.Button saturday;
        private System.Windows.Forms.Button wednesday;
        private System.Windows.Forms.Panel mondayPanel;
        private System.Windows.Forms.DataGridView tableSchedule;
    }
}