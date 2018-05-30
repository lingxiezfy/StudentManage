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
using Student.DBUtility;

namespace Student.Forms
{
    public partial class frmMATERIAL : DevExpress.XtraEditors.XtraForm
    {
        public frmMATERIAL()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        private void ReadData()
        {
            string condition = "";
            if (this.te_material.Text.Length > 0)
            {
                condition = "MATERIALNAME like '%" + this.te_material.Text + "%'";
            }
            BLL.MATERIAL_INFO materialBll = new MATERIAL_INFO();
            this.gridControl1.DataSource = materialBll.GetList(condition).Tables[0];
            this.gridView1.BestFitColumns();
            DBUtility.ToolHelper.DrawRowIndicator(gridView1, 40);
            DBUtility.ToolHelper.SetLineColorofGridView(this.gridView1);
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool deleteData(int id)
        {
            try
            {
                BLL.NODEMATERIALS nodematerialsBll = new NODEMATERIALS();
                int recordCount = nodematerialsBll.GetRecordCount("MATERIALNO = " + id.ToString());
                if (recordCount > 0)
                {
                    MessageBox.Show("该材料信息已经被使用，不能被删除！", "提示信息");
                    return false;
                }
                else
                {
                    BLL.MATERIAL_INFO materialBll = new MATERIAL_INFO();
                    materialBll.Delete(id);
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
        /// 清空查询条件
        /// </summary>
        private void BlankData()
        {
            this.te_material.Text = "";
        }

        private void sbt_find_Click(object sender, EventArgs e)
        {
            ReadData();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if ((e as MouseEventArgs).Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition);

            }
        }

        private void bbi_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMATERIALADD frm = new frmMATERIALADD();
            frm.ShowDialog();
            ReadData();
        }

        private void bbi_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("MATERIALNO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要修改的材料！", "提示信息");
                return;
            }
            else
            {
                frmMATERIALADD frm = new frmMATERIALADD(id, StatusClass.Edit);
                frm.ShowDialog();
                ReadData();
            }            
        }

        private void bbi_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("MATERIALNO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要删除的材料！", "提示信息");
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