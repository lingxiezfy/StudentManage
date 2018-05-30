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
    public partial class frmDORMITORY : DevExpress.XtraEditors.XtraForm
    {
        public frmDORMITORY()
        {
            InitializeComponent();
            init_building();
        }

        /// <summary>
        /// 初始化宿舍楼名称列表
        /// </summary>
        private void init_building()
        {
            Student.BLL.BUILDING_INFO buildingBll = new BUILDING_INFO();
            DataSet ds = buildingBll.GetAllList();
            this.cbb_buildingname.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbb_buildingname.Properties.Items.Clear();
            cbb_buildingname.EditValue = null;
            cbb_buildingname.Properties.NullText = "--请选择--";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string buildingName = ds.Tables[0].Rows[i]["BUILDINGNAME"].ToString();
                this.cbb_buildingname.Properties.Items.Add(buildingName);
            }
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        private void ReadData()
        {           
            string condition = "";
           
            if (this.cbb_buildingname.SelectedIndex != -1)
            {
                condition += " and A.BUILDINGNAME ='" + this.cbb_buildingname.Properties.Items[this.cbb_buildingname.SelectedIndex].ToString() + "' ";
            }
            if (this.te_plate.Text.Length > 0)
                condition += "and B.DORMITORY_PLATE like '%" + this.te_plate.Text + "%'";

            Student.BLL.DORMITORY_INFO dormitoryBll = new Student.BLL.DORMITORY_INFO();
            this.gridControl1.DataSource = dormitoryBll.GetList(condition).Tables[0];
            this.gridView1.BestFitColumns();
            DBUtility.ToolHelper.DrawRowIndicator(gridView1, 40);
            DBUtility.ToolHelper.SetLineColorofGridView(this.gridView1);
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
        /// 删除数据方法
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool deleteData(int id)
        {
            try
            {
                BLL.STUDENT_INFO studentBll = new STUDENT_INFO();
                int recordCount = studentBll.GetRecordCount("DORMITORY_ID = " + id.ToString());
                if (recordCount > 0)
                {
                    MessageBox.Show("该宿舍信息已经被使用，不能被删除！", "提示信息");
                    return false;
                }
                else
                {
                    BLL.DORMITORY_INFO dormitoryBll = new DORMITORY_INFO();
                    dormitoryBll.Delete(id);
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
        private void Sbtn_clear_Click(object sender, EventArgs e)
        {
            init_building();
            this.te_plate.Text = String.Empty;
        }

        /// <summary>
        /// Grid的鼠标右键单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridControl1_Click(object sender, EventArgs e)
        {
            if ((e as MouseEventArgs).Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition); //弹出弹出式菜单

            }
        }

        /// <summary>
        /// 弹出式菜单的“新增宿舍信息”按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDORMITORYADD frm = new frmDORMITORYADD();
            frm.ShowDialog();
            ReadData();
        }

        /// <summary>
        /// 弹出式菜单的“修改宿舍信息”按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("DORMITORY_ID").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要修改的宿舍！", "提示信息");
                return;
            }
            else
            {
                frmDORMITORYADD frm = new frmDORMITORYADD(id, StatusClass.Edit);
                frm.ShowDialog();
                ReadData();
            }
        }

      

        /// <summary>
        /// 弹出式菜单的“删除宿舍信息”按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("DORMITORY_ID").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要删除的宿舍！", "提示信息");
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