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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace Student.Forms
{
    public partial class SplashScreen1 : SplashScreen {
        public SplashScreen1() {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg) {
            base.ProcessCommand(cmd, arg);
            SplashScreenCommand command = (SplashScreenCommand)cmd;
            if (command == SplashScreenCommand.SetProgress) {
                int pos = (int)arg;
                progressBarControl1.Position = pos;
            }
        }

        #endregion

        public enum SplashScreenCommand {
            SetProgress,
            Command2,
            Command3
        }
    }
}