namespace WindowsVistaClassicLogonPrompt
{
    partial class UserDesktop
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
            this.checkBox_ctrlAltDelReq = new System.Windows.Forms.CheckBox();
            this.label_ctrlAltDelSimulation = new System.Windows.Forms.Label();
            this.button_ws = new System.Windows.Forms.Button();
            this.checkBox_displayLastUser = new System.Windows.Forms.CheckBox();
            this.checkBox_displayBackground = new System.Windows.Forms.CheckBox();
            this.label_username = new System.Windows.Forms.Label();
            this.button_lock = new System.Windows.Forms.Button();
            this.button_switchUser = new System.Windows.Forms.Button();
            this.button_logOff = new System.Windows.Forms.Button();
            this.button_sleep = new System.Windows.Forms.Button();
            this.button_restart = new System.Windows.Forms.Button();
            this.button_shutDown = new System.Windows.Forms.Button();
            this.button_shutDownDialogue = new System.Windows.Forms.Button();
            this.checkBox_lockAfterSleep = new System.Windows.Forms.CheckBox();
            this.comboBox_defaultActions = new System.Windows.Forms.ComboBox();
            this.label_defaultPowerAction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox_ctrlAltDelReq
            // 
            this.checkBox_ctrlAltDelReq.AutoSize = true;
            this.checkBox_ctrlAltDelReq.Location = new System.Drawing.Point(26, 219);
            this.checkBox_ctrlAltDelReq.Name = "checkBox_ctrlAltDelReq";
            this.checkBox_ctrlAltDelReq.Size = new System.Drawing.Size(204, 17);
            this.checkBox_ctrlAltDelReq.TabIndex = 9;
            this.checkBox_ctrlAltDelReq.Text = "Require users to press Ctrl+Alt+Delete";
            this.checkBox_ctrlAltDelReq.UseVisualStyleBackColor = true;
            // 
            // label_ctrlAltDelSimulation
            // 
            this.label_ctrlAltDelSimulation.AutoSize = true;
            this.label_ctrlAltDelSimulation.Location = new System.Drawing.Point(30, 28);
            this.label_ctrlAltDelSimulation.Name = "label_ctrlAltDelSimulation";
            this.label_ctrlAltDelSimulation.Size = new System.Drawing.Size(193, 13);
            this.label_ctrlAltDelSimulation.TabIndex = 1;
            this.label_ctrlAltDelSimulation.Text = "Press Delete to simulate Ctrl+Alt+Delete";
            // 
            // button_ws
            // 
            this.button_ws.Location = new System.Drawing.Point(63, 44);
            this.button_ws.Name = "button_ws";
            this.button_ws.Size = new System.Drawing.Size(132, 23);
            this.button_ws.TabIndex = 0;
            this.button_ws.Text = "Windows Security";
            this.button_ws.UseVisualStyleBackColor = true;
            this.button_ws.Click += new System.EventHandler(this.button_ws_Click);
            // 
            // checkBox_displayLastUser
            // 
            this.checkBox_displayLastUser.AutoSize = true;
            this.checkBox_displayLastUser.Checked = true;
            this.checkBox_displayLastUser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_displayLastUser.Location = new System.Drawing.Point(26, 242);
            this.checkBox_displayLastUser.Name = "checkBox_displayLastUser";
            this.checkBox_displayLastUser.Size = new System.Drawing.Size(131, 17);
            this.checkBox_displayLastUser.TabIndex = 10;
            this.checkBox_displayLastUser.Text = "Display last user name";
            this.checkBox_displayLastUser.UseVisualStyleBackColor = true;
            // 
            // checkBox_displayBackground
            // 
            this.checkBox_displayBackground.AutoSize = true;
            this.checkBox_displayBackground.Location = new System.Drawing.Point(26, 288);
            this.checkBox_displayBackground.Name = "checkBox_displayBackground";
            this.checkBox_displayBackground.Size = new System.Drawing.Size(209, 17);
            this.checkBox_displayBackground.TabIndex = 12;
            this.checkBox_displayBackground.Text = "Display background (restart to change)";
            this.checkBox_displayBackground.UseVisualStyleBackColor = true;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(30, 9);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(61, 13);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "Username: ";
            // 
            // button_lock
            // 
            this.button_lock.Location = new System.Drawing.Point(11, 158);
            this.button_lock.Name = "button_lock";
            this.button_lock.Size = new System.Drawing.Size(75, 23);
            this.button_lock.TabIndex = 3;
            this.button_lock.Text = "Lock";
            this.button_lock.UseVisualStyleBackColor = true;
            this.button_lock.Click += new System.EventHandler(this.button_lock_Click);
            // 
            // button_switchUser
            // 
            this.button_switchUser.Location = new System.Drawing.Point(92, 158);
            this.button_switchUser.Name = "button_switchUser";
            this.button_switchUser.Size = new System.Drawing.Size(75, 23);
            this.button_switchUser.TabIndex = 4;
            this.button_switchUser.Text = "Switch User";
            this.button_switchUser.UseVisualStyleBackColor = true;
            this.button_switchUser.Click += new System.EventHandler(this.button_switchUser_Click);
            // 
            // button_logOff
            // 
            this.button_logOff.Location = new System.Drawing.Point(173, 158);
            this.button_logOff.Name = "button_logOff";
            this.button_logOff.Size = new System.Drawing.Size(75, 23);
            this.button_logOff.TabIndex = 5;
            this.button_logOff.Text = "Log Off";
            this.button_logOff.UseVisualStyleBackColor = true;
            this.button_logOff.Click += new System.EventHandler(this.button_logOff_Click);
            // 
            // button_sleep
            // 
            this.button_sleep.Location = new System.Drawing.Point(11, 187);
            this.button_sleep.Name = "button_sleep";
            this.button_sleep.Size = new System.Drawing.Size(75, 23);
            this.button_sleep.TabIndex = 6;
            this.button_sleep.Text = "Sleep";
            this.button_sleep.UseVisualStyleBackColor = true;
            this.button_sleep.Click += new System.EventHandler(this.button_sleep_Click);
            // 
            // button_restart
            // 
            this.button_restart.Location = new System.Drawing.Point(92, 187);
            this.button_restart.Name = "button_restart";
            this.button_restart.Size = new System.Drawing.Size(75, 23);
            this.button_restart.TabIndex = 7;
            this.button_restart.Text = "Restart";
            this.button_restart.UseVisualStyleBackColor = true;
            this.button_restart.Click += new System.EventHandler(this.button_restart_Click);
            // 
            // button_shutDown
            // 
            this.button_shutDown.Location = new System.Drawing.Point(173, 187);
            this.button_shutDown.Name = "button_shutDown";
            this.button_shutDown.Size = new System.Drawing.Size(75, 23);
            this.button_shutDown.TabIndex = 8;
            this.button_shutDown.Text = "Shut Down";
            this.button_shutDown.UseVisualStyleBackColor = true;
            this.button_shutDown.Click += new System.EventHandler(this.button_shutDown_Click);
            // 
            // button_shutDownDialogue
            // 
            this.button_shutDownDialogue.Location = new System.Drawing.Point(63, 129);
            this.button_shutDownDialogue.Name = "button_shutDownDialogue";
            this.button_shutDownDialogue.Size = new System.Drawing.Size(132, 23);
            this.button_shutDownDialogue.TabIndex = 2;
            this.button_shutDownDialogue.Text = "Shut Down Dialogue... ";
            this.button_shutDownDialogue.UseVisualStyleBackColor = true;
            this.button_shutDownDialogue.Click += new System.EventHandler(this.button_shutDownDialogue_Click);
            // 
            // checkBox_lockAfterSleep
            // 
            this.checkBox_lockAfterSleep.AutoSize = true;
            this.checkBox_lockAfterSleep.Checked = true;
            this.checkBox_lockAfterSleep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_lockAfterSleep.Location = new System.Drawing.Point(26, 265);
            this.checkBox_lockAfterSleep.Name = "checkBox_lockAfterSleep";
            this.checkBox_lockAfterSleep.Size = new System.Drawing.Size(209, 17);
            this.checkBox_lockAfterSleep.TabIndex = 11;
            this.checkBox_lockAfterSleep.Text = "Require password on wake from sleep ";
            this.checkBox_lockAfterSleep.UseVisualStyleBackColor = true;
            // 
            // comboBox_defaultActions
            // 
            this.comboBox_defaultActions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_defaultActions.FormattingEnabled = true;
            this.comboBox_defaultActions.Items.AddRange(new object[] {
            "Sleep",
            "Shut Down"});
            this.comboBox_defaultActions.Location = new System.Drawing.Point(33, 95);
            this.comboBox_defaultActions.Name = "comboBox_defaultActions";
            this.comboBox_defaultActions.Size = new System.Drawing.Size(190, 21);
            this.comboBox_defaultActions.TabIndex = 1;
            // 
            // label_defaultPowerAction
            // 
            this.label_defaultPowerAction.AutoSize = true;
            this.label_defaultPowerAction.Location = new System.Drawing.Point(30, 79);
            this.label_defaultPowerAction.Name = "label_defaultPowerAction";
            this.label_defaultPowerAction.Size = new System.Drawing.Size(108, 13);
            this.label_defaultPowerAction.TabIndex = 5;
            this.label_defaultPowerAction.Text = "Default power action:";
            // 
            // UserDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 316);
            this.ControlBox = false;
            this.Controls.Add(this.label_defaultPowerAction);
            this.Controls.Add(this.comboBox_defaultActions);
            this.Controls.Add(this.button_logOff);
            this.Controls.Add(this.button_switchUser);
            this.Controls.Add(this.button_shutDown);
            this.Controls.Add(this.button_restart);
            this.Controls.Add(this.button_sleep);
            this.Controls.Add(this.button_lock);
            this.Controls.Add(this.button_shutDownDialogue);
            this.Controls.Add(this.button_ws);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_ctrlAltDelSimulation);
            this.Controls.Add(this.checkBox_displayBackground);
            this.Controls.Add(this.checkBox_lockAfterSleep);
            this.Controls.Add(this.checkBox_displayLastUser);
            this.Controls.Add(this.checkBox_ctrlAltDelReq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "UserDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Desktop";
            this.Load += new System.EventHandler(this.UserDesktop_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserDesktop_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_ctrlAltDelReq;
        private System.Windows.Forms.Label label_ctrlAltDelSimulation;
        private System.Windows.Forms.Button button_ws;
        private System.Windows.Forms.CheckBox checkBox_displayLastUser;
        private System.Windows.Forms.CheckBox checkBox_displayBackground;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_lock;
        private System.Windows.Forms.Button button_switchUser;
        private System.Windows.Forms.Button button_logOff;
        private System.Windows.Forms.Button button_sleep;
        private System.Windows.Forms.Button button_restart;
        private System.Windows.Forms.Button button_shutDown;
        private System.Windows.Forms.Button button_shutDownDialogue;
        private System.Windows.Forms.CheckBox checkBox_lockAfterSleep;
        private System.Windows.Forms.ComboBox comboBox_defaultActions;
        private System.Windows.Forms.Label label_defaultPowerAction;
    }
}