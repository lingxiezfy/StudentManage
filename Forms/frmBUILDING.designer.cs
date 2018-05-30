namespace Student.Forms
{
    partial class frmBUILDING
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBUILDING));
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bbiADD = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelect = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.sbt_Quit = new DevExpress.XtraEditors.SimpleButton();
            this.te_admin = new DevExpress.XtraEditors.TextEdit();
            this.te_buildingname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.sbt_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_Find = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_BUILDINGID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_BUILDINGNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_FLOORS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_ADMIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_admin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_buildingname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiADD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDelect)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // bbiADD
            // 
            this.bbiADD.Caption = "增加宿舍楼信息";
            this.bbiADD.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiADD.Glyph")));
            this.bbiADD.Id = 3;
            this.bbiADD.LargeGlyph = global::Student.Properties.Resources.add_32x32;
            this.bbiADD.Name = "bbiADD";
            this.bbiADD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiADD_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "修改宿舍楼信息";
            this.bbiEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiEdit.Glyph")));
            this.bbiEdit.Id = 4;
            this.bbiEdit.LargeGlyph = global::Student.Properties.Resources.remove_32x32;
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick_1);
            // 
            // bbiDelect
            // 
            this.bbiDelect.Caption = "删除宿舍楼信息";
            this.bbiDelect.Glyph = global::Student.Properties.Resources.deleteitem_32x32;
            this.bbiDelect.Id = 6;
            this.bbiDelect.Name = "bbiDelect";
            this.bbiDelect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelect_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiADD,
            this.bbiEdit,
            this.bbiDelect});
            this.barManager1.MaxItemId = 7;
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 572);
            this.barDockControlBottom.Size = new System.Drawing.Size(1276, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 572);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1276, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 572);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(35, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "宿舍楼名称";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.sbt_Quit);
            this.groupControl1.Controls.Add(this.te_admin);
            this.groupControl1.Controls.Add(this.te_buildingname);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.sbt_Clear);
            this.groupControl1.Controls.Add(this.sbt_Find);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1361, 79);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "查询条件";
            // 
            // sbt_Quit
            // 
            this.sbt_Quit.Image = global::Student.Properties.Resources.Close_16x16;
            this.sbt_Quit.Location = new System.Drawing.Point(896, 36);
            this.sbt_Quit.Name = "sbt_Quit";
            this.sbt_Quit.Size = new System.Drawing.Size(130, 23);
            this.sbt_Quit.TabIndex = 11;
            this.sbt_Quit.Text = "退出";
            this.sbt_Quit.Click += new System.EventHandler(this.sbt_Quit_Click);
            // 
            // te_admin
            // 
            this.te_admin.Location = new System.Drawing.Point(369, 37);
            this.te_admin.MenuManager = this.barManager1;
            this.te_admin.Name = "te_admin";
            this.te_admin.Size = new System.Drawing.Size(151, 20);
            this.te_admin.TabIndex = 10;
            // 
            // te_buildingname
            // 
            this.te_buildingname.Location = new System.Drawing.Point(117, 37);
            this.te_buildingname.MenuManager = this.barManager1;
            this.te_buildingname.Name = "te_buildingname";
            this.te_buildingname.Size = new System.Drawing.Size(151, 20);
            this.te_buildingname.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(287, 40);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "管理员姓名";
            // 
            // sbt_Clear
            // 
            this.sbt_Clear.Image = global::Student.Properties.Resources.Refresh_16x16;
            this.sbt_Clear.Location = new System.Drawing.Point(734, 36);
            this.sbt_Clear.Name = "sbt_Clear";
            this.sbt_Clear.Size = new System.Drawing.Size(130, 23);
            this.sbt_Clear.TabIndex = 7;
            this.sbt_Clear.Text = "清空查询条件";
            this.sbt_Clear.Click += new System.EventHandler(this.sbt_Clear_Click);
            // 
            // sbt_Find
            // 
            this.sbt_Find.Image = global::Student.Properties.Resources.Search;
            this.sbt_Find.Location = new System.Drawing.Point(572, 36);
            this.sbt_Find.Name = "sbt_Find";
            this.sbt_Find.Size = new System.Drawing.Size(130, 23);
            this.sbt_Find.TabIndex = 6;
            this.sbt_Find.Text = "查询数据";
            this.sbt_Find.Click += new System.EventHandler(this.sbt_Find_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 88);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1361, 481);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_BUILDINGID,
            this.gc_BUILDINGNAME,
            this.gc_FLOORS,
            this.gc_ADMIN});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // gc_BUILDINGID
            // 
            this.gc_BUILDINGID.AppearanceCell.Options.UseTextOptions = true;
            this.gc_BUILDINGID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_BUILDINGID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gc_BUILDINGID.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_BUILDINGID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_BUILDINGID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gc_BUILDINGID.Caption = "宿舍楼编号";
            this.gc_BUILDINGID.FieldName = "BUILDINGID";
            this.gc_BUILDINGID.MaxWidth = 389;
            this.gc_BUILDINGID.Name = "gc_BUILDINGID";
            this.gc_BUILDINGID.Width = 150;
            // 
            // gc_BUILDINGNAME
            // 
            this.gc_BUILDINGNAME.AppearanceCell.Options.UseTextOptions = true;
            this.gc_BUILDINGNAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_BUILDINGNAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gc_BUILDINGNAME.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_BUILDINGNAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_BUILDINGNAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gc_BUILDINGNAME.Caption = "宿舍楼名称";
            this.gc_BUILDINGNAME.FieldName = "BUILDINGNAME";
            this.gc_BUILDINGNAME.MaxWidth = 389;
            this.gc_BUILDINGNAME.Name = "gc_BUILDINGNAME";
            this.gc_BUILDINGNAME.Visible = true;
            this.gc_BUILDINGNAME.VisibleIndex = 0;
            this.gc_BUILDINGNAME.Width = 389;
            // 
            // gc_FLOORS
            // 
            this.gc_FLOORS.AppearanceCell.Options.UseTextOptions = true;
            this.gc_FLOORS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_FLOORS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gc_FLOORS.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_FLOORS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_FLOORS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gc_FLOORS.Caption = "楼层数";
            this.gc_FLOORS.FieldName = "FLOORS";
            this.gc_FLOORS.MaxWidth = 389;
            this.gc_FLOORS.Name = "gc_FLOORS";
            this.gc_FLOORS.Visible = true;
            this.gc_FLOORS.VisibleIndex = 1;
            this.gc_FLOORS.Width = 389;
            // 
            // gc_ADMIN
            // 
            this.gc_ADMIN.AppearanceCell.Options.UseTextOptions = true;
            this.gc_ADMIN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_ADMIN.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gc_ADMIN.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_ADMIN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_ADMIN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gc_ADMIN.Caption = "管理员";
            this.gc_ADMIN.FieldName = "ADMIN";
            this.gc_ADMIN.Name = "gc_ADMIN";
            this.gc_ADMIN.Visible = true;
            this.gc_ADMIN.VisibleIndex = 2;
            this.gc_ADMIN.Width = 415;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1276, 572);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // frmBUILDING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 572);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBUILDING";
            this.Text = "宿舍楼信息查询";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_admin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_buildingname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton sbt_Clear;
        private DevExpress.XtraEditors.SimpleButton sbt_Find;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gc_BUILDINGID;
        private DevExpress.XtraGrid.Columns.GridColumn gc_BUILDINGNAME;
        private DevExpress.XtraGrid.Columns.GridColumn gc_FLOORS;
        private DevExpress.XtraBars.BarButtonItem bbiADD;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn gc_ADMIN;
        private DevExpress.XtraBars.BarButtonItem bbiDelect;
        private DevExpress.XtraEditors.TextEdit te_admin;
        private DevExpress.XtraEditors.TextEdit te_buildingname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton sbt_Quit;
    }
}