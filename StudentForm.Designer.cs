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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Location = new System.Drawing.Point(313, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 348);
            this.panel3.TabIndex = 3;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(972, 574);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button scheduleStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button performance;
        private System.Windows.Forms.Button exams;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button nameStudent;
    }
}