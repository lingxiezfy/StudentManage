namespace Student.Forms
{
    partial class frmENTERPRISE
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.te_enteraddr = new DevExpress.XtraEditors.TextEdit();
            this.te_entername = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_enterprisename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_enterpriseinfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_enterpriseaddr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_enterprisecont1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_enterprisephone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_enterprisecont2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_enterprisephone2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_enterprisecont3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_enterprisephone3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_memo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_demand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.sbt_Find = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sbt_Quit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.te_enteraddr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_entername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "企业名称";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(281, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "企业地址";
            // 
            // te_enteraddr
            // 
            this.te_enteraddr.Location = new System.Drawing.Point(353, 38);
            this.te_enteraddr.Name = "te_enteraddr";
            this.te_enteraddr.Size = new System.Drawing.Size(169, 20);
            this.te_enteraddr.TabIndex = 2;
            // 
            // te_entername
            // 
            this.te_entername.Location = new System.Drawing.Point(89, 38);
            this.te_entername.Name = "te_entername";
            this.te_entername.Size = new System.Drawing.Size(169, 20);
            this.te_entername.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 88);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1270, 436);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.bandedGridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_enterprisename,
            this.gc_enterpriseinfo,
            this.gc_enterpriseaddr,
            this.gc_enterprisecont1,
            this.gc_enterprisephone1,
            this.gc_enterprisecont2,
            this.gc_enterprisephone2,
            this.gc_enterprisecont3,
            this.gc_enterprisephone3,
            this.gc_memo,
            this.gc_demand});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gc_enterprisename
            // 
            this.gc_enterprisename.Caption = "企业编号";
            this.gc_enterprisename.FieldName = "ENTNO";
            this.gc_enterprisename.Name = "gc_enterprisename";
            this.gc_enterprisename.Width = 57;
            // 
            // gc_enterpriseinfo
            // 
            this.gc_enterpriseinfo.Caption = "企业信息";
            this.gc_enterpriseinfo.FieldName = "ENTNAME";
            this.gc_enterpriseinfo.Name = "gc_enterpriseinfo";
            this.gc_enterpriseinfo.Visible = true;
            this.gc_enterpriseinfo.VisibleIndex = 0;
            this.gc_enterpriseinfo.Width = 107;
            // 
            // gc_enterpriseaddr
            // 
            this.gc_enterpriseaddr.Caption = "企业地址";
            this.gc_enterpriseaddr.FieldName = "ENTADDRESS";
            this.gc_enterpriseaddr.Name = "gc_enterpriseaddr";
            this.gc_enterpriseaddr.Visible = true;
            this.gc_enterpriseaddr.VisibleIndex = 1;
            this.gc_enterpriseaddr.Width = 115;
            // 
            // gc_enterprisecont1
            // 
            this.gc_enterprisecont1.Caption = "联系人1";
            this.gc_enterprisecont1.FieldName = "LINKER1";
            this.gc_enterprisecont1.Name = "gc_enterprisecont1";
            this.gc_enterprisecont1.Visible = true;
            this.gc_enterprisecont1.VisibleIndex = 2;
            this.gc_enterprisecont1.Width = 66;
            // 
            // gc_enterprisephone1
            // 
            this.gc_enterprisephone1.Caption = "联系电话1";
            this.gc_enterprisephone1.FieldName = "PHONE1";
            this.gc_enterprisephone1.Name = "gc_enterprisephone1";
            this.gc_enterprisephone1.Visible = true;
            this.gc_enterprisephone1.VisibleIndex = 3;
            this.gc_enterprisephone1.Width = 110;
            // 
            // gc_enterprisecont2
            // 
            this.gc_enterprisecont2.Caption = "联系人2";
            this.gc_enterprisecont2.FieldName = "LINKER2";
            this.gc_enterprisecont2.Name = "gc_enterprisecont2";
            this.gc_enterprisecont2.Visible = true;
            this.gc_enterprisecont2.VisibleIndex = 4;
            this.gc_enterprisecont2.Width = 55;
            // 
            // gc_enterprisephone2
            // 
            this.gc_enterprisephone2.Caption = "联系方式2";
            this.gc_enterprisephone2.FieldName = "PHONE2";
            this.gc_enterprisephone2.Name = "gc_enterprisephone2";
            this.gc_enterprisephone2.Visible = true;
            this.gc_enterprisephone2.VisibleIndex = 5;
            this.gc_enterprisephone2.Width = 133;
            // 
            // gc_enterprisecont3
            // 
            this.gc_enterprisecont3.Caption = "联系人3";
            this.gc_enterprisecont3.FieldName = "LINKER3";
            this.gc_enterprisecont3.Name = "gc_enterprisecont3";
            this.gc_enterprisecont3.Visible = true;
            this.gc_enterprisecont3.VisibleIndex = 6;
            this.gc_enterprisecont3.Width = 57;
            // 
            // gc_enterprisephone3
            // 
            this.gc_enterprisephone3.Caption = "联系方式3";
            this.gc_enterprisephone3.FieldName = "PHONE3";
            this.gc_enterprisephone3.Name = "gc_enterprisephone3";
            this.gc_enterprisephone3.Visible = true;
            this.gc_enterprisephone3.VisibleIndex = 7;
            this.gc_enterprisephone3.Width = 156;
            // 
            // gc_memo
            // 
            this.gc_memo.Caption = "企业简介";
            this.gc_memo.FieldName = "MEMO";
            this.gc_memo.Name = "gc_memo";
            this.gc_memo.Visible = true;
            this.gc_memo.VisibleIndex = 8;
            this.gc_memo.Width = 156;
            // 
            // gc_demand
            // 
            this.gc_demand.Caption = "企业要求";
            this.gc_demand.FieldName = "DEMAND";
            this.gc_demand.Name = "gc_demand";
            this.gc_demand.Visible = true;
            this.gc_demand.VisibleIndex = 9;
            this.gc_demand.Width = 198;
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            // 
            // sbt_Find
            // 
            this.sbt_Find.Location = new System.Drawing.Point(559, 37);
            this.sbt_Find.Name = "sbt_Find";
            this.sbt_Find.Size = new System.Drawing.Size(130, 23);
            this.sbt_Find.TabIndex = 5;
            this.sbt_Find.Text = "查询数据";
            this.sbt_Find.Click += new System.EventHandler(this.sbt_Find_Click);
            // 
            // sbt_Clear
            // 
            this.sbt_Clear.Location = new System.Drawing.Point(721, 37);
            this.sbt_Clear.Name = "sbt_Clear";
            this.sbt_Clear.Size = new System.Drawing.Size(130, 23);
            this.sbt_Clear.TabIndex = 6;
            this.sbt_Clear.Text = "清空查询条件";
            this.sbt_Clear.Click += new System.EventHandler(this.sbt_Clear_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.sbt_Quit);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.sbt_Clear);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.sbt_Find);
            this.groupControl1.Controls.Add(this.te_enteraddr);
            this.groupControl1.Controls.Add(this.te_entername);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1270, 79);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "查询条件";
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
            // bbiAdd
            // 
            this.bbiAdd.Caption = "增加企业信息";
            this.bbiAdd.Id = 4;
            this.bbiAdd.Name = "bbiAdd";
            this.bbiAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAdd_ItemClick_1);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "编辑企业信息";
            this.bbiEdit.Id = 6;
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "删除企业信息";
            this.bbiDelete.Id = 7;
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick_1);
            this.bbiAdd.Glyph = global::Student.Properties.Resources.additem_32x32;
            this.bbiEdit.Glyph = global::Student.Properties.Resources.edit_32x32;
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
            this.bbiEdit,
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 527);
            this.barDockControlBottom.Size = new System.Drawing.Size(1276, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 527);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1276, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 527);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1276, 527);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // sbt_Quit
            // 
            this.sbt_Quit.Image = Student.Properties.Resources.Close_16x16;
            this.sbt_Clear.Image = global::Student.Properties.Resources.Refresh_16x16;
            this.sbt_Find.Image = global::Student.Properties.Resources.Search;
            this.sbt_Quit.Location = new System.Drawing.Point(883, 37);
            this.sbt_Quit.Name = "sbt_Quit";
            this.sbt_Quit.Size = new System.Drawing.Size(130, 23);
            this.sbt_Quit.TabIndex = 7;
            this.sbt_Quit.Text = "退出";
            this.sbt_Quit.Click += new System.EventHandler(this.sbt_Quit_Click);
            // 
            // frmENTERPRISE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 527);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmENTERPRISE";
            this.Text = "用人企业信息管理";
            this.Load += new System.EventHandler(this.frmENTERPRISE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.te_enteraddr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_entername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit te_enteraddr;
        private DevExpress.XtraEditors.TextEdit te_entername;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton sbt_Find;
        private DevExpress.XtraEditors.SimpleButton sbt_Clear;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Columns.GridColumn gc_enterprisename;
        private DevExpress.XtraGrid.Columns.GridColumn gc_enterpriseinfo;
        private DevExpress.XtraGrid.Columns.GridColumn gc_enterpriseaddr;
        private DevExpress.XtraGrid.Columns.GridColumn gc_enterprisecont1;
        private DevExpress.XtraGrid.Columns.GridColumn gc_enterprisephone1;
        private DevExpress.XtraGrid.Columns.GridColumn gc_enterprisecont2;
        private DevExpress.XtraGrid.Columns.GridColumn gc_enterprisephone2;
        private DevExpress.XtraGrid.Columns.GridColumn gc_enterprisecont3;
        private DevExpress.XtraGrid.Columns.GridColumn gc_enterprisephone3;
        private DevExpress.XtraGrid.Columns.GridColumn gc_memo;
        private DevExpress.XtraGrid.Columns.GridColumn gc_demand;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton sbt_Quit;
    }
}