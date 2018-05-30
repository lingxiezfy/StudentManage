using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Student.BLL;
using Student.Model;
using Student.DBUtility;


namespace Student.Forms
{
    public partial class frmBUILDINGADD : DevExpress.XtraEditors.XtraForm
    {
        private StatusClass _enumStatus;
        private int _buildingno;

        /// <summary>
        /// 构造方法，新增宿舍楼用
        /// 其中，_enumStatus为标识该功能为“新增”、“删除”、“修改”的，AddNew为新增
        /// </summary>
        public frmBUILDINGADD()
        {
            this._enumStatus = StatusClass.AddNew;
            InitializeComponent();
        }

        /// <summary>
        /// 构造方法，修改宿舍楼用
        /// </summary>
        /// <param name="iID"></param>
        /// <param name="enumStatus"></param>
         public frmBUILDINGADD(int iID, StatusClass enumStatus)
        {
            this._enumStatus = StatusClass.Edit;
            this._buildingno = iID;
            InitializeComponent();
            this.Text = "修改宿舍楼信息";
            readData();
        }

        /// <summary>
        /// 读取数据
        /// </summary>
        private void readData()
        {
            if (this._buildingno > 0)
            {
                BLL.BUILDING_INFO departmentBll = new BLL.BUILDING_INFO();
                Model.BUILDING_INFO departmentMdl = new Model.BUILDING_INFO();

                departmentMdl = departmentBll.GetModel(_buildingno);
                if (departmentMdl == null)
                {
                    blankData();
                }
                else
                {
                    this.te_buildingname.Text = departmentMdl.BUILDINGNAME;
                    this.te_floors.Text = ToolHelper.ConvertToString(departmentMdl.FLOORS);
                    this.te_admin.Text = departmentMdl.ADMIN;
                }
            }
        }

        /// <summary>
        /// 清空输入框
        /// </summary>
        private void blankData()
        {
            this.te_admin.Text = "";
            this.te_buildingname.Text = "";
            this.te_floors.Text = "";
        }


        /// <summary>
        /// 保存数据方法
        /// </summary>
        /// <returns></returns>
        private bool saveData()
        {
            try
            {
                BLL.BUILDING_INFO buildingBll = new BLL.BUILDING_INFO();
                Model.BUILDING_INFO buildingMdl = new Model.BUILDING_INFO();

                if (!ToolHelper.IsNumeric(this.te_floors.Text))
                {
                    MessageBox.Show("楼层数必须为数字!", "提示信息");
                    return false;
                }

                buildingMdl.BUILDINGID = _buildingno;
                buildingMdl.FLOORS = ToolHelper.ConvertToInt(this.te_floors.Text);
                buildingMdl.BUILDINGNAME = this.te_buildingname.Text;
                buildingMdl.ADMIN = this.te_admin.Text;

                if (this._enumStatus == StatusClass.AddNew)
                {                                        
                    buildingBll.Add(buildingMdl);
                    return true;
                }
                else if (this._enumStatus == StatusClass.Edit)
                {                   
                   buildingBll.Update(buildingMdl);
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
        private void sbt_Save_Click(object sender, EventArgs e)
        {
            if (saveData())
            {
                this.Close();
                return;
            }
        }
        private void sbt_clear_Click(object sender, EventArgs e)
        {
            blankData();
        }

        private void sbt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

    }
}
