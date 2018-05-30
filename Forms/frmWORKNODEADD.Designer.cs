namespace Student.Forms
{
    partial class frmWORKNODEADD
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.te_nodename = new DevExpress.XtraEditors.TextEdit();
            this.te_memo = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.sbt_Save = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_Cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.te_nodename.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_memo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "工作节点名称";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "备注";
            // 
            // te_nodename
            // 
            this.te_nodename.Location = new System.Drawing.Point(113, 35);
            this.te_nodename.Name = "te_nodename";
            this.te_nodename.Size = new System.Drawing.Size(226, 20);
            this.te_nodename.TabIndex = 4;
            // 
            // te_memo
            // 
            this.te_memo.Location = new System.Drawing.Point(113, 73);
            this.te_memo.Name = "te_memo";
            this.te_memo.Properties.AutoHeight = false;
            this.te_memo.Size = new System.Drawing.Size(226, 88);
            this.te_memo.TabIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.te_memo);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.te_nodename);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(367, 173);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "工作节点信息";
            // 
            // sbt_Save
            // 
            this.sbt_Save.Location = new System.Drawing.Point(102, 191);
            this.sbt_Save.Name = "sbt_Save";
            this.sbt_Save.Size = new System.Drawing.Size(75, 23);
            this.sbt_Save.TabIndex = 7;
            this.sbt_Save.Text = "保存";
            this.sbt_Save.Click += new System.EventHandler(this.sbt_Save_Click);
            // 
            // sbt_Cancel
            // 
            this.sbt_Cancel.Location = new System.Drawing.Point(228, 191);
            this.sbt_Cancel.Name = "sbt_Cancel";
            this.sbt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.sbt_Cancel.TabIndex = 8;
            this.sbt_Cancel.Text = "取消";
            this.sbt_Save.Image = Student.Properties.Resources.Save_16x16;
            this.sbt_Cancel.Image = Student.Properties.Resources.Close_16x16;
            this.sbt_Cancel.Click += new System.EventHandler(this.sbt_Cancel_Click);
            // 
            // frmWORKNODEADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 221);
            this.Controls.Add(this.sbt_Cancel);
            this.Controls.Add(this.sbt_Save);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmWORKNODEADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加工作节点信息";
            ((System.ComponentModel.ISupportInitialize)(this.te_nodename.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_memo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit te_nodename;
        private DevExpress.XtraEditors.TextEdit te_memo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton sbt_Save;
        private DevExpress.XtraEditors.SimpleButton sbt_Cancel;
    }
}