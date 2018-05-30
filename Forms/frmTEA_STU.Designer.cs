namespace Student.Forms
{
    partial class frmTEA_STU
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.sbt_Quit = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_Find = new DevExpress.XtraEditors.SimpleButton();
            this.cbb_term = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbb_teacher = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbb_workflow = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_GUIDANCENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_TERMNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_STUNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_studentname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_teachername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_WORKFLOWNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tl_student = new DevExpress.XtraTreeList.TreeList();
            this.sbt_Add = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_term.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_teacher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_workflow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_student)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.sbt_Quit);
            this.groupControl1.Controls.Add(this.sbt_Find);
            this.groupControl1.Controls.Add(this.cbb_term);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cbb_teacher);
            this.groupControl1.Controls.Add(this.cbb_workflow);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1196, 74);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "查询条件";
            // 
            // sbt_Quit
            // 
            this.sbt_Quit.Image = global::Student.Properties.Resources.Close_16x16;
            this.sbt_Quit.Location = new System.Drawing.Point(1020, 35);
            this.sbt_Quit.Name = "sbt_Quit";
            this.sbt_Quit.Size = new System.Drawing.Size(156, 23);
            this.sbt_Quit.TabIndex = 8;
            this.sbt_Quit.Text = "退出";
            this.sbt_Quit.Click += new System.EventHandler(this.sbt_Quit_Click);
            // 
            // sbt_Find
            // 
            this.sbt_Find.Image = global::Student.Properties.Resources.Search;
            this.sbt_Find.Location = new System.Drawing.Point(858, 35);
            this.sbt_Find.Name = "sbt_Find";
            this.sbt_Find.Size = new System.Drawing.Size(156, 23);
            this.sbt_Find.TabIndex = 7;
            this.sbt_Find.Text = "查询全部教师数据";
            this.sbt_Find.Click += new System.EventHandler(this.sbt_Find_Click);
            // 
            // cbb_term
            // 
            this.cbb_term.Location = new System.Drawing.Point(90, 36);
            this.cbb_term.Name = "cbb_term";
            this.cbb_term.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_term.Size = new System.Drawing.Size(183, 20);
            this.cbb_term.TabIndex = 6;
            this.cbb_term.SelectedIndexChanged += new System.EventHandler(this.cbb_term_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "学期名称";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(579, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "指导教师";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(300, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "工作流名称";
            // 
            // cbb_teacher
            // 
            this.cbb_teacher.Location = new System.Drawing.Point(654, 36);
            this.cbb_teacher.Name = "cbb_teacher";
            this.cbb_teacher.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_teacher.Size = new System.Drawing.Size(183, 20);
            this.cbb_teacher.TabIndex = 1;
            this.cbb_teacher.SelectedIndexChanged += new System.EventHandler(this.cbb_teacher_SelectedIndexChanged);
            // 
            // cbb_workflow
            // 
            this.cbb_workflow.Location = new System.Drawing.Point(375, 36);
            this.cbb_workflow.Name = "cbb_workflow";
            this.cbb_workflow.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_workflow.Size = new System.Drawing.Size(183, 20);
            this.cbb_workflow.TabIndex = 0;
            this.cbb_workflow.SelectedIndexChanged += new System.EventHandler(this.cbb_workflow_SelectedIndexChanged);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControl1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(376, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(817, 682);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "教师指导学生信息";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 22);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(813, 658);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_GUIDANCENO,
            this.gc_TERMNAME,
            this.gc_STUNO,
            this.gc_studentname,
            this.gc_teachername,
            this.gc_WORKFLOWNAME});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.AutoCalcPreviewLineCount = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gc_GUIDANCENO
            // 
            this.gc_GUIDANCENO.Caption = "编号";
            this.gc_GUIDANCENO.FieldName = "GUIDANCENO";
            this.gc_GUIDANCENO.Name = "gc_GUIDANCENO";
            // 
            // gc_TERMNAME
            // 
            this.gc_TERMNAME.Caption = "学期";
            this.gc_TERMNAME.FieldName = "TERMNAME";
            this.gc_TERMNAME.Name = "gc_TERMNAME";
            this.gc_TERMNAME.Visible = true;
            this.gc_TERMNAME.VisibleIndex = 0;
            // 
            // gc_STUNO
            // 
            this.gc_STUNO.Caption = "学生学号";
            this.gc_STUNO.FieldName = "STUNO";
            this.gc_STUNO.Name = "gc_STUNO";
            this.gc_STUNO.Visible = true;
            this.gc_STUNO.VisibleIndex = 1;
            // 
            // gc_studentname
            // 
            this.gc_studentname.Caption = "学生姓名";
            this.gc_studentname.FieldName = "studentname";
            this.gc_studentname.Name = "gc_studentname";
            this.gc_studentname.Visible = true;
            this.gc_studentname.VisibleIndex = 2;
            // 
            // gc_teachername
            // 
            this.gc_teachername.Caption = "教师姓名";
            this.gc_teachername.FieldName = "teachername";
            this.gc_teachername.Name = "gc_teachername";
            this.gc_teachername.Visible = true;
            this.gc_teachername.VisibleIndex = 3;
            // 
            // gc_WORKFLOWNAME
            // 
            this.gc_WORKFLOWNAME.Caption = "工作流名称";
            this.gc_WORKFLOWNAME.FieldName = "WORKFLOWNAME";
            this.gc_WORKFLOWNAME.Name = "gc_WORKFLOWNAME";
            this.gc_WORKFLOWNAME.Visible = true;
            this.gc_WORKFLOWNAME.VisibleIndex = 4;
            // 
            // tl_student
            // 
            this.tl_student.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tl_student.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tl_student.Appearance.FocusedCell.Options.UseBackColor = true;
            this.tl_student.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl_student.Location = new System.Drawing.Point(3, 3);
            this.tl_student.Name = "tl_student";
            this.tl_student.OptionsBehavior.Editable = false;
            this.tl_student.OptionsBehavior.ReadOnly = true;
            this.tl_student.OptionsView.ShowCheckBoxes = true;
            this.tl_student.Size = new System.Drawing.Size(250, 682);
            this.tl_student.TabIndex = 3;
            this.tl_student.BeforeExpand += new DevExpress.XtraTreeList.BeforeExpandEventHandler(this.tl_student_BeforeExpand);
            this.tl_student.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.tl_student_AfterCheckNode);
            // 
            // sbt_Add
            // 
            this.sbt_Add.Location = new System.Drawing.Point(22, 102);
            this.sbt_Add.Name = "sbt_Add";
            this.sbt_Add.Size = new System.Drawing.Size(75, 23);
            this.sbt_Add.TabIndex = 4;
            this.sbt_Add.Text = "添加";
            this.sbt_Add.Click += new System.EventHandler(this.sbt_Add_Click);
            // 
            // sbt_Delete
            // 
            this.sbt_Delete.Location = new System.Drawing.Point(23, 153);
            this.sbt_Delete.Name = "sbt_Delete";
            this.sbt_Delete.Size = new System.Drawing.Size(75, 23);
            this.sbt_Delete.TabIndex = 5;
            this.sbt_Delete.Text = "删除";
            this.sbt_Delete.Click += new System.EventHandler(this.sbt_Delete_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1202, 774);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.48383F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.51617F));
            this.tableLayoutPanel2.Controls.Add(this.groupControl3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tl_student, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1196, 688);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sbt_Add);
            this.panel1.Controls.Add(this.sbt_Delete);
            this.panel1.Location = new System.Drawing.Point(259, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 309);
            this.panel1.TabIndex = 7;
            // 
            // frmTEA_STU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 774);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmTEA_STU";
            this.Text = "学生实习设置";
            this.Load += new System.EventHandler(this.frmTEA_STU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_term.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_teacher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_workflow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tl_student)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraTreeList.TreeList tl_student;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_teacher;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_workflow;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_term;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton sbt_Find;
        private DevExpress.XtraEditors.SimpleButton sbt_Add;
        private DevExpress.XtraEditors.SimpleButton sbt_Delete;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gc_GUIDANCENO;
        private DevExpress.XtraGrid.Columns.GridColumn gc_TERMNAME;
        private DevExpress.XtraGrid.Columns.GridColumn gc_STUNO;
        private DevExpress.XtraGrid.Columns.GridColumn gc_studentname;
        private DevExpress.XtraGrid.Columns.GridColumn gc_teachername;
        private DevExpress.XtraGrid.Columns.GridColumn gc_WORKFLOWNAME;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton sbt_Quit;
    }
}