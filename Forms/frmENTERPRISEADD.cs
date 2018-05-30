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
    public partial class frmENTERPRISEADD : DevExpress.XtraEditors.XtraForm
    {
        private StatusClass _enumStatus;
        private int _entno;

        public frmENTERPRISEADD()
        {
            InitializeComponent();
            this._enumStatus = StatusClass.AddNew;
        }

         /// <summary>
        /// 构造方法，修改专业功能可用，iID为传过来的专业编号，enumStatus标识当前功能
        /// </summary>
        /// <param name="iID"></param>
        /// <param name="enumStatus"></param>
        public frmENTERPRISEADD(int iID, StatusClass enumStatus)
        {
            this._enumStatus = StatusClass.Edit;     //修改专业信息
            this._entno = iID;
            InitializeComponent();
            this.Text = "修改企业信息";              //修改界面title
            readData();                              //查询数据
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        private void readData()
        {
            if (this._entno > 0)
            {
                BLL.ENTERPRISE_INFO entBll = new BLL.ENTERPRISE_INFO();
                Model.ENTERPRISE_INFO entMdl = new Model.ENTERPRISE_INFO();

                entMdl = entBll.GetModel(_entno);
                if (entMdl == null)   //新增专业功能时
                {
                    blankData();
                }
                else                   //修改专业功能时
                {
                    this.te_entname.Text = entMdl.ENTNAME;
                    this.te_entaddr.Text = entMdl.ENTADDRESS;
                    this.te_linker1.Text = entMdl.LINKER1;
                    this.te_phone1.Text = entMdl.PHONE1;
                    this.te_linker2.Text = entMdl.LINKER2;
                    this.te_phone2.Text = entMdl.PHONE2;
                    this.te_linker3.Text = entMdl.LINKER3;
                    this.te_phone3.Text = entMdl.PHONE3;
                    this.te_memo.Text = entMdl.MEMO;
                    this.te_demand.Text = entMdl.DEMAND;
                }
            }
        }

        /// <summary>
        /// 清空输入框数据
        /// </summary>
        private void blankData()
        {
            this.te_entname.Text = "";
            this.te_entaddr.Text = "";
            this.te_linker1.Text = "";
            this.te_phone1.Text = "";
            this.te_linker2.Text = "";
            this.te_phone2.Text = "";
            this.te_linker3.Text = "";
            this.te_phone3.Text = "";
            this.te_memo.Text = "";
            this.te_demand.Text = "";
        }

        /// <summary>
        /// 保存数据方法
        /// </summary>
        /// <returns></returns>
        private bool saveData()
        {
            try
            {
                BLL.ENTERPRISE_INFO entBll = new BLL.ENTERPRISE_INFO();
                Model.ENTERPRISE_INFO entMdl = new Model.ENTERPRISE_INFO();
                
                if (this.te_entname.Text == "")
                {
                    MessageBox.Show("企业名称不能为空!", "提示信息");
                    return false;
                }
                
                if (this._enumStatus == StatusClass.AddNew)  //新增专业
                {
                    entMdl.ENTNAME = te_entname.Text;
                    entMdl.ENTADDRESS = te_entaddr.Text;
                    entMdl.LINKER1 = te_linker1.Text;
                    entMdl.LINKER2 = te_linker2.Text;
                    entMdl.LINKER3 = te_linker3.Text;
                    entMdl.PHONE1 = te_phone1.Text;
                    entMdl.PHONE2 = te_phone2.Text;
                    entMdl.PHONE3 = te_phone2.Text;
                    entMdl.MEMO = te_memo.Text;
                    entMdl.DEMAND = te_demand.Text;
                    entBll.Add(entMdl);
                    return true;
                }
                else if (this._enumStatus == StatusClass.Edit)  //修改专业
                {
                    entMdl.ENTNO= this._entno;
                    entMdl.ENTNAME = te_entname.Text;
                    entMdl.ENTADDRESS = te_entaddr.Text;
                    entMdl.LINKER1 = te_linker1.Text;
                    entMdl.LINKER2 = te_linker2.Text;
                    entMdl.LINKER3 = te_linker3.Text;
                    entMdl.PHONE1 = te_phone1.Text;
                    entMdl.PHONE2 = te_phone2.Text;
                    entMdl.PHONE3 = te_phone2.Text;
                    entMdl.MEMO = te_memo.Text;
                    entMdl.DEMAND = te_demand.Text;
                    entBll.Update(entMdl);
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

        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbt_Save_Click(object sender, EventArgs e)
        {
            if (saveData())
            {
                this.Close();
                return;
            }
        }

        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}