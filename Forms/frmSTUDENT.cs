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
    public partial class frmSTUDENT : DevExpress.XtraEditors.XtraForm
    {
        public frmSTUDENT()
        {
            InitializeComponent();
            init_inyear();
            init_majordirct();
            init_class();
        }

        /// <summary>
        /// 初始化入学年份列表
        /// </summary>
        private void init_inyear()
        {
            BLL.STUDENT_INFO studentBll = new STUDENT_INFO();

            DataSet ds = studentBll.GetInYearList();
            this.cbb_inyear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbb_inyear.Properties.Items.Clear();
            cbb_inyear.EditValue = null;
            cbb_inyear.Properties.NullText = "--请选择--";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string inYear = ds.Tables[0].Rows[i]["InYear"].ToString();
                this.cbb_inyear.Properties.Items.Add(inYear);
            }
        }

        /// <summary>
        /// 初始化专业方向列表
        /// </summary>
        private void init_majordirct()
        {
            Student.BLL.MAJORDIRCT_INFO majordirctBll = new MAJORDIRCT_INFO();
            DataSet ds = majordirctBll.GetAllList();
            this.cbb_majordirct.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbb_majordirct.Properties.Items.Clear();
            cbb_majordirct.EditValue = null;
            cbb_majordirct.Properties.NullText = "--请选择--";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string majordirctName = ds.Tables[0].Rows[i]["MAJORDIRCTNAME"].ToString();
                this.cbb_majordirct.Properties.Items.Add(majordirctName);
            }
        }

        /// <summary>
        /// 初始化班级列表
        /// </summary>
        private void init_class()
        {
            Student.BLL.CLASS_INFO classBll = new CLASS_INFO();
            string majordirctname = "";
            DataSet ds = null;
            if (this.cbb_majordirct.SelectedIndex != -1)
            {
                majordirctname = this.cbb_majordirct.Properties.Items[this.cbb_majordirct.SelectedIndex].ToString();
            }
            if (majordirctname.Length > 0)
            {
                ds = classBll.GetList(" and B.MAJORDIRCTNAME = '" + majordirctname + "'");
            }
            else
            {
                ds = classBll.GetList("");
            }
            this.cbb_classno.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbb_classno.Properties.Items.Clear();
            cbb_classno.EditValue = null;
            cbb_classno.Properties.NullText = "--请选择--";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string className = ds.Tables[0].Rows[i]["CLASSNAME"].ToString();
                this.cbb_classno.Properties.Items.Add(className);
            }
        }


        private void ReadData()
        {
            string condition = "";

            if (this.te_stuno.Text.Length > 0)
            {
                condition += "and stuno like '%" + this.te_stuno.Text + "%'";
            }
            if (this.te_name.Text.Length > 0)
            {
                condition += "and name like '%" + this.te_name.Text + "%'";
            }
            if (this.te_dormitoryid.Text.Length > 0)
            {
                condition += "and B.DORMITORY_PLATE like '%" + this.te_dormitoryid.Text + "%'";
            }

            if (this.cbb_inyear.SelectedIndex != -1)
            {
                string inyear = this.cbb_inyear.Properties.Items[this.cbb_inyear.SelectedIndex].ToString();
                condition += "and left(A.STUNO,2) = right('" + inyear + "',2)";
            }

            string majordirctName = "";
            if (cbb_majordirct.SelectedIndex != -1)
            {
                majordirctName = cbb_majordirct.Properties.Items[cbb_majordirct.SelectedIndex].ToString();
                condition += " and D.MAJORDIRCTNAME = '" + majordirctName + "'";
            }

            string className = "";
            if (this.cbb_classno.SelectedIndex != -1)
            {
                className = cbb_classno.Properties.Items[cbb_classno.SelectedIndex].ToString();
                condition += " and C.CLASSNAME = '" + className + "'";
            }

            Student.BLL.STUDENT_INFO studentBll = new Student.BLL.STUDENT_INFO();
            this.gridControl1.DataSource = studentBll.GetList(condition).Tables[0];
            this.gridView1.BestFitColumns();
            DBUtility.ToolHelper.DrawRowIndicator(gridView1, 40);
            DBUtility.ToolHelper.SetLineColorofGridView(this.gridView1);
        }

        /// <summary>
        /// 弹出弹出式菜单
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
        /// 查询数据按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sbt_find_Click(object sender, EventArgs e)
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
            init_inyear();
            init_majordirct();
            init_class();
            this.te_name.Text = "";
            this.te_stuno.Text = "";
            this.te_dormitoryid.Text = "";
        }

        /// <summary>
        /// 新增学生信息菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSTUDENTADD frm = new frmSTUDENTADD();
            frm.ShowDialog();
            ReadData();
        }

        /// <summary>
        /// 修改学生信息菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string sid = "";
            if (this.gridView1.RowCount <= 0)
                return;
            sid = this.gridView1.GetFocusedRowCellValue("STUNO").ToString();
            if (sid.Length <= 0)
            {
                MessageBox.Show("请选择需要修改的学生信息！", "提示信息");
                return;
            }
            else
            {
                frmSTUDENTADD frm = new frmSTUDENTADD(sid, StatusClass.Edit);
                frm.ShowDialog();
                ReadData();
            }
        }

        /// <summary>
        /// 删除学生信息菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string id = "";
            if (this.gridView1.RowCount <= 0)
                return;
            id = this.gridView1.GetFocusedRowCellValue("STUNO").ToString();
            if (id.Length <= 0)
            {
                MessageBox.Show("请选择需要删除的学生！", "提示信息");
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
        private bool deleteData(string id)
        {
            try
            {
                BLL.TEA_STU teastuBll = new TEA_STU();
                int recordCount = teastuBll.GetRecordCount("stuno = " + id);
                if (recordCount > 0)
                {
                    MessageBox.Show("该学生信息已经被使用，不能被删除！", "提示信息");
                    return false;
                }
                else
                {
                    BLL.STUDENT_INFO studentBll = new STUDENT_INFO();
                    studentBll.Delete(id);
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
        /// 改变专业方向时初始化班级列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbb_majordirct_SelectedIndexChanged(object sender, EventArgs e)
        {
            init_class();
        }

        private void sbt_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
        
}