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
    public partial class frmTEACHERADD : DevExpress.XtraEditors.XtraForm
    {
        private StatusClass _enumStatus;
        private int _teacherno;

        /// <summary>
        /// 构造方法，新增教师信息功能可用
        /// </summary>
        public frmTEACHERADD()
        {
            InitializeComponent();
            init_major();
            this._enumStatus = StatusClass.AddNew;
        }

        /// <summary>
        /// 构造方法，修改教师信息功能可用，iID为传过来的教师工号，enumStatus标识当前功能
        /// </summary>
        /// <param name="iID"></param>
        /// <param name="enumStatus"></param>
        public frmTEACHERADD(int iID, StatusClass enumStatus)
       {
            this._enumStatus = StatusClass.Edit;     //修改教师信息
            this._teacherno = iID;
            InitializeComponent();
            this.Text = "修改教师信息";              //修改界面title
            readData();                              //查询数据
            this.te_workid.ReadOnly = true;         //教师工号输入框只读，不可修改
        }

        /// <summary>
        /// 初始化窗体，取得专业名称到列表
        /// </summary>
        private void init_major()
        {
            Student.BLL.MAJOR_INFO majorBll = new BLL.MAJOR_INFO();
            DataSet ds = majorBll.GetAllList();
            cbb_majorname.Properties.Items.Clear();
            cbb_majorname.EditValue = null;
            cbb_majorname.Properties.NullText = "--请选择--";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string majorName = ds.Tables[0].Rows[i]["MAJORNAME"].ToString();
                this.cbb_majorname.Properties.Items.Add(majorName);
            }
            this.cbb_majorname.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        private void readData()
        {
            if (this._teacherno > 0)
            {
                BLL.TEACHER_INFO teacherBll = new BLL.TEACHER_INFO();
                Model.TEACHER_INFO teacherMdl = new Model.TEACHER_INFO();

                teacherMdl = teacherBll.GetModel(_teacherno);
                init_major();
                if (teacherMdl == null)   //新增教师信息功能时
                {                    
                    blankData();
                }
                else                   //修改教师信息功能时
                {
                    BLL.MAJOR_INFO majorBll = new BLL.MAJOR_INFO();
                    Model.MAJOR_INFO majorMdl = new Model.MAJOR_INFO();

                    majorMdl = majorBll.GetModel((int)teacherMdl.MAJORNO);
                    this.cbb_majorname.Text = majorMdl.MAJORNAME;
                    this.te_name.Text = teacherMdl.NAME;
                    this.te_workid.Text = teacherMdl.WORKID;
                    this.cbb_sex.Text = teacherMdl.SEX;
                    this.cbb_political.Text = teacherMdl.POLITICAL;
                    this.cbb_nation.Text = teacherMdl.NATION;
                    this.te_phone.Text = teacherMdl.PHONE;
                    this.te_familyphone.Text = teacherMdl.FAMILYPHONE;
                    this.te_email.Text = teacherMdl.EMAIL;
                    this.te_idcard.Text = teacherMdl.IDCARD;
                    this.te_qqno.Text = teacherMdl.QQNO;
                    this.te_micromesageno.Text = teacherMdl.MICROMESSAGENO;
                    this.te_familyaddress.Text = teacherMdl.FAMILYADDRESS;
                }
            }
        }

        /// <summary>
        /// 清空输入框数据
        /// </summary>
        private void blankData()
        {
            init_major(); ;
            this.te_workid.Text = "";
            this.te_name.Text = "";
            this.cbb_sex.Text = "";
            this.cbb_political.Text = "";
            this.cbb_nation.Text = "";
            this.te_phone.Text = "";
            this.te_familyphone.Text = "";
            this.te_email.Text = "";
            this.te_idcard.Text = "";
            this.te_qqno.Text = "";
            this.te_micromesageno.Text = "";
            this.te_familyaddress.Text = "";
        }

        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbt_save_Click_1(object sender, EventArgs e)
        {
            if (saveData())
            {
                this.Close();
                return;
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
                BLL.TEACHER_INFO teacherBll = new BLL.TEACHER_INFO();
                Model.TEACHER_INFO teacherMdl = new Model.TEACHER_INFO();
               
                Student.BLL.MAJOR_INFO majorBll = new BLL.MAJOR_INFO();
                Student.Model.MAJOR_INFO majorMdl = new Model.MAJOR_INFO();

                if (this.cbb_majorname.SelectedIndex != -1)
                {
                    majorMdl = majorBll.GetModel(this.cbb_majorname.Properties.Items[this.cbb_majorname.SelectedIndex].ToString());
                    teacherMdl.MAJORNO = majorMdl.MAJORNO;
                }
                else
                {
                    MessageBox.Show("教师所属专业不能为空!", "提示信息");
                    return false;
                }

                if (this.te_name.Text == "")
                {
                    MessageBox.Show("教师姓名不能为空!", "提示信息");
                    return false;
                }
                
                teacherMdl.NATION = cbb_nation.Text;
                teacherMdl.NAME = this.te_name.Text;
                teacherMdl.WORKID = this.te_workid.Text;
                teacherMdl.SEX = this.cbb_sex.Text;
                teacherMdl.POLITICAL = this.cbb_political.Text;
                teacherMdl.PHONE = this.te_phone.Text;
                teacherMdl.FAMILYPHONE = this.te_familyphone.Text;
                teacherMdl.EMAIL = this.te_email.Text;
                teacherMdl.IDCARD = this.te_idcard.Text;
                teacherMdl.QQNO = this.te_qqno.Text;
                teacherMdl.MICROMESSAGENO = this.te_micromesageno.Text;
                teacherMdl.FAMILYADDRESS = this.te_familyaddress.Text;
 
                
                if (this._enumStatus == StatusClass.AddNew)  //新增教师信息
                {
                    if (teacherBll.Exists(this.te_name.Text))
                    {
                        MessageBox.Show("当前教师姓名已经存在，请核查!", "提示信息");
                        return false;
                    }

                    teacherBll.Add(teacherMdl);
                    return true;
                }
                else if (this._enumStatus == StatusClass.Edit)  //修改教师信息
                {
                    teacherMdl.TEACHERNO = this._teacherno;
                    teacherBll.Update(teacherMdl);
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
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
              
    }
}