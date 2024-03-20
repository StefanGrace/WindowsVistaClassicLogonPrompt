namespace WindowsVistaClassicLogonPrompt
{
    partial class WindowsSecurity
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
            this.groupBox_logonInfo = new System.Windows.Forms.GroupBox();
            this.label_dateLoggedOn = new System.Windows.Forms.Label();
            this.labelDateLoggedOn = new System.Windows.Forms.Label();
            this.label_logonDate = new System.Windows.Forms.Label();
            this.label_loggedOnAs = new System.Windows.Forms.Label();
            this.label_useTaskManager = new System.Windows.Forms.Label();
            this.button_changePassword = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_taskManager = new System.Windows.Forms.Button();
            this.button_lock = new System.Windows.Forms.Button();
            this.button_shutDown = new System.Windows.Forms.Button();
            this.button_logOff = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_logonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_logonInfo
            // 
            this.groupBox_logonInfo.Controls.Add(this.label_dateLoggedOn);
            this.groupBox_logonInfo.Controls.Add(this.labelDateLoggedOn);
            this.groupBox_logonInfo.Controls.Add(this.label_logonDate);
            this.groupBox_logonInfo.Controls.Add(this.label_loggedOnAs);
            this.groupBox_logonInfo.Location = new System.Drawing.Point(13, 80);
            this.groupBox_logonInfo.Name = "groupBox_logonInfo";
            this.groupBox_logonInfo.Size = new System.Drawing.Size(384, 78);
            this.groupBox_logonInfo.TabIndex = 6;
            this.groupBox_logonInfo.TabStop = false;
            this.groupBox_logonInfo.Text = "Logon Information";
            // 
            // label_dateLoggedOn
            // 
            this.label_dateLoggedOn.AutoSize = true;
            this.label_dateLoggedOn.Location = new System.Drawing.Point(80, 50);
            this.label_dateLoggedOn.Name = "label_dateLoggedOn";
            this.label_dateLoggedOn.Size = new System.Drawing.Size(34, 13);
            this.label_dateLoggedOn.TabIndex = 1;
            this.label_dateLoggedOn.Text = "[date]";
            // 
            // labelDateLoggedOn
            // 
            this.labelDateLoggedOn.AutoSize = true;
            this.labelDateLoggedOn.Location = new System.Drawing.Point(82, 50);
            this.labelDateLoggedOn.Name = "labelDateLoggedOn";
            this.labelDateLoggedOn.Size = new System.Drawing.Size(0, 13);
            this.labelDateLoggedOn.TabIndex = 0;
            // 
            // label_logonDate
            // 
            this.label_logonDate.AutoSize = true;
            this.label_logonDate.Location = new System.Drawing.Point(7, 50);
            this.label_logonDate.Name = "label_logonDate";
            this.label_logonDate.Size = new System.Drawing.Size(66, 13);
            this.label_logonDate.TabIndex = 0;
            this.label_logonDate.Text = "Logon Date:";
            // 
            // label_loggedOnAs
            // 
            this.label_loggedOnAs.AutoSize = true;
            this.label_loggedOnAs.Location = new System.Drawing.Point(7, 20);
            this.label_loggedOnAs.Name = "label_loggedOnAs";
            this.label_loggedOnAs.Size = new System.Drawing.Size(163, 13);
            this.label_loggedOnAs.TabIndex = 0;
            this.label_loggedOnAs.Text = "You are logged on as [username]";
            // 
            // label_useTaskManager
            // 
            this.label_useTaskManager.AutoSize = true;
            this.label_useTaskManager.Location = new System.Drawing.Point(12, 172);
            this.label_useTaskManager.Name = "label_useTaskManager";
            this.label_useTaskManager.Size = new System.Drawing.Size(314, 13);
            this.label_useTaskManager.TabIndex = 0;
            this.label_useTaskManager.Text = "Use Task Manager to close an application that is not responding.";
            // 
            // button_changePassword
            // 
            this.button_changePassword.Location = new System.Drawing.Point(13, 227);
            this.button_changePassword.Name = "button_changePassword";
            this.button_changePassword.Size = new System.Drawing.Size(122, 23);
            this.button_changePassword.TabIndex = 3;
            this.button_changePassword.Text = "Change Password...";
            this.button_changePassword.UseVisualStyleBackColor = true;
            this.button_changePassword.Click += new System.EventHandler(this.button_changePassword_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(275, 227);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(122, 23);
            this.button_cancel.TabIndex = 5;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_taskManager
            // 
            this.button_taskManager.Location = new System.Drawing.Point(144, 227);
            this.button_taskManager.Name = "button_taskManager";
            this.button_taskManager.Size = new System.Drawing.Size(122, 23);
            this.button_taskManager.TabIndex = 4;
            this.button_taskManager.Text = "Task Manager";
            this.button_taskManager.UseVisualStyleBackColor = true;
            this.button_taskManager.Click += new System.EventHandler(this.button_taskManager_Click);
            // 
            // button_lock
            // 
            this.button_lock.Location = new System.Drawing.Point(13, 198);
            this.button_lock.Name = "button_lock";
            this.button_lock.Size = new System.Drawing.Size(122, 23);
            this.button_lock.TabIndex = 0;
            this.button_lock.Text = "Lock Computer";
            this.button_lock.UseVisualStyleBackColor = true;
            this.button_lock.Click += new System.EventHandler(this.button_lock_Click);
            // 
            // button_shutDown
            // 
            this.button_shutDown.Location = new System.Drawing.Point(275, 198);
            this.button_shutDown.Name = "button_shutDown";
            this.button_shutDown.Size = new System.Drawing.Size(122, 23);
            this.button_shutDown.TabIndex = 2;
            this.button_shutDown.Text = "Shut Down...";
            this.button_shutDown.UseVisualStyleBackColor = true;
            this.button_shutDown.Click += new System.EventHandler(this.button_shutDown_Click);
            // 
            // button_logOff
            // 
            this.button_logOff.Location = new System.Drawing.Point(144, 198);
            this.button_logOff.Name = "button_logOff";
            this.button_logOff.Size = new System.Drawing.Size(122, 23);
            this.button_logOff.TabIndex = 1;
            this.button_logOff.Text = "Log Off...";
            this.button_logOff.UseVisualStyleBackColor = true;
            this.button_logOff.Click += new System.EventHandler(this.button_logOff_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsVistaClassicLogonPrompt.Properties.Resources.Windows_Vista_Loading_Bar_Frozen;
            this.pictureBox2.Location = new System.Drawing.Point(0, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(411, 5);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsVistaClassicLogonPrompt.Properties.Resources.Windows_Vista_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 72);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // WindowsSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(409, 261);
            this.ControlBox = false;
            this.Controls.Add(this.button_logOff);
            this.Controls.Add(this.button_taskManager);
            this.Controls.Add(this.button_shutDown);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_lock);
            this.Controls.Add(this.button_changePassword);
            this.Controls.Add(this.groupBox_logonInfo);
            this.Controls.Add(this.label_useTaskManager);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "WindowsSecurity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Security";
            this.Load += new System.EventHandler(this.WindowsSecurity_Load);
            this.groupBox_logonInfo.ResumeLayout(false);
            this.groupBox_logonInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox_logonInfo;
        private System.Windows.Forms.Label labelDateLoggedOn;
        private System.Windows.Forms.Label label_logonDate;
        private System.Windows.Forms.Label label_loggedOnAs;
        private System.Windows.Forms.Label label_useTaskManager;
        private System.Windows.Forms.Button button_changePassword;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_taskManager;
        private System.Windows.Forms.Button button_lock;
        private System.Windows.Forms.Button button_shutDown;
        private System.Windows.Forms.Button button_logOff;
        private System.Windows.Forms.Label label_dateLoggedOn;
    }
}