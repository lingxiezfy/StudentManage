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
using Student.DBUtility;

namespace Student.Forms
{
    public partial class frmSTU_JOBSTATUS : DevExpress.XtraEditors.XtraForm
    {
        private string _stuno;
        private List<string> lstCheckedStudentNo = new List<string>();//选择学生学号集合

        public frmSTU_JOBSTATUS()
        {
            InitializeComponent();
            init_student();
            this._stuno = "";
            this.cbb_ifcurrent.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        //初始化学生列表
        private void init_student()
        {
            BLL.STUDENT_INFO studentBll = new BLL.STUDENT_INFO();
            this.tl_student.DataSource = studentBll.GetStudentNodeList().Tables[0];
            this.tl_student.KeyFieldName = "nodeid";
            this.tl_student.ParentFieldName = "parentid";
            this.tl_student.Columns["nodename"].Caption = "学生列表";
        }

        /// <summary>
        /// flag:1——根据学生学号查询；2——根据输入条件查询
        /// </summary>
        /// <param name="flag"></param>
        private void readData(int flag,string stuno)
        {
            string condition = "";
            BLL.STUDENT_JOBSTATUS stujobstatusBll = new BLL.STUDENT_JOBSTATUS();
            if (flag == 1)
            {              
                condition += " and B.stuno = '" + stuno + "'";
                this.gridControl1.DataSource = stujobstatusBll.GetList(condition).Tables[0];
            }
            else if (flag == 2)
            {
                if (this.te_stuno.Text.Length > 0)
                {
                    condition += " and B.stuno like '%" + this.te_stuno.Text + "%'";
                }

                if(this.te_stuname.Text.Length > 0)
                {
                    condition += " and B.name like '%" + this.te_stuname.Text + "%'";
                }

                if (this.cbb_ifcurrent.SelectedIndex != -1)
                {
                    if (this.cbb_ifcurrent.Text == "已就业")
                    {
                        condition += " and A.IF_CURRENT = 1 ";
                    }
                    else
                    {
                        condition += " and A.IF_CURRENT = 0 ";
                    }
                }
                condition += " order by STATUSTIME";
                this.gridControl1.DataSource = stujobstatusBll.GetList(condition,1).Tables[0];
            }           

            this.gridView1.BestFitColumns();
            DBUtility.ToolHelper.DrawRowIndicator(gridView1, 40);
            DBUtility.ToolHelper.SetLineColorofGridView(this.gridView1);
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
            for (int i = 0; i < parentNode.Nodes.Count; i++)
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
        /// 关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbt_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 查询数据按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbt_Find_Click(object sender, EventArgs e)
        {
            readData(2,"");
            this._stuno = "";
        }

        /// <summary>
        /// 增加就业记录菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbi_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.gridView1.RowCount > 0)
            {
                this._stuno = this.gridView1.GetFocusedRowCellValue("STUNO").ToString();
            }
            else
            {
                if(this._stuno.Length <= 0)
                {
                    MessageBox.Show("请选择要增加就业信息的学生！","提示信息");
                    return;
                }                
            }
            frmSTU_JOBSTATUSADD frm = new frmSTU_JOBSTATUSADD(_stuno);
            frm.ShowDialog();
            readData(1, _stuno);
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
                BLL.STUDENT_JOBSTATUS stujobstatusBll = new BLL.STUDENT_JOBSTATUS();
                stujobstatusBll.Delete(id);
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("删除失败!", exception.Message);
                return false;
            }
        }

        /// <summary>
        /// 删除就业记录菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbi_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("STATUSNO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要删除的记录！", "提示信息");
                return;
            }
            else
            {
                if (MessageBox.Show("确定要删除该信息吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this._stuno = this.gridView1.GetFocusedRowCellValue("STUNO").ToString();
                    deleteData(id);
                    readData(1,_stuno);
                }
                else
                    return;
            }
        }

        /// <summary>
        /// 修改就业记录菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbi_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("STATUSNO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要修改的就业记录！", "提示信息");
                return;
            }
            else
            {
                this._stuno = this.gridView1.GetFocusedRowCellValue("STUNO").ToString();
                frmSTU_JOBSTATUSADD frm = new frmSTU_JOBSTATUSADD(id, StatusClass.Edit);
                frm.ShowDialog();
                readData(1,_stuno);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if ((e as MouseEventArgs).Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition); //弹出弹出式菜单

            }
        }

        private void tl_student_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            //选择前取消前面已经选择的，实现单选功能
            List<DevExpress.XtraTreeList.Nodes.TreeListNode> treeListNodes = this.tl_student.GetAllCheckedNodes();
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode node in treeListNodes)
            {
                node.Checked = false;
            }
            this.tl_student.FocusedNode.CheckState = CheckState.Checked;
            this.lstCheckedStudentNo.Clear();
            if (this.tl_student.Nodes.Count > 0)
            {
                foreach (TreeListNode root in tl_student.Nodes)
                {
                    GetCheckedStudentNo(root);
                }
            }  

            //将所选学生插入该教师所指导学生列表中
            foreach (string str in lstCheckedStudentNo)
            {
                if (str.Length >= 8)
                {
                    string stuno = str.Substring(0, 8);
                    this._stuno = stuno;
                    readData(1, stuno);
                }
            }
        }

        private void sbt_Clear_Click(object sender, EventArgs e)
        {
            this.te_entname.Text = "";
            this.te_stuno.Text = "";
            this.cbb_ifcurrent.Text = "";
        }

    }
}