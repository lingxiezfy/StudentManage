namespace Student.Forms
{
    partial class frmCOURSE_TYPEADD
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
            this.te_coursetypememo = new DevExpress.XtraEditors.TextEdit();
            this.te_coursetypename = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Ctb_save = new DevExpress.XtraEditors.SimpleButton();
            this.Cbtn_cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_coursetypememo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_coursetypename.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.te_coursetypememo);
            this.groupControl1.Controls.Add(this.te_coursetypename);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(16, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(317, 140);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "课程类型信息";
            // 
            // te_coursetypememo
            // 
            this.te_coursetypememo.Location = new System.Drawing.Point(93, 73);
            this.te_coursetypememo.Name = "te_coursetypememo";
            this.te_coursetypememo.Properties.AutoHeight = false;
            this.te_coursetypememo.Size = new System.Drawing.Size(200, 56);
            this.te_coursetypememo.TabIndex = 4;
            // 
            // te_coursetypename
            // 
            this.te_coursetypename.Location = new System.Drawing.Point(93, 35);
            this.te_coursetypename.Name = "te_coursetypename";
            this.te_coursetypename.Size = new System.Drawing.Size(200, 20);
            this.te_coursetypename.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(28, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "备注";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "课程名称";
            // 
            // Ctb_save
            // 
            this.Ctb_save.Image = global::Student.Properties.Resources.Save_16x16;
            this.Ctb_save.Location = new System.Drawing.Point(72, 167);
            this.Ctb_save.Name = "Ctb_save";
            this.Ctb_save.Size = new System.Drawing.Size(75, 23);
            this.Ctb_save.TabIndex = 0;
            this.Ctb_save.Text = "保存";
            this.Ctb_save.Click += new System.EventHandler(this.Ctb_save_Click);
            // 
            // Cbtn_cancel
            // 
            this.Cbtn_cancel.Image = global::Student.Properties.Resources.Close_16x16;
            this.Cbtn_cancel.Location = new System.Drawing.Point(205, 167);
            this.Cbtn_cancel.Name = "Cbtn_cancel";
            this.Cbtn_cancel.Size = new System.Drawing.Size(75, 23);
            this.Cbtn_cancel.TabIndex = 1;
            this.Cbtn_cancel.Text = "取消";
            this.Cbtn_cancel.Click += new System.EventHandler(this.Cbtn_cancel_Click);
            // 
            // frmCOURSE_TYPEADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 202);
            this.Controls.Add(this.Cbtn_cancel);
            this.Controls.Add(this.Ctb_save);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmCOURSE_TYPEADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加课程类型";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_coursetypememo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_coursetypename.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Ctb_save;
        private DevExpress.XtraEditors.SimpleButton Cbtn_cancel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit te_coursetypememo;
        private DevExpress.XtraEditors.TextEdit te_coursetypename;
    }
}