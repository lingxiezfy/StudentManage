using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Student.Forms;
using DevExpress.XtraEditors;
using Student.Model;
using Student.BLL;
using System.Threading;

namespace Student
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            //ribbonControl1.ExpandCollapseItem
            //ribbonControl1.ExpandCollapseItem.
            //ExpandCollapseItem
            //this.ribbonControl1.ExpandCollapseItem.
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbonControl1.Minimized = false;
            //this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
        }

        

        private void bbiNewTask_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        void showFrm(string sFrmName)
        {
            XtraForm form = this.CheckChildForm(sFrmName);
            if (form != null)
            {
                form.Activate();
                return;
            }

            switch (sFrmName)
            {  
                //学期设置
                case "TERM":
                    form = new frmTERM();
                    break;
                //学院管理
                case "DEPARTMENT":
                    form = new frmDEPARTMENT();
                    break;
                //专业管理
                case "MAJOR":
                    form = new frmMAJOR();
                    break;
                //专业方向管理
                case "MAJORDIRCT":
                    form = new frmMAJORDIRCT();
                    break;
                //班级管理
                case "CLASS":
                    form = new frmCLASS();
                    break;

                //工作流管理
                case "WORKFLOW":
                    form = new frmWORKFLOW();
                    break;
                //工作节点管理
                case "WORKNODE":
                    form = new frmWORKNODE();
                    break;

                //工作流设置
                case "WORKFLOWSET":
                    form = new frmWORKFLOWSET();
                    break;
                //课程类型管理
                case "COURSE_TYPE":
                    form = new frmCOURSE_TYPE();
                    break;
                //课程信息管理
                case "COURSE":
                    form = new frmCOURSE();
                    break;
                //材料信息管理
                case "MATERIAL":
                    form = new frmMATERIAL();
                    break;
                //节点材料信息设置
                case "NODEMATERIALS":
                    form = new frmNODEMATERIALS();
                    break;
                //宿舍楼管理
                case "BUILDING":
                    form = new frmBUILDING();
                    break;
                //宿舍信息管理
                case "DORMITORY":
                    form = new frmDORMITORY();
                    break;
                //学生信息管理
                case "STUDENT":
                    form = new frmSTUDENT();
                    break;
                //教师信息管理
                case "TEACHER":
                    form = new frmTEACHER();
                    break;
                //学生实习管理
                case "TEA_STU":
                    form = new frmTEA_STU();
                    break;
                //学生实习材料管理
                case "STU_MATERIALS":
                    form = new frmSTU_MATERIALS();
                    break;
                //企业管理
                case "ENTERPRISE":
                    form = new frmENTERPRISE();
                    break;
                //学生就业信息管理
                case "STU_JOBSTATUS":
                    form = new frmSTU_JOBSTATUS();
                    break;

                case "COMPETITION_GROUP":
                    form = new frmCOMPETITION_GROUP();
                    break;

                //登录管理
                case "ReLogin":
                    ReLoginSys();//调用重新登陆系统的方法
                    return;
                    

                default:
                    return;
            }
            form.MdiParent = this;
            form.Tag = sFrmName;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
            form.BringToFront();
            return;
        }

        public void ReLoginSys()
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("您确认要重新登陆吗？？", "提示信息", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //首先将所有mdi的子窗口关闭
                foreach (XtraForm form in base.MdiChildren)
                {
                    form.Close();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
                this.Dispose();
            }
        }

        public void loadInitForm()
        {
            /*DevExpress.Utils.WaitDialogForm WaitBeforeLogin = null;
            //弹出登录提示画面  
            Thread t = new Thread((ThreadStart)delegate
            {
                WaitBeforeLogin = new DevExpress.Utils.WaitDialogForm("请稍候...", "正在加载应用系统");
                Application.Run(WaitBeforeLogin);
            });
            t.Start();
            
            //MyWaitDialogForm dialog = new MyWaitDialogForm();

            //IList<MenuMdl> userWinMenu = new MenuBll().GetUserWinMenu(AppGlo.CurUser.USER_CDE);
            //this.SetWinMenu(userWinMenu);
            //showFrm("RealTimeQuery");

            //dialog.Close();

            WaitBeforeLogin.Invoke((EventHandler)delegate { WaitBeforeLogin.Close(); });    // 关闭加载进度窗口*/
             
        }

        public XtraForm CheckChildForm(string sFrmName)
        {
            foreach (XtraForm form in base.MdiChildren)
            {
                if (form.Tag.ToString() != "AppMain")
                {
                    if (form.Tag.ToString() == sFrmName)
                    {
                        return form;
                    }
                }
            }
            return null;
        }

        //private void SetWinMenu(IList<MenuMdl> menus)
        //{
            //this.bbiDepartmentInfo.Enabled = false;
            //this.bbiMajorInfo.Enabled = false;
            //this.bbiClassInfo.Enabled = false;
            //this.bbiStudentInfo.Enabled = false;
            //this.bbiTeacherInfo.Enabled = false;
            //this.bbiMajorDirectionInfo.Enabled = false;
            //this.bbiTermInfo.Enabled = false;
            //this.bbiBzData.Enabled = false;
            //this.bbiWorkFlowInfo.Enabled = false;
            //this.bbiNodeInfo.Enabled = false;
            //this.bbiWorkFlowNode.Enabled = false;
            //this.bbiMaterialsInfo.Enabled = false;
            //this.bbiQdjd.Enabled = false;
            //this.bbiLjyjjd.Enabled = false;
            //this.bbiSkjd.Enabled = false;
            //this.bbiDcjd.Enabled = false;
            //this.bbiDhxjd.Enabled = false;
            //this.bbiCxcljd.Enabled = false;
            //this.bbiHxzm.Enabled = false;
            //this.bbiJbdjd.Enabled = false;
            //this.bbiJzzjd.Enabled = false;
            //this.bbiLjjd.Enabled = false;
            //this.bbiJxdmjd.Enabled = false;
            //this.bbiTxdm.Enabled = false;
            //this.bbiYyhtjd.Enabled = false;
            //this.bbiWyhdjd.Enabled = false;
            //this.bbiMtxdm.Enabled = false;
            //this.bbiEnterpriseInfo.Enabled = false;
            //this.bbiStudentJob.Enabled = false;
            //this.bbiTskRealData.Enabled = false;
            //this.bsiNavigation.Enabled = false;
            //this.bbiPswd.Enabled = false;
            //this.bbiNodeMaterials.Enabled = false;
            //this.bbiStudentPractice.Enabled = false;

            ////由于目前暂未使用该节点信息，将最后一组的button设置为不可见
            //this.bbiLjjd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //this.bbiSkjd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //this.bbiTxdm.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //this.bbiYyhtjd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //this.bbiWyhdjd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            //this.bbiMtxdm.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            //foreach (MenuMdl info in menus)
            //{
            //    switch (info.Para)
            //    {
            //        case "DayReportImp":
            //            this.bbiDepartmentInfo.Enabled = true;
            //            break;

            //        case "WaterDataImp":
            //            this.bbiMajorInfo.Enabled = true;
            //            break;           
            //    }
            //}
       // }

        

        private void frmMain_Load(object sender, EventArgs e)
        {
            loadInitForm();
        }

        private void bsiNavigation_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("Navigation");
        }

       

        private void bbiPswd_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("Pswd");
        }

       

        private void bbiReLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("ReLogin");
        }



        private void bbiMajorDirectionInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("MAJORDIRCT");
        }

        private void bbiTermInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("TERM");
        }

        private void bbiWorkFlowInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("WORKFLOW");
        }

        private void bbiNodeInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("WORKNODE");
        }

        private void bbiWorkFlowNode_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("WORKFLOWSET");
        }

        private void bbiEnterpriseInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("ENTERPRISE");
        }

        private void bbiStudentJob_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("STU_JOBSTATUS");
        }
       
        private void bbiDepartmentInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("DEPARTMENT");
        }

        private void bbiMajorInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("MAJOR");
        }

        private void bbiClassInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("CLASS");
        }

        private void bbiStudentInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("STUDENT");
        }

        private void bbiTeacherInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("TEACHER");
        }

        private void bbiMaterialsInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("MATERIAL");
        }       

        private void bbiNodeMaterials_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("NODEMATERIALS");
        }

        private void bbiStudentPractice_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("TEA_STU");
        }

        private void bbiCourseTypeInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("COURSE_TYPE");
        }

        private void bbiCourseInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("COURSE");
        }

        private void bbiSystemSet_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbiColorMixer_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbi_building_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("BUILDING");
        }

        private void bbi_dormitory_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("DORMITORY");
        }

        private void barStu_Materials_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("STU_MATERIALS");
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void bbi_competiongroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("COMPETITION_GROUP"); 
        }

        private void bbiStuMaterials_ItemClick(object sender, ItemClickEventArgs e)
        {
            showFrm("STU_MATERIALS");
        }

       
    }
}