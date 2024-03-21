namespace EduNet
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.nameEnter = new System.Windows.Forms.Button();
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
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.BackColor = System.Drawing.Color.Pink;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Location = new System.Drawing.Point(843, 12);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(125, 28);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrationButton.BackColor = System.Drawing.Color.Pink;
            this.RegistrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationButton.ForeColor = System.Drawing.Color.Black;
            this.RegistrationButton.Location = new System.Drawing.Point(708, 12);
            this.RegistrationButton.Margin = new System.Windows.Forms.Padding(4);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(127, 28);
            this.RegistrationButton.TabIndex = 2;
            this.RegistrationButton.Text = "Регистрация";
            this.RegistrationButton.UseVisualStyleBackColor = false;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // nameEnter
            // 
            this.nameEnter.BackColor = System.Drawing.Color.Pink;
            this.nameEnter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.nameEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameEnter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameEnter.Location = new System.Drawing.Point(105, 8);
            this.nameEnter.Name = "nameEnter";
            this.nameEnter.Size = new System.Drawing.Size(75, 34);
            this.nameEnter.TabIndex = 3;
            this.nameEnter.Text = "...";
            this.nameEnter.UseVisualStyleBackColor = false;
            this.nameEnter.Click += new System.EventHandler(this.NameEnter_Click);
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(984, 517);
            this.Controls.Add(this.nameEnter);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Line);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EnterForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "EnterForm";
            this.Load += new System.EventHandler(this.EnterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Line;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Button nameEnter;
    }
}

