namespace Student.Forms
{
    partial class frmMAJORDIRCT
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
            this.cbb_major = new DevExpress.XtraEditors.ComboBoxEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbi_Add = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Edit = new DevExpress.XtraBars.BarButtonItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Sbtn_clear = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_Find = new DevExpress.XtraEditors.SimpleButton();
            this.te_majordirctname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_MAJORDIRCTNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_MAJORNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_MAJORDIRCTNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sbt_Quit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_major.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_majordirctname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.sbt_Quit);
            this.groupControl1.Controls.Add(this.cbb_major);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.Sbtn_clear);
            this.groupControl1.Controls.Add(this.sbtn_Find);
            this.groupControl1.Controls.Add(this.te_majordirctname);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1156, 79);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "查询条件";
            // 
            // cbb_major
            // 
            this.cbb_major.Location = new System.Drawing.Point(93, 37);
            this.cbb_major.MenuManager = this.barManager1;
            this.cbb_major.Name = "cbb_major";
            this.cbb_major.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_major.Size = new System.Drawing.Size(185, 20);
            this.cbb_major.TabIndex = 11;
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
            this.bbi_Delete,
            this.bbi_Edit});
            this.barManager1.MaxItemId = 8;
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 566);
            this.barDockControlBottom.Size = new System.Drawing.Size(1162, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 566);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1162, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 566);
            // 
            // bbi_Add
            // 
            this.bbi_Add.Caption = "增加专业方向信息";
            this.bbi_Add.Id = 1;
            this.bbi_Add.Name = "bbi_Add";
            this.bbi_Add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Add_ItemClick);
            // 
            // bbi_Delete
            // 
            this.bbi_Delete.Caption = "删除专业方向信息";
            this.bbi_Delete.Id = 2;
            this.bbi_Delete.Name = "bbi_Delete";
            this.bbi_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Delete_ItemClick);
            // 
            // bbi_Edit
            // 
            this.bbi_Edit.Caption = "修改专业方向信息";
            this.bbi_Edit.Id = 3;
            this.bbi_Edit.Name = "bbi_Edit";
            this.bbi_Edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Edit_ItemClick);
            this.bbi_Add.Glyph = global::Student.Properties.Resources.additem_32x32;
            this.bbi_Edit.Glyph = global::Student.Properties.Resources.edit_32x32;
            this.bbi_Delete.Glyph = global::Student.Properties.Resources.deleteitem_32x32;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "专业名称";
            // 
            // Sbtn_clear
            // 
            this.Sbtn_clear.Image = global::Student.Properties.Resources.Refresh_16x16;
            this.Sbtn_clear.Location = new System.Drawing.Point(774, 36);
            this.Sbtn_clear.Name = "Sbtn_clear";
            this.Sbtn_clear.Size = new System.Drawing.Size(130, 23);
            this.Sbtn_clear.TabIndex = 9;
            this.Sbtn_clear.Text = "清空查询条件 ";
            this.Sbtn_clear.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // sbtn_Find
            // 
            this.sbtn_Find.Image = global::Student.Properties.Resources.Search;
            this.sbtn_Find.Location = new System.Drawing.Point(624, 36);
            this.sbtn_Find.Name = "sbtn_Find";
            this.sbtn_Find.Size = new System.Drawing.Size(130, 23);
            this.sbtn_Find.TabIndex = 8;
            this.sbtn_Find.Text = "查询数据";
            this.sbtn_Find.Click += new System.EventHandler(this.sbtn_Find_Click);
            this.sbtn_Find.Paint += new System.Windows.Forms.PaintEventHandler(this.simpleButton1_Paint);
            // 
            // te_majordirctname
            // 
            this.te_majordirctname.Location = new System.Drawing.Point(411, 37);
            this.te_majordirctname.Name = "te_majordirctname";
            this.te_majordirctname.Size = new System.Drawing.Size(185, 20);
            this.te_majordirctname.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(315, 40);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 14);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "专业方向名称";
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
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 88);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1156, 475);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_MAJORDIRCTNO,
            this.gc_MAJORNAME,
            this.gc_MAJORDIRCTNAME});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gc_MAJORDIRCTNO
            // 
            this.gc_MAJORDIRCTNO.AppearanceCell.Options.UseTextOptions = true;
            this.gc_MAJORDIRCTNO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_MAJORDIRCTNO.AppearanceHeader.Options.UseTextOptions = true;
            this.gc_MAJORDIRCTNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gc_MAJORDIRCTNO.Caption = "专业方向编号";
            this.gc_MAJORDIRCTNO.FieldName = "MAJORDIRCTNO";
            this.gc_MAJORDIRCTNO.Name = "gc_MAJORDIRCTNO";
            this.gc_MAJORDIRCTNO.Width = 150;
            // 
            // gc_MAJORNAME
            // 
            this.gc_MAJORNAME.Caption = "所属专业名称";
            this.gc_MAJORNAME.FieldName = "MAJORNAME";
            this.gc_MAJORNAME.Name = "gc_MAJORNAME";
            this.gc_MAJORNAME.Visible = true;
            this.gc_MAJORNAME.VisibleIndex = 0;
            // 
            // gc_MAJORDIRCTNAME
            // 
            this.gc_MAJORDIRCTNAME.Caption = "专业方向名称";
            this.gc_MAJORDIRCTNAME.FieldName = "MAJORDIRCTNAME";
            this.gc_MAJORDIRCTNAME.Name = "gc_MAJORDIRCTNAME";
            this.gc_MAJORDIRCTNAME.Visible = true;
            this.gc_MAJORDIRCTNAME.VisibleIndex = 1;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1162, 566);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // sbt_Quit
            // 
            this.sbt_Quit.Image = Student.Properties.Resources.Close_16x16;
            this.sbt_Quit.Location = new System.Drawing.Point(931, 36);
            this.sbt_Quit.Name = "sbt_Quit";
            this.sbt_Quit.Size = new System.Drawing.Size(130, 23);
            this.sbt_Quit.TabIndex = 13;
            this.sbt_Quit.Text = "退出";
            this.sbt_Quit.Click += new System.EventHandler(this.sbt_Quit_Click);
            // 
            // frmMAJORDIRCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 566);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMAJORDIRCT";
            this.Text = "专业信息表";
            this.Load += new System.EventHandler(this.frmMAJORDIRCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_major.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_majordirctname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit te_majordirctname;
        private DevExpress.XtraEditors.SimpleButton Sbtn_clear;
        private DevExpress.XtraEditors.SimpleButton sbtn_Find;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbi_Add;
        private DevExpress.XtraBars.BarButtonItem bbi_Delete;
        private DevExpress.XtraBars.BarButtonItem bbi_Edit;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_major;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gc_MAJORDIRCTNO;
        private DevExpress.XtraGrid.Columns.GridColumn gc_MAJORNAME;
        private DevExpress.XtraGrid.Columns.GridColumn gc_MAJORDIRCTNAME;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton sbt_Quit;
    }
}