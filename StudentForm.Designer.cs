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
            this.schedule = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentButton = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exams = new System.Windows.Forms.Button();
            this.uspevaem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nameStudent = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // schedule
            // 
            this.schedule.BackColor = System.Drawing.Color.Pink;
            this.schedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.schedule.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedule.Location = new System.Drawing.Point(11, 52);
            this.schedule.Name = "schedule";
            this.schedule.Size = new System.Drawing.Size(166, 40);
            this.schedule.TabIndex = 0;
            this.schedule.Text = "Расписание";
            this.schedule.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nameStudent);
            this.panel1.Controls.Add(this.studentButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 45);
            this.panel1.TabIndex = 1;
            // 
            // studentButton
            // 
            this.studentButton.AutoSize = true;
            this.studentButton.BackColor = System.Drawing.Color.Pink;
            this.studentButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentButton.Location = new System.Drawing.Point(843, 8);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(78, 27);
            this.studentButton.TabIndex = 3;
            this.studentButton.Text = "student";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.exams);
            this.panel2.Controls.Add(this.uspevaem);
            this.panel2.Controls.Add(this.schedule);
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 529);
            this.panel2.TabIndex = 2;
            // 
            // exams
            // 
            this.exams.BackColor = System.Drawing.Color.Pink;
            this.exams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exams.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exams.Location = new System.Drawing.Point(11, 200);
            this.exams.Name = "exams";
            this.exams.Size = new System.Drawing.Size(166, 40);
            this.exams.TabIndex = 3;
            this.exams.Text = "Экзамены";
            this.exams.UseVisualStyleBackColor = false;
            // 
            // uspevaem
            // 
            this.uspevaem.BackColor = System.Drawing.Color.Pink;
            this.uspevaem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uspevaem.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uspevaem.Location = new System.Drawing.Point(11, 126);
            this.uspevaem.Name = "uspevaem";
            this.uspevaem.Size = new System.Drawing.Size(166, 40);
            this.uspevaem.TabIndex = 4;
            this.uspevaem.Text = "Успеваемость";
            this.uspevaem.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(313, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 348);
            this.panel3.TabIndex = 3;
            // 
            // nameStudent
            // 
            this.nameStudent.BackColor = System.Drawing.Color.Pink;
            this.nameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameStudent.Location = new System.Drawing.Point(123, 8);
            this.nameStudent.Name = "nameStudent";
            this.nameStudent.Size = new System.Drawing.Size(181, 32);
            this.nameStudent.TabIndex = 4;
            this.nameStudent.Text = "...";
            this.nameStudent.UseVisualStyleBackColor = false;
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

        private System.Windows.Forms.Button schedule;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button uspevaem;
        private System.Windows.Forms.Button exams;
        private System.Windows.Forms.Label studentButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button nameStudent;
    }
}