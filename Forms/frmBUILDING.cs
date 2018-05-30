using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Student.BLL;
using Student.DBUtility;


namespace Student.Forms
{
    public partial class frmBUILDING : DevExpress.XtraEditors.XtraForm
    {
        public frmBUILDING()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        /// 
        private void ReadData()
        {
            string condition = "";

            if (this.te_buildingname.Text != "")
            {
                condition += "BUILDINGNAME like '%" + this.te_buildingname.Text + "%' ";
            }

            if (this.te_admin.Text != "")
            {
                if (condition.Length > 0)
                {
                    condition += "and ADMIN like '%" + this.te_admin.Text + "%' ";
                }
                else
                {
                    condition += "ADMIN like '%" + this.te_admin.Text + "%' ";
                }
            }

            Student.BLL.BUILDING_INFO buildingBll = new Student.BLL.BUILDING_INFO();
            this.gridControl1.DataSource = buildingBll.GetList(condition).Tables[0];
            this.gridView1.BestFitColumns();
            DBUtility.ToolHelper.DrawRowIndicator(gridView1, 40);
            DBUtility.ToolHelper.SetLineColorofGridView(this.gridView1);
        }

        /// <summary>
        /// 清空查询条件
        /// </summary>
        private void BlankData()
        {
            this.te_admin.Text = "";
            this.te_buildingname.Text = "";
        }

        /// <param name="e"></param>
        /// 弹出右键菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridControl1_Click_1(object sender, EventArgs e)
        {
            if ((e as MouseEventArgs).Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition);
            }
        }

        /// <summary>
        /// 新增宿舍楼菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiADD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBUILDINGADD frm = new frmBUILDINGADD();
            frm.ShowDialog();
            ReadData();
        }

        /// <summary>
        /// 删除宿舍楼菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiDelect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("BUILDINGID").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要删除的宿舍楼！", "提示信息");
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

        /// <summary>
        /// 删除数据方法
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool deleteData(int id)
        {
            try
            {
                BLL.DORMITORY_INFO dormitoryBll = new DORMITORY_INFO();
                int recordCount = dormitoryBll.GetRecordCount("BUILDINGID = " + id.ToString());
                if (recordCount > 0)
                {
                    MessageBox.Show("该宿舍楼信息已经被使用，不能被删除！", "提示信息");
                    return false;
                }
                else
                {
                    BLL.BUILDING_INFO buildingBll = new BUILDING_INFO();
                    buildingBll.Delete(id);
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
        /// 清空查询条件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbt_Clear_Click(object sender, EventArgs e)
        {
            BlankData();
        }

        /// <summary>
        /// 查询数据按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbt_Find_Click(object sender, EventArgs e)
        {
            ReadData();
        }

        /// <summary>
        /// 修改菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiEdit_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("BUILDINGID").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要修改的宿舍楼！", "提示信息");
                return;
            }
            else
            {
                frmBUILDINGADD frm = new frmBUILDINGADD(id, StatusClass.Edit);
                frm.ShowDialog();
                ReadData();
            }
        }

        private void sbt_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
