using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student.Forms
{
    class MyWaitDialogForm : DevExpress.Utils.WaitDialogForm
    {
        WaitDialogForm WaitBeforeLogin = null;

        public MyWaitDialogForm()
            : base("正在加载中...", "请稍等", new System.Drawing.Size(300, 80))
        {
            base.TopMost = true;
            base.BackColor = System.Drawing.Color.LightGray;

            Thread t = new Thread((ThreadStart)delegate
            {
                WaitBeforeLogin = new DevExpress.Utils.WaitDialogForm("请稍候...", "正在加载应用系统");
                WaitBeforeLogin.TopMost = true;
                Application.Run(WaitBeforeLogin);
            });
            t.Start();
 
        }

        public MyWaitDialogForm(string caption, string title)
            : base(caption, title)
        {
            base.TopMost = true;
        }
        
        public void Close()
        {
            if (WaitBeforeLogin != null)
            {
                WaitBeforeLogin.Invoke((EventHandler)delegate { WaitBeforeLogin.Close(); }); 
            }
        }
        
    }
}
