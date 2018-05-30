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
using Student.Model;
using Student.DBUtility;

namespace Student.Forms
{
    public partial class frmDEPARTMENTADD : DevExpress.XtraEditors.XtraForm
    {
        private StatusClass _enumStatus;
        private int _departmentno;

        /// <summary>
        /// 构造方法
        /// 其中，_enumStatus为标识该功能为“新增”、“删除”、“修改”的，AddNew为新增
        /// </summary>
        public frmDEPARTMENTADD()
        {
            this._enumStatus = StatusClass.AddNew;
            InitializeComponent();
        }

        public frmDEPARTMENTADD(int iID, StatusClass enumStatus)
        {
            this._enumStatus = StatusClass.Edit;
            this._departmentno = iID;
            InitializeComponent();
            this.Text = "修改学院信息";
            readData();
            this.te_departmentno.ReadOnly = true;
        }

        private void readData()
        {
            if (this._departmentno > 0)
            {
                BLL.DEPARTMENT_INFO departmentbll = new BLL.DEPARTMENT_INFO();
                Model.DEPARTMENT_INFO departmentmdl = new Model.DEPARTMENT_INFO();
                departmentmdl = departmentbll.GetModel(_departmentno);
                if (departmentmdl == null)
                {
                    blankData();
                }
                else
                {
                    this.te_departmentname.Text = departmentmdl.DEPARTMENTNAME;
                    this.te_departmentno.Text = ToolHelper.ConvertToString(departmentmdl.DEPARTMENTNO);
                }
            }
        }

        private void blankData()
        {
            this.te_departmentno.Text = "";
            this.te_departmentname.Text = "";
        }


        /// <summary>
        /// 保存数据方法
        /// </summary>
        /// <returns></returns>
        private bool saveData()
        {
            try
            {
                BLL.DEPARTMENT_INFO departmentbll = new BLL.DEPARTMENT_INFO();
                Model.DEPARTMENT_INFO departmentmdl = new Model.DEPARTMENT_INFO();

                if (this.te_departmentname.Text == "")
                {
                    MessageBox.Show("学院编号不能为空!", "提示信息");
                    return false;
                }
                if (!ToolHelper.IsNumeric(this.te_departmentno.Text))
                {
                    MessageBox.Show("学院编号必须为数字!", "提示信息");
                    return false;
                }
                if (this._enumStatus == StatusClass.AddNew)
                {
                    if (departmentbll.Exists(ToolHelper.ConvertToInt(te_departmentno.Text)))
                    {
                        MessageBox.Show("当前编号已经存在，请核查!", "提示信息");
                        return false;
                    }     

                    departmentmdl.DEPARTMENTNO = ToolHelper.ConvertToInt(te_departmentno.Text);
                    departmentmdl.DEPARTMENTNAME = te_departmentname.Text;
                    departmentbll.Add(departmentmdl);
                    return true;
                }
                else if (this._enumStatus == StatusClass.Edit)
                {
                    departmentmdl.DEPARTMENTNO = this._departmentno;
                    departmentmdl.DEPARTMENTNAME = te_departmentname.Text;
                    departmentbll.Update(departmentmdl);
                    return true;
                }
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("保存失败!", exception.Message);
                return false;
            }
        }

        private void sbt_save_Click(object sender, EventArgs e)
        {
            if (saveData())
            {
                //MessageBox.Show("保存成功!", "提示信息");
                this.Close();
                return;
            }
        }

        private void sbt_clear_Click(object sender, EventArgs e)
        {
            te_departmentname.Text = "";
            te_departmentno.Text = "";
        }

        private void sbt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}