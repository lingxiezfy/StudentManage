namespace Student.Forms
{
    partial class frmCOMPETITIONADD
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
            this.te_majorno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sbt_save = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_department.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_majorno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textEdit4);
            this.groupControl1.Controls.Add(this.textEdit3);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.cbb_department);
            this.groupControl1.Controls.Add(this.te_majorno);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(711, 146);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "竞赛类别信息";
            // 
            // cbb_department
            // 
            this.cbb_department.Location = new System.Drawing.Point(440, 31);
            this.cbb_department.Name = "cbb_department";
            this.cbb_department.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_department.Size = new System.Drawing.Size(266, 20);
            this.cbb_department.TabIndex = 5;
            // 
            // te_majorno
            // 
            this.te_majorno.Location = new System.Drawing.Point(85, 31);
            this.te_majorno.Name = "te_majorno";
            this.te_majorno.Size = new System.Drawing.Size(266, 20);
            this.te_majorno.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "竞赛类别";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "竞赛编号";
            // 
            // sbt_save
            // 
            this.sbt_save.Image = global::Student.Properties.Resources.Save_16x16;
            this.sbt_save.Location = new System.Drawing.Point(194, 164);
            this.sbt_save.Name = "sbt_save";
            this.sbt_save.Size = new System.Drawing.Size(75, 23);
            this.sbt_save.TabIndex = 2;
            this.sbt_save.Text = "保存";
            // 
            // sbt_cancel
            // 
            this.sbt_cancel.Image = global::Student.Properties.Resources.Close_16x16;
            this.sbt_cancel.Location = new System.Drawing.Point(361, 164);
            this.sbt_cancel.Name = "sbt_cancel";
            this.sbt_cancel.Size = new System.Drawing.Size(75, 23);
            this.sbt_cancel.TabIndex = 3;
            this.sbt_cancel.Text = "取消";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "主办单位";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "备注";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "举办时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "等级";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(85, 67);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(266, 20);
            this.textEdit1.TabIndex = 14;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(85, 102);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(266, 20);
            this.textEdit2.TabIndex = 15;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(440, 67);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(266, 20);
            this.textEdit3.TabIndex = 16;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(440, 99);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(266, 20);
            this.textEdit4.TabIndex = 17;
            // 
            // frmCOMPETITIONADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 262);
            this.Controls.Add(this.sbt_cancel);
            this.Controls.Add(this.sbt_save);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmCOMPETITIONADD";
            this.Text = "增加竞赛类别信息";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_department.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_majorno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_department;
        private DevExpress.XtraEditors.TextEdit te_majorno;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sbt_save;
        private DevExpress.XtraEditors.SimpleButton sbt_cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}