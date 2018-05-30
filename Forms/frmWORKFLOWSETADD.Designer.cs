namespace Student.Forms
{
    partial class frmWORKFLOWSETADD
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.sbt_Save = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.te_workflowname = new DevExpress.XtraEditors.TextEdit();
            this.cbb_nodename = new DevExpress.XtraEditors.ComboBoxEdit();
            this.de_begintime = new DevExpress.XtraEditors.DateEdit();
            this.de_endtime = new DevExpress.XtraEditors.DateEdit();
            this.cbb_nodeorder = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_workflowname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_nodename.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_begintime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_begintime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_endtime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_endtime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_nodeorder.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbb_nodeorder);
            this.groupControl1.Controls.Add(this.de_endtime);
            this.groupControl1.Controls.Add(this.de_begintime);
            this.groupControl1.Controls.Add(this.cbb_nodename);
            this.groupControl1.Controls.Add(this.te_workflowname);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(537, 131);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "工作流新增节点";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "工作流名称";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "节点名称";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(300, 63);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "顺序";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(18, 97);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "开始日期";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(300, 97);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "截止日期";
            // 
            // sbt_Save
            // 
            this.sbt_Save.Location = new System.Drawing.Point(184, 162);
            this.sbt_Save.Name = "sbt_Save";
            this.sbt_Save.Size = new System.Drawing.Size(75, 23);
            this.sbt_Save.TabIndex = 1;
            this.sbt_Save.Text = "保存";
            this.sbt_Save.Click += new System.EventHandler(this.sbt_Save_Click);
            // 
            // sbt_Cancel
            // 
            this.sbt_Cancel.Location = new System.Drawing.Point(329, 162);
            this.sbt_Cancel.Name = "sbt_Cancel";
            this.sbt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.sbt_Cancel.TabIndex = 2;
            this.sbt_Cancel.Text = "取消";
            this.sbt_Save.Image = Student.Properties.Resources.Save_16x16;
            this.sbt_Cancel.Image = Student.Properties.Resources.Close_16x16;
            this.sbt_Cancel.Click += new System.EventHandler(this.sbt_Cancel_Click);
            // 
            // te_workflowname
            // 
            this.te_workflowname.Location = new System.Drawing.Point(95, 29);
            this.te_workflowname.Name = "te_workflowname";
            this.te_workflowname.Properties.ReadOnly = true;
            this.te_workflowname.Size = new System.Drawing.Size(423, 20);
            this.te_workflowname.TabIndex = 5;
            // 
            // cbb_nodename
            // 
            this.cbb_nodename.Location = new System.Drawing.Point(95, 60);
            this.cbb_nodename.Name = "cbb_nodename";
            this.cbb_nodename.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_nodename.Size = new System.Drawing.Size(187, 20);
            this.cbb_nodename.TabIndex = 7;
            // 
            // de_begintime
            // 
            this.de_begintime.EditValue = null;
            this.de_begintime.Location = new System.Drawing.Point(95, 94);
            this.de_begintime.Name = "de_begintime";
            this.de_begintime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_begintime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_begintime.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.de_begintime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_begintime.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.de_begintime.Size = new System.Drawing.Size(187, 20);
            this.de_begintime.TabIndex = 8;
            // 
            // de_endtime
            // 
            this.de_endtime.EditValue = null;
            this.de_endtime.Location = new System.Drawing.Point(359, 94);
            this.de_endtime.Name = "de_endtime";
            this.de_endtime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_endtime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_endtime.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.de_endtime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_endtime.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.de_endtime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_endtime.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.de_endtime.Size = new System.Drawing.Size(159, 20);
            this.de_endtime.TabIndex = 9;
            // 
            // cbb_nodeorder
            // 
            this.cbb_nodeorder.Location = new System.Drawing.Point(359, 60);
            this.cbb_nodeorder.Name = "cbb_nodeorder";
            this.cbb_nodeorder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_nodeorder.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cbb_nodeorder.Size = new System.Drawing.Size(159, 20);
            this.cbb_nodeorder.TabIndex = 10;
            // 
            // frmWORKFLOWSETADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 199);
            this.Controls.Add(this.sbt_Cancel);
            this.Controls.Add(this.sbt_Save);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmWORKFLOWSETADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加工作流节点";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_workflowname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_nodename.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_begintime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_begintime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_endtime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_endtime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_nodeorder.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit de_endtime;
        private DevExpress.XtraEditors.DateEdit de_begintime;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_nodename;
        private DevExpress.XtraEditors.TextEdit te_workflowname;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sbt_Save;
        private DevExpress.XtraEditors.SimpleButton sbt_Cancel;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_nodeorder;
    }
}