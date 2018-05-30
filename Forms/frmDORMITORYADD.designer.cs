namespace Student.Forms
{
    partial class frmDORMITORYADD
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
            this.cbb_buildingname = new DevExpress.XtraEditors.ComboBoxEdit();
            this.te_plate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sbt_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_save = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_buildingname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_plate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbb_buildingname);
            this.groupControl1.Controls.Add(this.te_plate);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(276, 107);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "宿舍信息";
            // 
            // cbb_buildingname
            // 
            this.cbb_buildingname.Location = new System.Drawing.Point(98, 28);
            this.cbb_buildingname.Name = "cbb_buildingname";
            this.cbb_buildingname.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_buildingname.Size = new System.Drawing.Size(150, 20);
            this.cbb_buildingname.TabIndex = 6;
            // 
            // te_plate
            // 
            this.te_plate.Location = new System.Drawing.Point(98, 66);
            this.te_plate.Name = "te_plate";
            this.te_plate.Size = new System.Drawing.Size(150, 20);
            this.te_plate.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "宿舍门牌号";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "宿舍楼名称";
            // 
            // sbt_cancel
            // 
            this.sbt_cancel.Image = global::Student.Properties.Resources.Close_16x16;
            this.sbt_cancel.Location = new System.Drawing.Point(161, 133);
            this.sbt_cancel.Name = "sbt_cancel";
            this.sbt_cancel.Size = new System.Drawing.Size(75, 23);
            this.sbt_cancel.TabIndex = 7;
            this.sbt_cancel.Text = "取消";
            this.sbt_cancel.Click += new System.EventHandler(this.sbt_cancel_Click);
            // 
            // sbt_save
            // 
            this.sbt_save.Image = global::Student.Properties.Resources.Save_16x16;
            this.sbt_save.Location = new System.Drawing.Point(45, 133);
            this.sbt_save.Name = "sbt_save";
            this.sbt_save.Size = new System.Drawing.Size(75, 23);
            this.sbt_save.TabIndex = 6;
            this.sbt_save.Text = "保存";
            this.sbt_save.Click += new System.EventHandler(this.sbt_save_Click);
            // 
            // frmDORMITORYADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 168);
            this.Controls.Add(this.sbt_cancel);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.sbt_save);
            this.Name = "frmDORMITORYADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加宿舍信息";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_buildingname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_plate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton sbt_cancel;
        private DevExpress.XtraEditors.SimpleButton sbt_save;
        private DevExpress.XtraEditors.TextEdit te_plate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_buildingname;
    }
}