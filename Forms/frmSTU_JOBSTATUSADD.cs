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
    public partial class frmSTU_JOBSTATUSADD : DevExpress.XtraEditors.XtraForm
    {
        private StatusClass _enumStatus;
        private int _statusno;
        private string _stuno;

        public frmSTU_JOBSTATUSADD(string stuno)
        {
            InitializeComponent();
            this._enumStatus = StatusClass.AddNew;
            this._stuno = stuno;
            init_ent();
            readData();
            this.Text = "添加学生就业信息";
        }

        /// <summary>
        /// 构造方法，用于修改班级
        /// </summary>
        /// <param name="iID"></param>
        /// <param name="enumStatus"></param>
        public frmSTU_JOBSTATUSADD(int iID, StatusClass enumStatus)
        {
            this._enumStatus = StatusClass.Edit;     //修改专业信息
            this._statusno = iID;
            InitializeComponent();
            init_ent();
            this.Text = "修改学生就业信息";              //修改界面title
            readData();                              //查询数据
        }

        /// <summary>
        /// 初始化所有用人单位列表
        /// </summary>
        private void init_ent()
        {
            Student.BLL.ENTERPRISE_INFO entBll = new BLL.ENTERPRISE_INFO();
            DataSet ds = entBll.GetAllList();
            this.cbb_entname.Properties.Items.Clear();
            cbb_entname.EditValue = null;
            cbb_entname.Properties.NullText = "--请选择--";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string entName = ds.Tables[0].Rows[i]["ENTNAME"].ToString();
                this.cbb_entname.Properties.Items.Add(entName);
            }
            //this.cbb_ent.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        private void readData()
        {
            BLL.STUDENT_JOBSTATUS stujobstatusBll = new BLL.STUDENT_JOBSTATUS();
            Model.STUDENT_JOBSTATUS stujobstatusMdl = new Model.STUDENT_JOBSTATUS();

            BLL.STUDENT_INFO studentBll = new BLL.STUDENT_INFO();
            Model.STUDENT_INFO studentMdl = new Model.STUDENT_INFO();

            if (this._statusno > 0 || this._stuno.Length > 0)
            {
                stujobstatusMdl = stujobstatusBll.GetModel(_statusno);
                if (stujobstatusMdl == null)   //新增就业记录功能时
                {
                    blankData();
                    studentMdl = studentBll.GetModel(_stuno,"1");
                    this.te_stuno.Text = studentMdl.STUNO;
                    this.te_stuname.Text = studentMdl.NAME;
                }
                else                   //修改就业记录功能时
                {
                    stujobstatusMdl = stujobstatusBll.GetModel(this._statusno);
                    this.te_stuno.Text = stujobstatusMdl.STUNO;
                    studentMdl = studentBll.GetModel(stujobstatusMdl.STUNO, "1");
                    this.te_stuname.Text = studentMdl.NAME;

                    BLL.ENTERPRISE_INFO entBll = new BLL.ENTERPRISE_INFO();
                    Model.ENTERPRISE_INFO entMdl = new Model.ENTERPRISE_INFO();
                    entMdl = entBll.GetModel((int)stujobstatusMdl.ENTNO);
                    this.cbb_entname.Text = entMdl.ENTNAME;
                    this.te_jobtitle.Text = stujobstatusMdl.JOBTITLE;
                    this.te_salary.Text = stujobstatusMdl.SALARY.ToString();
                    this.cbb_status.Text = stujobstatusMdl.STATUS;
                    if(stujobstatusMdl.IF_CURRENT == 0)
                    {
                        this.cbb_ifcurrent.Text = "未就业";
                    }
                    else
                    {
                        this.cbb_ifcurrent.Text = "已就业";
                    }
                    this.dt_statustime.Text = stujobstatusMdl.STATUSTIME.ToString();
                    this.te_memo.Text = stujobstatusMdl.MEMO;
                }
            }
        }

        private void blankData()
        {
            init_ent();
            this.te_jobtitle.Text = "";
            this.te_salary.Text = "";
            this.cbb_status.Text = "找工作";
            this.cbb_ifcurrent.Text = "未就业";
            this.te_memo.Text = "";
        }

        /// <summary>
        /// 保存方法
        /// </summary>
        /// <returns></returns>
        private bool saveData()
        {
            try
            {
                BLL.STUDENT_JOBSTATUS stujobstatusBll = new BLL.STUDENT_JOBSTATUS();
                Model.STUDENT_JOBSTATUS stujobstatusMdl = new Model.STUDENT_JOBSTATUS();

                if (this.cbb_entname.SelectedIndex != -1)
                {
                    BLL.ENTERPRISE_INFO entBll = new BLL.ENTERPRISE_INFO();
                    Model.ENTERPRISE_INFO entMdl = new Model.ENTERPRISE_INFO();
                    entMdl = entBll.GetModel(this.cbb_entname.Properties.Items[this.cbb_entname.SelectedIndex].ToString());
                    stujobstatusMdl.ENTNO = entMdl.ENTNO;
                }
                else
                {
                    stujobstatusMdl.ENTNO = 1;
                }
                stujobstatusMdl.STUNO = this.te_stuno.Text;
                stujobstatusMdl.JOBTITLE = this.te_jobtitle.Text;
                stujobstatusMdl.SALARY = ToolHelper.ConvertToInt(this.te_salary.Text);
                stujobstatusMdl.STATUS = this.cbb_status.Text;
                if (this.cbb_ifcurrent.Text == "未就业")
                {
                    stujobstatusMdl.IF_CURRENT = 0;
                }
                else
                {
                    stujobstatusMdl.IF_CURRENT = 1;
                }
                stujobstatusMdl.STATUSTIME = ToolHelper.ConvertToDateTime(this.dt_statustime.Value);
                stujobstatusMdl.MEMO = this.te_memo.Text;


                if (this.cbb_status.Text == "")
                {
                    MessageBox.Show("就业状态不能为空!", "提示信息");
                    return false;
                }

                if (this.cbb_ifcurrent.Text == "")
                {
                    MessageBox.Show("是否就业不能为空!", "提示信息");
                    return false;
                }

                if (this._enumStatus == StatusClass.AddNew)  //新增班级
                {
                    stujobstatusBll.Add(stujobstatusMdl);
                    return true;
                }
                else if (this._enumStatus == StatusClass.Edit)  //修改班级
                {
                    stujobstatusMdl.STATUSNO = this._statusno;
                    stujobstatusBll.Update(stujobstatusMdl);
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