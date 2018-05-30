// Developer Express Code Central Example:
// How to interact with a Splash Screen by sending commands
// 
// In this example a custom Progress Bar Control is added to a Splash Screen. The
// example shows how to update this Progress Bar Control dynamically by sending
// commands from a Splash Screen Manager.
// 
// Splash Screens are displayed by a
// Splash Screen Manager in a separate thread. Interaction with Splash Screens can
// be performed via the command mechanism. You send a command via the
// SplashScreenManager.SendCommand method and process this command by overriding
// the SplashScreen.ProcessCommand method.
// 
// In the example, custom commands are
// sent to the Splash Screen to advance the progress of the Splash Screen's
// Progress Bar Control.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3576

namespace Student.Forms
{
    partial class SplashScreen1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(23, 19);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(405, 25);
            this.progressBarControl1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "正在处理中......";
            // 
            // SplashScreen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 138);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarControl1);
            this.Name = "SplashScreen1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private System.Windows.Forms.Label label1;
    }
}
