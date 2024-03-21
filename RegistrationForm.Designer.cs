namespace EduNet
{
    partial class RegistrationForm
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
            this.emailAddress = new System.Windows.Forms.TextBox();
            this.comeUpWithPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeRegistr = new System.Windows.Forms.Label();
            this.registration = new System.Windows.Forms.Label();
            this.repeatPassword = new System.Windows.Forms.TextBox();
            this.toRegister = new System.Windows.Forms.Button();
            this.patronymic = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.institution = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailAddress
            // 
            this.emailAddress.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.emailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailAddress.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.emailAddress.Location = new System.Drawing.Point(101, 355);
            this.emailAddress.Multiline = true;
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.Size = new System.Drawing.Size(245, 37);
            this.emailAddress.TabIndex = 1;
            this.emailAddress.Text = "Эл. почта";
            // 
            // comeUpWithPassword
            // 
            this.comeUpWithPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comeUpWithPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comeUpWithPassword.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comeUpWithPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.comeUpWithPassword.Location = new System.Drawing.Point(101, 416);
            this.comeUpWithPassword.Multiline = true;
            this.comeUpWithPassword.Name = "comeUpWithPassword";
            this.comeUpWithPassword.Size = new System.Drawing.Size(245, 37);
            this.comeUpWithPassword.TabIndex = 2;
            this.comeUpWithPassword.Text = "Придумайте пароль";
            this.comeUpWithPassword.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeRegistr);
            this.panel1.Controls.Add(this.registration);
            this.panel1.Location = new System.Drawing.Point(-5, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 107);
            this.panel1.TabIndex = 3;
            // 
            // closeRegistr
            // 
            this.closeRegistr.AutoSize = true;
            this.closeRegistr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeRegistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeRegistr.Location = new System.Drawing.Point(424, 0);
            this.closeRegistr.Name = "closeRegistr";
            this.closeRegistr.Size = new System.Drawing.Size(28, 32);
            this.closeRegistr.TabIndex = 5;
            this.closeRegistr.Text = "x";
            this.closeRegistr.Click += new System.EventHandler(this.closeRegistr_Click);
            // 
            // registration
            // 
            this.registration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registration.ForeColor = System.Drawing.Color.Red;
            this.registration.Location = new System.Drawing.Point(0, 0);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(465, 107);
            this.registration.TabIndex = 4;
            this.registration.Text = "Регистрация";
            this.registration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // repeatPassword
            // 
            this.repeatPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.repeatPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repeatPassword.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.repeatPassword.Location = new System.Drawing.Point(101, 482);
            this.repeatPassword.Multiline = true;
            this.repeatPassword.Name = "repeatPassword";
            this.repeatPassword.Size = new System.Drawing.Size(245, 37);
            this.repeatPassword.TabIndex = 4;
            this.repeatPassword.Text = "Повторите пароль";
            // 
            // toRegister
            // 
            this.toRegister.BackColor = System.Drawing.Color.Red;
            this.toRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.toRegister.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toRegister.ForeColor = System.Drawing.Color.White;
            this.toRegister.Location = new System.Drawing.Point(83, 554);
            this.toRegister.Name = "toRegister";
            this.toRegister.Size = new System.Drawing.Size(275, 56);
            this.toRegister.TabIndex = 5;
            this.toRegister.Text = "Зарегистрироваться";
            this.toRegister.UseVisualStyleBackColor = false;
            this.toRegister.Click += new System.EventHandler(this.toRegister_Click);
            // 
            // patronymic
            // 
            this.patronymic.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.patronymic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patronymic.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patronymic.ForeColor = System.Drawing.SystemColors.Control;
            this.patronymic.Location = new System.Drawing.Point(101, 230);
            this.patronymic.Multiline = true;
            this.patronymic.Name = "patronymic";
            this.patronymic.Size = new System.Drawing.Size(245, 37);
            this.patronymic.TabIndex = 6;
            this.patronymic.Text = "Отчество";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.Control;
            this.name.Location = new System.Drawing.Point(101, 167);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(245, 37);
            this.name.TabIndex = 6;
            this.name.Text = "Имя";
            // 
            // Surname
            // 
            this.Surname.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Surname.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname.ForeColor = System.Drawing.SystemColors.Control;
            this.Surname.Location = new System.Drawing.Point(101, 106);
            this.Surname.Multiline = true;
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(245, 37);
            this.Surname.TabIndex = 7;
            this.Surname.Text = "Фамилия";
            // 
            // institution
            // 
            this.institution.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.institution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.institution.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.institution.ForeColor = System.Drawing.SystemColors.Control;
            this.institution.FormattingEnabled = true;
            this.institution.Items.AddRange(new object[] {
            "КФУ",
            "КНИТУ-КАИ",
            "КГЭУ",
            "КГАУ"});
            this.institution.Location = new System.Drawing.Point(101, 293);
            this.institution.Name = "institution";
            this.institution.Size = new System.Drawing.Size(245, 35);
            this.institution.TabIndex = 8;
            this.institution.Text = "Учреждение";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(448, 677);
            this.Controls.Add(this.institution);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.patronymic);
            this.Controls.Add(this.toRegister);
            this.Controls.Add(this.repeatPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comeUpWithPassword);
            this.Controls.Add(this.emailAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox emailAddress;
        private System.Windows.Forms.TextBox comeUpWithPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label registration;
        private System.Windows.Forms.TextBox repeatPassword;
        private System.Windows.Forms.Button toRegister;
        private System.Windows.Forms.Label closeRegistr;
        private System.Windows.Forms.TextBox patronymic;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.ComboBox institution;
    }
}