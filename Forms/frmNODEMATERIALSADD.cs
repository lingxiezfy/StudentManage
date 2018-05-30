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
    public partial class frmNODEMATERIALSADD : DevExpress.XtraEditors.XtraForm
    {
        private int _nodematerialsno;
        private Model.NODEMATERIALSADD nodematerialsaddMdl;
        private StatusClass _enumStatus;

        public frmNODEMATERIALSADD()
        {
            InitializeComponent();
        }

        public frmNODEMATERIALSADD(Model.NODEMATERIALSADD nodematerialsaddMdl, StatusClass enumStatus)
        {
            InitializeComponent();
            this.nodematerialsaddMdl = nodematerialsaddMdl;
            this.te_nodename.Text = nodematerialsaddMdl.NODENAME;
            this._nodematerialsno = nodematerialsaddMdl.NODEMATERIALSNO;
            this._enumStatus = enumStatus;
            init();
            if (enumStatus == StatusClass.AddNew)
            {                
                this.Text = "增加节点材料信息";
            }
            else
            {
                this.Text = "修改节点材料信息";
            }
        }

        //新增时初始化节点列表
        public void init()
        {
            BLL.MATERIAL_INFO materialBll = new BLL.MATERIAL_INFO();
            Model.MATERIAL_INFO materialMdl = new Model.MATERIAL_INFO();

            BLL.WORKNODE worknodeBll = new BLL.WORKNODE();
            Model.WORKNODE worknodeMdl = new Model.WORKNODE();

            BLL.TEACHER_INFO teacherBll = new BLL.TEACHER_INFO();
            Model.TEACHER_INFO teacherMdl = new Model.TEACHER_INFO();

            if (_enumStatus == StatusClass.AddNew)
            {
                //初始化材料名称下拉列表数据
                worknodeMdl = worknodeBll.GetModel(nodematerialsaddMdl.NODENAME);
                int nodeno = worknodeMdl.NODENO;
                DataSet materialds = materialBll.GetList(" MATERIALNO not in(select MATERIALNO from NODEMATERIALS  where NODENO  = " + nodeno.ToString() + " and MATERIALNO is not null)");
                this.cbb_materialname.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                cbb_materialname.Properties.Items.Clear();
                cbb_materialname.EditValue = null;
                cbb_materialname.Properties.NullText = "--请选择--";
                for (int i = 0; i < materialds.Tables[0].Rows.Count; i++)
                {
                    string materialname = materialds.Tables[0].Rows[i]["MATERIALNAME"].ToString();
                    this.cbb_materialname.Properties.Items.Add(materialname);
                }

                //初始化教师姓名下拉列表数据
                DataSet teacherds = teacherBll.GetAllList();
                this.cbb_name.Properties.Items.Clear();
                cbb_name.EditValue = null;
                cbb_name.Properties.NullText = "--请选择--";
                for (int i = 0; i < teacherds.Tables[0].Rows.Count; i++)
                {
                    string teachername = teacherds.Tables[0].Rows[i]["NAME"].ToString();
                    this.cbb_name.Properties.Items.Add(teachername);
                }
            }
            else if (_enumStatus == StatusClass.Edit)
            {
                //初始化材料名称下拉列表数据
                worknodeMdl = worknodeBll.GetModel(nodematerialsaddMdl.NODENAME);
                int nodeno = worknodeMdl.NODENO;
                DataSet materialds = materialBll.GetList(" MATERIALNO not in(select MATERIALNO from NODEMATERIALS  where NODENO  = " + nodeno.ToString() + " and MATERIALNO is not null)");
                this.cbb_materialname.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                cbb_materialname.Properties.Items.Clear();
                cbb_materialname.EditValue = nodematerialsaddMdl.MATERIALNAME;
                for (int i = 0; i < materialds.Tables[0].Rows.Count; i++)
                {
                    string materialname = materialds.Tables[0].Rows[i]["MATERIALNAME"].ToString();
                    this.cbb_materialname.Properties.Items.Add(materialname);
                }
                this.cbb_materialname.Properties.Items.Add(nodematerialsaddMdl.MATERIALNAME);

                //初始化教师姓名下拉列表数据
                DataSet teacherds = teacherBll.GetAllList();
                this.cbb_name.Properties.Items.Clear();
                cbb_name.EditValue = nodematerialsaddMdl.NAME;
                for (int i = 0; i < teacherds.Tables[0].Rows.Count; i++)
                {
                    string teachername = teacherds.Tables[0].Rows[i]["NAME"].ToString();
                    this.cbb_name.Properties.Items.Add(teachername);
                }

                this.te_nodename.Text = nodematerialsaddMdl.NODENAME;
                this.de_begintime.Text = nodematerialsaddMdl.BEGINTIME.ToString();
                this.de_endtime.Text = nodematerialsaddMdl.ENDTIME.ToString();
                this.te_memo.Text = nodematerialsaddMdl.MEMO;
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

                BLL.WORKNODE worknodeBll = new BLL.WORKNODE();
                Model.WORKNODE worknodeMdl = new Model.WORKNODE();

                BLL.TEACHER_INFO teacherBll = new BLL.TEACHER_INFO();
                Model.TEACHER_INFO teacherMdl = new Model.TEACHER_INFO();

                BLL.NODEMATERIALS nodematerialsBll = new BLL.NODEMATERIALS();
                Model.NODEMATERIALS nodematerialsMdl = new Model.NODEMATERIALS();

                if (this.cbb_materialname.Text  == "")
                {
                    MessageBox.Show("材料信息不能为空!", "提示信息");
                    return false;
                }

                if (this.cbb_name.Text == "")
                {
                    MessageBox.Show("负责教师不能为空!", "提示信息");
                    return false;
                }

                if (this.de_begintime.Text == "")
                {
                    MessageBox.Show("开始日期不能为空!", "提示信息");
                    return false;
                }

                if (this.de_endtime.Text == "")
                {
                    MessageBox.Show("截止日期不能为空!", "提示信息");
                    return false;
                }

                //获取工作节点编号                    
                worknodeMdl = worknodeBll.GetModel(this.te_nodename.Text);
                int nodeno = worknodeMdl.NODENO;
                nodematerialsMdl.NODENO = nodeno;

                //获取材料编号
                materialMdl = materialBll.GetModel(this.cbb_materialname.Text);
                nodematerialsMdl.MATERIALNO = materialMdl.MATERIALNO;

                //获取教师编号
                teacherMdl = teacherBll.GetModel(this.cbb_name.Text);
                nodematerialsMdl.TEACHERNO = teacherMdl.TEACHERNO;

                nodematerialsMdl.BEGINTIME = ToolHelper.ConvertToDateTime(this.de_begintime.Value);
                nodematerialsMdl.ENDTIME = ToolHelper.ConvertToDateTime(this.de_endtime.Value);
                nodematerialsMdl.MEMO = this.te_memo.Text;

                if (this._enumStatus == StatusClass.AddNew)  //新增节点材料信息
                {       
                    nodematerialsBll.Add(nodematerialsMdl);
                    return true;
                }
                else if (this._enumStatus == StatusClass.Edit)  //修改节点材料信息
                {

                    nodematerialsMdl.NODEMATERIALSNO = _nodematerialsno;
                    nodematerialsBll.Update(nodematerialsMdl);
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