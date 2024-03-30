namespace EduNet
{
    partial class AdminForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.performanceJournal = new System.Windows.Forms.Button();
            this.scheduleTeacher = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TeacherList = new System.Windows.Forms.Button();
            this.StudentList = new System.Windows.Forms.Button();
            this.schedulePanel = new System.Windows.Forms.Panel();
            this.performancePanel = new System.Windows.Forms.Panel();
            this.performanceeJournal = new System.Windows.Forms.DataGridView();
            this.mondayPanel = new System.Windows.Forms.Panel();
            this.tableScheduleAdmin = new System.Windows.Forms.DataGridView();
            this.studentListPanel = new System.Windows.Forms.Panel();
            this.dataStudentList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.schedulePanel.SuspendLayout();
            this.performancePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceeJournal)).BeginInit();
            this.mondayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableScheduleAdmin)).BeginInit();
            this.studentListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AdminLabel);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 45);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(129, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
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
            this.panel2.Controls.Add(this.TeacherList);
            this.panel2.Controls.Add(this.StudentList);
            this.panel2.Controls.Add(this.scheduleTeacher);
            this.panel2.Controls.Add(this.performanceJournal);
            this.panel2.Location = new System.Drawing.Point(3, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 524);
            this.panel2.TabIndex = 5;
            // 
            // TeacherList
            // 
            this.TeacherList.BackColor = System.Drawing.Color.Pink;
            this.TeacherList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TeacherList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.TeacherList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.TeacherList.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherList.Location = new System.Drawing.Point(3, 346);
            this.TeacherList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeacherList.Name = "TeacherList";
            this.TeacherList.Size = new System.Drawing.Size(185, 81);
            this.TeacherList.TabIndex = 6;
            this.TeacherList.Text = "Список преподавателей";
            this.TeacherList.UseVisualStyleBackColor = false;
            // 
            // StudentList
            // 
            this.StudentList.BackColor = System.Drawing.Color.Pink;
            this.StudentList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.StudentList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.StudentList.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentList.Location = new System.Drawing.Point(9, 241);
            this.StudentList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(179, 74);
            this.StudentList.TabIndex = 5;
            this.StudentList.Text = "Список учеников";
            this.StudentList.UseVisualStyleBackColor = false;
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
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1303, 787);
            this.Controls.Add(this.performancePanel);
            this.Controls.Add(this.schedulePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.schedulePanel.ResumeLayout(false);
            this.performancePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.performanceeJournal)).EndInit();
            this.mondayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableScheduleAdmin)).EndInit();
            this.studentListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataStudentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button performanceJournal;
        private System.Windows.Forms.Button scheduleTeacher;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TeacherList;
        private System.Windows.Forms.Button StudentList;
        private System.Windows.Forms.Panel schedulePanel;
        private System.Windows.Forms.Panel mondayPanel;
        private System.Windows.Forms.DataGridView tableScheduleAdmin;
        private System.Windows.Forms.DataGridView performanceeJournal;
        private System.Windows.Forms.Panel performancePanel;
        private System.Windows.Forms.Panel studentListPanel;
        private System.Windows.Forms.DataGridView dataStudentList;
    }
}