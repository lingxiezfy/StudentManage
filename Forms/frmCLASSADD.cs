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
    public partial class frmCLASSADD : DevExpress.XtraEditors.XtraForm
    {
        private StatusClass _enumStatus;
        private int _classno;

        /// <summary>
        /// 构造方法，用于新增班级
        /// </summary>
        public frmCLASSADD()
        {
            InitializeComponent();
            this._enumStatus = StatusClass.AddNew;
            init_teacher();
            init_majordirct();
            this.Text = "添加班级信息";
        }

        /// <summary>
        /// 构造方法，用于修改班级
        /// </summary>
        /// <param name="iID"></param>
        /// <param name="enumStatus"></param>
        public frmCLASSADD(int iID, StatusClass enumStatus)
        {
            this._enumStatus = StatusClass.Edit;     //修改专业信息
            this._classno = iID;
            InitializeComponent();
            init_teacher();
            init_majordirct();
            this.Text = "修改班级信息";              //修改界面title
            readData();                              //查询数据
        }

         /// <summary>
         /// 初始化所有教师列表
         /// </summary>
         private void init_teacher()
         {
             Student.BLL.TEACHER_INFO teacherBll = new BLL.TEACHER_INFO();
             DataSet ds = teacherBll.GetAllList();
             this.cbb_master.Properties.Items.Clear();
             this.cbb_organizer.Properties.Items.Clear();
             this.cbb_instructor.Properties.Items.Clear();
             cbb_master.EditValue = null;
             cbb_master.Properties.NullText = "--请选择--";
             cbb_organizer.EditValue = null;
             cbb_organizer.Properties.NullText = "--请选择--";
             cbb_instructor.EditValue = null;
             cbb_instructor.Properties.NullText = "--请选择--";
             this.cbb_master.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
             this.cbb_organizer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
             this.cbb_instructor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

             for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
             {
                 string teacherName = ds.Tables[0].Rows[i]["NAME"].ToString();
                 this.cbb_master.Properties.Items.Add(teacherName);
                 this.cbb_organizer.Properties.Items.Add(teacherName);
                 this.cbb_instructor.Properties.Items.Add(teacherName);
             }
         }

         /// <summary>
         /// 初始化专业方向列表
         /// </summary>
         private void init_majordirct()
         {
             Student.BLL.MAJORDIRCT_INFO majordirctBll = new BLL.MAJORDIRCT_INFO();
             DataSet ds = majordirctBll.GetAllList();
             this.cbb_majordirct.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
             cbb_majordirct.Properties.Items.Clear();
             cbb_majordirct.EditValue = null;
             cbb_majordirct.Properties.NullText = "--请选择--";

             for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
             {
                 string majordirctName = ds.Tables[0].Rows[i]["MAJORDIRCTNAME"].ToString();
                 this.cbb_majordirct.Properties.Items.Add(majordirctName);
             }
         }
        
        private void readData()
        {
            if (this._classno > 0)
            {
                BLL.CLASS_INFO classBll = new BLL.CLASS_INFO();
                Model.CLASS_INFO classMdl = new Model.CLASS_INFO();

                classMdl = classBll.GetModel(_classno);
                if (classMdl == null)   //新增班级功能时
                {
                    blankData();
                }
                else                   //修改班级功能时
                {
                    BLL.MAJORDIRCT_INFO majordirctBll = new BLL.MAJORDIRCT_INFO();
                    Model.MAJORDIRCT_INFO majordirctMdl = new Model.MAJORDIRCT_INFO();

                    majordirctMdl = majordirctBll.GetModel((int)classMdl.MAJORDIRCTNO);
                    this.cbb_majordirct.Text = majordirctMdl.MAJORDIRCTNAME;

                    BLL.TEACHER_INFO teacherBll = new BLL.TEACHER_INFO();
                    Model.TEACHER_INFO teacherMdl = new Model.TEACHER_INFO();
                    teacherMdl = teacherBll.GetModel((int)classMdl.TEACHERNO1);
                    this.cbb_master.Text = teacherMdl.NAME;
                    teacherMdl = teacherBll.GetModel((int)classMdl.TEACHERNO2);
                    this.cbb_instructor.Text = teacherMdl.NAME;
                    teacherMdl = teacherBll.GetModel((int)classMdl.TEACHERNO3);
                    this.cbb_organizer.Text = teacherMdl.NAME;

                    this.te_classname.Text = classMdl.CLASSNAME;    
                }
            }
        }

        /// <summary>
        /// 清空所有输入
        /// </summary>
        private void blankData()
        {
            this.te_classname.Text = "";
            init_teacher();
            init_majordirct();
        }

        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbt_save_Click(object sender, EventArgs e)
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
                BLL.CLASS_INFO classBll = new BLL.CLASS_INFO();
                Model.CLASS_INFO classMdl = new Model.CLASS_INFO();

                BLL.TEACHER_INFO teacherBll = new BLL.TEACHER_INFO();
                Model.TEACHER_INFO teacherMdl = new Model.TEACHER_INFO();

                BLL.MAJORDIRCT_INFO majordirctBll = new BLL.MAJORDIRCT_INFO();
                Model.MAJORDIRCT_INFO majordirctMdl = new Model.MAJORDIRCT_INFO();

                
                if (this.cbb_majordirct.SelectedIndex == -1)
                {
                    MessageBox.Show("专业方向不能为空!", "提示信息");
                    return false;
                }
               
                if (!ToolHelper.IsNumeric(this.te_classname.Text))
                {
                    MessageBox.Show("班级名称必须为数字!", "提示信息");
                    return false;
                }

                if (this.cbb_instructor.SelectedIndex == -1)
                {
                    MessageBox.Show("辅导员姓名不能为空!", "提示信息");
                    return false;
                }

                if (this.cbb_organizer.SelectedIndex == -1)
                {
                    MessageBox.Show("组织员姓名不能为空!", "提示信息");
                    return false;
                }

                if (this.cbb_master.SelectedIndex == -1)
                {
                    MessageBox.Show("班主任姓名不能为空!", "提示信息");
                    return false;
                }

                if (this.te_classname.Text == "")
                {
                    MessageBox.Show("班级名称不能为空!", "提示信息");
                    return false;
                }

                //取得专业编号
                majordirctMdl = majordirctBll.GetModel(this.cbb_majordirct.Text);
                classMdl.MAJORDIRCTNO = majordirctMdl.MAJORDIRCTNO;
                //取得班主任编号
                teacherMdl = teacherBll.GetModel(this.cbb_master.Text);
                classMdl.TEACHERNO1 = teacherMdl.TEACHERNO;
                //取得辅导员编号
                teacherMdl = teacherBll.GetModel(this.cbb_instructor.Text);
                classMdl.TEACHERNO2 = teacherMdl.TEACHERNO;
                //取得组织员编号
                teacherMdl = teacherBll.GetModel(this.cbb_organizer.Text);
                classMdl.TEACHERNO3 = teacherMdl.TEACHERNO;

                classMdl.CLASSNAME = te_classname.Text;              
                
                if (this._enumStatus == StatusClass.AddNew)  //新增班级
                {
                    if (classBll.Exists(te_classname.Text))
                    {
                        MessageBox.Show("当前班级名称已经存在，请核查!", "提示信息");
                        return false;
                    }
                    classBll.Add(classMdl);
                    return true;
                }
                else if (this._enumStatus == StatusClass.Edit)  //修改班级
                {
                    classMdl.CLASSNO = _classno;
                    classBll.Update(classMdl);
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
        
        private void sbt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}