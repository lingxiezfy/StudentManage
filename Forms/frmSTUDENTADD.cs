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
using System.IO;
using System.Drawing.Imaging;
using System.Text;

namespace Student.Forms
{
    public partial class frmSTUDENTADD : DevExpress.XtraEditors.XtraForm
    {
        private StatusClass _enumStatus;
        private string _stuno;
        public frmSTUDENTADD()
        {
            InitializeComponent();
            init_class();
            init_dormitory();
            this._enumStatus = StatusClass.AddNew;
            this.cbb_status.SelectedIndex = 0;
        }

        /// <summary>
        /// 构造方法，新增专业功能可用
        /// </summary>       
        public frmSTUDENTADD(string sID, StatusClass enumStatus)
        {
            this._enumStatus = StatusClass.Edit;     //修改专业信息
            this._stuno = sID;
            InitializeComponent();
            this.Text = "修改专业信息";              //修改界面title
            init_class();
            init_dormitory();
            readData();                              //查询数据
            this.te_stuno.ReadOnly = true;         //学生学号输入框只读，不可修改
        }

        /// <summary>
        /// 初始化班级列表
        /// </summary>
        private void init_class()
        {
            Student.BLL.CLASS_INFO classBll = new Student.BLL.CLASS_INFO();
            DataSet ds = classBll.GetAllList();
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

        /// <summary>
        /// 初始化宿舍列表
        /// </summary>
        private void init_dormitory()
        {
            Student.BLL.DORMITORY_INFO dormitoryBll = new Student.BLL.DORMITORY_INFO();
            DataSet ds = dormitoryBll.GetAllList();
            this.cbb_plate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            cbb_plate.Properties.Items.Clear();
            cbb_plate.EditValue = null;
            cbb_plate.Properties.NullText = "--请选择--";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string plateName = ds.Tables[0].Rows[i]["DORMITORY_PLATE"].ToString();
                this.cbb_plate.Properties.Items.Add(plateName);
            }
        }
        
        private void readData()
        {
            if (this._stuno.Length > 0)
            {
                BLL.STUDENT_INFO studentBll = new BLL.STUDENT_INFO();
                Model.STUDENT_INFO studentMdl = new Model.STUDENT_INFO();

                studentMdl = studentBll.GetModel(_stuno,"");
                if (studentMdl == null)   //新增专业功能时
                {
                    init_class();
                    init_dormitory();
                    blankData();
                }
                else                   //修改专业功能时
                {
                    BLL.CLASS_INFO classBll = new BLL.CLASS_INFO();
                    Model.CLASS_INFO classMdl = new Model.CLASS_INFO();
                    BLL.DORMITORY_INFO dormitoryBll = new BLL.DORMITORY_INFO();
                    Model.DORMITORY_INFO dormitoryMdl = new Model.DORMITORY_INFO();

                    init_class();
                    init_dormitory();

                    classMdl = classBll.GetModel((int)studentMdl.CLASSNO);
                    this.cbb_classno.Text = classMdl.CLASSNAME;
                    dormitoryMdl = dormitoryBll.GetModel((decimal)studentMdl.DORMITORY_ID);
                    this.cbb_plate.Text = dormitoryMdl.DORMITORY_PLATE;                    
                    this.te_stuno.Text = studentMdl.STUNO;
                    this.te_name.Text = studentMdl.NAME;
                    this.cbb_sex.Text = studentMdl.SEX;
                    this.cbb_nation.Text = studentMdl.NATION;
                    this.te_idcard.Text = studentMdl.IDCARD;
                    this.cbb_political.Text = studentMdl.POLITICAL;
                    this.cbb_source.Text = studentMdl.SOURCE;
                    this.te_email.Text = studentMdl.EMAIL;
                    this.te_zipcode.Text = studentMdl.ZIPCODE;
                    this.te_familyaddress.Text = studentMdl.FAMILYADDRESS;
                    this.te_phone.Text = studentMdl.PHONE;
                    this.te_familyphone.Text = studentMdl.FAMILYPHONE;
                    this.te_fatherphone.Text = studentMdl.FATHERPHONE;
                    this.te_motherphone.Text = studentMdl.MOTHERPHONE;
                    this.te_qqno.Text = studentMdl.QQNO;
                    this.te_micromessageno.Text = studentMdl.MICROMESSAGENO;
                    if (studentMdl.PICTURE != null)
                    {
                        byte[] b = (byte[])studentMdl.PICTURE;
                        if (b.Length > 0)
                        {
                            MemoryStream stream = new MemoryStream(b, true);
                            stream.Write(b, 0, b.Length);
                            this.pb_picture.Image = new Bitmap(stream);
                            stream.Close();
                        }
                    }
                    else
                    {
                        this.pb_picture.Image = null;
                    }

                    switch(studentMdl.STATUS)
                    {
                        case 1:
                            this.cbb_status.Text = "正常"; break;
                        case 2:
                            this.cbb_status.Text = "休学"; break;
                        case 3:
                            this.cbb_status.Text = "退学"; break;
                        case 4:
                            this.cbb_status.Text = "毕业"; break;
                    }
                }
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

        /// <summary>
        /// 清空输入框数据
        /// </summary>
        private void blankData()
        {
            init_class();
            init_dormitory();
            this.te_stuno.Text = "";
            this.te_name.Text = "";
            this.cbb_sex.Text = null;
            this.cbb_nation.Text = null;
            this.te_idcard.Text = "";
            this.cbb_political.Text = null;
            this.cbb_source.Text = null;
            this.te_email.Text = "";
            this.cbb_status.Text = "";
            this.te_zipcode.Text = "";
            this.te_familyaddress.Text = "";
            this.te_phone.Text = "";
            this.te_familyphone.Text = "";
            this.te_fatherphone.Text = "";
            this.te_motherphone.Text = "";
            this.te_qqno.Text = "";
            this.te_micromessageno.Text = "";
            this.pb_picture.Image = null;
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
        /// 将图像转换为byte
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        private byte[] GetImageBytes(Image image)
        {
            MemoryStream mstream = new MemoryStream();
            image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] byteData = new Byte[mstream.Length];
            mstream.Position = 0;
            mstream.Read(byteData, 0, byteData.Length);
            mstream.Close();
            return byteData;
        }

        /// <summary>
        /// 保存方法
        /// </summary>
        /// <returns></returns>
        private bool saveData()
        {
            try
            {
                BLL.CLASS_INFO classBll = new BLL.CLASS_INFO();
                Model.CLASS_INFO classMdl = new Model.CLASS_INFO();
                BLL.DORMITORY_INFO dormitoryBll = new BLL.DORMITORY_INFO();
                Model.DORMITORY_INFO dormitoryMdl = new Model.DORMITORY_INFO();
                BLL.STUDENT_INFO studentBll = new BLL.STUDENT_INFO();
                Model.STUDENT_INFO studentMdl = new Model.STUDENT_INFO();

                if (this.te_stuno.Text == "")
                {
                    MessageBox.Show("学生学号不能为空!", "提示信息");
                    return false;
                }

                if (!ToolHelper.IsNumeric(this.te_stuno.Text))
                {
                    MessageBox.Show("学生学号必须为数字!", "提示信息");
                    return false;
                }

                if (this.te_name.Text == "")
                {
                    MessageBox.Show("学生姓名不能为空!", "提示信息");
                    return false;
                }

                if (this.cbb_classno.SelectedIndex == -1)
                {
                    MessageBox.Show("学生所属班级不能为空!", "提示信息");
                    return false;
                }

                if(this.cbb_status.SelectedIndex == -1)
                {
                    MessageBox.Show("学生状态不能为空!", "提示信息");
                    return false;
                }

                if (this.cbb_plate.SelectedIndex == -1)
                {
                    MessageBox.Show("学生宿舍不能为空!", "提示信息");
                    return false;
                }

                classMdl = classBll.GetModel(this.cbb_classno.Properties.Items[this.cbb_classno.SelectedIndex].ToString());
                studentMdl.CLASSNO = classMdl.CLASSNO;
                dormitoryMdl = dormitoryBll.GetModel(this.cbb_plate.Properties.Items[this.cbb_plate.SelectedIndex].ToString());
                studentMdl.DORMITORY_ID = dormitoryMdl.DORMITORY_ID;
                studentMdl.NAME = te_name.Text;
                studentMdl.STUNO = this.te_stuno.Text;
                studentMdl.SEX = this.cbb_sex.Text;
                studentMdl.NATION = this.cbb_nation.Text;
                studentMdl.POLITICAL = this.cbb_political.Text;
                studentMdl.SOURCE = this.cbb_source.Text;
                studentMdl.PHONE = te_phone.Text;
                studentMdl.FATHERPHONE = te_fatherphone.Text;
                studentMdl.MOTHERPHONE = te_motherphone.Text;
                studentMdl.FAMILYPHONE = te_familyphone.Text;
                studentMdl.FAMILYADDRESS = te_familyaddress.Text;
                studentMdl.ZIPCODE = te_zipcode.Text;
                studentMdl.QQNO = te_qqno.Text;
                studentMdl.MICROMESSAGENO = te_micromessageno.Text;
                if (pb_picture.Image != null)
                {
                    byte[] imageBytes = GetImageBytes(pb_picture.Image);
                    studentMdl.PICTURE = imageBytes;
                }
                switch (this.cbb_status.Properties.Items[this.cbb_status.SelectedIndex].ToString())
                {
                    case "正常":
                        studentMdl.STATUS = 1;break;
                    case "休学":
                        studentMdl.STATUS = 2; break;
                    case "退学":
                        studentMdl.STATUS = 3; break;
                    case "毕业":
                        studentMdl.STATUS = 4; break;
                }

                if (this._enumStatus == StatusClass.AddNew)  //新增学生信息
                {
                    if (studentBll.Exists(te_stuno.Text))
                    {
                        MessageBox.Show("当前学生学号已经存在，请核查!", "提示信息");
                        return false;
                    }  
                    
                    studentBll.Add(studentMdl);
                    return true;
                }
                else if (this._enumStatus == StatusClass.Edit)  //修改姓名
                {
                    studentMdl.STUNO = _stuno;
                    studentBll.Update(studentMdl);
                    return true;
                }
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("保存失败!" + exception.Message, exception.Message);
                return false;
            }
        }

        private void sbt_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = ofd.FileName;

                if (filename.ToUpper().EndsWith("JPG"))
                {
                    this.pb_picture.Image = Image.FromFile(@filename);
                }
                else
                {
                    MessageBox.Show("文件类型错误，请选择正确的JPG文件 !", "文件错误");
                }
            }
        }

    }
}