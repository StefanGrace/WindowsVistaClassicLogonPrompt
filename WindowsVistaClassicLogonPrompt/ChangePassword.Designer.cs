namespace WindowsVistaClassicLogonPrompt
{
    partial class ChangePassword
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_oldPassword = new System.Windows.Forms.TextBox();
            this.textBox_newPassword = new System.Windows.Forms.TextBox();
            this.textBox_Confirm = new System.Windows.Forms.TextBox();
            this.button_backup = new System.Windows.Forms.Button();
            this.label_oldPassword = new System.Windows.Forms.Label();
            this.label_newPassword = new System.Windows.Forms.Label();
            this.label_confirm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsVistaClassicLogonPrompt.Properties.Resources.Windows_Vista_Loading_Bar_Frozen;
            this.pictureBox2.Location = new System.Drawing.Point(0, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(411, 5);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsVistaClassicLogonPrompt.Properties.Resources.Windows_Vista_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 72);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(322, 195);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 5;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(241, 195);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 4;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(111, 86);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(215, 20);
            this.textBox_username.TabIndex = 6;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(12, 89);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(61, 13);
            this.label_username.TabIndex = 11;
            this.label_username.Text = "User name:";
            // 
            // textBox_oldPassword
            // 
            this.textBox_oldPassword.Location = new System.Drawing.Point(111, 112);
            this.textBox_oldPassword.Name = "textBox_oldPassword";
            this.textBox_oldPassword.PasswordChar = '*';
            this.textBox_oldPassword.Size = new System.Drawing.Size(215, 20);
            this.textBox_oldPassword.TabIndex = 0;
            // 
            // textBox_newPassword
            // 
            this.textBox_newPassword.Location = new System.Drawing.Point(111, 138);
            this.textBox_newPassword.Name = "textBox_newPassword";
            this.textBox_newPassword.PasswordChar = '*';
            this.textBox_newPassword.Size = new System.Drawing.Size(215, 20);
            this.textBox_newPassword.TabIndex = 1;
            // 
            // textBox_Confirm
            // 
            this.textBox_Confirm.Location = new System.Drawing.Point(111, 164);
            this.textBox_Confirm.Name = "textBox_Confirm";
            this.textBox_Confirm.PasswordChar = '*';
            this.textBox_Confirm.Size = new System.Drawing.Size(215, 20);
            this.textBox_Confirm.TabIndex = 2;
            // 
            // button_backup
            // 
            this.button_backup.Location = new System.Drawing.Point(111, 195);
            this.button_backup.Name = "button_backup";
            this.button_backup.Size = new System.Drawing.Size(75, 23);
            this.button_backup.TabIndex = 3;
            this.button_backup.Text = "Backup...";
            this.button_backup.UseVisualStyleBackColor = true;
            this.button_backup.Click += new System.EventHandler(this.button_backup_Click);
            // 
            // label_oldPassword
            // 
            this.label_oldPassword.AutoSize = true;
            this.label_oldPassword.Location = new System.Drawing.Point(12, 115);
            this.label_oldPassword.Name = "label_oldPassword";
            this.label_oldPassword.Size = new System.Drawing.Size(74, 13);
            this.label_oldPassword.TabIndex = 11;
            this.label_oldPassword.Text = "Old password:";
            // 
            // label_newPassword
            // 
            this.label_newPassword.AutoSize = true;
            this.label_newPassword.Location = new System.Drawing.Point(12, 141);
            this.label_newPassword.Name = "label_newPassword";
            this.label_newPassword.Size = new System.Drawing.Size(80, 13);
            this.label_newPassword.TabIndex = 11;
            this.label_newPassword.Text = "New password:";
            // 
            // label_confirm
            // 
            this.label_confirm.AutoSize = true;
            this.label_confirm.Location = new System.Drawing.Point(12, 167);
            this.label_confirm.Name = "label_confirm";
            this.label_confirm.Size = new System.Drawing.Size(93, 13);
            this.label_confirm.TabIndex = 11;
            this.label_confirm.Text = "Confirm password:";
            // 
            // ChangePassword
            // 
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(409, 228);
            this.ControlBox = false;
            this.Controls.Add(this.label_confirm);
            this.Controls.Add(this.label_newPassword);
            this.Controls.Add(this.label_oldPassword);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.textBox_Confirm);
            this.Controls.Add(this.textBox_newPassword);
            this.Controls.Add(this.textBox_oldPassword);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.button_backup);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox textBox_oldPassword;
        private System.Windows.Forms.TextBox textBox_newPassword;
        private System.Windows.Forms.TextBox textBox_Confirm;
        private System.Windows.Forms.Button button_backup;
        private System.Windows.Forms.Label label_oldPassword;
        private System.Windows.Forms.Label label_newPassword;
        private System.Windows.Forms.Label label_confirm;
    }
}