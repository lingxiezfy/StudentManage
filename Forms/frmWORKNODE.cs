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
    public partial class frmWORKNODE : DevExpress.XtraEditors.XtraForm
    {
        public frmWORKNODE()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        private void ReadData()
        {
            string condition = "";

            if (this.te_nodename.Text.Length > 0)
            {
                condition += "NODENAME like '%" + this.te_nodename.Text + "%'";
            }

            Student.BLL.WORKNODE worknodeBll = new Student.BLL.WORKNODE();
            this.gridControl1.DataSource = worknodeBll.GetList(condition).Tables[0];
            this.gridView1.BestFitColumns();
            DBUtility.ToolHelper.DrawRowIndicator(gridView1, 40);
            DBUtility.ToolHelper.SetLineColorofGridView(this.gridView1);
        }

        private void sbt_find_Click(object sender, EventArgs e)
        {
            ReadData();
        }

        private void sbt_clear_Click(object sender, EventArgs e)
        {
            this.te_nodename.Text = "";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if ((e as MouseEventArgs).Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition); //弹出弹出式菜单

            }
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
                BLL.WORKFLOWSET workflowsetbll = new BLL.WORKFLOWSET();
                int recordCount = workflowsetbll.GetRecordCount("workflowno = " + id.ToString());
                if (recordCount > 0)
                {
                    MessageBox.Show("该工作节点信息已经被使用，不能被删除！", "提示信息");
                    return false;
                }
                else
                {
                    BLL.WORKNODE worknodebll = new BLL.WORKNODE();
                    worknodebll.Delete(id);
                    return true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("删除失败!", exception.Message);
                return false;
            }
        }

        private void bbi_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmWORKNODEADD frm = new frmWORKNODEADD();
            frm.ShowDialog();
            ReadData();
        }

        private void bbi_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("NODENO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要修改的工作节点！", "提示信息");
                return;
            }
            else
            {
                frmWORKNODEADD frm = new frmWORKNODEADD(id, StatusClass.Edit);
                frm.ShowDialog();
                ReadData();
            }            
        }

        private void bbi_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("NODENO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要删除的工作节点！", "提示信息");
                return;
            }
            else
            {
                if (MessageBox.Show("确定要删除该信息吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    deleteData(id);
                    ReadData();
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