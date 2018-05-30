using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Skins;
using Student.Forms;
using System.IO;

namespace Student
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //WindowsFormsSettings.ApplyDemoSettings();
            //new DevExpress.DemoReports.ConnectionStringConfigurator(System.Configuration.ConfigurationManager.ConnectionStrings)
            //    .SelectDbEngine()
            //    .ExpandDataDirectory(fileName => DevExpress.DemoData.Helpers.DataFilesHelper.FindFile(fileName, DevExpress.DemoData.Helpers.DataFilesHelper.DataPath));

            //string path = DevExpress.Utils.FilesHelper.FindingFileName(AppDomain.CurrentDomain.BaseDirectory, @"Data\NWind.mdf", false);
            //XtraReportsDemos.ConnectionHelper.ApplyDataDirectory(System.IO.Path.GetDirectoryName(path));

            //DataHelper.ApplicationArguments = arguments;
            System.Globalization.CultureInfo enUs = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = enUs;
            System.Threading.Thread.CurrentThread.CurrentUICulture = enUs;
            //DevExpress.Utils.LocalizationHelper.SetCurrentCulture(DataHelper.ApplicationArguments);
            //DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 8);
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013");
            SkinManager.EnableFormSkins();

            //EnumProcessingHelper.RegisterEnum<TaskStatus>();
            //SplashScreenManager.ShowForm(null, typeof(ssMain), true, true, false, 1000);

            InitConfigs();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());
            //Application.Run(new FrmCloseGateAnalysis());
            //Application.Run(new FrmWaterLossStat());
            //Application.Run(new FrmDDiffuseSimulationPrecise());
            //Application.Run(new FrmDComingWaterShow_kllk("f.txt", "卡拉贝利水库长系列来水过程"));
            //Application.Run(new FrmDComingWaterShow_klbl());
            Application.Run(new frmMain());
        }

        private static void InitConfigs()
        {
            Student.DBUtility.GlobalVariable.ProjectDirectory = getProJectDirectory();
        }

        private static string getProJectDirectory()
        {
            string strProjectDerectory = null;
            // strProjectDerectory
            strProjectDerectory = Application.ExecutablePath; ;
            string temppath = strProjectDerectory.Substring(0, strProjectDerectory.LastIndexOf("\\") + 1);
            strProjectDerectory = temppath;

            if (!Directory.Exists(strProjectDerectory))
            {

                Directory.CreateDirectory(strProjectDerectory);

            }
            return strProjectDerectory;
        }

    }
}
