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
            this.patronomyc = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.group = new System.Windows.Forms.ComboBox();
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
            this.emailAddress.Click += new System.EventHandler(this.emailAddress_Click);
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
            this.comeUpWithPassword.Click += new System.EventHandler(this.comeUpWithPassword_Click);
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
            this.repeatPassword.Click += new System.EventHandler(this.repeatPassword_Click);
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
            // patronomyc
            // 
            this.patronomyc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.patronomyc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patronomyc.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patronomyc.ForeColor = System.Drawing.SystemColors.Control;
            this.patronomyc.Location = new System.Drawing.Point(101, 230);
            this.patronomyc.Multiline = true;
            this.patronomyc.Name = "patronomyc";
            this.patronomyc.Size = new System.Drawing.Size(245, 37);
            this.patronomyc.TabIndex = 6;
            this.patronomyc.Text = "Отчество";
            this.patronomyc.Click += new System.EventHandler(this.patronomyc_Click);
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
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // surname
            // 
            this.surname.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surname.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname.ForeColor = System.Drawing.SystemColors.Control;
            this.surname.Location = new System.Drawing.Point(101, 106);
            this.surname.Multiline = true;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(245, 37);
            this.surname.TabIndex = 7;
            this.surname.Text = "Фамилия";
            this.surname.Click += new System.EventHandler(this.surname_Click);
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.group.Cursor = System.Windows.Forms.Cursors.Hand;
            this.group.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group.ForeColor = System.Drawing.SystemColors.Control;
            this.group.FormattingEnabled = true;
            this.group.Items.AddRange(new object[] {
            "321",
            "322"});
            this.group.Location = new System.Drawing.Point(101, 293);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(245, 35);
            this.group.TabIndex = 8;
            this.group.Text = "Группа";
            this.group.Click += new System.EventHandler(this.group_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(448, 677);
            this.Controls.Add(this.group);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.patronomyc);
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
        internal System.Windows.Forms.TextBox emailAddress;
        private System.Windows.Forms.TextBox comeUpWithPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label registration;
        private System.Windows.Forms.TextBox repeatPassword;
        private System.Windows.Forms.Button toRegister;
        private System.Windows.Forms.Label closeRegistr;
        internal System.Windows.Forms.TextBox patronomyc;
        internal System.Windows.Forms.TextBox name;
        internal System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.ComboBox group;
    }
}