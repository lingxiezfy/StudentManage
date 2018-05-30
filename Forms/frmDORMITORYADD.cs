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
    public partial class frmDORMITORYADD : DevExpress.XtraEditors.XtraForm
    {
        private StatusClass _enumStatus;
        private int _dormitoryid;

        public frmDORMITORYADD()
        {
            this._enumStatus = StatusClass.AddNew;
            InitializeComponent();
            this.Text = "增加宿舍信息";
            init_building();
        }

        public frmDORMITORYADD(int iID, StatusClass enumStatus)
        {
            this._enumStatus = StatusClass.Edit;         //修改宿舍信息
            this._dormitoryid = iID;
            InitializeComponent();
            this.Text = "修改宿舍信息";                  //修改界面title
            init_building();
            readData();                                  //查询数据
        }

        /// <summary>
        /// 初始化宿舍楼名称列表
        /// </summary>
        private void init_building()
        {
            Student.BLL.BUILDING_INFO buildingBll = new BLL.BUILDING_INFO();
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
        /// 读取数据方法
        /// </summary>
        private void readData()
        {
            if (this._dormitoryid > 0)
            {
                BLL.DORMITORY_INFO dormitoryBll = new BLL.DORMITORY_INFO();
                Model.DORMITORY_INFO dormitoryMdl = new Model.DORMITORY_INFO();

                dormitoryMdl = dormitoryBll.GetModel(_dormitoryid);
                if (dormitoryMdl == null)
                {
                    blankData();
                }
                else
                {
                    BLL.BUILDING_INFO buildingBll = new BLL.BUILDING_INFO();
                    Model.BUILDING_INFO buildingMdl = new Model.BUILDING_INFO();

                    buildingMdl = buildingBll.GetModel((int)dormitoryMdl.BUILDINGID);
                    this.cbb_buildingname.Text = buildingMdl.BUILDINGNAME;

                    this.te_plate.Text = dormitoryMdl.DORMITORY_PLATE;
                }
            }
        }

        /// <summary>
        /// 清空输入框数据
        /// </summary>
        private void blankData()
        {
            init_building();
            this.te_plate.Text = "";
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
                BLL.DORMITORY_INFO dormitoryBll = new BLL.DORMITORY_INFO();
                Model.DORMITORY_INFO dormitoryMdl = new Model.DORMITORY_INFO();

                BLL.BUILDING_INFO buildingBll = new BLL.BUILDING_INFO();
                Model.BUILDING_INFO buildingMdl = new Model.BUILDING_INFO();

                if (this.cbb_buildingname.Text == "--请选择--")
                {
                    MessageBox.Show("宿舍楼名称不能为空!", "提示信息");
                    return false;
                }

                if (this.te_plate.Text == "")
                {
                    MessageBox.Show("宿舍门牌号不能为空!", "提示信息");
                    return false;
                }

                buildingMdl = buildingBll.GetModel(this.cbb_buildingname.Text);
                dormitoryMdl.BUILDINGID = buildingMdl.BUILDINGID;
                dormitoryMdl.DORMITORY_PLATE = this.te_plate.Text;              

                if (this._enumStatus == StatusClass.AddNew)  //新增宿舍信息
                {
                    dormitoryBll.Add(dormitoryMdl);
                    return true;
                }
                else if (this._enumStatus == StatusClass.Edit)  //修改宿舍信息
                {
                    dormitoryMdl.DORMITORY_ID = _dormitoryid;
                    dormitoryBll.Update(dormitoryMdl);
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