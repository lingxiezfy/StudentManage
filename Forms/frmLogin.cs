using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Student.Model;
using Student.BLL;

namespace Student.Forms
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
            this.Width = 632;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            AppGlo.CurUser = this.ValidLogin(this.txtUser.Text, this.txtPwd.Text);
            if (AppGlo.CurUser != null)
            {
                base.Hide();
                frmMain frm = new frmMain();
                if (frm.ShowDialog(this) == DialogResult.Cancel)//根据frmMain的返回Result判断，若为cancel表示正常退出，若为ok,表示是选择“重新登陆”以后退出系统
                {
                    base.Close();
                    base.Dispose();
                }
                else
                {
                    base.Show();
                }
            }
            else
            {
               DevExpress.XtraEditors.XtraMessageBox.Show("用户名或密码错误!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private Student.Model.BRBAC_USER ValidLogin(string sOprCode, string sPsw)
        {
            Student.Model.BRBAC_USER userInfo = new Student.BLL.BRBAC_USER().GetModel(decimal.Parse(sOprCode));
            if ((userInfo != null) && (userInfo.USER_PWD.ToUpper() == sPsw.ToUpper()))
            {
                return userInfo;
            }
            return null;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.txtUser.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnOk_Click(null,null);
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.txtPwd.Focus();
            }
        }
    }
}