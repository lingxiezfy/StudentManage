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
    public partial class frmMAJORDIRCT : DevExpress.XtraEditors.XtraForm
    {
        public frmMAJORDIRCT()
        {
            InitializeComponent();
            init();
        }

        /// <summary>
        /// 初始化窗体，取得专业名称到列表
        /// </summary>
        private void init()
        {
            Student.BLL.MAJOR_INFO majorBll = new MAJOR_INFO();
            DataSet ds = majorBll.GetAllList();
            this.cbb_major.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbb_major.Properties.Items.Clear();
            cbb_major.EditValue = null;
            cbb_major.Properties.NullText = "--请选择--";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string majorName = ds.Tables[0].Rows[i]["MAJORNAME"].ToString();
                this.cbb_major.Properties.Items.Add(majorName);
            }
        }

        private void simpleButton1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        //查询数据
        private void ReadData()
        {
            string condition = "";
            if (this.cbb_major.SelectedIndex != -1)
            {
                condition += "and B.MAJORNAME like '%" + this.cbb_major.Properties.Items[this.cbb_major.SelectedIndex].ToString() + "%'";
            }
            if (this.te_majordirctname.Text.Length > 0)
            {
                condition += " and A.majordirctname like '%" + this.te_majordirctname.Text + "%'";
            }
            
            Student.BLL.MAJORDIRCT_INFO majordirctBll = new Student.BLL.MAJORDIRCT_INFO();
            this.gridControl1.DataSource = majordirctBll.GetList(condition).Tables[0];
            this.gridView1.BestFitColumns();
            DBUtility.ToolHelper.DrawRowIndicator(gridView1, 40);
            DBUtility.ToolHelper.SetLineColorofGridView(this.gridView1);
        }

        private void sbtn_Find_Click(object sender, EventArgs e)
        {
            ReadData();
        }

        /// <summary>
        ///  Grid的鼠标右键单击事件
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

       
        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
        /// <summary>
        /// 弹出式菜单的“修改专业方向信息”按钮
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
                MessageBox.Show("请选择需要修改的专业方向！", "提示信息");
                return;
            }
            else
            {
                frmMAJORADD frm = new frmMAJORADD(id, StatusClass.Edit);
                frm.ShowDialog();
                ReadData();
            }
        }

        private void frmMAJORDIRCT_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        ///  清空查询条件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            init();
            this.te_majordirctname.Text = "";
        }

        private void te_majordirctno_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void bbi_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMAJORDIRCTADD frm = new frmMAJORDIRCTADD();
            frm.ShowDialog();
            ReadData();
        }

        private void bbi_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("MAJORDIRCTNO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要修改的专业方向信息！", "提示信息");
                return;
            }
            else
            {
                frmMAJORDIRCTADD frm = new frmMAJORDIRCTADD(id, StatusClass.Edit);
                frm.ShowDialog();
                ReadData();
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
                BLL.CLASS_INFO classBll = new CLASS_INFO();
                int recordCount = classBll.GetRecordCount("CLASSNO = " + id.ToString());
                if (recordCount > 0)
                {
                    MessageBox.Show("该专业方向信息已经被使用，不能被删除！", "提示信息");
                    return false;
                }
                else
                {
                    BLL.MAJORDIRCT_INFO majordirctBll = new MAJORDIRCT_INFO();
                    majordirctBll.Delete(id);
                    return true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("删除失败!", exception.Message);
                return false;
            }
        }

        private void bbi_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("MAJORDIRCTNO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要删除的专业方向！", "提示信息");
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

        private void gridControl1_Click_1(object sender, EventArgs e)
        {
            if ((e as MouseEventArgs).Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition); //弹出弹出式菜单

            }
        }

        private void sbt_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}