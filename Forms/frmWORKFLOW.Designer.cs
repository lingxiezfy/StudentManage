namespace Student.Forms
{
    partial class frmWORKFLOW
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
            this.sbt_Quit = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_clear = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_find = new DevExpress.XtraEditors.SimpleButton();
            this.te_workflowname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_workflowno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_workflowname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_createdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bbi_Add = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Edit = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_workflowname.Properties)).BeginInit();
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
            this.groupControl1.Controls.Add(this.sbt_clear);
            this.groupControl1.Controls.Add(this.sbt_find);
            this.groupControl1.Controls.Add(this.te_workflowname);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1001, 79);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "查询条件";
            // 
            // sbt_Quit
            // 
            this.sbt_Quit.Location = new System.Drawing.Point(661, 36);
            this.sbt_Quit.Name = "sbt_Quit";
            this.sbt_Quit.Size = new System.Drawing.Size(130, 23);
            this.sbt_Quit.TabIndex = 7;
            this.sbt_Quit.Text = "退出";
            this.sbt_Quit.Click += new System.EventHandler(this.sbt_Quit_Click);
            // 
            // sbt_clear
            // 
            this.sbt_clear.Location = new System.Drawing.Point(502, 36);
            this.sbt_clear.Name = "sbt_clear";
            this.sbt_clear.Size = new System.Drawing.Size(130, 23);
            this.sbt_clear.TabIndex = 6;
            this.sbt_clear.Text = "清空查询条件";
            this.sbt_clear.Click += new System.EventHandler(this.sbt_clear_Click);
            // 
            // sbt_find
            // 
            this.sbt_Quit.Image = Student.Properties.Resources.Close_16x16;
            this.sbt_clear.Image = global::Student.Properties.Resources.Refresh_16x16;
            this.sbt_find.Image = global::Student.Properties.Resources.Search;
            this.sbt_find.Location = new System.Drawing.Point(343, 36);
            this.sbt_find.Name = "sbt_find";
            this.sbt_find.Size = new System.Drawing.Size(130, 23);
            this.sbt_find.TabIndex = 5;
            this.sbt_find.Text = "查询数据";
            this.sbt_find.Click += new System.EventHandler(this.sbt_find_Click);
            // 
            // te_workflowname
            // 
            this.te_workflowname.Location = new System.Drawing.Point(104, 37);
            this.te_workflowname.Name = "te_workflowname";
            this.te_workflowname.Size = new System.Drawing.Size(203, 20);
            this.te_workflowname.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 40);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "工作流名称";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 88);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1001, 336);
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
            this.gc_workflowno,
            this.gc_workflowname,
            this.gc_createdate,
            this.gc_status});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gc_workflowno
            // 
            this.gc_workflowno.AppearanceCell.Options.UseTextOptions = true;
            this.gc_workflowno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_workflowno.Caption = "工作流编号";
            this.gc_workflowno.FieldName = "WORKFLOWNO";
            this.gc_workflowno.MaxWidth = 150;
            this.gc_workflowno.Name = "gc_workflowno";
            this.gc_workflowno.Width = 150;
            // 
            // gc_workflowname
            // 
            this.gc_workflowname.Caption = "工作流名称";
            this.gc_workflowname.FieldName = "WORKFLOWNAME";
            this.gc_workflowname.Name = "gc_workflowname";
            this.gc_workflowname.Visible = true;
            this.gc_workflowname.VisibleIndex = 0;
            // 
            // gc_createdate
            // 
            this.gc_createdate.Caption = "创建时间";
            this.gc_createdate.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.gc_createdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gc_createdate.FieldName = "CREATEDATE";
            this.gc_createdate.Name = "gc_createdate";
            this.gc_createdate.Visible = true;
            this.gc_createdate.VisibleIndex = 1;
            this.gc_createdate.Width = 226;
            // 
            // gc_status
            // 
            this.gc_status.Caption = "状态";
            this.gc_status.FieldName = "STATUS";
            this.gc_status.Name = "gc_status";
            this.gc_status.Visible = true;
            this.gc_status.VisibleIndex = 2;
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
            this.bbi_Add.Caption = "增加工作流信息";
            this.bbi_Add.Id = 0;
            this.bbi_Add.Name = "bbi_Add";
            this.bbi_Add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Add_ItemClick);
            // 
            // bbi_Edit
            // 
            this.bbi_Edit.Caption = "修改工作流信息";
            this.bbi_Edit.Id = 1;
            this.bbi_Edit.Name = "bbi_Edit";
            this.bbi_Edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Edit_ItemClick);
            // 
            // bbi_Delete
            // 
            this.bbi_Delete.Caption = "删除工作流信息";
            this.bbi_Delete.Id = 2;
            this.bbi_Delete.Name = "bbi_Delete";
            this.bbi_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Delete_ItemClick);
            this.bbi_Add.Glyph = global::Student.Properties.Resources.additem_32x32;
            this.bbi_Edit.Glyph = global::Student.Properties.Resources.edit_32x32;
            this.bbi_Delete.Glyph = global::Student.Properties.Resources.deleteitem_32x32;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1007, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 427);
            this.barDockControlBottom.Size = new System.Drawing.Size(1007, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 427);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1007, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 427);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1007, 427);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // frmWORKFLOW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 427);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmWORKFLOW";
            this.Text = "工作流信息管理";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_workflowname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton sbt_clear;
        private DevExpress.XtraEditors.SimpleButton sbt_find;
        private DevExpress.XtraEditors.TextEdit te_workflowname;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gc_workflowno;
        private DevExpress.XtraGrid.Columns.GridColumn gc_workflowname;
        private DevExpress.XtraGrid.Columns.GridColumn gc_createdate;
        private DevExpress.XtraGrid.Columns.GridColumn gc_status;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbi_Add;
        private DevExpress.XtraBars.BarButtonItem bbi_Edit;
        private DevExpress.XtraBars.BarButtonItem bbi_Delete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton sbt_Quit;
    }
}