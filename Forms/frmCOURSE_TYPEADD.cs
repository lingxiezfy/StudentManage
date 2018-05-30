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
    public partial class frmCOURSE_TYPEADD : DevExpress.XtraEditors.XtraForm
    {
        private StatusClass _enumStatus;
        private int _coursetypeno;

        /// <summary>
        /// 构造方法，用于新增课程类型
        /// </summary>
        public frmCOURSE_TYPEADD()
        {
            InitializeComponent();
            this._enumStatus = StatusClass.AddNew;
            this.Text = "增加课程类型";            
        }
        
        /// <summary>
        /// 构造方法，用于修改课程类型
        /// </summary>
        /// <param name="iID"></param>
        /// <param name="enumStatus"></param>
        public frmCOURSE_TYPEADD(int iID, StatusClass enumStatus)
        {
            this._enumStatus = StatusClass.Edit;     //修改专业信息
            this._coursetypeno = iID;
            InitializeComponent();
            this.Text = "修改课程信息";              //修改界面title
            readData();                              //查询数据
        }

        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ctb_save_Click(object sender, EventArgs e)
        {
            if (saveData())
            {
                this.Close();
                return;
            }
        }   

        /// <summary>
        /// 查询数据
        /// </summary>
        private void readData()
        {
            if (this._coursetypeno > 0)
            {
                BLL.COURSE_TYPE coursetypeBll = new BLL.COURSE_TYPE();
                Model.COURSE_TYPE coursetypeMdl = new Model.COURSE_TYPE();
                coursetypeMdl = coursetypeBll.GetModel(_coursetypeno);
           
                if (coursetypeMdl == null)   //新增专业功能时
                {                   
                    blankData();
                }
                else                 
                {
                    this.te_coursetypename.Text = coursetypeMdl.COURSETYPENAME;
                    this.te_coursetypememo.Text = coursetypeMdl.MEMO;
                }            
            }
        }

        /// <summary>
        /// 清空输入框数据
        /// </summary>
        private void blankData()
        {
            this.te_coursetypename.Text = "";
            this.te_coursetypememo.Text = "";
        }

        /// 保存数据方法
        /// </summary>
        /// <returns></returns>
        private bool saveData()
        {
            try
            {
                BLL.COURSE_TYPE coursetypeBll = new BLL.COURSE_TYPE();           
                Model.COURSE_TYPE coursetypeMdl = new Model.COURSE_TYPE();

                if (this.te_coursetypename.Text == "")
                {
                    MessageBox.Show("专业名称不能为空!", "提示信息");
                    return false;
                }

                coursetypeMdl.COURSETYPENAME = this.te_coursetypename.Text;
                coursetypeMdl.MEMO = this.te_coursetypememo.Text;                
             
                if (this._enumStatus == StatusClass.AddNew)  //新增专业
                {
                    if (coursetypeBll.Exists(this.te_coursetypename.Text))
                    {
                        MessageBox.Show("当前课程类型已经存在，请核查!", "提示信息");
                        return false;
                    }

                    coursetypeBll.Add(coursetypeMdl);
                    return true;
                }
                else if (this._enumStatus == StatusClass.Edit)  //修改课程
                {
                    coursetypeMdl.COURSETYPENO = this._coursetypeno;
                    coursetypeBll.Update(coursetypeMdl);
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
        /// 取消按钮
        /// </summary>
         private void Cbtn_cancel_Click(object sender, EventArgs e)
         {
             this.Close();
         }
    
    }
}