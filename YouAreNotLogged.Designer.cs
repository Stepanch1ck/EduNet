namespace EduNet
{
    partial class YouAreNotLogged
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
            this.button1 = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.enterInAccount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(129, 138);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(82, 39);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // enterInAccount
            // 
            this.enterInAccount.BackColor = System.Drawing.SystemColors.Control;
            this.enterInAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterInAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterInAccount.Location = new System.Drawing.Point(62, 59);
            this.enterInAccount.Multiline = true;
            this.enterInAccount.Name = "enterInAccount";
            this.enterInAccount.Size = new System.Drawing.Size(250, 49);
            this.enterInAccount.TabIndex = 2;
            this.enterInAccount.Text = "Войдите в аккаунт";
            // 
            // YouAreNotLogged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(366, 205);
            this.Controls.Add(this.enterInAccount);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.button1);
            this.Name = "YouAreNotLogged";
            this.Text = "Ошибка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox enterInAccount;
    }
}