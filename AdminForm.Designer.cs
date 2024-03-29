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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.performanceJournal = new System.Windows.Forms.Button();
            this.scheduleTeacher = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StudentList = new System.Windows.Forms.Button();
            this.TeacherList = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AdminLabel);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 37);
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
            this.button1.Location = new System.Drawing.Point(97, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 30);
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
            this.AdminLabel.Location = new System.Drawing.Point(634, 6);
            this.AdminLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(59, 22);
            this.AdminLabel.TabIndex = 6;
            this.AdminLabel.Text = "teacher";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(234, 119);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(436, 279);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // performanceJournal
            // 
            this.performanceJournal.BackColor = System.Drawing.Color.Pink;
            this.performanceJournal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.performanceJournal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.performanceJournal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.performanceJournal.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performanceJournal.Location = new System.Drawing.Point(7, 117);
            this.performanceJournal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.performanceJournal.Name = "performanceJournal";
            this.performanceJournal.Size = new System.Drawing.Size(124, 60);
            this.performanceJournal.TabIndex = 3;
            this.performanceJournal.Text = "Журнал успеваемости";
            this.performanceJournal.UseVisualStyleBackColor = false;
            // 
            // scheduleTeacher
            // 
            this.scheduleTeacher.BackColor = System.Drawing.Color.Pink;
            this.scheduleTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scheduleTeacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.scheduleTeacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.scheduleTeacher.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleTeacher.Location = new System.Drawing.Point(7, 32);
            this.scheduleTeacher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scheduleTeacher.Name = "scheduleTeacher";
            this.scheduleTeacher.Size = new System.Drawing.Size(124, 60);
            this.scheduleTeacher.TabIndex = 4;
            this.scheduleTeacher.Text = "Расписание";
            this.scheduleTeacher.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TeacherList);
            this.panel2.Controls.Add(this.StudentList);
            this.panel2.Controls.Add(this.scheduleTeacher);
            this.panel2.Controls.Add(this.performanceJournal);
            this.panel2.Location = new System.Drawing.Point(2, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 426);
            this.panel2.TabIndex = 5;
            // 
            // StudentList
            // 
            this.StudentList.BackColor = System.Drawing.Color.Pink;
            this.StudentList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.StudentList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.StudentList.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentList.Location = new System.Drawing.Point(7, 196);
            this.StudentList.Margin = new System.Windows.Forms.Padding(2);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(124, 60);
            this.StudentList.TabIndex = 5;
            this.StudentList.Text = "Список учеников";
            this.StudentList.UseVisualStyleBackColor = false;
            // 
            // TeacherList
            // 
            this.TeacherList.BackColor = System.Drawing.Color.Pink;
            this.TeacherList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TeacherList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.TeacherList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.TeacherList.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherList.Location = new System.Drawing.Point(7, 281);
            this.TeacherList.Margin = new System.Windows.Forms.Padding(2);
            this.TeacherList.Name = "TeacherList";
            this.TeacherList.Size = new System.Drawing.Size(124, 60);
            this.TeacherList.TabIndex = 6;
            this.TeacherList.Text = "Список учеников";
            this.TeacherList.UseVisualStyleBackColor = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(725, 470);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button performanceJournal;
        private System.Windows.Forms.Button scheduleTeacher;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TeacherList;
        private System.Windows.Forms.Button StudentList;
    }
}