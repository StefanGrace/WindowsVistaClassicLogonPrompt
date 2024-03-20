namespace WindowsVistaClassicLogonPrompt
{
    partial class LoadingWindow
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
            this.components = new System.ComponentModel.Container();
            this.label_loadingText = new System.Windows.Forms.Label();
            this.timer_startingUp = new System.Windows.Forms.Timer(this.components);
            this.timer_shuttingDown = new System.Windows.Forms.Timer(this.components);
            this.timer_loggingOn = new System.Windows.Forms.Timer(this.components);
            this.timer_loggingOff = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_loadingText
            // 
            this.label_loadingText.AutoSize = true;
            this.label_loadingText.Location = new System.Drawing.Point(13, 90);
            this.label_loadingText.Name = "label_loadingText";
            this.label_loadingText.Size = new System.Drawing.Size(122, 13);
            this.label_loadingText.TabIndex = 2;
            this.label_loadingText.Text = "Windows is starting up...";
            // 
            // timer_startingUp
            // 
            this.timer_startingUp.Interval = 1500;
            this.timer_startingUp.Tick += new System.EventHandler(this.timer_startingUp_Tick);
            // 
            // timer_shuttingDown
            // 
            this.timer_shuttingDown.Interval = 2500;
            this.timer_shuttingDown.Tick += new System.EventHandler(this.timer_shuttingDown_Tick);
            // 
            // timer_loggingOn
            // 
            this.timer_loggingOn.Interval = 1500;
            this.timer_loggingOn.Tick += new System.EventHandler(this.timer_loggingOn_Tick);
            // 
            // timer_loggingOff
            // 
            this.timer_loggingOff.Interval = 1500;
            this.timer_loggingOff.Tick += new System.EventHandler(this.timer_loggingOff_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsVistaClassicLogonPrompt.Properties.Resources.Windows_Vista_Loading_Bar_Moving;
            this.pictureBox2.Location = new System.Drawing.Point(0, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(411, 5);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsVistaClassicLogonPrompt.Properties.Resources.Windows_Vista_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 72);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoadingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 115);
            this.ControlBox = false;
            this.Controls.Add(this.label_loadingText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Please wait...";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_loadingText;
        private System.Windows.Forms.Timer timer_startingUp;
        private System.Windows.Forms.Timer timer_shuttingDown;
        private System.Windows.Forms.Timer timer_loggingOn;
        private System.Windows.Forms.Timer timer_loggingOff;
    }
}

