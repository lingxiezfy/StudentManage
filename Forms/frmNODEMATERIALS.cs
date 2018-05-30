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
    public partial class frmNODEMATERIALS : DevExpress.XtraEditors.XtraForm
    {
        public frmNODEMATERIALS()
        {
            InitializeComponent();
            init_node();
        }

        /// <summary>
        /// 初始化左侧列表工作节点数据
        /// </summary>
        private void init_node()
        {
            //初始化工作节点列表数据
            BLL.WORKNODE worknodeBll = new BLL.WORKNODE();
            Model.WORKNODE worknodeMdl = new Model.WORKNODE();

            clbc_node.Items.Clear();
            List<Model.WORKNODE> worknodeList = new List<Model.WORKNODE>();
            worknodeList = worknodeBll.GetModelList("");
            foreach (Model.WORKNODE l in worknodeList)
            {
                clbc_node.Items.Add(l.NODENAME);
            }
            //默认显示第一个工作流的节点数据
            if (clbc_node.Items.Count > 0)
            {
                string worknodename = clbc_node.Items[0].Value.ToString();
                ReadData(worknodename);
            }
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        private void ReadData(string nodename)
        {
            string condition = "";

            BLL.WORKNODE worknodeBll = new BLL.WORKNODE();
            Model.WORKNODE worknodeMdl = new Model.WORKNODE();
            worknodeMdl = worknodeBll.GetModel(nodename);
            int worknodeno = worknodeMdl.NODENO;
            if (worknodeno > 0)
            {
                BLL.NODEMATERIALS nodematerialsBll = new BLL.NODEMATERIALS();
                condition = " D.NODENAME = '" + nodename + "'";
                this.gc_nodematerials.DataSource = nodematerialsBll.GetList(condition).Tables[0];
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
        private bool deleteData(decimal NODEMATERIALSNO)
        {
            try
            {
                BLL.STU_MATERIALS stu_materialsBll = new BLL.STU_MATERIALS();
                BLL.NODEMATERIALS nodematerialsBll = new BLL.NODEMATERIALS();
                Model.NODEMATERIALS nodematerialsMdl = new Model.NODEMATERIALS();
                nodematerialsMdl = nodematerialsBll.GetModel(NODEMATERIALSNO);
                int nodeno = (int)nodematerialsMdl.NODENO;
                int materialno = (int)nodematerialsMdl.MATERIALNO;
                int recordCount = stu_materialsBll.GetRecordCount("and STU_MATERIALS.MATERIALNO = " + materialno.ToString() + " and STU_WORKFLOW.NODENO = " + nodeno.ToString());
                if (recordCount > 0)
                {
                    MessageBox.Show("该设置信息已经被使用，不能被删除！", "提示信息");
                    return false;
                }
                else
                {
                    nodematerialsBll.Delete(NODEMATERIALSNO);
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
        private void clbc_node_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            for (int i = 0; i < this.clbc_node.ItemCount; i++)
            {
                if (i != e.Index)
                {
                    clbc_node.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private void clbc_node_SelectedIndexChanged(object sender, EventArgs e)
        {
            //设置点击一下即打钩
            //CheckedListBoxControl clb = sender as CheckedListBoxControl;
            int si = this.clbc_node.SelectedIndex;
            if (si == -1)
            {
                si = 0;
            }
            clbc_node.SetItemCheckState(si, CheckState.Checked); 
        }

        private void clbc_node_Click(object sender, EventArgs e)
        {
            //检索数据，在表格中显示
            int si = this.clbc_node.SelectedIndex;
            if (si >= 0)
            {
                string nodename = clbc_node.Items[si].ToString();
                ReadData(nodename);
            }
        }

        private void gc_nodematerials_Click(object sender, EventArgs e)
        {
            if ((e as MouseEventArgs).Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition); //弹出弹出式菜单

            }
        }

        private void bbi_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Model.NODEMATERIALSADD nodematerialsaddMdl = new Model.NODEMATERIALSADD();
            nodematerialsaddMdl.NODENAME = clbc_node.Items[clbc_node.SelectedIndex].ToString();
            if (nodematerialsaddMdl.NODENAME.Length <= 0 || nodematerialsaddMdl.NODENAME == null)
            {
                MessageBox.Show("请选择需要修改的工作节点！", "提示信息");
                return;
            }
            else
            {
                frmNODEMATERIALSADD frm = new frmNODEMATERIALSADD(nodematerialsaddMdl, StatusClass.AddNew);
                frm.ShowDialog();
                ReadData(nodematerialsaddMdl.NODENAME);
            }
        }

        private void bbi_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Model.NODEMATERIALSADD nodematerialsaddMdl = new Model.NODEMATERIALSADD();
            nodematerialsaddMdl.NODENAME = this.clbc_node.Items[clbc_node.SelectedIndex].ToString();
            if (nodematerialsaddMdl.NODENAME.Length <= 0 || nodematerialsaddMdl.NODENAME == null)
            {
                MessageBox.Show("请选择需要修改的工作节点！", "提示信息");
                return;
            }

            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("NODEMATERIALSNO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要修改的材料信息！", "提示信息");
                return;
            }
            else
            {
                nodematerialsaddMdl.NODEMATERIALSNO = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("NODEMATERIALSNO").ToString());
                nodematerialsaddMdl.NAME = this.gridView1.GetFocusedRowCellValue("NAME").ToString();
                nodematerialsaddMdl.MATERIALNAME = this.gridView1.GetFocusedRowCellValue("MATERIALNAME").ToString();
                nodematerialsaddMdl.BEGINTIME = ToolHelper.ConvertToDateTime(this.gridView1.GetFocusedRowCellValue("BEGINTIME").ToString());
                nodematerialsaddMdl.ENDTIME = ToolHelper.ConvertToDateTime(this.gridView1.GetFocusedRowCellValue("ENDTIME").ToString());
                nodematerialsaddMdl.MEMO = this.gridView1.GetFocusedRowCellValue("MEMO").ToString();

                frmNODEMATERIALSADD frm = new frmNODEMATERIALSADD(nodematerialsaddMdl, StatusClass.Edit);
                frm.ShowDialog();
                ReadData(nodematerialsaddMdl.NODENAME);
            }           
        }

        private void bbi_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.clbc_node.SelectedIndex < 0)
                return;
            decimal id = 0;
            string nodename = this.clbc_node.Items[clbc_node.SelectedIndex].ToString();

            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("NODEMATERIALSNO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要删除的材料设置信息！", "提示信息");
                return;
            }
            else
            {
                if (MessageBox.Show("确定要删除该信息吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    deleteData(id);
                    ReadData(nodename);
                }
                else
                    return;
            }
        }

    }
}