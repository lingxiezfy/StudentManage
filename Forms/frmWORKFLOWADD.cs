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
    public partial class frmWORKFLOWADD : DevExpress.XtraEditors.XtraForm
    {
        private StatusClass _enumStatus;
        private int _workflowno;

        public frmWORKFLOWADD()
        {
            InitializeComponent();
            this._enumStatus = StatusClass.AddNew;
            this.cbb_status.Properties.Items.Add("未用");
            this.cbb_status.Properties.Items.Add("在用");
            this.cbb_status.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        /// <summary>
        /// 构造方法，修改专业功能可用，iID为传过来的专业编号，enumStatus标识当前功能
        /// </summary>
        /// <param name="iID"></param>
        /// <param name="enumStatus"></param>
        public frmWORKFLOWADD(int iID, StatusClass enumStatus)
        {
            this._enumStatus = StatusClass.Edit;     //修改专业信息
            this._workflowno = iID;
            InitializeComponent();
            this.Text = "修改工作流信息";              //修改界面title
            readData();                              //查询数据
            this.cbb_status.Properties.Items.Add("未用");
            this.cbb_status.Properties.Items.Add("在用");
            this.cbb_status.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        private void readData()
        {
            if (this._workflowno > 0)
            {
                BLL.WORKFLOW workflowbll = new BLL.WORKFLOW();
                Model.WORKFLOW workflowmdl = new Model.WORKFLOW();
                workflowmdl = workflowbll.GetModel(_workflowno);
                if (workflowmdl == null)   //新增工作流功能时
                {
                    blankData();
                }
                else                   //修改工作流功能时
                {
                    this.te_workflowname.Text = workflowmdl.WORKFLOWNAME;
                    this.de_createdate.Text = ToolHelper.ConvertToString(workflowmdl.CREATEDATE);
                    
                    if (workflowmdl.STATUS == 0)
                    {
                        this.cbb_status.Text = "未用";
                    }
                    else
                    {
                        this.cbb_status.Text = "在用";
                    }
                }
            }
        }

        /// <summary>
        /// 清空输入框数据
        /// </summary>
        private void blankData()
        {
            this.te_workflowname.Text = "";
        }

        /// <summary>
        /// 保存数据方法
        /// </summary>
        /// <returns></returns>
        private bool saveData()
        {
            try
            {
                BLL.WORKFLOW workflowbll = new BLL.WORKFLOW();
                Model.WORKFLOW workflowmdl = new Model.WORKFLOW();   
                
                if (this.te_workflowname.Text == "")
                {
                    MessageBox.Show("工作流名称不能为空!", "提示信息");
                    return false;
                }
                if (this.cbb_status.Text == "")
                {
                    MessageBox.Show("状态不能为空!", "提示信息");
                    return false;
                }

                if (this.de_createdate.Text == "")
                {
                    MessageBox.Show("创建时间不能为空!", "提示信息");
                    return false;
                }
                if (this._enumStatus == StatusClass.AddNew)  //新增工作流
                {
                    workflowmdl.WORKFLOWNAME = this.te_workflowname.Text;
                    workflowmdl.CREATEDATE = ToolHelper.ConvertToDateTime(this.de_createdate.Text);
                    string status = this.cbb_status.Text;
                    if (status == "未用")
                    {
                        workflowmdl.STATUS = 0;
                    }
                    else
                    {
                        workflowmdl.STATUS = 1;
                    }
                    workflowbll.Add(workflowmdl);
                    return true;
                }
                else if (this._enumStatus == StatusClass.Edit)  //修改工作流
                {
                    workflowmdl.WORKFLOWNO = this._workflowno;
                    workflowmdl.WORKFLOWNAME = this.te_workflowname.Text;
                    workflowmdl.CREATEDATE = ToolHelper.ConvertToDateTime(this.de_createdate.Text);
                    string status = this.cbb_status.Text;
                    if (status == "未用")
                    {
                        workflowmdl.STATUS = 0;
                    }
                    else
                    {
                        workflowmdl.STATUS = 1;
                    }
                    workflowbll.Update(workflowmdl);
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

        private void sbt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbt_Save_Click(object sender, EventArgs e)
        {
            if (saveData())
            {
                this.Close();
                return;
            }
        }
    }
}