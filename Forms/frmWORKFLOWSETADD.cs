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
    public partial class frmWORKFLOWSETADD : DevExpress.XtraEditors.XtraForm
    {
        private int setno;
        private Model.WORKFLOWSETADD workflowsetaddMdl;
        private StatusClass _enumStatus;

        public frmWORKFLOWSETADD()
        {
            InitializeComponent();
        }

        public frmWORKFLOWSETADD(Model.WORKFLOWSETADD workflowsetaddMdl, StatusClass enumStatus)
        {
            InitializeComponent();
            this.workflowsetaddMdl = workflowsetaddMdl;
            this.te_workflowname.Text = workflowsetaddMdl.WORKFLOWNAME;
            this.setno = workflowsetaddMdl.SETNO;
            this._enumStatus = enumStatus;
            init();
            if (enumStatus == StatusClass.AddNew)
            {                
                this.Text = "新增工作流节点";
            }
            else
            {
                this.Text = "修改工作流节点";
            }

        }

        //新增时初始化节点列表
        public void init()
        {
            BLL.WORKNODE worknodeBll = new BLL.WORKNODE();
            BLL.WORKFLOW workflowBll = new BLL.WORKFLOW();
            Model.WORKFLOW workflowMdl = new Model.WORKFLOW();
            if (_enumStatus == StatusClass.AddNew)
            {
                workflowMdl = workflowBll.GetModel(workflowsetaddMdl.WORKFLOWNAME);
                int workflowno = workflowMdl.WORKFLOWNO;
                DataSet ds = worknodeBll.GetList(" NODENO not in(select NODENO from WORKFLOWSET  where workflowno  = " + workflowno.ToString() + " and NODENO is not null)");
                this.cbb_nodename.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                cbb_nodename.Properties.Items.Clear();
                cbb_nodename.EditValue = null;
                cbb_nodename.Properties.NullText = "--请选择--";
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string nodename = ds.Tables[0].Rows[i]["nodename"].ToString();
                    this.cbb_nodename.Properties.Items.Add(nodename);
                }
            }
            else if(_enumStatus == StatusClass.Edit)
            {
                workflowMdl = workflowBll.GetModel(workflowsetaddMdl.WORKFLOWNAME);
                int workflowno = workflowMdl.WORKFLOWNO;
                DataSet ds = worknodeBll.GetList(" NODENO not in(select NODENO from WORKFLOWSET  where workflowno  = " + workflowno.ToString() + " and NODENO is not null)");
                this.cbb_nodename.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                cbb_nodename.Properties.Items.Clear();
                cbb_nodename.EditValue = workflowsetaddMdl.NODENAME;
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    this.cbb_nodename.Properties.Items.Add(ds.Tables[0].Rows[i]["nodename"].ToString());
                }
                this.cbb_nodename.Properties.Items.Add(workflowsetaddMdl.NODENAME);
                this.te_workflowname.Text = workflowsetaddMdl.WORKFLOWNAME;
                this.cbb_nodeorder.Text = workflowsetaddMdl.NODEORDER.ToString();
                this.de_begintime.Text = workflowsetaddMdl.BEGINTIME.ToString();
                this.de_endtime.Text = workflowsetaddMdl.ENDTIME.ToString();
            }
        }        

        /// <summary>
        /// 保存数据方法
        /// </summary>
        /// <returns></returns>
        private bool saveData()
        {
            try
            {
                BLL.WORKFLOWSET workflowsetbll = new BLL.WORKFLOWSET();
                Model.WORKFLOWSET workflowsetmdl = new Model.WORKFLOWSET();

                BLL.WORKNODE worknodeBll = new BLL.WORKNODE();
                Model.WORKNODE worknodeMdl = new Model.WORKNODE();

                BLL.WORKFLOW workflowBll = new BLL.WORKFLOW();
                Model.WORKFLOW workflowMdl = new Model.WORKFLOW();

                if (this.cbb_nodename.Text == "")
                {
                    MessageBox.Show("工作节点不能为空!", "提示信息");
                    return false;
                }

                if (this.cbb_nodeorder.Text == "")
                {
                    MessageBox.Show("节点顺序不能为空!", "提示信息");
                    return false;
                }

                if (this.de_begintime.Text == "")
                {
                    MessageBox.Show("开始日期不能为空!", "提示信息");
                    return false;
                }

                if (this.de_endtime.Text == "")
                {
                    MessageBox.Show("截止日期不能为空!", "提示信息");
                    return false;
                }
                if (this._enumStatus == StatusClass.AddNew)  //新增工作流节点
                {
                    //获取工作流编号                    
                    workflowMdl = workflowBll.GetModel(workflowsetaddMdl.WORKFLOWNAME);
                    int workflowno = workflowMdl.WORKFLOWNO;
                    workflowsetmdl.WORKFLOWNO = workflowno;

                    //获取工作节点编号
                    worknodeMdl = worknodeBll.GetModel(this.cbb_nodename.Text);
                    workflowsetmdl.NODENO = worknodeMdl.NODENO;

                    workflowsetmdl.NODEORDER = ToolHelper.ConvertToInt(this.cbb_nodeorder.Text);
                    workflowsetmdl.BEGINTIME = ToolHelper.ConvertToDateTime(this.de_begintime.Text);
                    workflowsetmdl.ENDTIME = ToolHelper.ConvertToDateTime(this.de_endtime.Text);

                    workflowsetbll.Add(workflowsetmdl);
                    return true;
                }
                else if (this._enumStatus == StatusClass.Edit)  //修改工作节点
                {
                    //获取工作流编号                    
                    workflowMdl = workflowBll.GetModel(workflowsetaddMdl.WORKFLOWNAME);
                    int workflowno = workflowMdl.WORKFLOWNO;
                    workflowsetmdl.WORKFLOWNO = workflowno;
                    worknodeMdl = worknodeBll.GetModel(this.cbb_nodename.Text);
                    workflowsetmdl.NODENO = worknodeMdl.NODENO;
                    workflowsetmdl.NODEORDER = ToolHelper.ConvertToInt(this.cbb_nodeorder.Text);
                    workflowsetmdl.BEGINTIME = ToolHelper.ConvertToDateTime(this.de_begintime.Text);
                    workflowsetmdl.ENDTIME = ToolHelper.ConvertToDateTime(this.de_endtime.Text);
                    workflowsetmdl.SETNO = setno;

                    workflowsetbll.Update(workflowsetmdl);
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