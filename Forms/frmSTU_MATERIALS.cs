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
    public partial class frmSTU_MATERIALS : DevExpress.XtraEditors.XtraForm
    {
        public frmSTU_MATERIALS()
        {
            InitializeComponent();
            init_class();
            init_node();
            init_student();
            init_teacher();
            init_term();
            init_workflow();
            this.ce_In.Checked = true;
            this.ce_Out.Checked = true;
        }

        /// <summary>
        /// 初始化学期列表
        /// </summary>
        private void init_term()
        {
            Student.BLL.TERM_INFO termBll = new BLL.TERM_INFO();
            DataSet ds = termBll.GetAllList();
            this.cbb_Term.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbb_Term.Properties.Items.Clear();
            cbb_Term.EditValue = null;
            cbb_Term.Properties.NullText = "--请选择--";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string termName = ds.Tables[0].Rows[i]["TERMNAME"].ToString();
                this.cbb_Term.Properties.Items.Add(termName);
            }
        }

        /// <summary>
        /// 初始化工作流列表
        /// </summary>
        private void init_workflow()
        {
            Student.BLL.WORKFLOW workflowBll = new BLL.WORKFLOW();
            DataSet ds = workflowBll.GetList(" status = 1");
            this.cbb_Workflow.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbb_Workflow.Properties.Items.Clear();
            cbb_Workflow.EditValue = null;
            cbb_Workflow.Properties.NullText = "--请选择--";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string workflowName = ds.Tables[0].Rows[i]["WORKFLOWNAME"].ToString();
                this.cbb_Workflow.Properties.Items.Add(workflowName);
            }
        }

        /// <summary>
        /// 初始化工作流列表
        /// 根据学期检索工作流
        /// </summary>
        private void init_workflow(int termno)
        {
            Student.BLL.WORKFLOW workflowBll = new BLL.WORKFLOW();
            DataSet ds = workflowBll.GetList(" status = 1 and workflowno in (select distinct workflowno from TEA_STU where termno = " + termno.ToString() + ")");
            this.cbb_Workflow.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbb_Workflow.Properties.Items.Clear();
            cbb_Workflow.EditValue = null;
            cbb_Workflow.Properties.NullText = "--请选择--";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string workflowName = ds.Tables[0].Rows[i]["WORKFLOWNAME"].ToString();
                this.cbb_Workflow.Properties.Items.Add(workflowName);
            }
        }

        /// <summary>
        /// 初始化节点列表
        /// </summary>
        private void init_node()
        {
            Student.BLL.WORKNODE worknodeBll = new BLL.WORKNODE();
            DataSet ds = worknodeBll.GetList("");
            this.cbb_Node.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbb_Node.Properties.Items.Clear();
            cbb_Node.EditValue = null;
            cbb_Node.Properties.NullText = "--请选择--";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string nodeName = ds.Tables[0].Rows[i]["NODENAME"].ToString();
                this.cbb_Node.Properties.Items.Add(nodeName);
            }
        }

        /// <summary>
        /// 初始化节点列表
        /// 根据工作流检索节点
        /// </summary>
        private void init_node(int workflowno)
        {
            Student.BLL.WORKNODE worknodeBll = new BLL.WORKNODE();
            DataSet ds = worknodeBll.GetList(" nodeno in (select nodeno from WORKFLOWSET where workflowno = " + workflowno.ToString() + ")");
            this.cbb_Node.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbb_Node.Properties.Items.Clear();
            cbb_Node.EditValue = null;
            cbb_Node.Properties.NullText = "--请选择--";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string nodeName = ds.Tables[0].Rows[i]["NODENAME"].ToString();
                this.cbb_Node.Properties.Items.Add(nodeName);
            }
        }
       
        /// <summary>
        /// 初始化所有教师列表
        /// </summary>
        private void init_teacher()
        {
            Student.BLL.TEACHER_INFO teacherBll = new BLL.TEACHER_INFO();
            DataSet ds = teacherBll.GetAllList();
            this.cbb_Teacher.Properties.Items.Clear();
            cbb_Teacher.EditValue = null;
            cbb_Teacher.Properties.NullText = "--请选择--";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string teacherName = ds.Tables[0].Rows[i]["NAME"].ToString();
                this.cbb_Teacher.Properties.Items.Add(teacherName);
            }
            this.cbb_Teacher.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        /// <summary>
        /// 初始化所有班级列表
        /// </summary>
        private void init_class()
        {
            Student.BLL.CLASS_INFO classBll = new BLL.CLASS_INFO();
            DataSet ds = classBll.GetAllList();
            this.cbb_Class.Properties.Items.Clear();
            cbb_Class.EditValue = null;
            cbb_Class.Properties.NullText = "--请选择--";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string className = ds.Tables[0].Rows[i]["CLASSNAME"].ToString();
                this.cbb_Class.Properties.Items.Add(className);
            }
            this.cbb_Class.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        /// <summary>
        /// 初始化所有学生列表
        /// </summary>
        private void init_student()
        {
            Student.BLL.STUDENT_INFO studentBll = new BLL.STUDENT_INFO();
            DataSet ds = studentBll.GetList(" order by stuno asc");
            this.cbb_Stuno.Properties.Items.Clear();
            cbb_Stuno.EditValue = null;
            cbb_Stuno.Properties.NullText = "--请选择--";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string stuNo = ds.Tables[0].Rows[i]["stuno"].ToString();
                this.cbb_Stuno.Properties.Items.Add(stuNo);
            }
            this.cbb_Stuno.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        /// <summary>
        /// 初始化所有学生列表
        /// 根据班级检索学生信息
        /// </summary>
        private void init_student(int classno)
        {
            Student.BLL.STUDENT_INFO studentBll = new BLL.STUDENT_INFO();
            DataSet ds = studentBll.GetList(" and C.classno = " + classno.ToString());
            this.cbb_Stuno.Properties.Items.Clear();
            cbb_Stuno.EditValue = null;
            cbb_Stuno.Properties.NullText = "--请选择--";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string stuNo = ds.Tables[0].Rows[i]["stuno"].ToString();
                this.cbb_Stuno.Properties.Items.Add(stuNo);
            }
            this.cbb_Stuno.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        private void cbb_Term_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLL.TERM_INFO termBll = new BLL.TERM_INFO();
            Model.TERM_INFO termMdl = new Model.TERM_INFO();
            termMdl = termBll.GetModel(this.cbb_Term.Properties.Items[this.cbb_Term.SelectedIndex].ToString());
            init_workflow(termMdl.TERMNO);
        }

        private void cbb_Workflow_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLL.WORKFLOW workflowBll = new BLL.WORKFLOW();
            Model.WORKFLOW workflowMdl = new Model.WORKFLOW();
            workflowMdl = workflowBll.GetModel(this.cbb_Workflow.Properties.Items[this.cbb_Workflow.SelectedIndex].ToString());
            init_node(workflowMdl.WORKFLOWNO);
        }

        private void cbb_Node_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbb_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLL.CLASS_INFO classBll = new BLL.CLASS_INFO();
            Model.CLASS_INFO classMdl = new Model.CLASS_INFO();
            classMdl = classBll.GetModel(this.cbb_Class.Properties.Items[this.cbb_Class.SelectedIndex].ToString());
            init_student(classMdl.CLASSNO);
        }

        /// <summary>
        /// 查询数据方法
        /// </summary>
        private void readData()
        {
            string condition = "";
            if (this.cbb_Term.SelectedIndex != -1)
            {
                string termname = this.cbb_Term.Properties.Items[this.cbb_Term.SelectedIndex].ToString();
                condition += " and E.TERMNAME like '%" + termname + "%' ";
            }

            if (this.cbb_Workflow.SelectedIndex != -1)
            {
                string workflowname = this.cbb_Workflow.Properties.Items[this.cbb_Workflow.SelectedIndex].ToString();
                condition += " and F.WORKFLOWNAME like '%" + workflowname + "%' ";
            }

            if (this.cbb_Node.SelectedIndex != -1)
            {
                string nodename = this.cbb_Node.Properties.Items[this.cbb_Node.SelectedIndex].ToString();
                condition += " and G.NODENAME like '%" + nodename + "%' ";
            }

            if (this.cbb_Teacher.SelectedIndex != -1)
            {
                string teachername = this.cbb_Teacher.Properties.Items[this.cbb_Teacher.SelectedIndex].ToString();
                condition += " and D.NAME like '%" + teachername + "%' ";
            }

            if (this.cbb_Class.SelectedIndex != -1)
            {
                string classname = this.cbb_Class.Properties.Items[this.cbb_Class.SelectedIndex].ToString();
                condition += " and H.CLASSNAME like '%" + classname + "%' ";
            }

            if (this.cbb_Stuno.SelectedIndex != -1)
            {
                string stuno = this.cbb_Stuno.Properties.Items[this.cbb_Stuno.SelectedIndex].ToString();
                condition += " and C.STUNO like '%" + stuno + "%' ";
            }

            if (this.te_studentname.Text.Length > 0)
            {
                string stuname = this.te_studentname.Text;
                condition += " and C.NAME like '%" + stuname + "%' ";
            }

            if (this.ce_In.Checked == true && this.ce_Out.Checked == false)
            {
                condition += " and left(I.ENTNAME,2) like '%校内%'";
            }
            else if (this.ce_In.Checked == false && this.ce_Out.Checked == true)
            {
                condition += " and left(I.ENTNAME,2) not like '%校内%'";
            }
            
            BLL.STU_WORKFLOW stuworkflowBll = new BLL.STU_WORKFLOW();
            this.gridControl1.DataSource = stuworkflowBll.GetList(condition).Tables[0];
            this.gridView1.BestFitColumns();
            DBUtility.ToolHelper.DrawRowIndicator(gridView1, 50);
            DBUtility.ToolHelper.SetLineColorofGridView(this.gridView1);
        }

        /// <summary>
        /// 查询数据按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbt_Clear_Click(object sender, EventArgs e)
        {
            readData();
        }

        /// <summary>
        /// 刷新材料信息方法
        /// </summary>
        private void refresh_Materials()
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("EXECNO").ToString());
            if (id < 1)
            {
                return;
            }
            else
            {
                BLL.STU_MATERIALS stumaterialsBll = new BLL.STU_MATERIALS();
                this.gridControl2.DataSource = stumaterialsBll.GetList(" and A.EXECNO = " + id.ToString()).Tables[0];
                this.gridView2.BestFitColumns();
                DBUtility.ToolHelper.DrawRowIndicator(gridView2, 50);
                DBUtility.ToolHelper.SetLineColorofGridView(this.gridView2);
            }
        }

        /// <summary>
        /// 单击gridControl1事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridControl1_Click(object sender, EventArgs e)
        {
            if ((e as MouseEventArgs).Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition); //弹出弹出式菜单

            }
            else if ((e as MouseEventArgs).Button == MouseButtons.Left)
            {
                refresh_Materials();
            }
        }

        /// <summary>
        /// 清空查询条件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbt_Find_Click(object sender, EventArgs e)
        {
            init_class();
            init_node();
            init_student();
            init_teacher();
            init_term();
            init_workflow();
            this.te_studentname.Text = "";
        }

        private void bbi_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("EXECNO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要修改成绩的数据！", "提示信息");
                return;
            }
            else
            {
                string termname = this.gridView1.GetFocusedRowCellValue("TERMNAME").ToString();
                string workflowname = this.gridView1.GetFocusedRowCellValue("WORKFLOWNAME").ToString();
                string nodename = this.gridView1.GetFocusedRowCellValue("NODENAME").ToString();
                string stuno = this.gridView1.GetFocusedRowCellValue("STUNO").ToString();
                string stuname = this.gridView1.GetFocusedRowCellValue("STUNAME").ToString();
                string teachername = this.gridView1.GetFocusedRowCellValue("TEANAME").ToString();
                string entname = this.gridView1.GetFocusedRowCellValue("ENTNAME").ToString();
                frmSTU_MATERIALSEDIT frm = new frmSTU_MATERIALSEDIT(id, termname, workflowname, nodename, stuno, stuname, teachername, entname);
                frm.ShowDialog();
                readData();
            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            if ((e as MouseEventArgs).Button == MouseButtons.Right)
            {
                popupMenu2.ShowPopup(Control.MousePosition); //弹出弹出式菜单

            }
        }

        private void bbi_Turnover_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView2.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView2.GetFocusedRowCellValue("TURNOVERNO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要提交的材料记录！", "提示信息");
                return;
            }
            else
            {
                DateTime dt = DateTime.Now;
                BLL.STU_MATERIALS stumaterialsBll = new BLL.STU_MATERIALS();
                stumaterialsBll.Update(id, dt);
                refresh_Materials();
            }
        }

        private void sbt_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}