namespace Student.Forms
{
    partial class frmSTU_JOBSTATUSADD
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
            this.cbb_ifcurrent = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dt_statustime = new System.Windows.Forms.DateTimePicker();
            this.cbb_status = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbb_entname = new DevExpress.XtraEditors.ComboBoxEdit();
            this.te_memo = new DevExpress.XtraEditors.TextEdit();
            this.te_salary = new DevExpress.XtraEditors.TextEdit();
            this.te_jobtitle = new DevExpress.XtraEditors.TextEdit();
            this.te_stuname = new DevExpress.XtraEditors.TextEdit();
            this.te_stuno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.cbb_ifcurrent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_entname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_memo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_salary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_jobtitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stuname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stuno.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbb_ifcurrent);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.dt_statustime);
            this.groupControl1.Controls.Add(this.cbb_status);
            this.groupControl1.Controls.Add(this.cbb_entname);
            this.groupControl1.Controls.Add(this.te_memo);
            this.groupControl1.Controls.Add(this.te_salary);
            this.groupControl1.Controls.Add(this.te_jobtitle);
            this.groupControl1.Controls.Add(this.te_stuname);
            this.groupControl1.Controls.Add(this.te_stuno);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(549, 212);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "学生就业信息";
            // 
            // cbb_ifcurrent
            // 
            this.cbb_ifcurrent.Location = new System.Drawing.Point(88, 143);
            this.cbb_ifcurrent.Name = "cbb_ifcurrent";
            this.cbb_ifcurrent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_ifcurrent.Properties.Items.AddRange(new object[] {
            "未就业",
            "已就业"});
            this.cbb_ifcurrent.Size = new System.Drawing.Size(179, 20);
            this.cbb_ifcurrent.TabIndex = 16;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(22, 146);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 14);
            this.labelControl9.TabIndex = 3;
            this.labelControl9.Text = "是否就业";
            // 
            // dt_statustime
            // 
            this.dt_statustime.Location = new System.Drawing.Point(349, 142);
            this.dt_statustime.Name = "dt_statustime";
            this.dt_statustime.Size = new System.Drawing.Size(179, 22);
            this.dt_statustime.TabIndex = 15;
            // 
            // cbb_status
            // 
            this.cbb_status.Location = new System.Drawing.Point(349, 106);
            this.cbb_status.Name = "cbb_status";
            this.cbb_status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_status.Properties.Items.AddRange(new object[] {
            "找工作",
            "考研",
            "考公务员",
            "出国",
            "家族企业"});
            this.cbb_status.Size = new System.Drawing.Size(179, 20);
            this.cbb_status.TabIndex = 14;
            // 
            // cbb_entname
            // 
            this.cbb_entname.Location = new System.Drawing.Point(88, 69);
            this.cbb_entname.Name = "cbb_entname";
            this.cbb_entname.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_entname.Size = new System.Drawing.Size(179, 20);
            this.cbb_entname.TabIndex = 13;
            // 
            // te_memo
            // 
            this.te_memo.Location = new System.Drawing.Point(88, 180);
            this.te_memo.Name = "te_memo";
            this.te_memo.Size = new System.Drawing.Size(440, 20);
            this.te_memo.TabIndex = 12;
            // 
            // te_salary
            // 
            this.te_salary.Location = new System.Drawing.Point(88, 106);
            this.te_salary.Name = "te_salary";
            this.te_salary.Size = new System.Drawing.Size(179, 20);
            this.te_salary.TabIndex = 11;
            // 
            // te_jobtitle
            // 
            this.te_jobtitle.Location = new System.Drawing.Point(349, 69);
            this.te_jobtitle.Name = "te_jobtitle";
            this.te_jobtitle.Size = new System.Drawing.Size(179, 20);
            this.te_jobtitle.TabIndex = 10;
            // 
            // te_stuname
            // 
            this.te_stuname.Location = new System.Drawing.Point(349, 32);
            this.te_stuname.Name = "te_stuname";
            this.te_stuname.Properties.ReadOnly = true;
            this.te_stuname.Size = new System.Drawing.Size(179, 20);
            this.te_stuname.TabIndex = 9;
            // 
            // te_stuno
            // 
            this.te_stuno.Location = new System.Drawing.Point(88, 32);
            this.te_stuno.Name = "te_stuno";
            this.te_stuno.Properties.ReadOnly = true;
            this.te_stuno.Size = new System.Drawing.Size(179, 20);
            this.te_stuno.TabIndex = 8;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(22, 183);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(24, 14);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "备注";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(288, 146);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(48, 14);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "录入时间";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(288, 109);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 14);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "状态";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(22, 109);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "薪金";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(288, 72);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "职位";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 72);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "企业名称";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(288, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "学生姓名";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "学生学号";
            // 
            // sbt_Save
            // 
            this.sbt_Save.Image = global::Student.Properties.Resources.Save_16x16;
            this.sbt_Save.Location = new System.Drawing.Point(145, 245);
            this.sbt_Save.Name = "sbt_Save";
            this.sbt_Save.Size = new System.Drawing.Size(75, 23);
            this.sbt_Save.TabIndex = 1;
            this.sbt_Save.Text = "保存";
            this.sbt_Save.Click += new System.EventHandler(this.sbt_Save_Click);
            // 
            // sbt_Cancel
            // 
            this.sbt_Cancel.Image = global::Student.Properties.Resources.Close_16x16;
            this.sbt_Cancel.Location = new System.Drawing.Point(339, 245);
            this.sbt_Cancel.Name = "sbt_Cancel";
            this.sbt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.sbt_Cancel.TabIndex = 2;
            this.sbt_Cancel.Text = "取消";
            this.sbt_Cancel.Click += new System.EventHandler(this.sbt_Cancel_Click);
            // 
            // frmSTU_JOBSTATUSADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 279);
            this.Controls.Add(this.sbt_Cancel);
            this.Controls.Add(this.sbt_Save);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmSTU_JOBSTATUSADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生就业信息管理";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_ifcurrent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_entname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_memo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_salary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_jobtitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stuname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stuno.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DateTimePicker dt_statustime;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_status;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_entname;
        private DevExpress.XtraEditors.TextEdit te_memo;
        private DevExpress.XtraEditors.TextEdit te_salary;
        private DevExpress.XtraEditors.TextEdit te_jobtitle;
        private DevExpress.XtraEditors.TextEdit te_stuname;
        private DevExpress.XtraEditors.TextEdit te_stuno;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sbt_Save;
        private DevExpress.XtraEditors.SimpleButton sbt_Cancel;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_ifcurrent;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}