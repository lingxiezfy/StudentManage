namespace Student.Forms
{
    partial class frmSTU_JOBSTATUS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbb_ifcurrent = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.sbt_Quit = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_Find = new DevExpress.XtraEditors.SimpleButton();
            this.te_entname = new DevExpress.XtraEditors.TextEdit();
            this.te_stuname = new DevExpress.XtraEditors.TextEdit();
            this.te_stuno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tl_student = new DevExpress.XtraTreeList.TreeList();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_STATUSNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_STUNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_ENTNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_JOBTITLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_SALARY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_STATUSTIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_IF_CURRENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_MEMO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bbi_Add = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Edit = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_ifcurrent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_entname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stuname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stuno.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tl_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbb_ifcurrent);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.sbt_Quit);
            this.groupControl1.Controls.Add(this.sbt_Clear);
            this.groupControl1.Controls.Add(this.sbt_Find);
            this.groupControl1.Controls.Add(this.te_entname);
            this.groupControl1.Controls.Add(this.te_stuname);
            this.groupControl1.Controls.Add(this.te_stuno);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1270, 79);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "查询条件";
            // 
            // cbb_ifcurrent
            // 
            this.cbb_ifcurrent.Location = new System.Drawing.Point(705, 41);
            this.cbb_ifcurrent.Name = "cbb_ifcurrent";
            this.cbb_ifcurrent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_ifcurrent.Properties.Items.AddRange(new object[] {
            "未就业",
            "已就业"});
            this.cbb_ifcurrent.Size = new System.Drawing.Size(156, 20);
            this.cbb_ifcurrent.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(640, 44);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "是否就业";
            // 
            // sbt_Quit
            // 
            this.sbt_Quit.Location = new System.Drawing.Point(1215, 40);
            this.sbt_Quit.Name = "sbt_Quit";
            this.sbt_Quit.Size = new System.Drawing.Size(130, 23);
            this.sbt_Quit.TabIndex = 8;
            this.sbt_Quit.Text = "退出";
            this.sbt_Quit.Click += new System.EventHandler(this.sbt_Quit_Click);
            // 
            // sbt_Clear
            // 
            this.sbt_Clear.Location = new System.Drawing.Point(1062, 40);
            this.sbt_Clear.Name = "sbt_Clear";
            this.sbt_Clear.Size = new System.Drawing.Size(130, 23);
            this.sbt_Clear.TabIndex = 7;
            this.sbt_Clear.Text = "清空查询条件";
            this.sbt_Clear.Click += new System.EventHandler(this.sbt_Clear_Click);
            // 
            // sbt_Find
            // 
            this.sbt_Find.Location = new System.Drawing.Point(909, 40);
            this.sbt_Find.Name = "sbt_Find";
            this.sbt_Find.Size = new System.Drawing.Size(130, 23);
            this.sbt_Find.TabIndex = 6;
            this.sbt_Find.Text = "查询数据";
            this.sbt_Find.Click += new System.EventHandler(this.sbt_Find_Click);
            // 
            // te_entname
            // 
            this.te_entname.Location = new System.Drawing.Point(425, 41);
            this.te_entname.Name = "te_entname";
            this.te_entname.Size = new System.Drawing.Size(195, 20);
            this.te_entname.TabIndex = 5;
            // 
            // te_stuname
            // 
            this.te_stuname.Location = new System.Drawing.Point(255, 41);
            this.te_stuname.Name = "te_stuname";
            this.te_stuname.Size = new System.Drawing.Size(87, 20);
            this.te_stuname.TabIndex = 4;
            // 
            // te_stuno
            // 
            this.te_stuno.Location = new System.Drawing.Point(82, 41);
            this.te_stuno.Name = "te_stuno";
            this.te_stuno.Size = new System.Drawing.Size(87, 20);
            this.te_stuno.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(357, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "企业名称";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(184, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "学生姓名";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "学生学号";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1276, 502);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tl_student, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gridControl1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 88);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1270, 411);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tl_student
            // 
            this.tl_student.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl_student.Location = new System.Drawing.Point(3, 3);
            this.tl_student.Name = "tl_student";
            this.tl_student.OptionsBehavior.Editable = false;
            this.tl_student.OptionsBehavior.ReadOnly = true;
            this.tl_student.Size = new System.Drawing.Size(250, 405);
            this.tl_student.TabIndex = 0;
            this.tl_student.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.None;
            this.tl_student.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tl_student_FocusedNodeChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(259, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1008, 405);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_STATUSNO,
            this.gc_STUNO,
            this.gc_NAME,
            this.gc_ENTNAME,
            this.gc_JOBTITLE,
            this.gc_SALARY,
            this.gc_STATUS,
            this.gc_STATUSTIME,
            this.gc_IF_CURRENT,
            this.gc_MEMO});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gc_STATUSNO
            // 
            this.gc_STATUSNO.Caption = "编号";
            this.gc_STATUSNO.FieldName = "STATUSNO";
            this.gc_STATUSNO.Name = "gc_STATUSNO";
            // 
            // gc_STUNO
            // 
            this.gc_STUNO.Caption = "学生学号";
            this.gc_STUNO.FieldName = "STUNO";
            this.gc_STUNO.Name = "gc_STUNO";
            this.gc_STUNO.Visible = true;
            this.gc_STUNO.VisibleIndex = 0;
            // 
            // gc_NAME
            // 
            this.gc_NAME.Caption = "学生姓名";
            this.gc_NAME.FieldName = "NAME";
            this.gc_NAME.Name = "gc_NAME";
            this.gc_NAME.Visible = true;
            this.gc_NAME.VisibleIndex = 1;
            // 
            // gc_ENTNAME
            // 
            this.gc_ENTNAME.Caption = "企业名称";
            this.gc_ENTNAME.FieldName = "ENTNAME";
            this.gc_ENTNAME.Name = "gc_ENTNAME";
            this.gc_ENTNAME.Visible = true;
            this.gc_ENTNAME.VisibleIndex = 2;
            // 
            // gc_JOBTITLE
            // 
            this.gc_JOBTITLE.Caption = "职位";
            this.gc_JOBTITLE.FieldName = "JOBTITLE";
            this.gc_JOBTITLE.Name = "gc_JOBTITLE";
            this.gc_JOBTITLE.Visible = true;
            this.gc_JOBTITLE.VisibleIndex = 3;
            // 
            // gc_SALARY
            // 
            this.gc_SALARY.Caption = "薪金";
            this.gc_SALARY.FieldName = "SALARY";
            this.gc_SALARY.Name = "gc_SALARY";
            this.gc_SALARY.Visible = true;
            this.gc_SALARY.VisibleIndex = 4;
            // 
            // gc_STATUS
            // 
            this.gc_STATUS.Caption = "状态";
            this.gc_STATUS.FieldName = "STATUS";
            this.gc_STATUS.Name = "gc_STATUS";
            this.gc_STATUS.Visible = true;
            this.gc_STATUS.VisibleIndex = 5;
            // 
            // gc_STATUSTIME
            // 
            this.gc_STATUSTIME.Caption = "录入时间";
            this.gc_STATUSTIME.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.gc_STATUSTIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gc_STATUSTIME.FieldName = "STATUSTIME";
            this.gc_STATUSTIME.Name = "gc_STATUSTIME";
            this.gc_STATUSTIME.Visible = true;
            this.gc_STATUSTIME.VisibleIndex = 6;
            // 
            // gc_IF_CURRENT
            // 
            this.gc_IF_CURRENT.Caption = "是否就业";
            this.gc_IF_CURRENT.FieldName = "IF_CURRENT";
            this.gc_IF_CURRENT.Name = "gc_IF_CURRENT";
            this.gc_IF_CURRENT.Visible = true;
            this.gc_IF_CURRENT.VisibleIndex = 7;
            // 
            // gc_MEMO
            // 
            this.gc_MEMO.Caption = "备注";
            this.gc_MEMO.FieldName = "MEMO";
            this.gc_MEMO.Name = "gc_MEMO";
            this.gc_MEMO.Visible = true;
            this.gc_MEMO.VisibleIndex = 8;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Add),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Edit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Delete)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // bbi_Add
            // 
            this.bbi_Add.Caption = "增加就业记录";
            this.bbi_Add.Id = 0;
            this.bbi_Add.Name = "bbi_Add";
            this.bbi_Add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Add_ItemClick);
            // 
            // bbi_Edit
            // 
            this.bbi_Edit.Caption = "修改就业记录";
            this.bbi_Edit.Id = 1;
            this.bbi_Edit.Name = "bbi_Edit";
            this.bbi_Edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Edit_ItemClick);
            // 
            // bbi_Delete
            // 
            this.bbi_Delete.Caption = "删除就业记录";
            this.bbi_Delete.Id = 2;
            this.bbi_Delete.Name = "bbi_Delete";
            this.bbi_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Delete_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbi_Add,
            this.bbi_Edit,
            this.bbi_Delete});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1276, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 502);
            this.barDockControlBottom.Size = new System.Drawing.Size(1276, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 502);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1276, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 502);
            // 
            // frmSTU_JOBSTATUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmSTU_JOBSTATUS";
            this.Text = "学生就业信息管理";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_ifcurrent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_entname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stuname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stuno.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tl_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton sbt_Quit;
        private DevExpress.XtraEditors.SimpleButton sbt_Clear;
        private DevExpress.XtraEditors.SimpleButton sbt_Find;
        private DevExpress.XtraEditors.TextEdit te_entname;
        private DevExpress.XtraEditors.TextEdit te_stuname;
        private DevExpress.XtraEditors.TextEdit te_stuno;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraTreeList.TreeList tl_student;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_ifcurrent;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn gc_STATUSNO;
        private DevExpress.XtraGrid.Columns.GridColumn gc_STUNO;
        private DevExpress.XtraGrid.Columns.GridColumn gc_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn gc_ENTNAME;
        private DevExpress.XtraGrid.Columns.GridColumn gc_JOBTITLE;
        private DevExpress.XtraGrid.Columns.GridColumn gc_SALARY;
        private DevExpress.XtraGrid.Columns.GridColumn gc_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn gc_STATUSTIME;
        private DevExpress.XtraGrid.Columns.GridColumn gc_IF_CURRENT;
        private DevExpress.XtraGrid.Columns.GridColumn gc_MEMO;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem bbi_Add;
        private DevExpress.XtraBars.BarButtonItem bbi_Edit;
        private DevExpress.XtraBars.BarButtonItem bbi_Delete;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}