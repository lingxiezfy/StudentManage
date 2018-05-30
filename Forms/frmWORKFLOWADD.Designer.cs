namespace Student.Forms
{
    partial class frmWORKFLOWADD
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
            this.cbb_status = new DevExpress.XtraEditors.ComboBoxEdit();
            this.de_createdate = new DevExpress.XtraEditors.DateEdit();
            this.te_workflowname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sbt_Save = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_Cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_createdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_createdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_workflowname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbb_status);
            this.groupControl1.Controls.Add(this.de_createdate);
            this.groupControl1.Controls.Add(this.te_workflowname);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(428, 158);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "工作流信息";
            // 
            // cbb_status
            // 
            this.cbb_status.Location = new System.Drawing.Point(121, 120);
            this.cbb_status.Name = "cbb_status";
            this.cbb_status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_status.Size = new System.Drawing.Size(272, 20);
            this.cbb_status.TabIndex = 7;
            // 
            // de_createdate
            // 
            this.de_createdate.EditValue = null;
            this.de_createdate.Location = new System.Drawing.Point(121, 81);
            this.de_createdate.Name = "de_createdate";
            this.de_createdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_createdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_createdate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.de_createdate.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.de_createdate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.de_createdate.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.de_createdate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.de_createdate.Size = new System.Drawing.Size(272, 20);
            this.de_createdate.TabIndex = 6;
            // 
            // te_workflowname
            // 
            this.te_workflowname.Location = new System.Drawing.Point(123, 42);
            this.te_workflowname.Name = "te_workflowname";
            this.te_workflowname.Size = new System.Drawing.Size(272, 20);
            this.te_workflowname.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(31, 123);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "状态";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(31, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "创建时间";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "工作流名称";
            // 
            // sbt_Save
            // 
            this.sbt_Save.Location = new System.Drawing.Point(121, 186);
            this.sbt_Save.Name = "sbt_Save";
            this.sbt_Save.Size = new System.Drawing.Size(75, 23);
            this.sbt_Save.TabIndex = 1;
            this.sbt_Save.Text = "保存";
            this.sbt_Save.Click += new System.EventHandler(this.sbt_Save_Click);
            // 
            // sbt_Cancel
            // 
            this.sbt_Cancel.Location = new System.Drawing.Point(243, 186);
            this.sbt_Cancel.Name = "sbt_Cancel";
            this.sbt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.sbt_Cancel.TabIndex = 2;
            this.sbt_Cancel.Text = "取消";
            this.sbt_Save.Image = Student.Properties.Resources.Save_16x16;
            this.sbt_Cancel.Image = Student.Properties.Resources.Close_16x16;
            this.sbt_Cancel.Click += new System.EventHandler(this.sbt_Cancel_Click);
            // 
            // frmWORKFLOWADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 220);
            this.Controls.Add(this.sbt_Cancel);
            this.Controls.Add(this.sbt_Save);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmWORKFLOWADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加工作流信息";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_createdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_createdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_workflowname.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_status;
        private DevExpress.XtraEditors.DateEdit de_createdate;
        private DevExpress.XtraEditors.TextEdit te_workflowname;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton sbt_Save;
        private DevExpress.XtraEditors.SimpleButton sbt_Cancel;
    }
}