namespace Student.Forms
{
    partial class frmDEPARTMENT
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
            this.Sbtn_clear = new DevExpress.XtraEditors.SimpleButton();
            this.Sbtn_find = new DevExpress.XtraEditors.SimpleButton();
            this.Te_departmentname = new DevExpress.XtraEditors.TextEdit();
            this.Lblc_departmentname = new DevExpress.XtraEditors.LabelControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiedit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiadd = new DevExpress.XtraBars.BarButtonItem();
            this.bbidelete = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcDEPARTMENTNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDEPARTMENTNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Te_departmentname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.sbt_Quit);
            this.groupControl1.Controls.Add(this.Sbtn_clear);
            this.groupControl1.Controls.Add(this.Sbtn_find);
            this.groupControl1.Controls.Add(this.Te_departmentname);
            this.groupControl1.Controls.Add(this.Lblc_departmentname);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1270, 84);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "查询条件";
            // 
            // sbt_Quit
            // 
            this.sbt_Quit.Image = global::Student.Properties.Resources.Close_16x16;
            this.sbt_Quit.Location = new System.Drawing.Point(637, 40);
            this.sbt_Quit.Name = "sbt_Quit";
            this.sbt_Quit.Size = new System.Drawing.Size(130, 23);
            this.sbt_Quit.TabIndex = 5;
            this.sbt_Quit.Text = "退出";
            this.sbt_Quit.Click += new System.EventHandler(this.sbt_Quit_Click);
            // 
            // Sbtn_clear
            // 
            this.Sbtn_clear.Image = global::Student.Properties.Resources.Refresh_16x16;
            this.Sbtn_clear.Location = new System.Drawing.Point(486, 40);
            this.Sbtn_clear.Name = "Sbtn_clear";
            this.Sbtn_clear.Size = new System.Drawing.Size(130, 23);
            this.Sbtn_clear.TabIndex = 3;
            this.Sbtn_clear.Text = "清空查询条件";
            this.Sbtn_clear.Click += new System.EventHandler(this.Sbtn_clear_Click);
            // 
            // Sbtn_find
            // 
            this.Sbtn_find.Image = global::Student.Properties.Resources.Search;
            this.Sbtn_find.Location = new System.Drawing.Point(335, 40);
            this.Sbtn_find.Name = "Sbtn_find";
            this.Sbtn_find.Size = new System.Drawing.Size(130, 23);
            this.Sbtn_find.TabIndex = 2;
            this.Sbtn_find.Text = "查询数据";
            this.Sbtn_find.Click += new System.EventHandler(this.Sbtn_find_Click);
            // 
            // Te_departmentname
            // 
            this.Te_departmentname.Location = new System.Drawing.Point(88, 41);
            this.Te_departmentname.Name = "Te_departmentname";
            this.Te_departmentname.Size = new System.Drawing.Size(241, 20);
            this.Te_departmentname.TabIndex = 1;
            // 
            // Lblc_departmentname
            // 
            this.Lblc_departmentname.Location = new System.Drawing.Point(26, 44);
            this.Lblc_departmentname.Name = "Lblc_departmentname";
            this.Lblc_departmentname.Size = new System.Drawing.Size(48, 14);
            this.Lblc_departmentname.TabIndex = 0;
            this.Lblc_departmentname.Text = "学院名称";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiedit,
            this.bbiadd,
            this.bbidelete});
            this.barManager1.MaxItemId = 5;
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 634);
            this.barDockControlBottom.Size = new System.Drawing.Size(1276, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 634);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1276, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 634);
            // 
            // bbiedit
            // 
            this.bbiedit.Caption = "修改学院信息";
            this.bbiedit.Glyph = global::Student.Properties.Resources.edit_32x32;
            this.bbiedit.Id = 0;
            this.bbiedit.Name = "bbiedit";
            this.bbiedit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiedit_ItemClick);
            // 
            // bbiadd
            // 
            this.bbiadd.Caption = "增加学院信息";
            this.bbiadd.Glyph = global::Student.Properties.Resources.additem_32x32;
            this.bbiadd.Id = 1;
            this.bbiadd.Name = "bbiadd";
            this.bbiadd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiadd_ItemClick);
            // 
            // bbidelete
            // 
            this.bbidelete.Caption = "删除学院信息";
            this.bbidelete.Glyph = global::Student.Properties.Resources.deleteitem_32x32;
            this.bbidelete.Id = 2;
            this.bbidelete.Name = "bbidelete";
            this.bbidelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbidelete_ItemClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiadd),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiedit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbidelete)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcDEPARTMENTNO,
            this.gcDEPARTMENTNAME});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // gcDEPARTMENTNO
            // 
            this.gcDEPARTMENTNO.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gcDEPARTMENTNO.AppearanceCell.Options.UseTextOptions = true;
            this.gcDEPARTMENTNO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcDEPARTMENTNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gcDEPARTMENTNO.Caption = "学院编号";
            this.gcDEPARTMENTNO.FieldName = "DEPARTMENTNO";
            this.gcDEPARTMENTNO.MaxWidth = 150;
            this.gcDEPARTMENTNO.Name = "gcDEPARTMENTNO";
            this.gcDEPARTMENTNO.Visible = true;
            this.gcDEPARTMENTNO.VisibleIndex = 0;
            // 
            // gcDEPARTMENTNAME
            // 
            this.gcDEPARTMENTNAME.Caption = "学院名称";
            this.gcDEPARTMENTNAME.FieldName = "DEPARTMENTNAME";
            this.gcDEPARTMENTNAME.Name = "gcDEPARTMENTNAME";
            this.gcDEPARTMENTNAME.Visible = true;
            this.gcDEPARTMENTNAME.VisibleIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 93);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1270, 538);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 542F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1276, 634);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // frmDEPARTMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 634);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDEPARTMENT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学院信息管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Te_departmentname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Sbtn_clear;
        private DevExpress.XtraEditors.SimpleButton Sbtn_find;
        private DevExpress.XtraEditors.TextEdit Te_departmentname;
        private DevExpress.XtraEditors.LabelControl Lblc_departmentname;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiedit;
        private DevExpress.XtraBars.BarButtonItem bbiadd;
        private DevExpress.XtraBars.BarButtonItem bbidelete;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gcDEPARTMENTNO;
        private DevExpress.XtraGrid.Columns.GridColumn gcDEPARTMENTNAME;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton sbt_Quit;
    }
}