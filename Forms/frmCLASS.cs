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
    public partial class frmCLASS : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public frmCLASS()
        {
            InitializeComponent();
            init_inyear();
            init_majordirct();
            init_teacher();
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
            this.cbb_majordirctname.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbb_majordirctname.Properties.Items.Clear();
            cbb_majordirctname.EditValue = null;
            cbb_majordirctname.Properties.NullText = "--请选择--";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string majordirctName = ds.Tables[0].Rows[i]["MAJORDIRCTNAME"].ToString();
                this.cbb_majordirctname.Properties.Items.Add(majordirctName);
            }  
        }

        /// <summary>
        /// 初始化所有教师列表
        /// </summary>
        private void init_teacher()
        {
            Student.BLL.TEACHER_INFO teacherBll = new TEACHER_INFO();
            DataSet ds = teacherBll.GetAllList();
            this.cbb_master.Properties.Items.Clear();
            this.cbb_organizer.Properties.Items.Clear();
            this.cbb_instructor.Properties.Items.Clear();
            cbb_master.EditValue = null;
            cbb_master.Properties.NullText = "--请选择--";
            cbb_organizer.EditValue = null;
            cbb_organizer.Properties.NullText = "--请选择--";
            cbb_instructor.EditValue = null;
            cbb_instructor.Properties.NullText = "--请选择--";
            cbb_inyear.EditValue = null;
            cbb_inyear.Properties.NullText = "--请选择--";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string teacherName = ds.Tables[0].Rows[i]["NAME"].ToString();
                this.cbb_master.Properties.Items.Add(teacherName);
                this.cbb_organizer.Properties.Items.Add(teacherName);
                this.cbb_instructor.Properties.Items.Add(teacherName);
            }
            this.cbb_inyear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbb_master.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbb_organizer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbb_instructor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        /// <summary>
        /// 查询数据方法
        /// </summary>
        private void ReadData()
        {
            string condition = "";
           
            if (this.cbb_master.SelectedIndex != -1 || cbb_master.Text != "--请选择--")
            {
                condition += "and D.NAME like '%" + this.cbb_master.Properties.Items[this.cbb_master.SelectedIndex].ToString() + "%' ";
            }
            if (this.cbb_instructor.SelectedIndex != -1 || cbb_instructor.Text != "--请选择--")
            {
                condition += "and E.NAME like '%" + this.cbb_instructor.Properties.Items[this.cbb_instructor.SelectedIndex].ToString() + "%' ";
            }
            if(this.cbb_organizer.SelectedIndex != -1 || cbb_organizer.Text != "--请选择--")
            {
                condition += "and F.NAME like '%" + this.cbb_organizer.Properties.Items[this.cbb_organizer.SelectedIndex].ToString() + "%' ";
            }

            if (this.cbb_inyear.SelectedIndex != -1)
            {
                condition += "and left(A.CLASSNAME,2) = right('" + this.cbb_inyear.Properties.Items[this.cbb_inyear.SelectedIndex].ToString() + "',2) ";
            }
            
            if (this.te_classname.Text.Length > 0)
            {
                condition += "and A.CLASSNAME like '%" + this.te_classname.Text + "%' ";
            }

            if (this.cbb_majordirctname.SelectedIndex != -1)
            {
                condition += "and B.MAJORDIRCTNAME like '%" + this.cbb_majordirctname.Properties.Items[this.cbb_majordirctname.SelectedIndex].ToString() + "%' ";
            }        
            

            Student.BLL.CLASS_INFO majorBll = new Student.BLL.CLASS_INFO();
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
            init_majordirct();
            init_teacher();
            init_inyear();
            this.te_classname.Text = "";
        }

        /// <summary>
        /// 弹出菜单
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
        /// 修改菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("CLASSNO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要修改的班级！", "提示信息");
                return;
            }
            else
            {
                frmCLASSADD frm = new frmCLASSADD(id, StatusClass.Edit);
                frm.ShowDialog();
                ReadData();
            }
        }

        /// <summary>
        /// 删除菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = 0;
            if (this.gridView1.RowCount <= 0)
                return;
            id = ToolHelper.ConvertToInt(this.gridView1.GetFocusedRowCellValue("CLASSNO").ToString());
            if (id < 1)
            {
                MessageBox.Show("请选择需要删除的班级！", "提示信息");
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
                BLL.STUDENT_INFO studentBll = new STUDENT_INFO();
                int recordCount = studentBll.GetRecordCount("CLASSNO = " + id.ToString());
                if (recordCount > 0)
                {
                    MessageBox.Show("该班级信息已经被使用，不能被删除！", "提示信息");
                    return false;
                }
                else
                {
                    BLL.CLASS_INFO classBll = new CLASS_INFO();
                    classBll.Delete(id);
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
        /// 增加菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCLASSADD frm = new frmCLASSADD();
            frm.ShowDialog();
            ReadData();
        }

        private void sbt_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}