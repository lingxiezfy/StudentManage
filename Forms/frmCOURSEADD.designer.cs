namespace Student.Forms
{
    partial class frmCOURSEADD
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
            this.cbb_coursetype = new DevExpress.XtraEditors.ComboBoxEdit();
            this.te_memo = new DevExpress.XtraEditors.TextEdit();
            this.te_credit = new DevExpress.XtraEditors.TextEdit();
            this.te_experimenthour = new DevExpress.XtraEditors.TextEdit();
            this.te_theoryhour = new DevExpress.XtraEditors.TextEdit();
            this.te_totalhour = new DevExpress.XtraEditors.TextEdit();
            this.te_coursename = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sbt_Save = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_Cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_coursetype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_memo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_credit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_experimenthour.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_theoryhour.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_totalhour.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_coursename.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbb_coursetype);
            this.groupControl1.Controls.Add(this.te_memo);
            this.groupControl1.Controls.Add(this.te_credit);
            this.groupControl1.Controls.Add(this.te_experimenthour);
            this.groupControl1.Controls.Add(this.te_theoryhour);
            this.groupControl1.Controls.Add(this.te_totalhour);
            this.groupControl1.Controls.Add(this.te_coursename);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(518, 204);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "课程信息";
            // 
            // cbb_coursetype
            // 
            this.cbb_coursetype.Location = new System.Drawing.Point(350, 37);
            this.cbb_coursetype.Name = "cbb_coursetype";
            this.cbb_coursetype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_coursetype.Size = new System.Drawing.Size(147, 20);
            this.cbb_coursetype.TabIndex = 19;
            // 
            // te_memo
            // 
            this.te_memo.Location = new System.Drawing.Point(86, 139);
            this.te_memo.Name = "te_memo";
            this.te_memo.Properties.AutoHeight = false;
            this.te_memo.Size = new System.Drawing.Size(411, 49);
            this.te_memo.TabIndex = 15;
            // 
            // te_credit
            // 
            this.te_credit.Location = new System.Drawing.Point(350, 71);
            this.te_credit.Name = "te_credit";
            this.te_credit.Size = new System.Drawing.Size(147, 20);
            this.te_credit.TabIndex = 14;
            // 
            // te_experimenthour
            // 
            this.te_experimenthour.Location = new System.Drawing.Point(350, 105);
            this.te_experimenthour.Name = "te_experimenthour";
            this.te_experimenthour.Size = new System.Drawing.Size(147, 20);
            this.te_experimenthour.TabIndex = 13;
            // 
            // te_theoryhour
            // 
            this.te_theoryhour.Location = new System.Drawing.Point(86, 105);
            this.te_theoryhour.Name = "te_theoryhour";
            this.te_theoryhour.Size = new System.Drawing.Size(147, 20);
            this.te_theoryhour.TabIndex = 12;
            // 
            // te_totalhour
            // 
            this.te_totalhour.Location = new System.Drawing.Point(86, 71);
            this.te_totalhour.Name = "te_totalhour";
            this.te_totalhour.Size = new System.Drawing.Size(147, 20);
            this.te_totalhour.TabIndex = 11;
            // 
            // te_coursename
            // 
            this.te_coursename.Location = new System.Drawing.Point(86, 37);
            this.te_coursename.Name = "te_coursename";
            this.te_coursename.Size = new System.Drawing.Size(147, 20);
            this.te_coursename.TabIndex = 10;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(19, 142);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(24, 14);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "备注";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(273, 74);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 14);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "学分";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(273, 108);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "实验学时";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(19, 108);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "理论学时";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(19, 74);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 14);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "总学时";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(19, 40);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "课程名称";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(273, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "课程类型";
            // 
            // sbt_Save
            // 
            this.sbt_Save.Location = new System.Drawing.Point(134, 222);
            this.sbt_Save.Name = "sbt_Save";
            this.sbt_Save.Size = new System.Drawing.Size(75, 23);
            this.sbt_Save.TabIndex = 1;
            this.sbt_Save.Text = "保存";
            this.sbt_Save.Click += new System.EventHandler(this.sbt_Save_Click);
            // 
            // sbt_Cancel
            // 
            this.sbt_Cancel.Location = new System.Drawing.Point(316, 222);
            this.sbt_Cancel.Name = "sbt_Cancel";
            this.sbt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.sbt_Cancel.TabIndex = 2;
            this.sbt_Cancel.Text = "取消";
            this.sbt_Save.Image = Student.Properties.Resources.Save_16x16;
            this.sbt_Cancel.Image = Student.Properties.Resources.Close_16x16;
            this.sbt_Cancel.Click += new System.EventHandler(this.sbt_Cancel_Click);
            // 
            // frmCOURSEADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 249);
            this.Controls.Add(this.sbt_Cancel);
            this.Controls.Add(this.sbt_Save);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmCOURSEADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加课程信息";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_coursetype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_memo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_credit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_experimenthour.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_theoryhour.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_totalhour.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_coursename.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit te_memo;
        private DevExpress.XtraEditors.TextEdit te_credit;
        private DevExpress.XtraEditors.TextEdit te_experimenthour;
        private DevExpress.XtraEditors.TextEdit te_theoryhour;
        private DevExpress.XtraEditors.TextEdit te_totalhour;
        private DevExpress.XtraEditors.TextEdit te_coursename;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_coursetype;
        private DevExpress.XtraEditors.SimpleButton sbt_Save;
        private DevExpress.XtraEditors.SimpleButton sbt_Cancel;
    }
}