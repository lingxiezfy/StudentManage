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

namespace Student.Forms
{
    public partial class frmTERMADD : DevExpress.XtraEditors.XtraForm
    {
        private StatusClass _enumStatus;
        private int _termno;

        public frmTERMADD()
        {
            InitializeComponent();
            this._enumStatus = StatusClass.AddNew;
            this.cbb_flag.Text = "当前学期";
        }
        
        public frmTERMADD(int iID, StatusClass enumStatus)
        {
            
            this._enumStatus = StatusClass.Edit;     //修改学期信息
            this._termno = iID;
            InitializeComponent();
            this.Text = "修改学期信息";              //修改界面title
            readData();                              //查询数据
        }

        
        /// <summary>
        /// 读取数据
        /// </summary>
        private void readData()
        {
            if (this._termno > 0)
            {
                BLL.TERM_INFO termBll = new BLL.TERM_INFO();
                Model.TERM_INFO termMdl = new Model.TERM_INFO();

                termMdl = termBll.GetModel(_termno);
                if (termMdl == null)   //新增学期功能时
                {
                     blankData();
                }
                else                   //修改学期功能时
                {
                    this.te_termname.Text = termMdl.TERMNAME;
                    this.dt_begintime.Text = termMdl.BEGINTIME.ToString();
                    this.dt_endtime.Text = termMdl.ENDTIME.ToString();
                    if (termMdl.FLAG == 0)
                    {
                        this.cbb_flag.Text = "非当前学期";
                    }
                    else
                    {
                        this.cbb_flag.Text = "当前学期";
                    }
                }
            }
        }
        private void blankData()
        {
            this.te_termname.Text = "";
            this.cbb_flag.Text = "当前学期";
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
        /// 保存方法
        /// </summary>
        /// <returns></returns>
        private bool saveData()
        {
            try
            {
                BLL.TERM_INFO termBll = new BLL.TERM_INFO();
                Model.TERM_INFO termMdl = new Model.TERM_INFO();
                
                if (this.te_termname.Text == "")
                {
                    MessageBox.Show("学期名称不能为空!", "提示信息");
                    return false;
                }

                if (dt_begintime.Value >= dt_endtime.Value)
                {
                    MessageBox.Show("起始时间不能大于截止日期!", "提示信息");
                    return false;
                }
              
                if (cbb_flag.Text == "")
                {
                    MessageBox.Show("学期标志不能为空！", "提示信息");
                    return false;
                }

                if (this._enumStatus == StatusClass.AddNew)  //新增学期
                {
                    termMdl.TERMNAME = te_termname.Text;
                    termMdl.BEGINTIME = Student.DBUtility.ToolHelper.ConvertToDateTime(dt_begintime.Value);
                    termMdl.ENDTIME = Student.DBUtility.ToolHelper.ConvertToDateTime(dt_endtime.Value);
                    if (cbb_flag.Text == "当前学期")
                    {
                        termMdl.FLAG = 1;
                    }
                    else
                    {
                        termMdl.FLAG = 0;
                    }

                    termBll.Add(termMdl);
                    return true;
                }
                else if (this._enumStatus == StatusClass.Edit)  //修改信息
                {
                    termMdl.TERMNO = this._termno;
                    termMdl.TERMNAME = te_termname.Text;
                    termMdl.BEGINTIME = Student.DBUtility.ToolHelper.ConvertToDateTime(dt_begintime.Value);
                    termMdl.ENDTIME = Student.DBUtility.ToolHelper.ConvertToDateTime(dt_endtime.Value);
                    termBll.Update(termMdl);
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

       
    }
}