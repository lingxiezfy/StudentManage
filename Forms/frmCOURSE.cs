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
    public partial class frmCOURSE : DevExpress.XtraEditors.XtraForm
    {
        public frmCOURSE()
        {
            InitializeComponent();
            init_coursetype();
        }

        /// <summary>
        /// 初始化课程类型列表
        /// </summary>
        private void init_coursetype()
        {
            Student.BLL.COURSE_TYPE coursetypeBll = new COURSE_TYPE();
            DataSet ds = coursetypeBll.GetAllList();
            cbb_coursetype.Properties.Items.Clear();
            cbb_coursetype.EditValue = null;
            cbb_coursetype.Properties.NullText = "--请选择--";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string coursetypeName = ds.Tables[0].Rows[i]["COURSETYPENAME"].ToString();
                this.cbb_coursetype.Properties.Items.Add(coursetypeName);
            }
            this.cbb_coursetype.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        private void ReadData()
        {
            string condition = "";
            if (this.cbb_coursetype.SelectedIndex != -1)
            {
                string coursetypename = this.cbb_coursetype.Properties.Items[this.cbb_coursetype.SelectedIndex].ToString();
                condition += " and B.COURSETYPENAME like '%" + coursetypename + "%'";
            }
          
            if (te_coursename.Text.Length > 0)
            {
                condition += " and COURSENAME like '%" + this.te_coursename.Text + "%'";
            }

            BLL.COURSE_INFO courseBll = new BLL.COURSE_INFO();
            this.gridControl1.DataSource = courseBll.GetList(condition).Tables[0];
            this.gridView1.BestFitColumns();
            DBUtility.ToolHelper.DrawRowIndicator(gridView1, 40);
            DBUtility.ToolHelper.SetLineColorofGridView(this.gridView1);
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
                BLL.COURSE_INFO courseBll = new COURSE_INFO();
                courseBll.Delete(id);
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("删除失败!", exception.Message);
                return false;
            }
        }

        private void bbi_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCOURSEADD frm = new frmCOURSEADD();
            frm.ShowDialog();
            ReadData();

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if ((e as MouseEventArgs).Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition);

            }
        }

        private void bbi_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("COURSENO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要修改的课程！", "提示信息");
                return;
            }
            else
            {
                frmCOURSEADD frm = new frmCOURSEADD(id, StatusClass.Edit);
                frm.ShowDialog();
                ReadData();
            }            
        }

        private void bbi_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("COURSENO").ToString());
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

        private void sbt_Find_Click(object sender, EventArgs e)
        {
            ReadData();
        }

        private void sbt_Clear_Click(object sender, EventArgs e)
        {
            init_coursetype();
            this.te_coursename.Text = "";
        }

        private void sbt_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}