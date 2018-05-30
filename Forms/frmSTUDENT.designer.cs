namespace Student.Forms
{
    partial class frmSTUDENT
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
            this.cbb_inyear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.te_dormitoryid = new DevExpress.XtraEditors.TextEdit();
            this.te_name = new DevExpress.XtraEditors.TextEdit();
            this.name = new DevExpress.XtraEditors.LabelControl();
            this.dormitory_id = new DevExpress.XtraEditors.LabelControl();
            this.Sbt_clear = new DevExpress.XtraEditors.SimpleButton();
            this.Sbt_find = new DevExpress.XtraEditors.SimpleButton();
            this.te_stuno = new DevExpress.XtraEditors.TextEdit();
            this.cbb_classno = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbb_majordirct = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_STUNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_CLASSNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_DORMITORY_PLATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_MAJORDIRCTNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_idcard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_sex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_nation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_political = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_source = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_intenteddate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pc_graduationdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pc_phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pc_email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_fatherphone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_motherphone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_familyphone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_familyaddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_zipcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_qqno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_micromessageno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_picture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sbt_Quit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_inyear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_dormitoryid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stuno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_classno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_majordirct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.sbt_Quit);
            this.groupControl1.Controls.Add(this.cbb_inyear);
            this.groupControl1.Controls.Add(this.te_dormitoryid);
            this.groupControl1.Controls.Add(this.te_name);
            this.groupControl1.Controls.Add(this.name);
            this.groupControl1.Controls.Add(this.dormitory_id);
            this.groupControl1.Controls.Add(this.Sbt_clear);
            this.groupControl1.Controls.Add(this.Sbt_find);
            this.groupControl1.Controls.Add(this.te_stuno);
            this.groupControl1.Controls.Add(this.cbb_classno);
            this.groupControl1.Controls.Add(this.cbb_majordirct);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1156, 104);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "查询条件";
            // 
            // cbb_inyear
            // 
            this.cbb_inyear.Location = new System.Drawing.Point(81, 34);
            this.cbb_inyear.MenuManager = this.barManager1;
            this.cbb_inyear.Name = "cbb_inyear";
            this.cbb_inyear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_inyear.Size = new System.Drawing.Size(113, 20);
            this.cbb_inyear.TabIndex = 15;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiAdd,
            this.bbiEdit,
            this.bbiDelete});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1162, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 508);
            this.barDockControlBottom.Size = new System.Drawing.Size(1162, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 508);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1162, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 508);
            // 
            // bbiAdd
            // 
            this.bbiAdd.Caption = "添加学生信息";
            this.bbiAdd.Id = 0;
            this.bbiAdd.Name = "bbiAdd";
            this.bbiAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAdd_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "修改学生信息";
            this.bbiEdit.Id = 1;
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "删除学生信息";
            this.bbiDelete.Id = 2;
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            this.bbiAdd.Glyph = global::Student.Properties.Resources.additem_32x32;
            this.bbiEdit.Glyph = global::Student.Properties.Resources.edit_32x32;
            this.bbiDelete.Glyph = global::Student.Properties.Resources.deleteitem_32x32;
            // 
            // te_dormitoryid
            // 
            this.te_dormitoryid.Location = new System.Drawing.Point(493, 68);
            this.te_dormitoryid.MenuManager = this.barManager1;
            this.te_dormitoryid.Name = "te_dormitoryid";
            this.te_dormitoryid.Size = new System.Drawing.Size(113, 20);
            this.te_dormitoryid.TabIndex = 14;
            // 
            // te_name
            // 
            this.te_name.Location = new System.Drawing.Point(274, 68);
            this.te_name.MenuManager = this.barManager1;
            this.te_name.Name = "te_name";
            this.te_name.Size = new System.Drawing.Size(113, 20);
            this.te_name.TabIndex = 13;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(211, 71);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(48, 14);
            this.name.TabIndex = 11;
            this.name.Text = "学生姓名";
            // 
            // dormitory_id
            // 
            this.dormitory_id.Location = new System.Drawing.Point(413, 71);
            this.dormitory_id.Name = "dormitory_id";
            this.dormitory_id.Size = new System.Drawing.Size(60, 14);
            this.dormitory_id.TabIndex = 10;
            this.dormitory_id.Text = "宿舍门牌号";
            // 
            // Sbt_clear
            // 
            this.Sbt_clear.Image = global::Student.Properties.Resources.Refresh_16x16;
            this.Sbt_clear.Location = new System.Drawing.Point(810, 67);
            this.Sbt_clear.Name = "Sbt_clear";
            this.Sbt_clear.Size = new System.Drawing.Size(130, 23);
            this.Sbt_clear.TabIndex = 9;
            this.Sbt_clear.Text = "清空查询条件";
            this.Sbt_clear.Click += new System.EventHandler(this.Sbtn_clear_Click);
            // 
            // Sbt_find
            // 
            this.Sbt_find.Image = global::Student.Properties.Resources.Search;
            this.Sbt_find.Location = new System.Drawing.Point(653, 67);
            this.Sbt_find.Name = "Sbt_find";
            this.Sbt_find.Size = new System.Drawing.Size(130, 23);
            this.Sbt_find.TabIndex = 8;
            this.Sbt_find.Text = "查询数据";
            this.Sbt_find.Click += new System.EventHandler(this.Sbt_find_Click);
            // 
            // te_stuno
            // 
            this.te_stuno.Location = new System.Drawing.Point(81, 68);
            this.te_stuno.Name = "te_stuno";
            this.te_stuno.Size = new System.Drawing.Size(113, 20);
            this.te_stuno.TabIndex = 7;
            // 
            // cbb_classno
            // 
            this.cbb_classno.Location = new System.Drawing.Point(493, 34);
            this.cbb_classno.Name = "cbb_classno";
            this.cbb_classno.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_classno.Size = new System.Drawing.Size(113, 20);
            this.cbb_classno.TabIndex = 6;
            // 
            // cbb_majordirct
            // 
            this.cbb_majordirct.Location = new System.Drawing.Point(274, 34);
            this.cbb_majordirct.Name = "cbb_majordirct";
            this.cbb_majordirct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_majordirct.Size = new System.Drawing.Size(113, 20);
            this.cbb_majordirct.TabIndex = 5;
            this.cbb_majordirct.SelectedIndexChanged += new System.EventHandler(this.cbb_majordirct_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 71);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "学生学号";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(211, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "专业方向";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(413, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "班级名称";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "入学年份";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDelete)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_STUNO,
            this.gc_name,
            this.gc_CLASSNAME,
            this.gc_DORMITORY_PLATE,
            this.gc_MAJORDIRCTNAME,
            this.gc_status,
            this.gc_idcard,
            this.gc_sex,
            this.gc_nation,
            this.gc_political,
            this.gc_source,
            this.gc_intenteddate,
            this.pc_graduationdate,
            this.pc_phone,
            this.pc_email,
            this.gc_fatherphone,
            this.gc_motherphone,
            this.gc_familyphone,
            this.gc_familyaddress,
            this.gc_zipcode,
            this.gc_qqno,
            this.gc_micromessageno,
            this.gc_picture});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gc_STUNO
            // 
            this.gc_STUNO.Caption = "学号";
            this.gc_STUNO.FieldName = "STUNO";
            this.gc_STUNO.Name = "gc_STUNO";
            this.gc_STUNO.Visible = true;
            this.gc_STUNO.VisibleIndex = 0;
            // 
            // gc_name
            // 
            this.gc_name.Caption = "姓名";
            this.gc_name.FieldName = "NAME";
            this.gc_name.Name = "gc_name";
            this.gc_name.Visible = true;
            this.gc_name.VisibleIndex = 2;
            // 
            // gc_CLASSNAME
            // 
            this.gc_CLASSNAME.Caption = "班级";
            this.gc_CLASSNAME.FieldName = "CLASSNAME";
            this.gc_CLASSNAME.Name = "gc_CLASSNAME";
            this.gc_CLASSNAME.Visible = true;
            this.gc_CLASSNAME.VisibleIndex = 1;
            // 
            // gc_DORMITORY_PLATE
            // 
            this.gc_DORMITORY_PLATE.Caption = "所在宿舍";
            this.gc_DORMITORY_PLATE.FieldName = "DORMITORY_PLATE";
            this.gc_DORMITORY_PLATE.Name = "gc_DORMITORY_PLATE";
            this.gc_DORMITORY_PLATE.Visible = true;
            this.gc_DORMITORY_PLATE.VisibleIndex = 3;
            // 
            // gc_MAJORDIRCTNAME
            // 
            this.gc_MAJORDIRCTNAME.Caption = "专业方向";
            this.gc_MAJORDIRCTNAME.FieldName = "MAJORDIRCTNAME";
            this.gc_MAJORDIRCTNAME.Name = "gc_MAJORDIRCTNAME";
            this.gc_MAJORDIRCTNAME.Visible = true;
            this.gc_MAJORDIRCTNAME.VisibleIndex = 4;
            // 
            // gc_status
            // 
            this.gc_status.Caption = "当前状态";
            this.gc_status.FieldName = "STATUS";
            this.gc_status.Name = "gc_status";
            this.gc_status.Visible = true;
            this.gc_status.VisibleIndex = 21;
            // 
            // gc_idcard
            // 
            this.gc_idcard.Caption = "身份证号";
            this.gc_idcard.FieldName = "IDCARD";
            this.gc_idcard.Name = "gc_idcard";
            this.gc_idcard.Visible = true;
            this.gc_idcard.VisibleIndex = 5;
            // 
            // gc_sex
            // 
            this.gc_sex.Caption = "性别";
            this.gc_sex.FieldName = "SEX";
            this.gc_sex.Name = "gc_sex";
            this.gc_sex.Visible = true;
            this.gc_sex.VisibleIndex = 6;
            // 
            // gc_nation
            // 
            this.gc_nation.Caption = "民族";
            this.gc_nation.FieldName = "NATION";
            this.gc_nation.Name = "gc_nation";
            this.gc_nation.Visible = true;
            this.gc_nation.VisibleIndex = 7;
            // 
            // gc_political
            // 
            this.gc_political.Caption = "政治面貌";
            this.gc_political.FieldName = "POLITICAL";
            this.gc_political.Name = "gc_political";
            this.gc_political.Visible = true;
            this.gc_political.VisibleIndex = 8;
            // 
            // gc_source
            // 
            this.gc_source.Caption = "生源所在地";
            this.gc_source.FieldName = "SOURCE";
            this.gc_source.Name = "gc_source";
            this.gc_source.Visible = true;
            this.gc_source.VisibleIndex = 9;
            // 
            // gc_intenteddate
            // 
            this.gc_intenteddate.Caption = "入学时间";
            this.gc_intenteddate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.gc_intenteddate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gc_intenteddate.FieldName = "INTENTEDDATE";
            this.gc_intenteddate.Name = "gc_intenteddate";
            this.gc_intenteddate.Visible = true;
            this.gc_intenteddate.VisibleIndex = 10;
            // 
            // pc_graduationdate
            // 
            this.pc_graduationdate.Caption = "毕业时间";
            this.pc_graduationdate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.pc_graduationdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pc_graduationdate.FieldName = "GRADUATIONDATE";
            this.pc_graduationdate.Name = "pc_graduationdate";
            this.pc_graduationdate.Visible = true;
            this.pc_graduationdate.VisibleIndex = 11;
            // 
            // pc_phone
            // 
            this.pc_phone.Caption = "手机号码";
            this.pc_phone.FieldName = "PHONE";
            this.pc_phone.Name = "pc_phone";
            this.pc_phone.Visible = true;
            this.pc_phone.VisibleIndex = 12;
            // 
            // pc_email
            // 
            this.pc_email.Caption = "电子邮箱";
            this.pc_email.FieldName = "EMAIL";
            this.pc_email.Name = "pc_email";
            this.pc_email.Visible = true;
            this.pc_email.VisibleIndex = 13;
            // 
            // gc_fatherphone
            // 
            this.gc_fatherphone.Caption = "父亲联系电话";
            this.gc_fatherphone.FieldName = "FATHERPHONE";
            this.gc_fatherphone.Name = "gc_fatherphone";
            this.gc_fatherphone.Visible = true;
            this.gc_fatherphone.VisibleIndex = 14;
            // 
            // gc_motherphone
            // 
            this.gc_motherphone.Caption = "母亲联系电话";
            this.gc_motherphone.FieldName = "MOTHERPHONE";
            this.gc_motherphone.Name = "gc_motherphone";
            this.gc_motherphone.Visible = true;
            this.gc_motherphone.VisibleIndex = 15;
            // 
            // gc_familyphone
            // 
            this.gc_familyphone.Caption = "家庭常用电话";
            this.gc_familyphone.FieldName = "FAMILYPHONE";
            this.gc_familyphone.Name = "gc_familyphone";
            this.gc_familyphone.Visible = true;
            this.gc_familyphone.VisibleIndex = 16;
            // 
            // gc_familyaddress
            // 
            this.gc_familyaddress.Caption = "家庭常用地址";
            this.gc_familyaddress.FieldName = "FAMILYADDRESS";
            this.gc_familyaddress.Name = "gc_familyaddress";
            this.gc_familyaddress.Visible = true;
            this.gc_familyaddress.VisibleIndex = 17;
            // 
            // gc_zipcode
            // 
            this.gc_zipcode.Caption = "邮政编码";
            this.gc_zipcode.FieldName = "ZIPCODE";
            this.gc_zipcode.Name = "gc_zipcode";
            this.gc_zipcode.Visible = true;
            this.gc_zipcode.VisibleIndex = 18;
            // 
            // gc_qqno
            // 
            this.gc_qqno.Caption = "QQ号码";
            this.gc_qqno.FieldName = "QQNO";
            this.gc_qqno.Name = "gc_qqno";
            this.gc_qqno.Visible = true;
            this.gc_qqno.VisibleIndex = 19;
            // 
            // gc_micromessageno
            // 
            this.gc_micromessageno.Caption = "微信号码";
            this.gc_micromessageno.FieldName = "MICRROMESSAGENO";
            this.gc_micromessageno.Name = "gc_micromessageno";
            this.gc_micromessageno.Visible = true;
            this.gc_micromessageno.VisibleIndex = 20;
            // 
            // gc_picture
            // 
            this.gc_picture.Caption = "照片";
            this.gc_picture.FieldName = "PICTURE";
            this.gc_picture.Name = "gc_picture";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 113);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1156, 392);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1162, 508);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // sbt_Quit
            // 
            this.sbt_Quit.Image = Student.Properties.Resources.Close_16x16;
            this.sbt_Quit.Location = new System.Drawing.Point(967, 67);
            this.sbt_Quit.Name = "sbt_Quit";
            this.sbt_Quit.Size = new System.Drawing.Size(130, 23);
            this.sbt_Quit.TabIndex = 16;
            this.sbt_Quit.Text = "退出";
            this.sbt_Quit.Click += new System.EventHandler(this.sbt_Quit_Click);
            // 
            // frmSTUDENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 508);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmSTUDENT";
            this.Text = "学生信息管理";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_inyear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_dormitoryid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stuno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_classno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_majordirct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_classno;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_majordirct;
        private DevExpress.XtraEditors.TextEdit te_stuno;
        private DevExpress.XtraEditors.SimpleButton Sbt_clear;
        private DevExpress.XtraEditors.SimpleButton Sbt_find;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gc_name;
        private DevExpress.XtraGrid.Columns.GridColumn gc_idcard;
        private DevExpress.XtraGrid.Columns.GridColumn gc_sex;
        private DevExpress.XtraGrid.Columns.GridColumn gc_nation;
        private DevExpress.XtraGrid.Columns.GridColumn gc_political;
        private DevExpress.XtraGrid.Columns.GridColumn gc_source;
        private DevExpress.XtraGrid.Columns.GridColumn gc_intenteddate;
        private DevExpress.XtraGrid.Columns.GridColumn pc_graduationdate;
        private DevExpress.XtraGrid.Columns.GridColumn pc_phone;
        private DevExpress.XtraGrid.Columns.GridColumn pc_email;
        private DevExpress.XtraGrid.Columns.GridColumn gc_fatherphone;
        private DevExpress.XtraGrid.Columns.GridColumn gc_motherphone;
        private DevExpress.XtraGrid.Columns.GridColumn gc_familyphone;
        private DevExpress.XtraGrid.Columns.GridColumn gc_familyaddress;
        private DevExpress.XtraGrid.Columns.GridColumn gc_zipcode;
        private DevExpress.XtraGrid.Columns.GridColumn gc_qqno;
        private DevExpress.XtraGrid.Columns.GridColumn gc_micromessageno;
        private DevExpress.XtraGrid.Columns.GridColumn gc_picture;
        private DevExpress.XtraGrid.Columns.GridColumn gc_status;
        private DevExpress.XtraEditors.TextEdit te_dormitoryid;
        private DevExpress.XtraEditors.TextEdit te_name;
        private DevExpress.XtraEditors.LabelControl name;
        private DevExpress.XtraEditors.LabelControl dormitory_id;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_inyear;
        private DevExpress.XtraGrid.Columns.GridColumn gc_STUNO;
        private DevExpress.XtraGrid.Columns.GridColumn gc_CLASSNAME;
        private DevExpress.XtraGrid.Columns.GridColumn gc_DORMITORY_PLATE;
        private DevExpress.XtraGrid.Columns.GridColumn gc_MAJORDIRCTNAME;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton sbt_Quit;
    }
}