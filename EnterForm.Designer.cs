﻿namespace EduNet
{
    partial class EnterForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Line = new System.Windows.Forms.Panel();
            this.nameEnter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edit = new System.Windows.Forms.Panel();
            this.editProfile = new System.Windows.Forms.Label();
            this.editEmail = new System.Windows.Forms.TextBox();
            this.editPatronomyc = new System.Windows.Forms.TextBox();
            this.editName = new System.Windows.Forms.TextBox();
            this.editSurname = new System.Windows.Forms.TextBox();
            this.edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // Line
            // 
            this.Line.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Line.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Line.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Line.Location = new System.Drawing.Point(0, 48);
            this.Line.Margin = new System.Windows.Forms.Padding(4);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(1001, 1);
            this.Line.TabIndex = 0;
            // 
            // nameEnter
            // 
            this.nameEnter.BackColor = System.Drawing.Color.Pink;
            this.nameEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameEnter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.nameEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.nameEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.nameEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameEnter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameEnter.Location = new System.Drawing.Point(80, 7);
            this.nameEnter.Name = "nameEnter";
            this.nameEnter.Size = new System.Drawing.Size(75, 34);
            this.nameEnter.TabIndex = 3;
            this.nameEnter.Text = "...";
            this.nameEnter.UseVisualStyleBackColor = false;
            this.nameEnter.Click += new System.EventHandler(this.NameEnter_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(658, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Регистрация";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Pink;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(822, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Вход";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 33);
            this.panel1.TabIndex = 6;
            // 
            // edit
            // 
            this.edit.Controls.Add(this.editProfile);
            this.edit.Controls.Add(this.editEmail);
            this.edit.Controls.Add(this.editPatronomyc);
            this.edit.Controls.Add(this.editName);
            this.edit.Controls.Add(this.editSurname);
            this.edit.Location = new System.Drawing.Point(157, 38);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(671, 440);
            this.edit.TabIndex = 7;
            this.edit.Visible = false;
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
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(984, 517);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameEnter);
            this.Controls.Add(this.Line);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EnterForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "EnterForm";
            this.Load += new System.EventHandler(this.EnterForm_Load);
            this.edit.ResumeLayout(false);
            this.edit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Line;
        private System.Windows.Forms.Button nameEnter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel edit;
        private System.Windows.Forms.Label editProfile;
        private System.Windows.Forms.TextBox editEmail;
        private System.Windows.Forms.TextBox editPatronomyc;
        private System.Windows.Forms.TextBox editName;
        private System.Windows.Forms.TextBox editSurname;
    }
}

