namespace Student.Forms
{
    partial class frmTERM
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
            this.groupContro1 = new DevExpress.XtraEditors.GroupControl();
            this.te_termname = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.sbtn_clear = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_find = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridviews = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_TERMno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_TERMname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_termbegintime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_termendtime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_termflag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sbt_Quit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupContro1)).BeginInit();
            this.groupContro1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_termname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupContro1
            // 
            this.groupContro1.Controls.Add(this.sbt_Quit);
            this.groupContro1.Controls.Add(this.te_termname);
            this.groupContro1.Controls.Add(this.sbtn_clear);
            this.groupContro1.Controls.Add(this.sbtn_find);
            this.groupContro1.Controls.Add(this.labelControl2);
            this.groupContro1.Controls.Add(this.labelControl1);
            this.groupContro1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupContro1.Location = new System.Drawing.Point(3, 3);
            this.groupContro1.Name = "groupContro1";
            this.groupContro1.Size = new System.Drawing.Size(1064, 74);
            this.groupContro1.TabIndex = 0;
            this.groupContro1.Text = "查询条件";
            // 
            // te_termname
            // 
            this.te_termname.Location = new System.Drawing.Point(69, 38);
            this.te_termname.MenuManager = this.barManager1;
            this.te_termname.Name = "te_termname";
            this.te_termname.Size = new System.Drawing.Size(199, 20);
            this.te_termname.TabIndex = 10;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1070, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 572);
            this.barDockControlBottom.Size = new System.Drawing.Size(1070, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(1070, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 572);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "添加学期信息";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "删除学期信息";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick_1);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "修改学期信息";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick_1);
            this.barButtonItem1.Glyph = global::Student.Properties.Resources.additem_32x32;
            this.barButtonItem3.Glyph = global::Student.Properties.Resources.edit_32x32;
            this.barButtonItem2.Glyph = global::Student.Properties.Resources.deleteitem_32x32;
            // 
            // sbtn_clear
            // 
            this.sbtn_clear.Image = global::Student.Properties.Resources.Refresh_16x16;
            this.sbtn_clear.Location = new System.Drawing.Point(480, 37);
            this.sbtn_clear.Name = "sbtn_clear";
            this.sbtn_clear.Size = new System.Drawing.Size(130, 23);
            this.sbtn_clear.TabIndex = 9;
            this.sbtn_clear.Text = "清空查询条件";
            this.sbtn_clear.Click += new System.EventHandler(this.sbtn_clear_Click_1);
            // 
            // sbtn_find
            // 
            this.sbtn_find.Image = global::Student.Properties.Resources.Search;
            this.sbtn_find.Location = new System.Drawing.Point(319, 37);
            this.sbtn_find.Name = "sbtn_find";
            this.sbtn_find.Size = new System.Drawing.Size(130, 23);
            this.sbtn_find.TabIndex = 8;
            this.sbtn_find.Text = "查询数据";
            this.sbtn_find.Click += new System.EventHandler(this.sbtn_find_Click_1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "学期名称";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 14);
            this.labelControl1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(3, 83);
            this.gridControl1.MainView = this.gridviews;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1064, 486);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridviews});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            // 
            // gridviews
            // 
            this.gridviews.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_TERMno,
            this.gc_TERMname,
            this.gc_termbegintime,
            this.gc_termendtime,
            this.gc_termflag});
            this.gridviews.GridControl = this.gridControl1;
            this.gridviews.Name = "gridviews";
            this.gridviews.OptionsBehavior.Editable = false;
            this.gridviews.OptionsView.ShowGroupPanel = false;
            // 
            // gc_TERMno
            // 
            this.gc_TERMno.Caption = "学期编号";
            this.gc_TERMno.FieldName = "TERMNO";
            this.gc_TERMno.Name = "gc_TERMno";
            this.gc_TERMno.Visible = true;
            this.gc_TERMno.VisibleIndex = 0;
            this.gc_TERMno.Width = 90;
            // 
            // gc_TERMname
            // 
            this.gc_TERMname.Caption = "学期名称";
            this.gc_TERMname.FieldName = "TERMNAME";
            this.gc_TERMname.Name = "gc_TERMname";
            this.gc_TERMname.Visible = true;
            this.gc_TERMname.VisibleIndex = 1;
            this.gc_TERMname.Width = 120;
            // 
            // gc_termbegintime
            // 
            this.gc_termbegintime.Caption = "起始时间";
            this.gc_termbegintime.FieldName = "BEGINTIME";
            this.gc_termbegintime.Name = "gc_termbegintime";
            this.gc_termbegintime.Visible = true;
            this.gc_termbegintime.VisibleIndex = 2;
            this.gc_termbegintime.Width = 217;
            // 
            // gc_termendtime
            // 
            this.gc_termendtime.Caption = "截止时间";
            this.gc_termendtime.FieldName = "ENDTIME";
            this.gc_termendtime.Name = "gc_termendtime";
            this.gc_termendtime.Visible = true;
            this.gc_termendtime.VisibleIndex = 3;
            this.gc_termendtime.Width = 217;
            // 
            // gc_termflag
            // 
            this.gc_termflag.Caption = "标志";
            this.gc_termflag.FieldName = "FLAG";
            this.gc_termflag.Name = "gc_termflag";
            this.gc_termflag.Visible = true;
            this.gc_termflag.VisibleIndex = 4;
            this.gc_termflag.Width = 70;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupContro1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1070, 572);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // sbt_Quit
            // 
            this.sbt_Quit.Image = Student.Properties.Resources.Close_16x16;
            this.sbt_Quit.Location = new System.Drawing.Point(641, 37);
            this.sbt_Quit.Name = "sbt_Quit";
            this.sbt_Quit.Size = new System.Drawing.Size(130, 23);
            this.sbt_Quit.TabIndex = 11;
            this.sbt_Quit.Text = "退出";
            this.sbt_Quit.Click += new System.EventHandler(this.sbt_Quit_Click);
            // 
            // frmTERM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 572);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTERM";
            this.Text = "学期信息管理";
            this.Load += new System.EventHandler(this.frmTERM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupContro1)).EndInit();
            this.groupContro1.ResumeLayout(false);
            this.groupContro1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_termname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupContro1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridviews;
        private DevExpress.XtraGrid.Columns.GridColumn gc_TERMno;
        private DevExpress.XtraGrid.Columns.GridColumn gc_TERMname;
        private DevExpress.XtraGrid.Columns.GridColumn gc_termbegintime;
        private DevExpress.XtraGrid.Columns.GridColumn gc_termendtime;
        private DevExpress.XtraGrid.Columns.GridColumn gc_termflag;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton sbtn_find;
        private DevExpress.XtraEditors.SimpleButton sbtn_clear;
        private DevExpress.XtraEditors.TextEdit te_termname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton sbt_Quit;
    }
}