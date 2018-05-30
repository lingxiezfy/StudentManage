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

namespace Student.Forms
{
    public partial class frmTERM : DevExpress.XtraEditors.XtraForm
    {
        public frmTERM()
        {
            InitializeComponent();
        }

        //查询数据

        private void ReadData()
        {
            string condition = "";
            if (this.te_termname.Text.Length > 0)
            {
                condition += " termname like '%" + this.te_termname.Text + "%'";
            }
           
            Student.BLL.TERM_INFO tremBll = new Student.BLL.TERM_INFO();
            this.gridControl1.DataSource = tremBll.GetList(condition).Tables[0];
            this.gridviews.BestFitColumns();
            DBUtility.ToolHelper.DrawRowIndicator(gridviews, 40);
            DBUtility.ToolHelper.SetLineColorofGridView(this.gridviews);
        }
     
      
       
        private bool deleteData(int id)
        {
            try
            {
                Student.BLL.TERM_INFO majordirctinfobll = new Student.BLL.TERM_INFO();
                int recordCount = majordirctinfobll.GetRecordCount("termno = " + id.ToString());
                if (recordCount > 1)
                {
                    MessageBox.Show("该学期信息已经被使用，不能被删除！", "提示信息");
                    return false;
                }
                else
                {
                    BLL.TERM_INFO termbll = new Student.BLL.TERM_INFO();
                    termbll.Delete(id);
                    return true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("删除失败!", exception.Message);
                return false;
            }
        }

       

        private void sbtn_find_Click_1(object sender, EventArgs e)
        {
            ReadData();
        }

        private void sbtn_clear_Click_1(object sender, EventArgs e)
        {
            this.te_termname.Text = "";
        }

        private void frmTERM_Load(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {
            if ((e as MouseEventArgs).Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition); //弹出弹出式菜单

            }
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTERMADD frm = new frmTERMADD();
            frm.ShowDialog();
            ReadData();
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridviews.RowCount <= 0)
                return;
            id = Student.DBUtility.ToolHelper.ConvertToInt(this.gridviews.GetFocusedRowCellValue("TERMNO").ToString());
            if (id < 0)
            {
                MessageBox.Show("请选择需要删除的学期！", "提示信息");
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

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridviews.RowCount <= 0)
                return;
            id = Student.DBUtility.ToolHelper.ConvertToInt(this.gridviews.GetFocusedRowCellValue("TERMNO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要修改的学期！", "提示信息");
                return;
            }
            else
            {
                frmTERMADD frm = new frmTERMADD(id, StatusClass.Edit);
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