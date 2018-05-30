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
using Student.BLL;

namespace Student.Forms
{
    public partial class frmFModifyPsw : DevExpress.XtraEditors.XtraForm
    {
        public frmFModifyPsw()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.CheckData() && this.SaveData())
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("修改成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                base.Close();
            }
        }

        private bool CheckData()
        {
            if (AppGlo.CurUser.USER_PWD != this.txtOldPsw.Text.Trim())
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("旧密码错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            if (this.txtNewPsw.Text != this.txtDblPsw.Text)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("新密码与确认密码不一致!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            if (this.txtNewPsw.Text.Trim().Length < 6)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("密码长度不能少于6位!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            return true;
        }

        private bool SaveData()
        {
            Student.BLL.BRBAC_USER user = new BRBAC_USER();
            AppGlo.CurUser.USER_PWD = this.txtNewPsw.Text.Trim();
            user.Update(AppGlo.CurUser);
            return true;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            base.Close();
        }
    }
}