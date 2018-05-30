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
    public partial class frmENTERPRISE : DevExpress.XtraEditors.XtraForm
    {
       

        public frmENTERPRISE()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        private void ReadData()
        {
            string condition = "";
            if (this.te_enteraddr.Text.Length > 0)
            {
                condition += " ENTADDRESS like '%" + this.te_enteraddr.Text + "%'";
            }
            if (this.te_entername.Text.Length > 0)
            {
                if(condition.Length > 0)
                    condition += " and entname like '%" + this.te_entername.Text + "%'";
                else 
                    condition += " entname like '%" + this.te_entername.Text + "%'";
            }           

            Student.BLL.ENTERPRISE_INFO enterBll = new Student.BLL.ENTERPRISE_INFO();
            this.gridControl1.DataSource = enterBll.GetList(condition).Tables[0];
            this.gridView1.BestFitColumns();
            DBUtility.ToolHelper.DrawRowIndicator(gridView1, 40);
            DBUtility.ToolHelper.SetLineColorofGridView(this.gridView1);
        }

        private void sbt_Find_Click(object sender, EventArgs e)
        {
            ReadData();
        }

        /// <summary>
        /// 清空查询条件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbt_Clear_Click(object sender, EventArgs e)
        {
            this.te_entername.Text = "";
            this.te_enteraddr.Text = "";
        }

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

        private void bbiAdd_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmENTERPRISEADD frm = new frmENTERPRISEADD();
            frm.ShowDialog();
            ReadData();
        }

        /// <summary>
        /// 弹出式菜单的“修改专业信息”按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("ENTNO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要修改的企业信息！", "提示信息");
                return;
            }
            else
            {
                frmENTERPRISEADD frm = new frmENTERPRISEADD(id, StatusClass.Edit);
                frm.ShowDialog();
                ReadData();
            }         
        }
        /// <summary>
        /// 弹出式菜单的“删除专业信息”按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiDelete_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("ENTNO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要删除的企业信息！", "提示信息");
                return;
            }
            else if (id == 1)
            {
                MessageBox.Show("该数据不允许删除！", "提示信息");
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
                BLL.STU_WORKFLOW stuworkflowBll = new STU_WORKFLOW();
                int recordCount = stuworkflowBll.GetRecordCount(" and ENTNO = " + id.ToString());
                if (recordCount > 0)
                {
                    MessageBox.Show("该企业信息已经被使用，不能被删除！", "提示信息");
                    return false;
                }
                else
                {
                    BLL.ENTERPRISE_INFO enterBll = new ENTERPRISE_INFO();
                    enterBll.Delete(id);
                    return true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("删除失败!", exception.Message);
                return false;
            }
        }

        private void frmENTERPRISE_Load(object sender, EventArgs e)
        {
            this.Text = "用人企业信息";
        }

        private void sbt_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}