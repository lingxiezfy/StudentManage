namespace Student.Forms
{
    partial class frmCLASSADD
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
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.te_classname = new DevExpress.XtraEditors.TextEdit();
            this.cbb_organizer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbb_instructor = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbb_master = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbb_majordirct = new DevExpress.XtraEditors.ComboBoxEdit();
            this.sbt_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_Save = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_classname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_organizer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_instructor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_master.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_majordirct.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(15, 147);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 14);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "辅导员";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(15, 183);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 14);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "组织员";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(15, 39);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 14);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "专业方向";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 111);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 14);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "班主任";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 75);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "班级名称";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.te_classname);
            this.groupControl1.Controls.Add(this.cbb_organizer);
            this.groupControl1.Controls.Add(this.cbb_instructor);
            this.groupControl1.Controls.Add(this.cbb_master);
            this.groupControl1.Controls.Add(this.cbb_majordirct);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(298, 215);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "班级信息";
            // 
            // te_classname
            // 
            this.te_classname.Location = new System.Drawing.Point(90, 72);
            this.te_classname.Name = "te_classname";
            this.te_classname.Size = new System.Drawing.Size(184, 20);
            this.te_classname.TabIndex = 26;
            // 
            // cbb_organizer
            // 
            this.cbb_organizer.Location = new System.Drawing.Point(90, 180);
            this.cbb_organizer.Name = "cbb_organizer";
            this.cbb_organizer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_organizer.Size = new System.Drawing.Size(184, 20);
            this.cbb_organizer.TabIndex = 25;
            // 
            // cbb_instructor
            // 
            this.cbb_instructor.Location = new System.Drawing.Point(90, 144);
            this.cbb_instructor.Name = "cbb_instructor";
            this.cbb_instructor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_instructor.Size = new System.Drawing.Size(184, 20);
            this.cbb_instructor.TabIndex = 24;
            // 
            // cbb_master
            // 
            this.cbb_master.Location = new System.Drawing.Point(90, 108);
            this.cbb_master.Name = "cbb_master";
            this.cbb_master.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_master.Size = new System.Drawing.Size(184, 20);
            this.cbb_master.TabIndex = 23;
            // 
            // cbb_majordirct
            // 
            this.cbb_majordirct.Location = new System.Drawing.Point(90, 36);
            this.cbb_majordirct.Name = "cbb_majordirct";
            this.cbb_majordirct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_majordirct.Size = new System.Drawing.Size(184, 20);
            this.cbb_majordirct.TabIndex = 22;
            // 
            // sbt_Cancel
            // 
            this.sbt_Cancel.Image = global::Student.Properties.Resources.Close_16x16;
            this.sbt_Cancel.Location = new System.Drawing.Point(198, 247);
            this.sbt_Cancel.Name = "sbt_Cancel";
            this.sbt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.sbt_Cancel.TabIndex = 22;
            this.sbt_Cancel.Text = "取消";
            this.sbt_Cancel.Click += new System.EventHandler(this.sbt_cancel_Click);
            // 
            // sbt_Save
            // 
            this.sbt_Save.Image = global::Student.Properties.Resources.Save_16x16;
            this.sbt_Save.Location = new System.Drawing.Point(57, 247);
            this.sbt_Save.Name = "sbt_Save";
            this.sbt_Save.Size = new System.Drawing.Size(75, 23);
            this.sbt_Save.TabIndex = 21;
            this.sbt_Save.Text = "保存";
            this.sbt_Save.Click += new System.EventHandler(this.sbt_save_Click);
            // 
            // frmCLASSADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 279);
            this.Controls.Add(this.sbt_Cancel);
            this.Controls.Add(this.sbt_Save);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmCLASSADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加班级信息";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_classname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_organizer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_instructor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_master.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_majordirct.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbt_Save;
        private DevExpress.XtraEditors.SimpleButton sbt_Cancel;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit te_classname;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_organizer;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_instructor;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_master;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_majordirct;

    }
}