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
    public partial class frmSTU_MATERIALSEDIT : DevExpress.XtraEditors.XtraForm
    {
        private decimal _execno;
        public frmSTU_MATERIALSEDIT()
        {
            InitializeComponent();
            this.te_grade.Text = "0";
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="id"></param>
        /// <param name="termname"></param>
        /// <param name="workflowname"></param>
        /// <param name="nodename"></param>
        /// <param name="stuno"></param>
        /// <param name="stuname"></param>
        /// <param name="teachername"></param>
        public frmSTU_MATERIALSEDIT(int id,string termname,string workflowname,string nodename,string stuno,string stuname,string teachername,string entname)
        {
            InitializeComponent();
            this._execno = id;
            this.te_term.Text = termname;
            this.te_workflow.Text = workflowname;
            this.te_node.Text = nodename;
            this.te_stuno.Text = stuno;
            this.te_stuname.Text = stuname;
            this.te_teacher.Text = teachername;
            init_ent();
            if (entname.Length > 0)
            {
                this.cbb_ent.EditValue = entname;
            }
            this.te_grade.Text = "0";
        }

        /// <summary>
        /// 初始化所有用人单位列表
        /// </summary>
        private void init_ent()
        {
            Student.BLL.ENTERPRISE_INFO entBll = new BLL.ENTERPRISE_INFO();
            DataSet ds = entBll.GetAllList();
            this.cbb_ent.Properties.Items.Clear();
            cbb_ent.EditValue = null;
            cbb_ent.Properties.NullText = "--请选择--";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string entName = ds.Tables[0].Rows[i]["ENTNAME"].ToString();
                this.cbb_ent.Properties.Items.Add(entName);
            }
            //this.cbb_ent.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        /// <summary>
        /// 保存方法
        /// </summary>
        private bool saveData()
        {
            BLL.STU_WORKFLOW stuworkflowBll = new BLL.STU_WORKFLOW();

            if (!ToolHelper.IsNumeric(this.te_grade.Text))
            {
                MessageBox.Show("成绩必须为数值!", "提示信息");
                return  false;
            }

            if(this.te_grade.Text.Length <= 0)
            {
                MessageBox.Show("成绩不能为空!", "提示信息");
                return false;
            }

            float grade = ToolHelper.ConvertToFloat(this.te_grade.Text);
            if (grade < 0 || grade > 100)
            {
                MessageBox.Show("成绩不合法，请核查!", "提示信息");
                return false;
            }

            BLL.ENTERPRISE_INFO enterpriseBll = new BLL.ENTERPRISE_INFO();
            Model.ENTERPRISE_INFO enterpriseMdl = new Model.ENTERPRISE_INFO();

            if (this.cbb_ent.SelectedIndex != -1)
            {
                string entname = this.cbb_ent.Properties.Items[this.cbb_ent.SelectedIndex].ToString();
                
                enterpriseMdl = enterpriseBll.GetModel(entname);               
                int entno = (int)enterpriseMdl.ENTNO;
                stuworkflowBll.Update(grade, _execno, entno);
            }
            else
            {
                string entname = this.cbb_ent.EditValue.ToString();
                if (entname.Length > 0)
                {
                    enterpriseMdl = enterpriseBll.GetModel(entname);
                    if (enterpriseMdl == null)
                    {
                        MessageBox.Show("该企业不存在，请添加该企业信息!", "提示信息");
                        return false;
                    }
                    else
                    {
                        int entno = (int)enterpriseMdl.ENTNO;
                        stuworkflowBll.Update(grade, _execno, entno);
                    }
                }
                else
                {
                    stuworkflowBll.Update(grade, _execno);
                }
            }            
            return true;
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