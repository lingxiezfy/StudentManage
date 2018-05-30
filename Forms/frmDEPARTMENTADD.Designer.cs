namespace Student.Forms
{
    partial class frmDEPARTMENTADD
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
            this.te_departmentname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sbt_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_save = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.te_departmentno = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_departmentname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_departmentno.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.te_departmentname);
            this.groupControl1.Controls.Add(this.te_departmentno);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(293, 119);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "学院信息";
            // 
            // te_departmentname
            // 
            this.te_departmentname.Location = new System.Drawing.Point(99, 81);
            this.te_departmentname.Name = "te_departmentname";
            this.te_departmentname.Size = new System.Drawing.Size(168, 20);
            this.te_departmentname.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 84);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "学院名称";
            // 
            // sbt_cancel
            // 
            this.sbt_cancel.Image = global::Student.Properties.Resources.Close_16x16;
            this.sbt_cancel.Location = new System.Drawing.Point(186, 146);
            this.sbt_cancel.Name = "sbt_cancel";
            this.sbt_cancel.Size = new System.Drawing.Size(75, 23);
            this.sbt_cancel.TabIndex = 1;
            this.sbt_cancel.Text = "取消";
            this.sbt_cancel.Click += new System.EventHandler(this.sbt_cancel_Click);
            // 
            // sbt_save
            // 
            this.sbt_save.Image = global::Student.Properties.Resources.Save_16x16;
            this.sbt_save.Location = new System.Drawing.Point(57, 146);
            this.sbt_save.Name = "sbt_save";
            this.sbt_save.Size = new System.Drawing.Size(75, 23);
            this.sbt_save.TabIndex = 1;
            this.sbt_save.Text = "保存";
            this.sbt_save.Click += new System.EventHandler(this.sbt_save_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "学院编号";
            // 
            // te_departmentno
            // 
            this.te_departmentno.Location = new System.Drawing.Point(99, 42);
            this.te_departmentno.Name = "te_departmentno";
            this.te_departmentno.Size = new System.Drawing.Size(168, 20);
            this.te_departmentno.TabIndex = 1;
            // 
            // frmDEPARTMENTADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 181);
            this.Controls.Add(this.sbt_cancel);
            this.Controls.Add(this.sbt_save);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDEPARTMENTADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加学院信息";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_departmentname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_departmentno.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit te_departmentname;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton sbt_save;
        private DevExpress.XtraEditors.SimpleButton sbt_cancel;
        private DevExpress.XtraEditors.TextEdit te_departmentno;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}