namespace Student.Forms
{
    partial class frmCLASS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCLASS));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Sbtn_find = new DevExpress.XtraEditors.SimpleButton();
            this.Sbtn_clear = new DevExpress.XtraEditors.SimpleButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.classAdd = new DevExpress.XtraBars.BarButtonItem();
            this.classDelete = new DevExpress.XtraBars.BarButtonItem();
            this.classEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_CLASSNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_MAJORNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_MAJORDIRCTNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_CLASSNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_HEADMASTER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_INSTRUCTOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_ORGANIZER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.sbt_Quit = new DevExpress.XtraEditors.SimpleButton();
            this.cbb_instructor = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbb_organizer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbb_master = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbb_inyear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbb_majordirctname = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.te_classname = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_instructor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_organizer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_master.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_inyear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_majordirctname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_classname.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(486, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "班级名称";
            // 
            // Sbtn_find
            // 
            this.Sbtn_find.Image = global::Student.Properties.Resources.Search;
            this.Sbtn_find.Location = new System.Drawing.Point(707, 71);
            this.Sbtn_find.Name = "Sbtn_find";
            this.Sbtn_find.Size = new System.Drawing.Size(130, 23);
            this.Sbtn_find.TabIndex = 5;
            this.Sbtn_find.Text = "查询数据";
            this.Sbtn_find.Click += new System.EventHandler(this.Sbtn_find_Click);
            // 
            // Sbtn_clear
            // 
            this.Sbtn_clear.Image = global::Student.Properties.Resources.Refresh_16x16;
            this.Sbtn_clear.Location = new System.Drawing.Point(861, 71);
            this.Sbtn_clear.Name = "Sbtn_clear";
            this.Sbtn_clear.Size = new System.Drawing.Size(130, 23);
            this.Sbtn_clear.TabIndex = 6;
            this.Sbtn_clear.Text = "清空查询条件";
            this.Sbtn_clear.Click += new System.EventHandler(this.Sbtn_clear_Click);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.classAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.classDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.classEdit)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // classAdd
            // 
            this.classAdd.Caption = "增加班级信息";
            this.classAdd.Glyph = ((System.Drawing.Image)(resources.GetObject("classAdd.Glyph")));
            this.classAdd.Id = 0;
            this.classAdd.Name = "classAdd";
            this.classAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAdd_ItemClick);
            // 
            // classDelete
            // 
            this.classDelete.Caption = "删除班级信息";
            this.classDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("classDelete.Glyph")));
            this.classDelete.Id = 2;
            this.classDelete.Name = "classDelete";
            this.classDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // classEdit
            // 
            this.classEdit.Caption = "修改班级信息";
            this.classEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("classEdit.Glyph")));
            this.classEdit.Id = 3;
            this.classEdit.Name = "classEdit";
            this.classEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barEdit_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.classAdd,
            this.classDelete,
            this.classEdit,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 5;
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
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 118);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1156, 387);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_CLASSNO,
            this.gc_MAJORNAME,
            this.gc_MAJORDIRCTNAME,
            this.gc_CLASSNAME,
            this.gc_HEADMASTER,
            this.gc_INSTRUCTOR,
            this.gc_ORGANIZER});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gc_CLASSNO
            // 
            this.gc_CLASSNO.Caption = "班级编号";
            this.gc_CLASSNO.FieldName = "CLASSNO";
            this.gc_CLASSNO.Name = "gc_CLASSNO";
            // 
            // gc_MAJORNAME
            // 
            this.gc_MAJORNAME.Caption = "所属专业";
            this.gc_MAJORNAME.FieldName = "MAJORNAME";
            this.gc_MAJORNAME.Name = "gc_MAJORNAME";
            this.gc_MAJORNAME.Visible = true;
            this.gc_MAJORNAME.VisibleIndex = 0;
            // 
            // gc_MAJORDIRCTNAME
            // 
            this.gc_MAJORDIRCTNAME.Caption = "所属专业方向";
            this.gc_MAJORDIRCTNAME.FieldName = "MAJORDIRCTNAME";
            this.gc_MAJORDIRCTNAME.Name = "gc_MAJORDIRCTNAME";
            this.gc_MAJORDIRCTNAME.Visible = true;
            this.gc_MAJORDIRCTNAME.VisibleIndex = 1;
            // 
            // gc_CLASSNAME
            // 
            this.gc_CLASSNAME.Caption = "班级名称";
            this.gc_CLASSNAME.FieldName = "CLASSNAME";
            this.gc_CLASSNAME.Name = "gc_CLASSNAME";
            this.gc_CLASSNAME.Visible = true;
            this.gc_CLASSNAME.VisibleIndex = 2;
            // 
            // gc_HEADMASTER
            // 
            this.gc_HEADMASTER.Caption = "班主任";
            this.gc_HEADMASTER.FieldName = "HEADMASTER";
            this.gc_HEADMASTER.Name = "gc_HEADMASTER";
            this.gc_HEADMASTER.Visible = true;
            this.gc_HEADMASTER.VisibleIndex = 3;
            // 
            // gc_INSTRUCTOR
            // 
            this.gc_INSTRUCTOR.Caption = "辅导员";
            this.gc_INSTRUCTOR.FieldName = "INSTRUCTOR";
            this.gc_INSTRUCTOR.Name = "gc_INSTRUCTOR";
            this.gc_INSTRUCTOR.Visible = true;
            this.gc_INSTRUCTOR.VisibleIndex = 4;
            // 
            // gc_ORGANIZER
            // 
            this.gc_ORGANIZER.Caption = "组织员";
            this.gc_ORGANIZER.FieldName = "ORGANIZER";
            this.gc_ORGANIZER.Name = "gc_ORGANIZER";
            this.gc_ORGANIZER.Visible = true;
            this.gc_ORGANIZER.VisibleIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.sbt_Quit);
            this.groupControl1.Controls.Add(this.cbb_instructor);
            this.groupControl1.Controls.Add(this.cbb_organizer);
            this.groupControl1.Controls.Add(this.cbb_master);
            this.groupControl1.Controls.Add(this.cbb_inyear);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.cbb_majordirctname);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.te_classname);
            this.groupControl1.Controls.Add(this.Sbtn_find);
            this.groupControl1.Controls.Add(this.Sbtn_clear);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1156, 109);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "查询条件";
            // 
            // sbt_Quit
            // 
            this.sbt_Quit.Image = global::Student.Properties.Resources.Close_16x16;
            this.sbt_Quit.Location = new System.Drawing.Point(1015, 71);
            this.sbt_Quit.Name = "sbt_Quit";
            this.sbt_Quit.Size = new System.Drawing.Size(130, 23);
            this.sbt_Quit.TabIndex = 28;
            this.sbt_Quit.Text = "退出";
            this.sbt_Quit.Click += new System.EventHandler(this.sbt_Quit_Click);
            // 
            // cbb_instructor
            // 
            this.cbb_instructor.Location = new System.Drawing.Point(319, 74);
            this.cbb_instructor.MenuManager = this.barManager1;
            this.cbb_instructor.Name = "cbb_instructor";
            this.cbb_instructor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_instructor.Size = new System.Drawing.Size(128, 20);
            this.cbb_instructor.TabIndex = 27;
            // 
            // cbb_organizer
            // 
            this.cbb_organizer.Location = new System.Drawing.Point(555, 74);
            this.cbb_organizer.MenuManager = this.barManager1;
            this.cbb_organizer.Name = "cbb_organizer";
            this.cbb_organizer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_organizer.Size = new System.Drawing.Size(128, 20);
            this.cbb_organizer.TabIndex = 26;
            // 
            // cbb_master
            // 
            this.cbb_master.Location = new System.Drawing.Point(95, 74);
            this.cbb_master.MenuManager = this.barManager1;
            this.cbb_master.Name = "cbb_master";
            this.cbb_master.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_master.Size = new System.Drawing.Size(128, 20);
            this.cbb_master.TabIndex = 25;
            // 
            // cbb_inyear
            // 
            this.cbb_inyear.Location = new System.Drawing.Point(94, 36);
            this.cbb_inyear.MenuManager = this.barManager1;
            this.cbb_inyear.Name = "cbb_inyear";
            this.cbb_inyear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_inyear.Size = new System.Drawing.Size(128, 20);
            this.cbb_inyear.TabIndex = 24;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "入学年份";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(486, 77);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "组织员";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(250, 77);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 14);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "辅导员";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(25, 77);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 14);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "班主任";
            // 
            // cbb_majordirctname
            // 
            this.cbb_majordirctname.Location = new System.Drawing.Point(319, 36);
            this.cbb_majordirctname.MenuManager = this.barManager1;
            this.cbb_majordirctname.Name = "cbb_majordirctname";
            this.cbb_majordirctname.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_majordirctname.Size = new System.Drawing.Size(128, 20);
            this.cbb_majordirctname.TabIndex = 16;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(247, 39);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "专业方向";
            // 
            // te_classname
            // 
            this.te_classname.Location = new System.Drawing.Point(555, 36);
            this.te_classname.MenuManager = this.barManager1;
            this.te_classname.Name = "te_classname";
            this.te_classname.Size = new System.Drawing.Size(128, 20);
            this.te_classname.TabIndex = 12;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1162, 508);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // frmCLASS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 508);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCLASS";
            this.Text = "班级信息管理";
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_instructor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_organizer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_master.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_inyear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_majordirctname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_classname.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton Sbtn_find;
        private DevExpress.XtraEditors.SimpleButton Sbtn_clear;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit te_classname;
        private DevExpress.XtraBars.BarButtonItem classAdd;
        private DevExpress.XtraBars.BarButtonItem classDelete;
        private DevExpress.XtraBars.BarButtonItem classEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_majordirctname;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        //private DevExpress.CodeRush.Extensions.IntellassistExtension intellassistExtension1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_inyear;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_instructor;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_organizer;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_master;
        private DevExpress.XtraGrid.Columns.GridColumn gc_CLASSNO;
        private DevExpress.XtraGrid.Columns.GridColumn gc_MAJORNAME;
        private DevExpress.XtraGrid.Columns.GridColumn gc_MAJORDIRCTNAME;
        private DevExpress.XtraGrid.Columns.GridColumn gc_CLASSNAME;
        private DevExpress.XtraGrid.Columns.GridColumn gc_HEADMASTER;
        private DevExpress.XtraGrid.Columns.GridColumn gc_INSTRUCTOR;
        private DevExpress.XtraGrid.Columns.GridColumn gc_ORGANIZER;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton sbt_Quit;
    }
}