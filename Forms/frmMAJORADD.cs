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
using Student.Model;
using Student.DBUtility;

namespace Student.Forms
{
    public partial class frmMAJORADD : DevExpress.XtraEditors.XtraForm
    {
        private StatusClass _enumStatus;
        private int _majorno;

        /// <summary>
        /// 构造方法，新增专业功能可用
        /// </summary>
        public frmMAJORADD()
        {
            InitializeComponent();
            init_department();
            this._enumStatus = StatusClass.AddNew;
        }

        /// <summary>
        /// 构造方法，修改专业功能可用，iID为传过来的专业编号，enumStatus标识当前功能
        /// </summary>
        /// <param name="iID"></param>
        /// <param name="enumStatus"></param>
        public frmMAJORADD(int iID, StatusClass enumStatus)
        {
            this._enumStatus = StatusClass.Edit;     //修改专业信息
            this._majorno = iID;
            InitializeComponent();
            this.Text = "修改专业信息";              //修改界面title
            readData();                              //查询数据
        }

        /// <summary>
        /// 初始化窗体，取得学院名称到下拉列表
        /// </summary>
        private void init_department()
        {
            Student.BLL.DEPARTMENT_INFO departmentBll = new Student.BLL.DEPARTMENT_INFO();
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
        private void readData()
        {
            if (this._majorno > 0)
            {
                BLL.MAJOR_INFO majorbll = new BLL.MAJOR_INFO();
                Model.MAJOR_INFO majormdl = new Model.MAJOR_INFO();
                majormdl = majorbll.GetModel(_majorno);
                if (majormdl == null)   //新增专业功能时
                {
                    blankData();
                }
                else                   //修改专业功能时
                {
                    init_department();
                    this.te_majorname.Text = majormdl.MAJORNAME;
                    Student.Model.DEPARTMENT_INFO departmentmdl = new Model.DEPARTMENT_INFO();
                    Student.BLL.DEPARTMENT_INFO departmentbll = new BLL.DEPARTMENT_INFO();
                    departmentmdl = departmentbll.GetModel(majormdl.DEPARTMENTNO);
                    this.cbb_department.EditValue = departmentmdl.DEPARTMENTNAME;
                }
            }
        }

        /// <summary>
        /// 清空输入框数据
        /// </summary>
        private void blankData()
        {
            init_department();
            this.te_majorname.Text = "";
        }

        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbt_save_Click(object sender, EventArgs e)
        {
            if (saveData())
            {
                this.Close();
                return;
            }
        }

        /// <summary>
        /// 保存数据方法
        /// </summary>
        /// <returns></returns>
        private bool saveData()
        {
            try
            {
                BLL.MAJOR_INFO majorbll = new BLL.MAJOR_INFO();
                Model.MAJOR_INFO majormdl = new Model.MAJOR_INFO();
                Student.BLL.DEPARTMENT_INFO departmentbll = new BLL.DEPARTMENT_INFO();
                Student.Model.DEPARTMENT_INFO departmentmdl = new Model.DEPARTMENT_INFO();
                if (this.cbb_department.SelectedIndex != -1)
                {
                    departmentmdl = departmentbll.GetModel(this.cbb_department.Properties.Items[this.cbb_department.SelectedIndex].ToString());
                }

                if (this.te_majorname.Text == "")
                {
                    MessageBox.Show("专业名称不能为空!", "提示信息");
                    return false;
                }
                if (this.cbb_department.SelectedIndex == -1)
                {
                    MessageBox.Show("所属学院不能为空!", "提示信息");
                    return false;
                }

                majormdl.MAJORNAME = te_majorname.Text;
                majormdl.DEPARTMENTNO = departmentmdl.DEPARTMENTNO;

                if (this._enumStatus == StatusClass.AddNew)  //新增专业
                {                    
                    majorbll.Add(majormdl);
                    return true;
                }
                else if (this._enumStatus == StatusClass.Edit)  //修改专业
                {
                    majormdl.MAJORNO = this._majorno;
                    majorbll.Update(majormdl);
                    return true;
                }
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("保存失败!", exception.Message);
                return false;
            }
        }

        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}