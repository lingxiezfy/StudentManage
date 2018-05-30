namespace Student.Forms
{
    partial class frmWORKFLOWSET
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
            this.clbc_workflow = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gc_workflowset = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_SETNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_NODENAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_WORKFLOWNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_NODEORDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_BEGINTIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_ENDTIME = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.clbc_workflow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_workflowset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.clbc_workflow);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(269, 686);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "工作流列表";
            // 
            // clbc_workflow
            // 
            this.clbc_workflow.CheckOnClick = true;
            this.clbc_workflow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbc_workflow.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick;
            this.clbc_workflow.Location = new System.Drawing.Point(2, 22);
            this.clbc_workflow.Name = "clbc_workflow";
            this.clbc_workflow.Size = new System.Drawing.Size(265, 662);
            this.clbc_workflow.TabIndex = 1;
            this.clbc_workflow.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.clbc_workflow_ItemCheck);
            this.clbc_workflow.SelectedIndexChanged += new System.EventHandler(this.clbc_workflow_SelectedIndexChanged);
            this.clbc_workflow.Click += new System.EventHandler(this.clbc_workflow_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gc_workflowset);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(278, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(995, 686);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "工作流设置信息";
            // 
            // gc_workflowset
            // 
            this.gc_workflowset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_workflowset.Location = new System.Drawing.Point(2, 22);
            this.gc_workflowset.MainView = this.gridView1;
            this.gc_workflowset.Name = "gc_workflowset";
            this.gc_workflowset.Size = new System.Drawing.Size(991, 662);
            this.gc_workflowset.TabIndex = 0;
            this.gc_workflowset.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gc_workflowset.Click += new System.EventHandler(this.gc_workflowset_Click);
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
            this.gc_SETNO,
            this.gc_NODENAME,
            this.gc_WORKFLOWNAME,
            this.gc_NODEORDER,
            this.gc_BEGINTIME,
            this.gc_ENDTIME});
            this.gridView1.GridControl = this.gc_workflowset;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gc_SETNO
            // 
            this.gc_SETNO.Caption = "编号";
            this.gc_SETNO.FieldName = "SETNO";
            this.gc_SETNO.Name = "gc_SETNO";
            this.gc_SETNO.Width = 84;
            // 
            // gc_NODENAME
            // 
            this.gc_NODENAME.Caption = "工作节点名称";
            this.gc_NODENAME.FieldName = "NODENAME";
            this.gc_NODENAME.Name = "gc_NODENAME";
            this.gc_NODENAME.Visible = true;
            this.gc_NODENAME.VisibleIndex = 1;
            // 
            // gc_WORKFLOWNAME
            // 
            this.gc_WORKFLOWNAME.Caption = "工作流名称";
            this.gc_WORKFLOWNAME.FieldName = "WORKFLOWNAME";
            this.gc_WORKFLOWNAME.Name = "gc_WORKFLOWNAME";
            this.gc_WORKFLOWNAME.Visible = true;
            this.gc_WORKFLOWNAME.VisibleIndex = 0;
            // 
            // gc_NODEORDER
            // 
            this.gc_NODEORDER.Caption = "节点顺序";
            this.gc_NODEORDER.FieldName = "NODEORDER";
            this.gc_NODEORDER.Name = "gc_NODEORDER";
            this.gc_NODEORDER.Visible = true;
            this.gc_NODEORDER.VisibleIndex = 2;
            // 
            // gc_BEGINTIME
            // 
            this.gc_BEGINTIME.Caption = "生效日期";
            this.gc_BEGINTIME.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.gc_BEGINTIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gc_BEGINTIME.FieldName = "BEGINTIME";
            this.gc_BEGINTIME.Name = "gc_BEGINTIME";
            this.gc_BEGINTIME.Visible = true;
            this.gc_BEGINTIME.VisibleIndex = 3;
            // 
            // gc_ENDTIME
            // 
            this.gc_ENDTIME.Caption = "失效日期";
            this.gc_ENDTIME.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.gc_ENDTIME.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gc_ENDTIME.FieldName = "ENDTIME";
            this.gc_ENDTIME.Name = "gc_ENDTIME";
            this.gc_ENDTIME.Visible = true;
            this.gc_ENDTIME.VisibleIndex = 4;
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
            this.bbi_Add.Caption = "增加工作流节点";
            this.bbi_Add.Id = 2;
            this.bbi_Add.Name = "bbi_Add";
            this.bbi_Add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Add_ItemClick);
            // 
            // bbi_Edit
            // 
            this.bbi_Edit.Caption = "修改工作流设置";
            this.bbi_Edit.Id = 1;
            this.bbi_Edit.Name = "bbi_Edit";
            this.bbi_Edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Edit_ItemClick);
            this.bbi_Add.Glyph = global::Student.Properties.Resources.additem_32x32;
            this.bbi_Edit.Glyph = global::Student.Properties.Resources.edit_32x32;
            this.bbi_Delete.Glyph = global::Student.Properties.Resources.deleteitem_32x32;
            // 
            // bbi_Delete
            // 
            this.bbi_Delete.Caption = "删除工作流节点";
            this.bbi_Delete.Id = 3;
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
            this.barManager1.MaxItemId = 4;
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 692);
            this.barDockControlBottom.Size = new System.Drawing.Size(1276, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 692);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1276, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 692);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1276, 692);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // frmWORKFLOWSET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 692);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmWORKFLOWSET";
            this.Text = "工作流设置";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clbc_workflow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_workflowset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gc_workflowset;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gc_SETNO;
        private DevExpress.XtraGrid.Columns.GridColumn gc_WORKFLOWNAME;
        private DevExpress.XtraGrid.Columns.GridColumn gc_NODENAME;
        private DevExpress.XtraGrid.Columns.GridColumn gc_NODEORDER;
        private DevExpress.XtraGrid.Columns.GridColumn gc_BEGINTIME;
        private DevExpress.XtraGrid.Columns.GridColumn gc_ENDTIME;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem bbi_Add;
        private DevExpress.XtraBars.BarButtonItem bbi_Edit;
        private DevExpress.XtraBars.BarButtonItem bbi_Delete;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.CheckedListBoxControl clbc_workflow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}