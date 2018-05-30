namespace Student.Forms
{
    partial class frmTERMADD
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
            this.学期信息添加 = new DevExpress.XtraEditors.GroupControl();
            this.dt_endtime = new System.Windows.Forms.DateTimePicker();
            this.dt_begintime = new System.Windows.Forms.DateTimePicker();
            this.cbb_flag = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.label = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.te_termname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sbt_Save = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_Cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.学期信息添加)).BeginInit();
            this.学期信息添加.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_flag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_termname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // 学期信息添加
            // 
            this.学期信息添加.Controls.Add(this.dt_endtime);
            this.学期信息添加.Controls.Add(this.dt_begintime);
            this.学期信息添加.Controls.Add(this.cbb_flag);
            this.学期信息添加.Controls.Add(this.labelControl4);
            this.学期信息添加.Controls.Add(this.label);
            this.学期信息添加.Controls.Add(this.labelControl3);
            this.学期信息添加.Controls.Add(this.te_termname);
            this.学期信息添加.Controls.Add(this.labelControl2);
            this.学期信息添加.Location = new System.Drawing.Point(12, 12);
            this.学期信息添加.Name = "学期信息添加";
            this.学期信息添加.Size = new System.Drawing.Size(345, 171);
            this.学期信息添加.TabIndex = 0;
            this.学期信息添加.Text = "学期信息";
            // 
            // dt_endtime
            // 
            this.dt_endtime.Location = new System.Drawing.Point(84, 98);
            this.dt_endtime.Name = "dt_endtime";
            this.dt_endtime.Size = new System.Drawing.Size(239, 22);
            this.dt_endtime.TabIndex = 12;
            // 
            // dt_begintime
            // 
            this.dt_begintime.Location = new System.Drawing.Point(84, 64);
            this.dt_begintime.Name = "dt_begintime";
            this.dt_begintime.Size = new System.Drawing.Size(239, 22);
            this.dt_begintime.TabIndex = 11;
            // 
            // cbb_flag
            // 
            this.cbb_flag.Location = new System.Drawing.Point(84, 133);
            this.cbb_flag.Name = "cbb_flag";
            this.cbb_flag.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_flag.Properties.Items.AddRange(new object[] {
            "当前学期",
            "非当年学期"});
            this.cbb_flag.Size = new System.Drawing.Size(239, 20);
            this.cbb_flag.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 136);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "学期标志";
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(21, 102);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 14);
            this.label.TabIndex = 8;
            this.label.Text = "终止时间";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "起始时间";
            // 
            // te_termname
            // 
            this.te_termname.Location = new System.Drawing.Point(84, 31);
            this.te_termname.Name = "te_termname";
            this.te_termname.Size = new System.Drawing.Size(239, 20);
            this.te_termname.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "学期名称";
            // 
            // sbt_Save
            // 
            this.sbt_Save.Image = global::Student.Properties.Resources.Save_16x16;
            this.sbt_Save.Location = new System.Drawing.Point(83, 193);
            this.sbt_Save.Name = "sbt_Save";
            this.sbt_Save.Size = new System.Drawing.Size(75, 23);
            this.sbt_Save.TabIndex = 2;
            this.sbt_Save.Text = "保存";
            this.sbt_Save.Click += new System.EventHandler(this.sbt_Save_Click);
            // 
            // sbt_Cancel
            // 
            this.sbt_Cancel.Image = global::Student.Properties.Resources.Close_16x16;
            this.sbt_Cancel.Location = new System.Drawing.Point(215, 193);
            this.sbt_Cancel.Name = "sbt_Cancel";
            this.sbt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.sbt_Cancel.TabIndex = 3;
            this.sbt_Cancel.Text = "取消";
            this.sbt_Cancel.Click += new System.EventHandler(this.sbt_Cancel_Click);
            // 
            // frmTERMADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 231);
            this.Controls.Add(this.sbt_Cancel);
            this.Controls.Add(this.sbt_Save);
            this.Controls.Add(this.学期信息添加);
            this.Name = "frmTERMADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加学期信息";
            ((System.ComponentModel.ISupportInitialize)(this.学期信息添加)).EndInit();
            this.学期信息添加.ResumeLayout(false);
            this.学期信息添加.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_flag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_termname.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl 学期信息添加;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl label;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit te_termname;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton sbt_Save;
        private DevExpress.XtraEditors.SimpleButton sbt_Cancel;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_flag;
        private System.Windows.Forms.DateTimePicker dt_endtime;
        private System.Windows.Forms.DateTimePicker dt_begintime;
    }
}