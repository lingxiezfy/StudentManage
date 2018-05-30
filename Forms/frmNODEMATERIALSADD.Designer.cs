namespace Student.Forms
{
    partial class frmNODEMATERIALSADD
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
            this.de_endtime = new System.Windows.Forms.DateTimePicker();
            this.de_begintime = new System.Windows.Forms.DateTimePicker();
            this.cbb_name = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbb_materialname = new DevExpress.XtraEditors.ComboBoxEdit();
            this.te_memo = new DevExpress.XtraEditors.TextEdit();
            this.te_nodename = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.cbb_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_materialname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_memo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_nodename.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.de_endtime);
            this.groupControl1.Controls.Add(this.de_begintime);
            this.groupControl1.Controls.Add(this.cbb_name);
            this.groupControl1.Controls.Add(this.cbb_materialname);
            this.groupControl1.Controls.Add(this.te_memo);
            this.groupControl1.Controls.Add(this.te_nodename);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(549, 241);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "节点材料信息";
            // 
            // de_endtime
            // 
            this.de_endtime.Location = new System.Drawing.Point(354, 109);
            this.de_endtime.Name = "de_endtime";
            this.de_endtime.Size = new System.Drawing.Size(163, 22);
            this.de_endtime.TabIndex = 11;
            // 
            // de_begintime
            // 
            this.de_begintime.Location = new System.Drawing.Point(99, 109);
            this.de_begintime.Name = "de_begintime";
            this.de_begintime.Size = new System.Drawing.Size(163, 22);
            this.de_begintime.TabIndex = 10;
            // 
            // cbb_name
            // 
            this.cbb_name.Location = new System.Drawing.Point(354, 70);
            this.cbb_name.Name = "cbb_name";
            this.cbb_name.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_name.Size = new System.Drawing.Size(163, 20);
            this.cbb_name.TabIndex = 9;
            // 
            // cbb_materialname
            // 
            this.cbb_materialname.Location = new System.Drawing.Point(99, 70);
            this.cbb_materialname.Name = "cbb_materialname";
            this.cbb_materialname.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_materialname.Size = new System.Drawing.Size(163, 20);
            this.cbb_materialname.TabIndex = 8;
            // 
            // te_memo
            // 
            this.te_memo.Location = new System.Drawing.Point(99, 143);
            this.te_memo.Name = "te_memo";
            this.te_memo.Properties.AutoHeight = false;
            this.te_memo.Size = new System.Drawing.Size(418, 85);
            this.te_memo.TabIndex = 7;
            // 
            // te_nodename
            // 
            this.te_nodename.Location = new System.Drawing.Point(99, 34);
            this.te_nodename.Name = "te_nodename";
            this.te_nodename.Properties.ReadOnly = true;
            this.te_nodename.Size = new System.Drawing.Size(418, 20);
            this.te_nodename.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(28, 145);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 14);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "备注";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(283, 109);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "截止日期";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(28, 109);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "起始日期";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(283, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "负责教师";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "材料名称";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "节点名称";
            // 
            // sbt_Save
            // 
            this.sbt_Save.Location = new System.Drawing.Point(161, 272);
            this.sbt_Save.Name = "sbt_Save";
            this.sbt_Save.Size = new System.Drawing.Size(75, 23);
            this.sbt_Save.TabIndex = 1;
            this.sbt_Save.Text = "保存";
            this.sbt_Save.Click += new System.EventHandler(this.sbt_Save_Click);
            // 
            // sbt_Cancel
            // 
            this.sbt_Cancel.Location = new System.Drawing.Point(345, 272);
            this.sbt_Cancel.Name = "sbt_Cancel";
            this.sbt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.sbt_Cancel.TabIndex = 2;
            this.sbt_Cancel.Text = "取消";
            this.sbt_Save.Image = Student.Properties.Resources.Save_16x16;
            this.sbt_Cancel.Image = Student.Properties.Resources.Close_16x16;
            this.sbt_Cancel.Click += new System.EventHandler(this.sbt_Cancel_Click);
            // 
            // frmNODEMATERIALSADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 307);
            this.Controls.Add(this.sbt_Cancel);
            this.Controls.Add(this.sbt_Save);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmNODEMATERIALSADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加节点材料信息";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_materialname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_memo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_nodename.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_name;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_materialname;
        private DevExpress.XtraEditors.TextEdit te_memo;
        private DevExpress.XtraEditors.TextEdit te_nodename;
        private DevExpress.XtraEditors.SimpleButton sbt_Save;
        private DevExpress.XtraEditors.SimpleButton sbt_Cancel;
        private System.Windows.Forms.DateTimePicker de_endtime;
        private System.Windows.Forms.DateTimePicker de_begintime;
    }
}