namespace Student.Forms
{
    partial class frmDORMITORY
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
            this.cbb_buildingname = new DevExpress.XtraEditors.ComboBoxEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barEdit = new DevExpress.XtraBars.BarButtonItem();
            this.te_plate = new DevExpress.XtraEditors.TextEdit();
            this.Sbtn_clear = new DevExpress.XtraEditors.SimpleButton();
            this.Sbtn_find = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_DORMITORY_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_DORMITORY_PLATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_BUILDINGNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.sbt_Quit = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_buildingname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_plate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbb_buildingname
            // 
            this.cbb_buildingname.Location = new System.Drawing.Point(101, 38);
            this.cbb_buildingname.MenuManager = this.barManager1;
            this.cbb_buildingname.Name = "cbb_buildingname";
            this.cbb_buildingname.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_buildingname.Size = new System.Drawing.Size(165, 20);
            this.cbb_buildingname.TabIndex = 8;
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
            this.bbiDelete,
            this.barEdit});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1069, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 662);
            this.barDockControlBottom.Size = new System.Drawing.Size(1069, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 662);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1069, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 662);
            // 
            // bbiAdd
            // 
            this.bbiAdd.Caption = "增加宿舍信息";
            this.bbiAdd.Id = 0;
            this.bbiAdd.Name = "bbiAdd";
            this.bbiAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAdd_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "删除宿舍信息";
            this.bbiDelete.Id = 1;
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // barEdit
            // 
            this.barEdit.Caption = "修改宿舍信息";
            this.barEdit.Id = 2;
            this.barEdit.Name = "barEdit";
            this.barEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barEdit_ItemClick);
            this.bbiAdd.Glyph = global::Student.Properties.Resources.additem_32x32;
            this.barEdit.Glyph = global::Student.Properties.Resources.edit_32x32;
            this.bbiDelete.Glyph = global::Student.Properties.Resources.deleteitem_32x32;
            // 
            // te_plate
            // 
            this.te_plate.Location = new System.Drawing.Point(373, 38);
            this.te_plate.Name = "te_plate";
            this.te_plate.Size = new System.Drawing.Size(165, 20);
            this.te_plate.TabIndex = 7;
            // 
            // Sbtn_clear
            // 
            this.Sbtn_clear.Image = global::Student.Properties.Resources.Refresh_16x16;
            this.Sbtn_clear.Location = new System.Drawing.Point(724, 37);
            this.Sbtn_clear.Name = "Sbtn_clear";
            this.Sbtn_clear.Size = new System.Drawing.Size(130, 23);
            this.Sbtn_clear.TabIndex = 4;
            this.Sbtn_clear.Text = "清空查询条件";
            this.Sbtn_clear.Click += new System.EventHandler(this.Sbtn_clear_Click);
            // 
            // Sbtn_find
            // 
            this.Sbtn_find.Image = global::Student.Properties.Resources.Search;
            this.Sbtn_find.Location = new System.Drawing.Point(571, 37);
            this.Sbtn_find.Name = "Sbtn_find";
            this.Sbtn_find.Size = new System.Drawing.Size(130, 23);
            this.Sbtn_find.TabIndex = 3;
            this.Sbtn_find.Text = "查询信息";
            this.Sbtn_find.Click += new System.EventHandler(this.Sbtn_find_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(296, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "宿舍门牌号";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "宿舍楼名称";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 88);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1063, 571);
            this.gridControl1.TabIndex = 1;
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
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_DORMITORY_ID,
            this.gc_DORMITORY_PLATE,
            this.gc_BUILDINGNAME});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gc_DORMITORY_ID
            // 
            this.gc_DORMITORY_ID.Caption = "宿舍编号";
            this.gc_DORMITORY_ID.FieldName = "DORMITORY_ID";
            this.gc_DORMITORY_ID.Name = "gc_DORMITORY_ID";
            this.gc_DORMITORY_ID.Width = 127;
            // 
            // gc_DORMITORY_PLATE
            // 
            this.gc_DORMITORY_PLATE.Caption = "宿舍门牌号";
            this.gc_DORMITORY_PLATE.FieldName = "DORMITORY_PLATE";
            this.gc_DORMITORY_PLATE.Name = "gc_DORMITORY_PLATE";
            this.gc_DORMITORY_PLATE.Visible = true;
            this.gc_DORMITORY_PLATE.VisibleIndex = 1;
            this.gc_DORMITORY_PLATE.Width = 316;
            // 
            // gc_BUILDINGNAME
            // 
            this.gc_BUILDINGNAME.Caption = "所属宿舍楼";
            this.gc_BUILDINGNAME.FieldName = "BUILDINGNAME";
            this.gc_BUILDINGNAME.Name = "gc_BUILDINGNAME";
            this.gc_BUILDINGNAME.Visible = true;
            this.gc_BUILDINGNAME.VisibleIndex = 0;
            this.gc_BUILDINGNAME.Width = 312;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Caption, this.bbiAdd, "增加宿舍信息"),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEdit)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.sbt_Quit);
            this.groupControl1.Controls.Add(this.cbb_buildingname);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.te_plate);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.Sbtn_clear);
            this.groupControl1.Controls.Add(this.Sbtn_find);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1063, 79);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "查询条件";
            // 
            // sbt_Quit
            // 
            this.sbt_Quit.Image = Student.Properties.Resources.Close_16x16;
            this.sbt_Quit.Location = new System.Drawing.Point(877, 37);
            this.sbt_Quit.Name = "sbt_Quit";
            this.sbt_Quit.Size = new System.Drawing.Size(130, 23);
            this.sbt_Quit.TabIndex = 10;
            this.sbt_Quit.Text = "退出";
            this.sbt_Quit.Click += new System.EventHandler(this.sbt_Quit_Click);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1069, 662);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // frmDORMITORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 662);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDORMITORY";
            this.Text = "宿舍信息管理";
            ((System.ComponentModel.ISupportInitialize)(this.cbb_buildingname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_plate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit te_plate;
        private DevExpress.XtraEditors.SimpleButton Sbtn_clear;
        private DevExpress.XtraEditors.SimpleButton Sbtn_find;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gc_DORMITORY_ID;
        private DevExpress.XtraGrid.Columns.GridColumn gc_BUILDINGNAME;
        private DevExpress.XtraGrid.Columns.GridColumn gc_DORMITORY_PLATE;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem barEdit;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_buildingname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton sbt_Quit;
    }
}