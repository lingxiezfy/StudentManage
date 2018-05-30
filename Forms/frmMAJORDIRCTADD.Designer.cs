namespace Student.Forms
{
    partial class frmMAJORDIRCTADD
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
            this.te_majordirctname = new DevExpress.XtraEditors.TextEdit();
            this.cbb_majorname = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sbtn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_majordirctname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_majorname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.te_majordirctname);
            this.groupControl1.Controls.Add(this.cbb_majorname);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(331, 113);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "专业方向信息";
            // 
            // te_majordirctname
            // 
            this.te_majordirctname.Location = new System.Drawing.Point(119, 72);
            this.te_majordirctname.Name = "te_majordirctname";
            this.te_majordirctname.Size = new System.Drawing.Size(191, 20);
            this.te_majordirctname.TabIndex = 3;
            // 
            // cbb_majorname
            // 
            this.cbb_majorname.Location = new System.Drawing.Point(119, 37);
            this.cbb_majorname.Name = "cbb_majorname";
            this.cbb_majorname.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_majorname.Size = new System.Drawing.Size(191, 20);
            this.cbb_majorname.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "专业方向名称";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "所属专业名称";
            // 
            // sbtn_Save
            // 
            this.sbtn_Save.Location = new System.Drawing.Point(81, 141);
            this.sbtn_Save.Name = "sbtn_Save";
            this.sbtn_Save.Size = new System.Drawing.Size(80, 23);
            this.sbtn_Save.TabIndex = 1;
            this.sbtn_Save.Text = "保存";
            this.sbtn_Save.Click += new System.EventHandler(this.sbtn_Save_Click);
            // 
            // sbtn_Cancel
            // 
            this.sbtn_Cancel.Location = new System.Drawing.Point(213, 141);
            this.sbtn_Cancel.Name = "sbtn_Cancel";
            this.sbtn_Cancel.Size = new System.Drawing.Size(80, 23);
            this.sbtn_Cancel.TabIndex = 2;
            this.sbtn_Cancel.Text = "取消";
            this.sbtn_Save.Image = Student.Properties.Resources.Save_16x16;
            this.sbtn_Cancel.Image = Student.Properties.Resources.Close_16x16;
            this.sbtn_Cancel.Click += new System.EventHandler(this.sbtn_Cancel_Click);
            // 
            // frmMAJORDIRCTADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 181);
            this.Controls.Add(this.sbtn_Cancel);
            this.Controls.Add(this.sbtn_Save);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmMAJORDIRCTADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加专业方向信息";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_majordirctname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_majorname.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit te_majordirctname;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_majorname;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sbtn_Save;
        private DevExpress.XtraEditors.SimpleButton sbtn_Cancel;
    }
}