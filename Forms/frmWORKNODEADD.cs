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
using Student.DBUtility;

namespace Student.Forms
{
    public partial class frmWORKNODEADD : DevExpress.XtraEditors.XtraForm
    {
        private StatusClass _enumStatus;
        private int _nodeno;

        public frmWORKNODEADD()
        {
            InitializeComponent();
            this._enumStatus = StatusClass.AddNew;
        }

        /// <summary>
        /// 构造方法，修改专业功能可用，iID为传过来的专业编号，enumStatus标识当前功能
        /// </summary>
        /// <param name="iID"></param>
        /// <param name="enumStatus"></param>
        public frmWORKNODEADD(int iID, StatusClass enumStatus)
        {
            this._enumStatus = StatusClass.Edit;     //修改专业信息
            this._nodeno = iID;
            InitializeComponent();
            this.Text = "修改工作节点信息";              //修改界面title
            readData();                              //查询数据
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        private void readData()
        {
            if (this._nodeno > 0)
            {
                BLL.WORKNODE worknodebll = new BLL.WORKNODE();
                Model.WORKNODE worknodemdl = new Model.WORKNODE();
                worknodemdl = worknodebll.GetModel(_nodeno);
                if (worknodemdl == null)   //新增工作节点功能时
                {
                    blankData();
                }
                else                   //修改工作节点功能时
                {
                    this.te_nodename.Text = worknodemdl.NODENAME;
                    this.te_memo.Text = worknodemdl.MEMO;                   
                }
            }
        }

        /// <summary>
        /// 清空输入框数据
        /// </summary>
        private void blankData()
        {
            this.te_nodename.Text = "";
            this.te_memo.Text = "";
        }

        /// <summary>
        /// 保存数据方法
        /// </summary>
        /// <returns></returns>
        private bool saveData()
        {
            try
            {
                BLL.WORKNODE worknodebll = new BLL.WORKNODE();
                Model.WORKNODE worknodemdl = new Model.WORKNODE();

                if (this.te_nodename.Text == "")
                {
                    MessageBox.Show("工作节点名称不能为空!", "提示信息");
                    return false;
                }

                if (this._enumStatus == StatusClass.AddNew)  //新增工作节点
                {
                    worknodemdl.NODENAME = this.te_nodename.Text;
                    worknodemdl.MEMO = this.te_memo.Text;
                   
                    worknodebll.Add(worknodemdl);
                    return true;
                }
                else if (this._enumStatus == StatusClass.Edit)  //修改工作节点
                {
                    worknodemdl.NODENO = this._nodeno;
                    worknodemdl.NODENAME = this.te_nodename.Text;
                    worknodemdl.MEMO = this.te_memo.Text;
                    
                    worknodebll.Update(worknodemdl);
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

        private void sbt_Save_Click(object sender, EventArgs e)
        {
            if (saveData())
            {
                this.Close();
                return;
            }
        }

        private void sbt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}