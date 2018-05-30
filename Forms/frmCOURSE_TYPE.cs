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
    public partial class frmCOURSE_TYPE : DevExpress.XtraEditors.XtraForm
    {
        public frmCOURSE_TYPE()
        {
            InitializeComponent();
        }
            
        /// <summary>
        /// 查询数据按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sbtn_find_Click(object sender, EventArgs e)
        {
            ReadData();
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        private void ReadData()
        {
            string condition = "";

            if (this.te_coursetypename.Text.Length > 0)
            {
                condition += " coursetypename like '%" + this.te_coursetypename.Text + "%'";
            }

            Student.BLL.COURSE_TYPE coursetypeBll = new Student.BLL.COURSE_TYPE();
            this.gridControl1.DataSource = coursetypeBll.GetList(condition).Tables[0];
            this.gridView1.BestFitColumns();
            DBUtility.ToolHelper.DrawRowIndicator(gridView1, 40);
            DBUtility.ToolHelper.SetLineColorofGridView(this.gridView1);
        }

        private void Cbtn_clear_Click(object sender, EventArgs e)   //清空查询条件按钮
        {
            this.te_coursetypename.Text = "";
        }

        private void gridControl1_Click(object sender, EventArgs e)   //右击事件
        {
            if ((e as MouseEventArgs).Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition); //弹出弹出式菜单
            }
        }

        /// <summary>
        /// 弹出式菜单的“新增课程信息”按钮
        /// </summary>
        private void bbiAdd_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCOURSE_TYPEADD frm = new frmCOURSE_TYPEADD();
            frm.ShowDialog();
            ReadData();
        }

        /// <summary>
        /// 弹出式菜单的“修改课程信息”按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("COURSETYPENO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要修改的课程类型！", "提示信息");
                return;
            }
            else
            {
                frmCOURSE_TYPEADD frm = new frmCOURSE_TYPEADD(id, StatusClass.Edit);
                frm.ShowDialog();
                ReadData();
            }
        }

        /// <summary>
        /// 弹出式菜单的“删除课程信息”按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("COURSETYPENO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要删除的课程！", "提示信息");
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
        /// 删除方法
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool deleteData(int id)
        {
            try
            {
                BLL.COURSE_INFO courseBll = new BLL.COURSE_INFO();
                int recordCount = courseBll.GetRecordCount("COURSETYPENO = " + id.ToString());
                if (recordCount > 0)
                {
                    MessageBox.Show("该课程类型信息已经被使用，不能被删除！", "提示信息");
                    return false;
                }
                else
                {
                    BLL.COURSE_TYPE coursetypeBll = new BLL.COURSE_TYPE();
                    coursetypeBll.Delete(id);
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
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cbtn_find_Click_Click(object sender, EventArgs e)   //查询
        {
            ReadData();
        }

        private void sbt_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}