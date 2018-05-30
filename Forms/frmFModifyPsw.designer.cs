namespace Student.Forms
{
    partial class frmFModifyPsw
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
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtOldPsw = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDblPsw = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNewPsw = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPsw.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDblPsw.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPsw.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton3
            // 
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton3.Image = global::Student.Properties.Resources.Close_16x16;
            this.simpleButton3.Location = new System.Drawing.Point(189, 175);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(100, 25);
            this.simpleButton3.TabIndex = 9;
            this.simpleButton3.Text = "关闭退出";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSave.Image = global::Student.Properties.Resources.Save_16x16;
            this.btnSave.Location = new System.Drawing.Point(66, 175);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 25);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存数据";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtOldPsw);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtDblPsw);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtNewPsw);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(364, 152);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "修改密码";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(50, 40);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "旧密码：";
            // 
            // txtOldPsw
            // 
            this.txtOldPsw.Location = new System.Drawing.Point(153, 37);
            this.txtOldPsw.Name = "txtOldPsw";
            this.txtOldPsw.Size = new System.Drawing.Size(176, 20);
            this.txtOldPsw.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(50, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "新密码：";
            // 
            // txtDblPsw
            // 
            this.txtDblPsw.Location = new System.Drawing.Point(153, 103);
            this.txtDblPsw.Name = "txtDblPsw";
            this.txtDblPsw.Size = new System.Drawing.Size(176, 20);
            this.txtDblPsw.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(50, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(0, 14);
            this.labelControl2.TabIndex = 0;
            // 
            // txtNewPsw
            // 
            this.txtNewPsw.Location = new System.Drawing.Point(153, 68);
            this.txtNewPsw.Name = "txtNewPsw";
            this.txtNewPsw.Size = new System.Drawing.Size(176, 20);
            this.txtNewPsw.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(50, 106);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "确认密码：";
            // 
            // frmFModifyPsw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 217);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.btnSave);
            this.Name = "frmFModifyPsw";
            this.Text = "更改操作员密码";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPsw.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDblPsw.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPsw.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtOldPsw;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDblPsw;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNewPsw;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}