using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student.BLL;
using DevExpress.XtraEditors;
using Student.DBUtility;

namespace Student.Forms
{
    public partial class frmTEACHER : DevExpress.XtraEditors.XtraForm
    {
        public frmTEACHER()
        {
            InitializeComponent();
            init_major();
        }
        /// <summary>
        /// 初始化窗体，取得专业名称到列表
        /// </summary>
        private void init_major()
        {
            Student.BLL.MAJOR_INFO majorBll = new MAJOR_INFO();
            DataSet ds = majorBll.GetAllList();
            cbb_majorname.Properties.Items.Clear();
            cbb_majorname.EditValue = null;
            cbb_majorname.Properties.NullText = "--请选择--";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string majorName = ds.Tables[0].Rows[i]["MAJORNAME"].ToString();
                this.cbb_majorname.Properties.Items.Add(majorName);
            }
            this.cbb_majorname.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }
        /// <summary>
        /// 查询数据
        /// </summary>
        private void ReadData()
        {
            string condition = "";

            if (this.te_name.Text.Length > 0)
            {
                condition += " and name like '%" + this.te_name.Text + "%'";
            }

            string majorName = "";
            if (cbb_majorname.SelectedIndex != -1)
            {
                majorName = cbb_majorname.Properties.Items[cbb_majorname.SelectedIndex].ToString();
                condition += " and B.MAJORNAME like '%" + majorName + "%'";
            }

            Student.BLL.TEACHER_INFO teacherBll = new Student.BLL.TEACHER_INFO();
            this.gridControl1.DataSource = teacherBll.GetList(condition).Tables[0];
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
            init_major();
            this.te_name.Text = "";
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
        /// 弹出式菜单的“修改教师信息”按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("TEACHERNO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要修改的教师信息！", "提示信息");
                return;
            }
            else
            {
                frmTEACHERADD frm = new frmTEACHERADD(id, StatusClass.Edit);
                frm.ShowDialog();
                ReadData();
            }
        }
               
        /// <summary>
        /// 弹出式菜单的“新增教师信息”按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTEACHERADD frm = new frmTEACHERADD();
            frm.ShowDialog();
            ReadData();
        }

        /// <summary>
        /// 弹出式菜单的“删除教师信息”按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("TEACHERNO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要删除的教师信息！", "提示信息");
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
                BLL.TEA_STU teastuBll = new TEA_STU();
                int recordCount = teastuBll.GetRecordCount("TEACHERNO = " + id.ToString());
                if (recordCount > 0)
                {
                    MessageBox.Show("该教师信息已经被使用，不能被删除！", "提示信息");
                    return false;
                }
                else
                {
                    BLL.TEACHER_INFO teacherbll = new TEACHER_INFO();
                    teacherbll.Delete(id);
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