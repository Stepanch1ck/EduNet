namespace EduNet
{
    partial class LoginForm
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
            this.enter = new System.Windows.Forms.Label();
            this.closeLogin = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.closeLogin1 = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeLogin1);
            this.panel1.Controls.Add(this.enter);
            this.panel1.Controls.Add(this.closeLogin);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 100);
            this.panel1.TabIndex = 0;
            // 
            // enter
            // 
            this.enter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.ForeColor = System.Drawing.Color.Red;
            this.enter.Location = new System.Drawing.Point(0, 0);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(415, 100);
            this.enter.TabIndex = 0;
            this.enter.Text = "Войдите в аккаунт";
            this.enter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeLogin
            // 
            this.closeLogin.AutoSize = true;
            this.closeLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeLogin.Location = new System.Drawing.Point(391, 0);
            this.closeLogin.Name = "closeLogin";
            this.closeLogin.Size = new System.Drawing.Size(24, 29);
            this.closeLogin.TabIndex = 1;
            this.closeLogin.Text = "х";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.login.Location = new System.Drawing.Point(95, 129);
            this.login.Multiline = true;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(222, 33);
            this.login.TabIndex = 1;
            this.login.Text = "Логин";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.password.Location = new System.Drawing.Point(95, 196);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(222, 33);
            this.password.TabIndex = 2;
            this.password.Text = "Пароль";
            // 
            // closeLogin1
            // 
            this.closeLogin1.AutoSize = true;
            this.closeLogin1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeLogin1.Location = new System.Drawing.Point(387, 0);
            this.closeLogin1.Name = "closeLogin1";
            this.closeLogin1.Size = new System.Drawing.Size(28, 32);
            this.closeLogin1.TabIndex = 3;
            this.closeLogin1.Text = "x";
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.Red;
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.enterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.enterButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enterButton.Location = new System.Drawing.Point(143, 274);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(117, 43);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 372);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label enter;
        private System.Windows.Forms.Label closeLogin;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label closeLogin1;
        private System.Windows.Forms.Button enterButton;
    }
}