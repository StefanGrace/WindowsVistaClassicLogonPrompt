namespace WindowsVistaClassicLogonPrompt
{
    partial class LogOffPrompt
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_switchUser = new System.Windows.Forms.Button();
            this.button_LogOff = new System.Windows.Forms.Button();
            this.label_LogOff = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(233, 61);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 0;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_switchUser
            // 
            this.button_switchUser.Location = new System.Drawing.Point(152, 61);
            this.button_switchUser.Name = "button_switchUser";
            this.button_switchUser.Size = new System.Drawing.Size(75, 23);
            this.button_switchUser.TabIndex = 1;
            this.button_switchUser.Text = "Switch User";
            this.button_switchUser.UseVisualStyleBackColor = true;
            this.button_switchUser.Click += new System.EventHandler(this.button_switchUser_Click);
            // 
            // button_LogOff
            // 
            this.button_LogOff.Location = new System.Drawing.Point(71, 61);
            this.button_LogOff.Name = "button_LogOff";
            this.button_LogOff.Size = new System.Drawing.Size(75, 23);
            this.button_LogOff.TabIndex = 2;
            this.button_LogOff.Text = "Log Off";
            this.button_LogOff.UseVisualStyleBackColor = true;
            this.button_LogOff.Click += new System.EventHandler(this.button_LogOff_Click);
            // 
            // label_LogOff
            // 
            this.label_LogOff.Location = new System.Drawing.Point(68, 13);
            this.label_LogOff.Name = "label_LogOff";
            this.label_LogOff.Size = new System.Drawing.Size(240, 45);
            this.label_LogOff.TabIndex = 3;
            this.label_LogOff.Text = "Are you sure you want to log off?\r\nIf you want to leave programs running and swit" +
    "ch to another user, click Switch User.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsVistaClassicLogonPrompt.Properties.Resources.Log_Off_Icon_32x32;
            this.pictureBox1.InitialImage = global::WindowsVistaClassicLogonPrompt.Properties.Resources.Log_Off_Icon_32x32;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LogOffPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(324, 96);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_LogOff);
            this.Controls.Add(this.button_LogOff);
            this.Controls.Add(this.button_switchUser);
            this.Controls.Add(this.button_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LogOffPrompt";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log Off Windows";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_switchUser;
        private System.Windows.Forms.Button button_LogOff;
        private System.Windows.Forms.Label label_LogOff;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}