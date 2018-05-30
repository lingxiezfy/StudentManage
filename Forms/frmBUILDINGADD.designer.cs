namespace Student.Forms
{
    partial class frmBUILDINGADD
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.sbt_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_Save = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.te_admin = new DevExpress.XtraEditors.TextEdit();
            this.te_floors = new DevExpress.XtraEditors.TextEdit();
            this.te_buildingname = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_admin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_floors.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_buildingname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(31, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "宿舍楼名称";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(31, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "楼层数";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(31, 105);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 14);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "管理员";
            // 
            // sbt_Cancel
            // 
            this.sbt_Cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbt_Cancel.Appearance.Options.UseFont = true;
            this.sbt_Cancel.Image = global::Student.Properties.Resources.Close_16x16;
            this.sbt_Cancel.Location = new System.Drawing.Point(206, 167);
            this.sbt_Cancel.Name = "sbt_Cancel";
            this.sbt_Cancel.Size = new System.Drawing.Size(74, 22);
            this.sbt_Cancel.TabIndex = 8;
            this.sbt_Cancel.Text = "取消";
            this.sbt_Cancel.Click += new System.EventHandler(this.sbt_Cancel_Click);
            // 
            // sbt_Save
            // 
            this.sbt_Save.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbt_Save.Appearance.Options.UseFont = true;
            this.sbt_Save.Image = global::Student.Properties.Resources.Save_16x16;
            this.sbt_Save.Location = new System.Drawing.Point(88, 166);
            this.sbt_Save.Name = "sbt_Save";
            this.sbt_Save.Size = new System.Drawing.Size(78, 24);
            this.sbt_Save.TabIndex = 9;
            this.sbt_Save.Text = "保存";
            this.sbt_Save.Click += new System.EventHandler(this.sbt_Save_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.te_admin);
            this.groupControl1.Controls.Add(this.te_floors);
            this.groupControl1.Controls.Add(this.te_buildingname);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(354, 138);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "宿舍楼信息";
            // 
            // te_admin
            // 
            this.te_admin.Location = new System.Drawing.Point(115, 102);
            this.te_admin.Name = "te_admin";
            this.te_admin.Size = new System.Drawing.Size(207, 20);
            this.te_admin.TabIndex = 6;
            // 
            // te_floors
            // 
            this.te_floors.Location = new System.Drawing.Point(115, 69);
            this.te_floors.Name = "te_floors";
            this.te_floors.Size = new System.Drawing.Size(207, 20);
            this.te_floors.TabIndex = 5;
            // 
            // te_buildingname
            // 
            this.te_buildingname.Location = new System.Drawing.Point(115, 31);
            this.te_buildingname.Name = "te_buildingname";
            this.te_buildingname.Size = new System.Drawing.Size(207, 20);
            this.te_buildingname.TabIndex = 4;
            // 
            // frmBUILDINGADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 203);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.sbt_Save);
            this.Controls.Add(this.sbt_Cancel);
            this.Name = "frmBUILDINGADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加宿舍楼信息";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_admin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_floors.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_buildingname.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton sbt_Cancel;
        private DevExpress.XtraEditors.SimpleButton sbt_Save;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit te_admin;
        private DevExpress.XtraEditors.TextEdit te_floors;
        private DevExpress.XtraEditors.TextEdit te_buildingname;

    }
}