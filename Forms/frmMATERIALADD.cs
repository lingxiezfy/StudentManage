using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using DevExpress.XtraEditors;
using Student.DBUtility;

namespace Student.Forms
{
    public partial class frmMATERIALADD : DevExpress.XtraEditors.XtraForm
    {
        private StatusClass _enumStatus;
        private int _materialno;

        /// <summary>
        /// 构造方法
        /// </summary>
        public frmMATERIALADD()
        {
            InitializeComponent();
            this._enumStatus = StatusClass.AddNew;
        }
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="iID"></param>
        /// <param name="enumStatus"></param>
        public frmMATERIALADD(int iID, StatusClass enumStatus)
        {
            this._enumStatus = StatusClass.Edit;
            this._materialno = iID;
            InitializeComponent();
            this.Text = "修改材料信息";
            readData();
        }

        /// <summary>
        /// 读取数据
        /// </summary>
        private void readData()
        {
            if (this._materialno > 0)
            {
                BLL.MATERIAL_INFO materialBll = new BLL.MATERIAL_INFO();
                Model.MATERIAL_INFO materialMdl = new Model.MATERIAL_INFO();
                materialMdl = materialBll.GetModel(_materialno);
                if (materialMdl == null)
                {
                    blankData();
                }
                else
                {
                    this.te_materialname.Text = materialMdl.MATERIALNAME;
                    this.te_memo.Text = materialMdl.MEMO;
                }
            }
        }

        /// <summary>
        /// 清空数据
        /// </summary>
        private void blankData()
        {
            this.te_materialname.Text = "";
            this.te_memo.Text = "";
            this.be_model.Text = "";
        }

        /// <summary>
        /// 选择模板文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void be_model_MouseClick(object sender, MouseEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string safeFileName = openFileDialog1.SafeFileName;
                if (filename.ToUpper().EndsWith("DOC") || filename.ToUpper().EndsWith("DOCX"))
                {
                    this.be_model.Text = filename;
                }
                else
                {
                    MessageBox.Show("文件类型错误，请选择正确的Word文件 !", "文件错误");
                    this.be_model.Text = "";
                }
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
                BLL.MATERIAL_INFO materialBll = new BLL.MATERIAL_INFO();
                Model.MATERIAL_INFO materialMdl = new Model.MATERIAL_INFO();

                if (this.te_materialname.Text == "")
                {
                    MessageBox.Show("材料名称不能为空!", "提示信息");
                    return false;
                }
                
                if (this._enumStatus == StatusClass.AddNew)
                {
                    if (this.be_model.Text == "")
                    {
                        MessageBox.Show("材料模板不能为空!", "提示信息");
                        return false;
                    }
                    materialMdl.MATERIALNAME = this.te_materialname.Text;
                    materialMdl.MEMO = this.te_memo.Text;
                    string pathName = this.be_model.Text;
                    FileInfo fi = new FileInfo(pathName);
                    FileStream fs = fi.OpenRead();
                    byte[] buffByte = new byte[fs.Length];
                    fs.Read(buffByte, 0, (int)fs.Length);
                    fs.Close();
                    fs = null;

                    materialMdl.TEMPLATE = buffByte;
                    materialBll.Add(materialMdl);
                    return true;
                }
                else if (this._enumStatus == StatusClass.Edit)
                {
                    materialMdl.MATERIALNO = this._materialno;
                    materialMdl.MATERIALNAME = this.te_materialname.Text;
                    materialMdl.MEMO = this.te_memo.Text;
                    string pathName = this.be_model.Text;
                    if (pathName.Length <= 0)
                    {
                        materialBll.Update(materialMdl, 0);
                    }
                    else
                    {
                        FileInfo fi = new FileInfo(pathName);
                        FileStream fs = fi.OpenRead();
                        byte[] buffByte = new byte[fs.Length];
                        fs.Read(buffByte, 0, (int)fs.Length);
                        fs.Close();
                        fs = null;

                        materialMdl.TEMPLATE = buffByte;
                        materialBll.Update(materialMdl);
                    }
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

        private void sbt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}