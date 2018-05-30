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
    public partial class frmCOURSEADD : DevExpress.XtraEditors.XtraForm
    {
        private StatusClass _enumStatus;
        private int _courseno;

        /// <summary>
        /// 构造方法，用于新增课程信息
        /// </summary>
        public frmCOURSEADD()
        {
            InitializeComponent();
            init_coursetype();
            this._enumStatus = StatusClass.AddNew;
            this.Text = "新增课程信息";
        }

        /// <summary>
        /// 构造方法，用于修改课程信息
        /// </summary>
        /// <param name="iID"></param>
        /// <param name="enumStatus"></param>
        public frmCOURSEADD(int iID, StatusClass enumStatus)
        {
            this._enumStatus = StatusClass.Edit;
            this._courseno = iID;
            InitializeComponent();
            this.Text = "修改课程信息";
            readData();
        }

        /// <summary>
        /// 初始化课程类型列表
        /// </summary>
        private void init_coursetype()
        {
            Student.BLL.COURSE_TYPE coursetypeBll = new BLL.COURSE_TYPE();
            DataSet ds = coursetypeBll.GetAllList();
            cbb_coursetype.Properties.Items.Clear();
            cbb_coursetype.EditValue = null;
            cbb_coursetype.Properties.NullText = "--请选择--";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string coursetypeName = ds.Tables[0].Rows[i]["COURSETYPENAME"].ToString();
                this.cbb_coursetype.Properties.Items.Add(coursetypeName);
            }
            this.cbb_coursetype.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        /// <summary>
        /// 读取数据
        /// </summary>
        private void readData()
        {
            if (this._courseno > 0)
            {
                BLL.COURSE_INFO coutseBll = new BLL.COURSE_INFO();
                Model.COURSE_INFO courseMdl = new Model.COURSE_INFO();

                courseMdl = coutseBll.GetModel(this._courseno);
                if (courseMdl == null)
                {
                    blankData();
                }
                else
                {
                    this.te_coursename.Text = courseMdl.COURSENAME;
                    init_coursetype();
                    this.te_totalhour.Text = DBUtility.ToolHelper.ConvertToString(courseMdl.TOTALHOUR);
                    this.te_theoryhour.Text = DBUtility.ToolHelper.ConvertToString(courseMdl.THEORYHOUR);
                    this.te_experimenthour.Text = DBUtility.ToolHelper.ConvertToString(courseMdl.EXPERIMENTHOUR);
                    this.te_credit.Text = DBUtility.ToolHelper.ConvertToString(courseMdl.CREDIT);
                    this.te_memo.Text = courseMdl.MEMO;

                    Model.COURSE_TYPE coursetypeMdl = new Model.COURSE_TYPE();
                    BLL.COURSE_TYPE coursetypeBll = new BLL.COURSE_TYPE();

                    coursetypeMdl = coursetypeBll.GetModel((int)courseMdl.COURSETYPENO);
                    this.cbb_coursetype.EditValue = coursetypeMdl.COURSETYPENAME;
                }
            }
        }

        /// <summary>
        /// 清空输入框数据方法
        /// </summary>
        private void blankData()
        {
            init_coursetype();
            this.te_coursename.Text = "";
            this.te_totalhour.Text = "";
            this.te_theoryhour.Text = "";
            this.te_experimenthour.Text = "";
            this.te_credit.Text = "";
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
                BLL.COURSE_INFO courseBll = new BLL.COURSE_INFO();
                Model.COURSE_INFO courseMdl = new Model.COURSE_INFO();
                BLL.COURSE_TYPE coursetypeBll = new BLL.COURSE_TYPE();
                Model.COURSE_TYPE coursetypeMdl = new Model.COURSE_TYPE();

                if (this.cbb_coursetype.SelectedIndex != -1)
                {
                    coursetypeMdl = coursetypeBll.GetModel(this.cbb_coursetype.Properties.Items[this.cbb_coursetype.SelectedIndex].ToString());
                    courseMdl.COURSETYPENO = coursetypeMdl.COURSETYPENO;
                }
                else
                {
                    MessageBox.Show("课程类型不能为空!", "提示信息");
                    return false;
                }               
               
                if (this.te_coursename.Text == "")
                {
                    MessageBox.Show("课程名称不能为空!", "提示信息");
                    return false;
                }

                courseMdl.COURSENAME = te_coursename.Text;
                courseMdl.TOTALHOUR = ToolHelper.ConvertToInt(te_totalhour.Text);
                courseMdl.THEORYHOUR = ToolHelper.ConvertToInt(te_theoryhour.Text);
                courseMdl.EXPERIMENTHOUR = ToolHelper.ConvertToInt(te_experimenthour.Text);
                courseMdl.CREDIT = (decimal)ToolHelper.ConvertToFloat(te_credit.Text);
                courseMdl.MEMO = te_memo.Text;
               
                if (this._enumStatus == StatusClass.AddNew)
                {                    
                    courseBll.Add(courseMdl);
                    return true;
                }
                else if (this._enumStatus == StatusClass.Edit)
                {
                    courseMdl.COURSENO = this._courseno;                    
                    courseBll.Update(courseMdl);
                    return true;
                }
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("保存失败!" + exception.Message, exception.Message);
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