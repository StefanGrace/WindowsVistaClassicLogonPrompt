namespace WindowsVistaClassicLogonPrompt
{
    partial class CtrlAltDelLocked
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
            this.button_switchUser = new System.Windows.Forms.Button();
            this.label_helpText = new System.Windows.Forms.Label();
            this.label_userLoggedOn = new System.Windows.Forms.Label();
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
            // button_switchUser
            // 
            this.button_switchUser.Location = new System.Drawing.Point(322, 152);
            this.button_switchUser.Name = "button_switchUser";
            this.button_switchUser.Size = new System.Drawing.Size(75, 23);
            this.button_switchUser.TabIndex = 0;
            this.button_switchUser.Text = "Switch User";
            this.button_switchUser.UseVisualStyleBackColor = true;
            this.button_switchUser.Click += new System.EventHandler(this.button_switchUser_Click);
            // 
            // label_helpText
            // 
            this.label_helpText.AutoSize = true;
            this.label_helpText.Location = new System.Drawing.Point(12, 94);
            this.label_helpText.Name = "label_helpText";
            this.label_helpText.Size = new System.Drawing.Size(213, 13);
            this.label_helpText.TabIndex = 8;
            this.label_helpText.Text = "Press Ctrl+Alt+Delte to unlock this computer";
            // 
            // label_userLoggedOn
            // 
            this.label_userLoggedOn.AutoSize = true;
            this.label_userLoggedOn.Location = new System.Drawing.Point(12, 127);
            this.label_userLoggedOn.Name = "label_userLoggedOn";
            this.label_userLoggedOn.Size = new System.Drawing.Size(122, 13);
            this.label_userLoggedOn.TabIndex = 8;
            this.label_userLoggedOn.Text = "[username] is logged on.";
            // 
            // CtrlAltDelLocked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 187);
            this.ControlBox = false;
            this.Controls.Add(this.label_userLoggedOn);
            this.Controls.Add(this.label_helpText);
            this.Controls.Add(this.button_switchUser);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "CtrlAltDelLocked";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Locked";
            this.Load += new System.EventHandler(this.CtrlAltDelLocked_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CtrlAltDelLocked_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_switchUser;
        private System.Windows.Forms.Label label_helpText;
        private System.Windows.Forms.Label label_userLoggedOn;
    }
}