namespace Student.Forms
{
    partial class frmTEACHER
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
            this.Sbtn_clear = new DevExpress.XtraEditors.SimpleButton();
            this.Sbtn_find = new DevExpress.XtraEditors.SimpleButton();
            this.te_name = new DevExpress.XtraEditors.TextEdit();
            this.cbb_majorname = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_teacherno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_WORKID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_MAJORNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_sex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_IDCARD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_nation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_POLITICAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_EMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_FAMILYPHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_FAMILYADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_QQNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_MICROMESSAGENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sbt_Quit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_majorname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.sbt_Quit);
            this.groupControl1.Controls.Add(this.Sbtn_clear);
            this.groupControl1.Controls.Add(this.Sbtn_find);
            this.groupControl1.Controls.Add(this.te_name);
            this.groupControl1.Controls.Add(this.cbb_majorname);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1270, 79);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "查询条件";
            // 
            // Sbtn_clear
            // 
            this.Sbtn_clear.Image = global::Student.Properties.Resources.Refresh_16x16;
            this.Sbtn_clear.Location = new System.Drawing.Point(687, 39);
            this.Sbtn_clear.Name = "Sbtn_clear";
            this.Sbtn_clear.Size = new System.Drawing.Size(130, 23);
            this.Sbtn_clear.TabIndex = 7;
            this.Sbtn_clear.Text = "清空查询条件";
            this.Sbtn_clear.Click += new System.EventHandler(this.Sbtn_clear_Click);
            // 
            // Sbtn_find
            // 
            this.Sbtn_find.Image = global::Student.Properties.Resources.Search;
            this.Sbtn_find.Location = new System.Drawing.Point(524, 39);
            this.Sbtn_find.Name = "Sbtn_find";
            this.Sbtn_find.Size = new System.Drawing.Size(130, 23);
            this.Sbtn_find.TabIndex = 6;
            this.Sbtn_find.Text = "查询数据";
            this.Sbtn_find.Click += new System.EventHandler(this.Sbtn_find_Click);
            // 
            // te_name
            // 
            this.te_name.Location = new System.Drawing.Point(333, 40);
            this.te_name.Name = "te_name";
            this.te_name.Size = new System.Drawing.Size(145, 20);
            this.te_name.TabIndex = 5;
            // 
            // cbb_majorname
            // 
            this.cbb_majorname.Location = new System.Drawing.Point(92, 40);
            this.cbb_majorname.Name = "cbb_majorname";
            this.cbb_majorname.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_majorname.Size = new System.Drawing.Size(145, 20);
            this.cbb_majorname.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(261, 43);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "教师姓名";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "专业名称";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 88);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1270, 572);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_teacherno,
            this.gc_name,
            this.gc_WORKID,
            this.gc_MAJORNAME,
            this.gc_sex,
            this.gc_phone,
            this.gc_IDCARD,
            this.gc_nation,
            this.gc_POLITICAL,
            this.gc_EMAIL,
            this.gc_FAMILYPHONE,
            this.gc_FAMILYADDRESS,
            this.gc_QQNO,
            this.gc_MICROMESSAGENO});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gc_teacherno
            // 
            this.gc_teacherno.Caption = "教师编号";
            this.gc_teacherno.FieldName = "TEACHERNO";
            this.gc_teacherno.Name = "gc_teacherno";
            // 
            // gc_name
            // 
            this.gc_name.Caption = "教师姓名";
            this.gc_name.FieldName = "NAME";
            this.gc_name.Name = "gc_name";
            this.gc_name.Visible = true;
            this.gc_name.VisibleIndex = 0;
            this.gc_name.Width = 77;
            // 
            // gc_WORKID
            // 
            this.gc_WORKID.Caption = "教师工号";
            this.gc_WORKID.FieldName = "WORKID";
            this.gc_WORKID.Name = "gc_WORKID";
            this.gc_WORKID.Visible = true;
            this.gc_WORKID.VisibleIndex = 1;
            this.gc_WORKID.Width = 74;
            // 
            // gc_MAJORNAME
            // 
            this.gc_MAJORNAME.Caption = "所属专业";
            this.gc_MAJORNAME.FieldName = "MAJORNAME";
            this.gc_MAJORNAME.Name = "gc_MAJORNAME";
            this.gc_MAJORNAME.Visible = true;
            this.gc_MAJORNAME.VisibleIndex = 3;
            this.gc_MAJORNAME.Width = 45;
            // 
            // gc_sex
            // 
            this.gc_sex.Caption = "性别";
            this.gc_sex.FieldName = "SEX";
            this.gc_sex.Name = "gc_sex";
            this.gc_sex.Visible = true;
            this.gc_sex.VisibleIndex = 5;
            this.gc_sex.Width = 45;
            // 
            // gc_phone
            // 
            this.gc_phone.Caption = "手机号码";
            this.gc_phone.FieldName = "PHONE";
            this.gc_phone.Name = "gc_phone";
            this.gc_phone.Visible = true;
            this.gc_phone.VisibleIndex = 7;
            this.gc_phone.Width = 45;
            // 
            // gc_IDCARD
            // 
            this.gc_IDCARD.Caption = "身份证号";
            this.gc_IDCARD.FieldName = "IDCARD";
            this.gc_IDCARD.Name = "gc_IDCARD";
            this.gc_IDCARD.Visible = true;
            this.gc_IDCARD.VisibleIndex = 2;
            this.gc_IDCARD.Width = 71;
            // 
            // gc_nation
            // 
            this.gc_nation.Caption = "民族";
            this.gc_nation.FieldName = "NATION";
            this.gc_nation.Name = "gc_nation";
            this.gc_nation.Visible = true;
            this.gc_nation.VisibleIndex = 4;
            this.gc_nation.Width = 45;
            // 
            // gc_POLITICAL
            // 
            this.gc_POLITICAL.Caption = "政治面貌";
            this.gc_POLITICAL.FieldName = "POLITICAL";
            this.gc_POLITICAL.Name = "gc_POLITICAL";
            this.gc_POLITICAL.Visible = true;
            this.gc_POLITICAL.VisibleIndex = 6;
            this.gc_POLITICAL.Width = 45;
            // 
            // gc_EMAIL
            // 
            this.gc_EMAIL.Caption = "电子邮箱";
            this.gc_EMAIL.FieldName = "EMAIL";
            this.gc_EMAIL.Name = "gc_EMAIL";
            this.gc_EMAIL.Visible = true;
            this.gc_EMAIL.VisibleIndex = 8;
            this.gc_EMAIL.Width = 45;
            // 
            // gc_FAMILYPHONE
            // 
            this.gc_FAMILYPHONE.Caption = "家庭电话";
            this.gc_FAMILYPHONE.FieldName = "FAMILYPHONE";
            this.gc_FAMILYPHONE.Name = "gc_FAMILYPHONE";
            this.gc_FAMILYPHONE.Visible = true;
            this.gc_FAMILYPHONE.VisibleIndex = 9;
            this.gc_FAMILYPHONE.Width = 45;
            // 
            // gc_FAMILYADDRESS
            // 
            this.gc_FAMILYADDRESS.Caption = "家庭地址";
            this.gc_FAMILYADDRESS.FieldName = "FAMILYADDRESS";
            this.gc_FAMILYADDRESS.Name = "gc_FAMILYADDRESS";
            this.gc_FAMILYADDRESS.Visible = true;
            this.gc_FAMILYADDRESS.VisibleIndex = 10;
            this.gc_FAMILYADDRESS.Width = 45;
            // 
            // gc_QQNO
            // 
            this.gc_QQNO.Caption = "QQ号码";
            this.gc_QQNO.FieldName = "QQNO";
            this.gc_QQNO.Name = "gc_QQNO";
            this.gc_QQNO.Visible = true;
            this.gc_QQNO.VisibleIndex = 11;
            this.gc_QQNO.Width = 45;
            // 
            // gc_MICROMESSAGENO
            // 
            this.gc_MICROMESSAGENO.Caption = "微信号码";
            this.gc_MICROMESSAGENO.FieldName = "MICROMESSAGENO";
            this.gc_MICROMESSAGENO.Name = "gc_MICROMESSAGENO";
            this.gc_MICROMESSAGENO.Visible = true;
            this.gc_MICROMESSAGENO.VisibleIndex = 12;
            this.gc_MICROMESSAGENO.Width = 69;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDelete)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // bbiAdd
            // 
            this.bbiAdd.Caption = "增加教师信息";
            this.bbiAdd.Id = 5;
            this.bbiAdd.Name = "bbiAdd";
            this.bbiAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barEdit
            // 
            this.barEdit.Caption = "修改教师信息";
            this.barEdit.Id = 6;
            this.barEdit.Name = "barEdit";
            this.barEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barEdit_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "删除教师信息";
            this.bbiDelete.Id = 7;
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            this.bbiAdd.Glyph = global::Student.Properties.Resources.additem_32x32;
            this.barEdit.Glyph = global::Student.Properties.Resources.edit_32x32;
            this.bbiDelete.Glyph = global::Student.Properties.Resources.deleteitem_32x32;
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
            this.barEdit,
            this.bbiDelete});
            this.barManager1.MaxItemId = 8;
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 663);
            this.barDockControlBottom.Size = new System.Drawing.Size(1276, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 663);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1276, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 663);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1276, 663);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // sbt_Quit
            // 
            this.sbt_Quit.Image = Student.Properties.Resources.Close_16x16;
            this.sbt_Quit.Location = new System.Drawing.Point(850, 39);
            this.sbt_Quit.Name = "sbt_Quit";
            this.sbt_Quit.Size = new System.Drawing.Size(130, 23);
            this.sbt_Quit.TabIndex = 8;
            this.sbt_Quit.Text = "退出";
            this.sbt_Quit.Click += new System.EventHandler(this.sbt_Quit_Click);
            // 
            // frmTEACHER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 663);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTEACHER";
            this.Text = "教师信息管理";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_majorname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_majorname;
        private DevExpress.XtraEditors.TextEdit te_name;
        private DevExpress.XtraEditors.SimpleButton Sbtn_clear;
        private DevExpress.XtraEditors.SimpleButton Sbtn_find;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gc_teacherno;
        private DevExpress.XtraGrid.Columns.GridColumn gc_WORKID;
        private DevExpress.XtraGrid.Columns.GridColumn gc_name;
        private DevExpress.XtraGrid.Columns.GridColumn gc_IDCARD;
        private DevExpress.XtraGrid.Columns.GridColumn gc_sex;
        private DevExpress.XtraGrid.Columns.GridColumn gc_POLITICAL;
        private DevExpress.XtraGrid.Columns.GridColumn gc_phone;
        private DevExpress.XtraGrid.Columns.GridColumn gc_EMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn gc_FAMILYPHONE;
        private DevExpress.XtraGrid.Columns.GridColumn gc_FAMILYADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn gc_QQNO;
        private DevExpress.XtraGrid.Columns.GridColumn gc_MICROMESSAGENO;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn gc_nation;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem barEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gc_MAJORNAME;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton sbt_Quit;
    }
}