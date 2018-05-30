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
    public partial class frmMAJOR : DevExpress.XtraEditors.XtraForm
    {
        public frmMAJOR()
        {
            InitializeComponent();
            init_department();
        }
        /// <summary>
        /// 初始化窗体，取得学院名称到列表
        /// </summary>
        private void init_department()
        {
            Student.BLL.DEPARTMENT_INFO departmentBll = new DEPARTMENT_INFO();
            DataSet ds = departmentBll.GetAllList();
            cbb_department.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbb_department.Properties.Items.Clear();
            cbb_department.EditValue = null;
            cbb_department.Properties.NullText = "--请选择--";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string departmentName = ds.Tables[0].Rows[i]["departmentname"].ToString();
                this.cbb_department.Properties.Items.Add(departmentName);                
            }
        }


        /// <summary>
        /// 查询数据
        /// </summary>
        private void ReadData()
        {
            string condition = "";

            if (this.te_majorname.Text.Length > 0)
            {
                condition += " and majorname like '%" + this.te_majorname.Text + "%'";               
            }

            string departmentName = "";
            if (cbb_department.SelectedIndex > -1)
            {
                departmentName = cbb_department.Properties.Items[cbb_department.SelectedIndex].ToString();
            }
            if (departmentName.Length > 0)
            {
                condition += " and department_info.departmentname like'%" + departmentName + "%'";
            }

            Student.BLL.MAJOR_INFO majorBll = new Student.BLL.MAJOR_INFO();
            this.gridControl1.DataSource = majorBll.GetList(condition).Tables[0];
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
        /// 清空查询条件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sbtn_clear_Click(object sender, EventArgs e)
        {
            init_department();
            this.te_majorname.Text = "";
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
        /// 弹出式菜单的“新增专业信息”按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMAJORADD frm = new frmMAJORADD();
            frm.ShowDialog();
            ReadData();
        }

        /// <summary>
        /// 弹出式菜单的“修改专业信息”按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("MAJORNO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要修改的专业！", "提示信息");
                return;
            }
            else
            {
                frmMAJORADD frm = new frmMAJORADD(id, StatusClass.Edit);
                frm.ShowDialog();
                ReadData();
            }            
        }

        /// <summary>
        /// 弹出式菜单的“删除专业信息”按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("MAJORNO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要删除的专业！", "提示信息");
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
                BLL.MAJORDIRCT_INFO majordirctinfobll = new MAJORDIRCT_INFO();
                int recordCount = majordirctinfobll.GetRecordCount("majorno = " + id.ToString());
                if (recordCount > 0)
                {
                    MessageBox.Show("该专业信息已经被使用，不能被删除！", "提示信息");
                    return false;
                }
                else
                {
                    BLL.MAJOR_INFO majorbll = new MAJOR_INFO();
                    majorbll.Delete(id);
                    return true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("删除失败!", exception.Message);
                return false;
            }
        }

        private void sbt_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}