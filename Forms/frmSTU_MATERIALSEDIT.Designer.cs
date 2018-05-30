namespace Student.Forms
{
    partial class frmSTU_MATERIALSEDIT
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
            this.cbb_ent = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.te_teacher = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.te_grade = new DevExpress.XtraEditors.TextEdit();
            this.te_stuname = new DevExpress.XtraEditors.TextEdit();
            this.te_node = new DevExpress.XtraEditors.TextEdit();
            this.te_workflow = new DevExpress.XtraEditors.TextEdit();
            this.te_stuno = new DevExpress.XtraEditors.TextEdit();
            this.te_term = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sbt_Save = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_Cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_ent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_teacher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_grade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stuname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_node.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_workflow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stuno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_term.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbb_ent);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.te_teacher);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.te_grade);
            this.groupControl1.Controls.Add(this.te_stuname);
            this.groupControl1.Controls.Add(this.te_node);
            this.groupControl1.Controls.Add(this.te_workflow);
            this.groupControl1.Controls.Add(this.te_stuno);
            this.groupControl1.Controls.Add(this.te_term);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(509, 227);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "成绩信息";
            // 
            // cbb_ent
            // 
            this.cbb_ent.Location = new System.Drawing.Point(92, 151);
            this.cbb_ent.Name = "cbb_ent";
            this.cbb_ent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_ent.Size = new System.Drawing.Size(386, 20);
            this.cbb_ent.TabIndex = 14;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(16, 154);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 14);
            this.labelControl8.TabIndex = 3;
            this.labelControl8.Text = "实习单位";
            // 
            // te_teacher
            // 
            this.te_teacher.Location = new System.Drawing.Point(336, 115);
            this.te_teacher.Name = "te_teacher";
            this.te_teacher.Properties.ReadOnly = true;
            this.te_teacher.Size = new System.Drawing.Size(142, 20);
            this.te_teacher.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(261, 118);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(48, 14);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "指导教师";
            // 
            // te_grade
            // 
            this.te_grade.Location = new System.Drawing.Point(91, 187);
            this.te_grade.Name = "te_grade";
            this.te_grade.Size = new System.Drawing.Size(387, 20);
            this.te_grade.TabIndex = 11;
            // 
            // te_stuname
            // 
            this.te_stuname.Location = new System.Drawing.Point(336, 75);
            this.te_stuname.Name = "te_stuname";
            this.te_stuname.Properties.ReadOnly = true;
            this.te_stuname.Size = new System.Drawing.Size(142, 20);
            this.te_stuname.TabIndex = 10;
            // 
            // te_node
            // 
            this.te_node.Location = new System.Drawing.Point(92, 112);
            this.te_node.Name = "te_node";
            this.te_node.Properties.ReadOnly = true;
            this.te_node.Size = new System.Drawing.Size(142, 20);
            this.te_node.TabIndex = 9;
            // 
            // te_workflow
            // 
            this.te_workflow.Location = new System.Drawing.Point(92, 75);
            this.te_workflow.Name = "te_workflow";
            this.te_workflow.Properties.ReadOnly = true;
            this.te_workflow.Size = new System.Drawing.Size(142, 20);
            this.te_workflow.TabIndex = 8;
            // 
            // te_stuno
            // 
            this.te_stuno.Location = new System.Drawing.Point(336, 38);
            this.te_stuno.Name = "te_stuno";
            this.te_stuno.Properties.ReadOnly = true;
            this.te_stuno.Size = new System.Drawing.Size(142, 20);
            this.te_stuno.TabIndex = 7;
            // 
            // te_term
            // 
            this.te_term.Location = new System.Drawing.Point(92, 38);
            this.te_term.Name = "te_term";
            this.te_term.Properties.ReadOnly = true;
            this.te_term.Size = new System.Drawing.Size(142, 20);
            this.te_term.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(16, 190);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "成      绩";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(261, 78);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "学生姓名";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(261, 41);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "学生学号";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "节点名称";
            // 
            // labelControl2
            // 
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl2.Location = new System.Drawing.Point(16, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "工作流名称";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "学期名称";
            // 
            // sbt_Save
            // 
            this.sbt_Save.Location = new System.Drawing.Point(143, 261);
            this.sbt_Save.Name = "sbt_Save";
            this.sbt_Save.Size = new System.Drawing.Size(75, 23);
            this.sbt_Save.TabIndex = 1;
            this.sbt_Save.Text = "保存";
            this.sbt_Save.Click += new System.EventHandler(this.sbt_Save_Click);
            // 
            // sbt_Cancel
            // 
            this.sbt_Cancel.Location = new System.Drawing.Point(312, 261);
            this.sbt_Cancel.Name = "sbt_Cancel";
            this.sbt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.sbt_Cancel.TabIndex = 2;
            this.sbt_Cancel.Text = "取消";
            this.sbt_Save.Image = Student.Properties.Resources.Save_16x16;
            this.sbt_Cancel.Image = Student.Properties.Resources.Close_16x16;
            this.sbt_Cancel.Click += new System.EventHandler(this.sbt_Cancel_Click);
            // 
            // frmSTU_MATERIALSEDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 295);
            this.Controls.Add(this.sbt_Cancel);
            this.Controls.Add(this.sbt_Save);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmSTU_MATERIALSEDIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改成绩";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_ent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_teacher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_grade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stuname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_node.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_workflow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stuno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_term.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton sbt_Save;
        private DevExpress.XtraEditors.SimpleButton sbt_Cancel;
        private DevExpress.XtraEditors.TextEdit te_grade;
        private DevExpress.XtraEditors.TextEdit te_stuname;
        private DevExpress.XtraEditors.TextEdit te_node;
        private DevExpress.XtraEditors.TextEdit te_workflow;
        private DevExpress.XtraEditors.TextEdit te_stuno;
        private DevExpress.XtraEditors.TextEdit te_term;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit te_teacher;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_ent;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}