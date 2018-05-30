namespace Student.Forms
{
    partial class frmMAJORADD
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
            this.cbb_department = new DevExpress.XtraEditors.ComboBoxEdit();
            this.te_majorname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sbt_save = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_department.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_majorname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbb_department);
            this.groupControl1.Controls.Add(this.te_majorname);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(315, 115);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "专业信息";
            // 
            // cbb_department
            // 
            this.cbb_department.Location = new System.Drawing.Point(85, 36);
            this.cbb_department.Name = "cbb_department";
            this.cbb_department.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_department.Size = new System.Drawing.Size(208, 20);
            this.cbb_department.TabIndex = 5;
            // 
            // te_majorname
            // 
            this.te_majorname.Location = new System.Drawing.Point(85, 75);
            this.te_majorname.Name = "te_majorname";
            this.te_majorname.Size = new System.Drawing.Size(208, 20);
            this.te_majorname.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "专业名称";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "学院名称";
            // 
            // sbt_save
            // 
            this.sbt_save.Image = global::Student.Properties.Resources.Save_16x16;
            this.sbt_save.Location = new System.Drawing.Point(58, 147);
            this.sbt_save.Name = "sbt_save";
            this.sbt_save.Size = new System.Drawing.Size(75, 23);
            this.sbt_save.TabIndex = 1;
            this.sbt_save.Text = "保存";
            this.sbt_save.Click += new System.EventHandler(this.sbt_save_Click);
            // 
            // sbt_cancel
            // 
            this.sbt_cancel.Image = global::Student.Properties.Resources.Close_16x16;
            this.sbt_cancel.Location = new System.Drawing.Point(199, 147);
            this.sbt_cancel.Name = "sbt_cancel";
            this.sbt_cancel.Size = new System.Drawing.Size(75, 23);
            this.sbt_cancel.TabIndex = 2;
            this.sbt_cancel.Text = "取消";
            this.sbt_cancel.Click += new System.EventHandler(this.sbt_cancel_Click);
            // 
            // frmMAJORADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 182);
            this.Controls.Add(this.sbt_cancel);
            this.Controls.Add(this.sbt_save);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmMAJORADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加专业信息";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_department.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_majorname.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_department;
        private DevExpress.XtraEditors.TextEdit te_majorname;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton sbt_save;
        private DevExpress.XtraEditors.SimpleButton sbt_cancel;
    }
}