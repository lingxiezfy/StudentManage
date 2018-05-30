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
    public partial class frmMAJORDIRCTADD : DevExpress.XtraEditors.XtraForm
    {
        private StatusClass _enumStatus;
        private int _majordirctno;

        public frmMAJORDIRCTADD()
        {
            InitializeComponent();
            init();
        }

       /// <summary>
        /// 构造方法，修改专业功能可用，iID为传过来的专业编号，enumStatus标识当前功能
        /// </summary>
        /// <param name="iID"></param>
        /// <param name="enumStatus"></param>
        public frmMAJORDIRCTADD(int iID, StatusClass enumStatus)
        {
            this._enumStatus = StatusClass.Edit;     //修改专业信息
            this._majordirctno = iID;
            InitializeComponent();
            this.Text = "修改专业方向信息";              //修改界面title
            readData();                              //查询数据
        }

        /// <summary>
        /// 初始化窗体，取得专业名称到下拉列表
        /// </summary>
        private void init()
        {
            Student.BLL.MAJOR_INFO majorBll = new Student.BLL.MAJOR_INFO();
            DataSet ds = majorBll.GetAllList();
            this.cbb_majorname.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbb_majorname.Properties.Items.Clear();
            cbb_majorname.EditValue = null;
            cbb_majorname.Properties.NullText = "--请选择--";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string majorName = ds.Tables[0].Rows[i]["majorname"].ToString();
                this.cbb_majorname.Properties.Items.Add(majorName);
            }
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        private void readData()
        {
            if (this._majordirctno > 0)
            {
                BLL.MAJORDIRCT_INFO majordirctBll = new BLL.MAJORDIRCT_INFO();
                Model.MAJORDIRCT_INFO majordirctMdl = new Model.MAJORDIRCT_INFO();
                majordirctMdl = majordirctBll.GetModel(_majordirctno);
                if (majordirctMdl == null)   //新增专业方向功能时
                {
                    init();
                    blankData();
                }
                else                   //修改专业方向功能时
                {
                    init();
                    this.te_majordirctname.Text = majordirctMdl.MAJORDIRCTNAME;
                    Student.Model.MAJOR_INFO majorMdl = new Model.MAJOR_INFO();
                    Student.BLL.MAJOR_INFO majorBll = new BLL.MAJOR_INFO();
                    majorMdl = majorBll.GetModel((int)majordirctMdl.MAJORNO);
                    this.cbb_majorname.EditValue = majorMdl.MAJORNAME;
                }
            }
        }

        /// <summary>
        /// 清空输入框数据
        /// </summary>
        private void blankData()
        {
            this.te_majordirctname.Text = "";
            init();
        }

        /// <summary>
        /// 保存数据方法
        /// </summary>
        /// <returns></returns>
        private bool saveData()
        {
            try
            {
                BLL.MAJOR_INFO majorBll = new BLL.MAJOR_INFO();
                Model.MAJOR_INFO majorMdl = new Model.MAJOR_INFO();
                Student.BLL.MAJORDIRCT_INFO majordirctBll = new BLL.MAJORDIRCT_INFO();
                Student.Model.MAJORDIRCT_INFO majordirctMdl = new Model.MAJORDIRCT_INFO();

                if (this.cbb_majorname.SelectedIndex != -1)
                {
                    majorMdl = majorBll.GetModel(this.cbb_majorname.Properties.Items[this.cbb_majorname.SelectedIndex].ToString());
                }

                if (this.te_majordirctname.Text == "")
                {
                    MessageBox.Show("专业方向名称不能为空!", "提示信息");
                    return false;
                }
                if (this.cbb_majorname.SelectedIndex == -1)
                {
                    MessageBox.Show("所属专业不能为空!", "提示信息");
                    return false;
                }
                if (this._enumStatus == StatusClass.AddNew)  //新增专业
                {
                    majordirctMdl.MAJORDIRCTNAME = this.te_majordirctname.Text;
                    majordirctMdl.MAJORNO = majorMdl.MAJORNO;
                    majordirctBll.Add(majordirctMdl);
                    return true;
                }
                else if (this._enumStatus == StatusClass.Edit)  //修改专业
                {
                    majordirctMdl.MAJORDIRCTNO = this._majordirctno;
                    majordirctMdl.MAJORDIRCTNAME = this.te_majordirctname.Text;
                    majordirctMdl.MAJORNO = majorMdl.MAJORNO;
                    majordirctBll.Update(majordirctMdl);
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

        private void sbtn_Save_Click(object sender, EventArgs e)
        {
            if (saveData())
            {
                this.Close();
                return;
            }
        }

        private void sbtn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}