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
            this.teacherLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.performanceJournal = new System.Windows.Forms.Button();
            this.scheduleTeacher = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.teacherLabel);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 45);
            this.panel1.TabIndex = 0;
            // 
            // teacherLabel
            // 
            this.teacherLabel.AutoSize = true;
            this.teacherLabel.BackColor = System.Drawing.Color.Pink;
            this.teacherLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacherLabel.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherLabel.Location = new System.Drawing.Point(845, 7);
            this.teacherLabel.Name = "teacherLabel";
            this.teacherLabel.Size = new System.Drawing.Size(74, 27);
            this.teacherLabel.TabIndex = 6;
            this.teacherLabel.Text = "teacher";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(312, 146);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(582, 343);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // performanceJournal
            // 
            this.performanceJournal.BackColor = System.Drawing.Color.Pink;
            this.performanceJournal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.performanceJournal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.performanceJournal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.performanceJournal.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performanceJournal.Location = new System.Drawing.Point(9, 144);
            this.performanceJournal.Name = "performanceJournal";
            this.performanceJournal.Size = new System.Drawing.Size(166, 74);
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
            this.scheduleTeacher.Location = new System.Drawing.Point(9, 40);
            this.scheduleTeacher.Name = "scheduleTeacher";
            this.scheduleTeacher.Size = new System.Drawing.Size(166, 74);
            this.scheduleTeacher.TabIndex = 4;
            this.scheduleTeacher.Text = "Расписание";
            this.scheduleTeacher.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.scheduleTeacher);
            this.panel2.Controls.Add(this.performanceJournal);
            this.panel2.Location = new System.Drawing.Point(2, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 524);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(129, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(967, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
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
        private System.Windows.Forms.Label teacherLabel;
        private System.Windows.Forms.Button button1;
    }
}