namespace Student.Forms
{
    partial class frmCOURSE
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.sbt_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_Find = new DevExpress.XtraEditors.SimpleButton();
            this.cbb_coursetype = new DevExpress.XtraEditors.ComboBoxEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbi_Add = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Edit = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.te_coursename = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_COURSENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_COURSENAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_COURSETYPENAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_TOTALHOUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_THEORYHOUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_EXPERIMENTHOUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_CREDIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_MEMO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sbt_Quit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_coursetype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_coursename.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.sbt_Quit);
            this.groupControl1.Controls.Add(this.sbt_Clear);
            this.groupControl1.Controls.Add(this.sbt_Find);
            this.groupControl1.Controls.Add(this.cbb_coursetype);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.te_coursename);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1161, 79);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "查询条件";
            // 
            // sbt_Clear
            // 
            this.sbt_Clear.Image = global::Student.Properties.Resources.Refresh_16x16;
            this.sbt_Clear.Location = new System.Drawing.Point(754, 33);
            this.sbt_Clear.Name = "sbt_Clear";
            this.sbt_Clear.Size = new System.Drawing.Size(130, 23);
            this.sbt_Clear.TabIndex = 11;
            this.sbt_Clear.Text = "清空查询条件";
            this.sbt_Clear.Click += new System.EventHandler(this.sbt_Clear_Click);
            // 
            // sbt_Find
            // 
            this.sbt_Find.Image = global::Student.Properties.Resources.Search;
            this.sbt_Find.Location = new System.Drawing.Point(595, 33);
            this.sbt_Find.Name = "sbt_Find";
            this.sbt_Find.Size = new System.Drawing.Size(130, 23);
            this.sbt_Find.TabIndex = 10;
            this.sbt_Find.Text = "查询数据";
            this.sbt_Find.Click += new System.EventHandler(this.sbt_Find_Click);
            // 
            // cbb_coursetype
            // 
            this.cbb_coursetype.Location = new System.Drawing.Point(102, 37);
            this.cbb_coursetype.MenuManager = this.barManager1;
            this.cbb_coursetype.Name = "cbb_coursetype";
            this.cbb_coursetype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_coursetype.Size = new System.Drawing.Size(173, 20);
            this.cbb_coursetype.TabIndex = 9;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1167, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 507);
            this.barDockControlBottom.Size = new System.Drawing.Size(1167, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 507);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1167, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 507);
            // 
            // bbi_Add
            // 
            this.bbi_Add.Caption = "添加课程信息";
            this.bbi_Add.Id = 0;
            this.bbi_Add.Name = "bbi_Add";
            this.bbi_Add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Add_ItemClick);
            // 
            // bbi_Edit
            // 
            this.bbi_Edit.Caption = "修改课程信息";
            this.bbi_Edit.Id = 1;
            this.bbi_Edit.Name = "bbi_Edit";
            this.bbi_Edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Edit_ItemClick);
            // 
            // bbi_Delete
            // 
            this.bbi_Delete.Caption = "删除课程信息";
            this.bbi_Delete.Id = 2;
            this.bbi_Delete.Name = "bbi_Delete";
            this.bbi_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Delete_ItemClick);
            this.bbi_Add.Glyph = global::Student.Properties.Resources.additem_32x32;
            this.bbi_Edit.Glyph = global::Student.Properties.Resources.edit_32x32;
            this.bbi_Delete.Glyph = global::Student.Properties.Resources.deleteitem_32x32;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(305, 40);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "课程名称";
            // 
            // te_coursename
            // 
            this.te_coursename.Location = new System.Drawing.Point(373, 37);
            this.te_coursename.Name = "te_coursename";
            this.te_coursename.Size = new System.Drawing.Size(173, 20);
            this.te_coursename.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "课程类型";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(3, 88);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1161, 416);
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
            this.gc_COURSENO,
            this.gc_COURSENAME,
            this.gc_COURSETYPENAME,
            this.gc_TOTALHOUR,
            this.gc_THEORYHOUR,
            this.gc_EXPERIMENTHOUR,
            this.gc_CREDIT,
            this.gc_MEMO});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gc_COURSENO
            // 
            this.gc_COURSENO.Caption = "课程编号";
            this.gc_COURSENO.FieldName = "COURSENO";
            this.gc_COURSENO.Name = "gc_COURSENO";
            this.gc_COURSENO.Width = 61;
            // 
            // gc_COURSENAME
            // 
            this.gc_COURSENAME.Caption = "课程名称";
            this.gc_COURSENAME.FieldName = "COURSENAME";
            this.gc_COURSENAME.Name = "gc_COURSENAME";
            this.gc_COURSENAME.Visible = true;
            this.gc_COURSENAME.VisibleIndex = 0;
            this.gc_COURSENAME.Width = 155;
            // 
            // gc_COURSETYPENAME
            // 
            this.gc_COURSETYPENAME.Caption = "课程类型";
            this.gc_COURSETYPENAME.FieldName = "COURSETYPENAME";
            this.gc_COURSETYPENAME.Name = "gc_COURSETYPENAME";
            this.gc_COURSETYPENAME.Visible = true;
            this.gc_COURSETYPENAME.VisibleIndex = 1;
            this.gc_COURSETYPENAME.Width = 107;
            // 
            // gc_TOTALHOUR
            // 
            this.gc_TOTALHOUR.Caption = "总学时";
            this.gc_TOTALHOUR.FieldName = "TOTALHOUR";
            this.gc_TOTALHOUR.Name = "gc_TOTALHOUR";
            this.gc_TOTALHOUR.Visible = true;
            this.gc_TOTALHOUR.VisibleIndex = 2;
            this.gc_TOTALHOUR.Width = 50;
            // 
            // gc_THEORYHOUR
            // 
            this.gc_THEORYHOUR.Caption = "理论学时";
            this.gc_THEORYHOUR.FieldName = "THEORYHOUR";
            this.gc_THEORYHOUR.Name = "gc_THEORYHOUR";
            this.gc_THEORYHOUR.Visible = true;
            this.gc_THEORYHOUR.VisibleIndex = 3;
            this.gc_THEORYHOUR.Width = 69;
            // 
            // gc_EXPERIMENTHOUR
            // 
            this.gc_EXPERIMENTHOUR.Caption = "实验学时";
            this.gc_EXPERIMENTHOUR.FieldName = "EXPERIMENTHOUR";
            this.gc_EXPERIMENTHOUR.Name = "gc_EXPERIMENTHOUR";
            this.gc_EXPERIMENTHOUR.Visible = true;
            this.gc_EXPERIMENTHOUR.VisibleIndex = 4;
            this.gc_EXPERIMENTHOUR.Width = 72;
            // 
            // gc_CREDIT
            // 
            this.gc_CREDIT.Caption = "学分";
            this.gc_CREDIT.FieldName = "CREDIT";
            this.gc_CREDIT.Name = "gc_CREDIT";
            this.gc_CREDIT.Visible = true;
            this.gc_CREDIT.VisibleIndex = 5;
            this.gc_CREDIT.Width = 61;
            // 
            // gc_MEMO
            // 
            this.gc_MEMO.Caption = "备注";
            this.gc_MEMO.FieldName = "MEMO";
            this.gc_MEMO.Name = "gc_MEMO";
            this.gc_MEMO.Visible = true;
            this.gc_MEMO.VisibleIndex = 6;
            this.gc_MEMO.Width = 182;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1167, 507);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // sbt_Quit
            // 
            this.sbt_Quit.Image = Student.Properties.Resources.Close_16x16;
            this.sbt_Quit.Location = new System.Drawing.Point(913, 33);
            this.sbt_Quit.Name = "sbt_Quit";
            this.sbt_Quit.Size = new System.Drawing.Size(130, 23);
            this.sbt_Quit.TabIndex = 12;
            this.sbt_Quit.Text = "退出";
            this.sbt_Quit.Click += new System.EventHandler(this.sbt_Quit_Click);
            // 
            // frmCOURSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 507);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCOURSE";
            this.Text = "课程信息查询";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_coursetype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_coursename.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit te_coursename;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gc_COURSENO;
        private DevExpress.XtraGrid.Columns.GridColumn gc_COURSETYPENAME;
        private DevExpress.XtraGrid.Columns.GridColumn gc_COURSENAME;
        private DevExpress.XtraGrid.Columns.GridColumn gc_TOTALHOUR;
        private DevExpress.XtraGrid.Columns.GridColumn gc_THEORYHOUR;
        private DevExpress.XtraGrid.Columns.GridColumn gc_EXPERIMENTHOUR;
        private DevExpress.XtraGrid.Columns.GridColumn gc_CREDIT;
        private DevExpress.XtraGrid.Columns.GridColumn gc_MEMO;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem bbi_Add;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbi_Edit;
        private DevExpress.XtraBars.BarButtonItem bbi_Delete;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_coursetype;
        private DevExpress.XtraEditors.SimpleButton sbt_Clear;
        private DevExpress.XtraEditors.SimpleButton sbt_Find;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton sbt_Quit;
    }
}