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
using DevExpress.XtraTreeList.Nodes;
using Student.BLL;
using Student.Model;
using Student.DBUtility;

namespace Student.Forms
{
    public partial class frmTEA_STU : DevExpress.XtraEditors.XtraForm
    {
        private List<string> lstCheckedStudentNo = new List<string>();//选择学生学号集合

        public frmTEA_STU()
        {
            InitializeComponent();
            init_term();
            cbb_workflow.EditValue = null;
            cbb_workflow.Properties.NullText = "--请选择学期--";
            this.cbb_workflow.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbb_teacher.EditValue = null;
            cbb_teacher.Properties.NullText = "--请选择工作流--";
            this.cbb_teacher.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;            
        }

        /// <summary>
        /// 初始化学期列表
        /// </summary>
        private void init_term()
        {
            Student.BLL.TERM_INFO termBll = new BLL.TERM_INFO();
            DataSet ds = termBll.GetAllList();
            this.cbb_term.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbb_term.Properties.Items.Clear();
            cbb_term.EditValue = null;
            cbb_term.Properties.NullText = "--请选择--";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string termName = ds.Tables[0].Rows[i]["TERMNAME"].ToString();
                this.cbb_term.Properties.Items.Add(termName);
            }
        }

        /// <summary>
        /// 初始化工作流列表
        /// </summary>
        private void init_workflow()
        {
            Student.BLL.WORKFLOW workflowBll = new BLL.WORKFLOW();
            DataSet ds = workflowBll.GetList(" status = 1");
            this.cbb_workflow.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbb_workflow.Properties.Items.Clear();
            cbb_workflow.EditValue = null;
            cbb_workflow.Properties.NullText = "--请选择--";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string workflowName = ds.Tables[0].Rows[i]["WORKFLOWNAME"].ToString();
                this.cbb_workflow.Properties.Items.Add(workflowName);
            }
        }

        /// <summary>
        /// 初始化所有教师列表
        /// </summary>
        private void init_teacher()
        {
            Student.BLL.TEACHER_INFO teacherBll = new BLL.TEACHER_INFO();
            DataSet ds = teacherBll.GetAllList();
            this.cbb_teacher.Properties.Items.Clear();
            cbb_teacher.EditValue = null;
            cbb_teacher.Properties.NullText = "--请选择--";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string teacherName = ds.Tables[0].Rows[i]["NAME"].ToString();
                this.cbb_teacher.Properties.Items.Add(teacherName);
            }
            this.cbb_teacher.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        /// <summary>
        /// 窗口初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTEA_STU_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 读取数据
        /// </summary>
        private void readData(int flag)
        {
            int termno, teacherno, workflowno;

            BLL.STUDENT_INFO studentBll = new BLL.STUDENT_INFO();
            BLL.TERM_INFO termBll = new BLL.TERM_INFO();
            Model.TERM_INFO termMdl = new Model.TERM_INFO();
            BLL.WORKFLOW workflowBll = new BLL.WORKFLOW();
            Model.WORKFLOW workflowMdl = new Model.WORKFLOW();
            BLL.TEACHER_INFO teacherBll = new BLL.TEACHER_INFO();
            Model.TEACHER_INFO teacherMdl = new Model.TEACHER_INFO();

            termMdl = termBll.GetModel(this.cbb_term.Properties.Items[this.cbb_term.SelectedIndex].ToString());
            termno = termMdl.TERMNO;

            workflowMdl = workflowBll.GetModel(this.cbb_workflow.Properties.Items[this.cbb_workflow.SelectedIndex].ToString());
            workflowno = workflowMdl.WORKFLOWNO;           

            //初始化学生列表
            this.tl_student.DataSource = studentBll.GetStudentNodeList(termno,workflowno).Tables[0];
            this.tl_student.KeyFieldName = "nodeid";
            this.tl_student.ParentFieldName = "parentid";
            this.tl_student.Columns["nodename"].Caption = "学生列表";

            //初始化教师指导学生列表
            string condition = "";
            condition += " and D.TERMNO = '" + termno.ToString() + "' ";
            condition += " and E.WORKFLOWNO = '" + workflowno.ToString() + "' ";
            if (flag == 2)
            {
                teacherMdl = teacherBll.GetModel(this.cbb_teacher.Properties.Items[this.cbb_teacher.SelectedIndex].ToString());
                teacherno = teacherMdl.TEACHERNO;
                condition += " and C.TEACHERNO = '" + teacherno.ToString() + "' ";
            }

            BLL.TEA_STU teastuBll = new BLL.TEA_STU();
            this.gridControl1.DataSource = teastuBll.GetList(condition).Tables[0];
            this.gridView1.BestFitColumns();
            DBUtility.ToolHelper.DrawRowIndicator(gridView1, 50);
            DBUtility.ToolHelper.SetLineColorofGridView(this.gridView1);
        }


        /// <summary>
        /// 选择某一节点时，该节点的所有子节点全部选择，取消时，则全部取消
        /// </summary>
        /// <param name="node"></param>
        /// <param name="check"></param>
        private void setCheckedChildNodes(TreeListNode node, CheckState check)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                node.Nodes[i].CheckState = check;
                setCheckedChildNodes(node.Nodes[i], check);
            }
        }

        /// <summary>
        /// 某节点的子节点全部选择时,该节点选择   某节点的子节点未全部选择时,该节点不选择
        /// </summary>
        /// <param name="node"></param>
        /// <param name="check"></param>
        private void SetCheckedParentNodes(TreeListNode node, CheckState check)
        {
            if (node.ParentNode != null)
            {

                CheckState parentCheckState = node.ParentNode.CheckState;
                CheckState nodeCheckState;
                for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
                {
                    nodeCheckState = (CheckState)node.ParentNode.Nodes[i].CheckState;
                    if (!check.Equals(nodeCheckState))//只要任意一个与其选中状态不一样即父节点状态不全选
                    {
                        parentCheckState = CheckState.Unchecked;
                        break;
                    }
                    parentCheckState = check;//否则（该节点的兄弟节点选中状态都相同），则父节点选中状态为该节点的选中状态
                }

                node.ParentNode.CheckState = parentCheckState;
                SetCheckedParentNodes(node.ParentNode, check);//遍历上级节点
            }
        }

        private void tl_student_BeforeExpand(object sender, DevExpress.XtraTreeList.BeforeExpandEventArgs e)
        {
            
        }

        private void tl_student_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            setCheckedChildNodes(e.Node, e.Node.CheckState);
            SetCheckedParentNodes(e.Node, e.Node.CheckState);
        }

        private void cbb_term_SelectedIndexChanged(object sender, EventArgs e)
        {
            init_workflow();
        }

        private void cbb_workflow_SelectedIndexChanged(object sender, EventArgs e)
        {
            init_teacher();
            readData(1);
        }

        /// <summary>
        /// 清空查询条件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbt_Find_Click(object sender, EventArgs e)
        {
            if (this.cbb_term.SelectedIndex == -1)
            {
                MessageBox.Show("请选择学期！", "提示信息");
                return;
            }

            if (this.cbb_workflow.SelectedIndex == -1)
            {
                MessageBox.Show("请选择工作流！", "提示信息");
                return;
            }
            init_teacher();
            readData(1);
        }

        
        /// <summary>
        /// 获取选择状态的数据主键ID集合
        /// </summary>
        /// <param name="parentNode">父级节点</param>
        private void GetCheckedStudentNo(TreeListNode parentNode)
        {
            if (parentNode.Nodes.Count == 0)
            {
                return;//递归终止
            }

            //foreach (TreeListNode node in parentNode.Nodes)
            for(int i = 0; i < parentNode.Nodes.Count; i++)
            {
                if (parentNode.Nodes[i].CheckState == CheckState.Checked && !parentNode.Nodes[i].HasChildren)
                {
                    DataRowView drv = this.tl_student.GetDataRecordByNode(parentNode.Nodes[i]) as DataRowView;//关键代码
                    if (drv != null)
                    {
                        string studentNo = (string)drv["NODENAME"];
                        if (studentNo.Length >= 8)
                        {
                            studentNo = studentNo.Substring(0, 8);
                            lstCheckedStudentNo.Add(studentNo);
                        }
                    }
                }
                GetCheckedStudentNo(parentNode.Nodes[i]);
            }
        }


        /// <summary>
        /// 增加数据方法
        /// </summary>
        private void Add()
        {
            int termno, teacherno, workflowno;

            if (this.cbb_teacher.SelectedIndex == -1)
            {
                MessageBox.Show("请选择指导教师！", "提示信息");
                return;
            }

            BLL.STUDENT_INFO studentBll = new BLL.STUDENT_INFO();
            BLL.TERM_INFO termBll = new BLL.TERM_INFO();
            Model.TERM_INFO termMdl = new Model.TERM_INFO();
            BLL.WORKFLOW workflowBll = new BLL.WORKFLOW();
            Model.WORKFLOW workflowMdl = new Model.WORKFLOW();
            BLL.TEACHER_INFO teacherBll = new BLL.TEACHER_INFO();
            Model.TEACHER_INFO teacherMdl = new Model.TEACHER_INFO();
            BLL.TEA_STU teastuBll = new BLL.TEA_STU();
            Model.TEA_STU teastuMdl = new Model.TEA_STU();

            termMdl = termBll.GetModel(this.cbb_term.Properties.Items[this.cbb_term.SelectedIndex].ToString());
            termno = termMdl.TERMNO;

            workflowMdl = workflowBll.GetModel(this.cbb_workflow.Properties.Items[this.cbb_workflow.SelectedIndex].ToString());
            workflowno = workflowMdl.WORKFLOWNO;

            teacherMdl = teacherBll.GetModel(this.cbb_teacher.Properties.Items[this.cbb_teacher.SelectedIndex].ToString());
            teacherno = teacherMdl.TEACHERNO;

            teastuMdl.TEACHERNO = teacherno;
            teastuMdl.TERMNO = termno;
            teastuMdl.WORKFLOWNO = workflowno;

            //获取所选学生学号列表
            this.lstCheckedStudentNo.Clear();

            if (this.tl_student.Nodes.Count > 0)
            {
                foreach (TreeListNode root in tl_student.Nodes)
                {
                    GetCheckedStudentNo(root);
                }
            }

            //将所选学生插入该教师所指导学生列表中
            string idStr = string.Empty;
            foreach (string stuno in lstCheckedStudentNo)
            {
                teastuMdl.STUNO = stuno;
                teastuBll.Add(teastuMdl);
            }
            //显示更新数据
            readData(2);
        }

        //添加按钮
        private void sbt_Add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void cbb_teacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbb_term.SelectedIndex == -1)
            {
                MessageBox.Show("请选择学期！", "提示信息");
                return;
            }

            if (this.cbb_workflow.SelectedIndex == -1)
            {
                MessageBox.Show("请选择工作流！", "提示信息");
                return;
            }

            readData(2);
        }       

        /// <summary>
        /// 删除数据方法
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool deleteData(int id)
        {
            try
            {
                BLL.TEA_STU teastuBll = new BLL.TEA_STU();
                teastuBll.Delete(id);
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("删除失败!", exception.Message);
                return false;
            }
        }

        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbt_Delete_Click(object sender, EventArgs e)
        {
            if (this.cbb_teacher.SelectedIndex == -1)
            {
                MessageBox.Show("请选择指导教师！", "提示信息");
                return;
            }

            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("GUIDANCENO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要删除的数据！", "提示信息");
                return;
            }
            else
            {
                if (MessageBox.Show("确定要删除该信息吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    deleteData(id);
                    readData(2);
                }
                else
                    return;
            }
        }

        private void sbt_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}