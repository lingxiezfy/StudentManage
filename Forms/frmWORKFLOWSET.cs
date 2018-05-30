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
    public partial class frmWORKFLOWSET : DevExpress.XtraEditors.XtraForm
    {
        public frmWORKFLOWSET()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            //初始化工作流列表数据
            BLL.WORKFLOW workflowBll = new BLL.WORKFLOW();
            Model.WORKFLOW workflowMdl = new Model.WORKFLOW();           

            clbc_workflow.Items.Clear();
            List<Model.WORKFLOW> workflowList = new List<Model.WORKFLOW>();
            workflowList = workflowBll.GetModelList(" status = 1");
            foreach (Model.WORKFLOW l in workflowList)
            {
                clbc_workflow.Items.Add(l.WORKFLOWNAME);         
            }
            //默认显示第一个工作流的节点数据
            if (clbc_workflow.Items.Count > 0)
            {
                string workflowname = clbc_workflow.Items[0].Value.ToString();
                ReadData(workflowname);
            }
        }

        private void clbc_workflow_SelectedIndexChanged(object sender, EventArgs e)
        {
            //设置点击一下即打钩
            CheckedListBoxControl clb = sender as CheckedListBoxControl;
            int si = clb.SelectedIndex;
            if (si == -1)
            {
                si = 0;
            }
            clb.SetItemCheckState(si, CheckState.Checked);                     
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        private void ReadData(string workflowname)
        {
            string condition = "";
            
            BLL.WORKFLOW workflowBll = new BLL.WORKFLOW();
            Model.WORKFLOW workflowMdl = new Model.WORKFLOW();
            workflowMdl = workflowBll.GetModel(workflowname);
            int workflowno = workflowMdl.WORKFLOWNO;
            if (workflowno > 0)
            {
                BLL.WORKFLOWSET workflowsetBll = new BLL.WORKFLOWSET();
                condition = " WORKFLOWSET.WORKFLOWNO = " + workflowno.ToString();
                this.gc_workflowset.DataSource = workflowsetBll.GetList(condition).Tables[0];
                this.gridView1.BestFitColumns();
                DBUtility.ToolHelper.DrawRowIndicator(gridView1, 40);
                DBUtility.ToolHelper.SetLineColorofGridView(this.gridView1);
            }
        }

        /// <summary>
        /// 删除数据方法
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool deleteData(decimal setno)
        {
            try
            {
                int nodeno, workflowno;
                BLL.WORKFLOWSET workflowsetBll = new BLL.WORKFLOWSET();
                Model.WORKFLOWSET workflowsetMdl = new Model.WORKFLOWSET(); 

                BLL.STU_WORKFLOW stu_workflowBll = new BLL.STU_WORKFLOW();

                workflowsetMdl = workflowsetBll.GetModel(setno);
                nodeno = (int)workflowsetMdl.NODENO;
                workflowno = (int)workflowsetMdl.WORKFLOWNO;

                int recordCount = stu_workflowBll.GetRecordCount("and STU_WORKFLOW.nodeno = " + nodeno.ToString() + " and TEA_STU.workflowno = " + workflowno.ToString());
                if (recordCount > 0)
                {
                    MessageBox.Show("该设置信息已经被使用，不能被删除！", "提示信息");
                    return false;
                }
                else
                {
                    workflowsetBll.Delete(setno);
                    return true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("删除失败!", exception.Message);
                return false;
            }
        }

        /// <summary>
        /// 设置左侧列表只能单选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clbc_workflow_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {

            for (int i = 0; i < clbc_workflow.ItemCount; i++)
            {
                if (i != e.Index)
                {
                    clbc_workflow.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private void clbc_workflow_Click(object sender, EventArgs e)
        {
            //检索数据，在表格中显示
            int si = clbc_workflow.SelectedIndex;
            if (si >= 0)
            {
                string workflowname = clbc_workflow.Items[si].ToString();
                ReadData(workflowname);
            }
        }

        private void gc_workflowset_Click(object sender, EventArgs e)
        {
            if ((e as MouseEventArgs).Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition); //弹出弹出式菜单

            }
        }

        /// <summary>
        /// 新增菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbi_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.clbc_workflow.SelectedIndex < 0)
                return;
            Model.WORKFLOWSETADD workflowsetaddMdl = new Model.WORKFLOWSETADD();
            workflowsetaddMdl.WORKFLOWNAME = clbc_workflow.Items[clbc_workflow.SelectedIndex].ToString();
            if (workflowsetaddMdl.WORKFLOWNAME.Length <= 0 || workflowsetaddMdl.WORKFLOWNAME == null)
            {
                MessageBox.Show("请选择需要修改的工作流！", "提示信息");
                return;
            }
            else
            {
                frmWORKFLOWSETADD frm = new frmWORKFLOWSETADD(workflowsetaddMdl, StatusClass.AddNew);
                frm.ShowDialog();
                ReadData(workflowsetaddMdl.WORKFLOWNAME);
            }
        }

        /// <summary>
        /// 修改菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbi_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Model.WORKFLOWSETADD workflowsetaddMdl = new Model.WORKFLOWSETADD();
            workflowsetaddMdl.WORKFLOWNAME = clbc_workflow.Items[clbc_workflow.SelectedIndex].ToString();
            if (workflowsetaddMdl.WORKFLOWNAME.Length <= 0 || workflowsetaddMdl.WORKFLOWNAME == null)
            {
                MessageBox.Show("请选择需要修改的工作流！", "提示信息");
                return;
            }
           
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("SETNO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要修改的工作流节点！", "提示信息");
                return;
            }
            else
            {
                workflowsetaddMdl.SETNO = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("SETNO").ToString());
                workflowsetaddMdl.NODENAME = this.gridView1.GetFocusedRowCellValue("NODENAME").ToString();
                workflowsetaddMdl.NODEORDER = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("NODEORDER").ToString());
                workflowsetaddMdl.BEGINTIME = ToolHelper.ConvertToDateTime(this.gridView1.GetFocusedRowCellValue("BEGINTIME").ToString());
                workflowsetaddMdl.ENDTIME = ToolHelper.ConvertToDateTime(this.gridView1.GetFocusedRowCellValue("ENDTIME").ToString());

                frmWORKFLOWSETADD frm = new frmWORKFLOWSETADD(workflowsetaddMdl, StatusClass.Edit);
                frm.ShowDialog();
                ReadData(workflowsetaddMdl.WORKFLOWNAME);
            }            
        }

        /// <summary>
        /// 删除菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbi_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (clbc_workflow.SelectedIndex < 0)
                return;
            decimal id = 0;
            string workflowname = clbc_workflow.Items[clbc_workflow.SelectedIndex].ToString();

            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("SETNO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要删除的工作流节点！", "提示信息");
                return;
            }
            else
            {
                if (MessageBox.Show("确定要删除该信息吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    deleteData(id);
                    ReadData(workflowname);
                }
                else
                    return;
            }
        }
    }
}