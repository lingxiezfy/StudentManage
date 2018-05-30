namespace Student.Forms
{
    partial class frmTEACHERADD
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
            this.cbb_nation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbb_political = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbb_sex = new DevExpress.XtraEditors.ComboBoxEdit();
            this.te_micromesageno = new DevExpress.XtraEditors.TextEdit();
            this.te_qqno = new DevExpress.XtraEditors.TextEdit();
            this.te_familyaddress = new DevExpress.XtraEditors.TextEdit();
            this.te_workid = new DevExpress.XtraEditors.TextEdit();
            this.te_name = new DevExpress.XtraEditors.TextEdit();
            this.te_idcard = new DevExpress.XtraEditors.TextEdit();
            this.te_familyphone = new DevExpress.XtraEditors.TextEdit();
            this.te_email = new DevExpress.XtraEditors.TextEdit();
            this.te_phone = new DevExpress.XtraEditors.TextEdit();
            this.cbb_majorname = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sbt_save = new DevExpress.XtraEditors.SimpleButton();
            this.sbt_cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_nation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_political.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_sex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_micromesageno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_qqno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_familyaddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_workid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_idcard.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_familyphone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_majorname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbb_nation);
            this.groupControl1.Controls.Add(this.cbb_political);
            this.groupControl1.Controls.Add(this.cbb_sex);
            this.groupControl1.Controls.Add(this.te_micromesageno);
            this.groupControl1.Controls.Add(this.te_qqno);
            this.groupControl1.Controls.Add(this.te_familyaddress);
            this.groupControl1.Controls.Add(this.te_workid);
            this.groupControl1.Controls.Add(this.te_name);
            this.groupControl1.Controls.Add(this.te_idcard);
            this.groupControl1.Controls.Add(this.te_familyphone);
            this.groupControl1.Controls.Add(this.te_email);
            this.groupControl1.Controls.Add(this.te_phone);
            this.groupControl1.Controls.Add(this.cbb_majorname);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(754, 221);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "教师信息";
            // 
            // cbb_nation
            // 
            this.cbb_nation.Location = new System.Drawing.Point(576, 76);
            this.cbb_nation.Name = "cbb_nation";
            this.cbb_nation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_nation.Properties.Items.AddRange(new object[] {
            "汉族",
            "满族",
            "蒙古族",
            "回族",
            "藏族",
            "维吾尔族",
            "苗族",
            "彝族",
            "壮族",
            "布依族",
            "朝鲜族",
            "侗族",
            "瑶族",
            "白族",
            "土家族"});
            this.cbb_nation.Size = new System.Drawing.Size(161, 20);
            this.cbb_nation.TabIndex = 30;
            // 
            // cbb_political
            // 
            this.cbb_political.Location = new System.Drawing.Point(323, 76);
            this.cbb_political.Name = "cbb_political";
            this.cbb_political.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_political.Properties.Items.AddRange(new object[] {
            "中共党员",
            "中共预备党员",
            "团员",
            "群众"});
            this.cbb_political.Size = new System.Drawing.Size(161, 20);
            this.cbb_political.TabIndex = 29;
            // 
            // cbb_sex
            // 
            this.cbb_sex.Location = new System.Drawing.Point(86, 76);
            this.cbb_sex.Name = "cbb_sex";
            this.cbb_sex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_sex.Properties.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbb_sex.Size = new System.Drawing.Size(161, 20);
            this.cbb_sex.TabIndex = 28;
            // 
            // te_micromesageno
            // 
            this.te_micromesageno.Location = new System.Drawing.Point(576, 148);
            this.te_micromesageno.Name = "te_micromesageno";
            this.te_micromesageno.Size = new System.Drawing.Size(161, 20);
            this.te_micromesageno.TabIndex = 27;
            // 
            // te_qqno
            // 
            this.te_qqno.Location = new System.Drawing.Point(323, 148);
            this.te_qqno.Name = "te_qqno";
            this.te_qqno.Size = new System.Drawing.Size(161, 20);
            this.te_qqno.TabIndex = 26;
            // 
            // te_familyaddress
            // 
            this.te_familyaddress.Location = new System.Drawing.Point(86, 184);
            this.te_familyaddress.Name = "te_familyaddress";
            this.te_familyaddress.Size = new System.Drawing.Size(651, 20);
            this.te_familyaddress.TabIndex = 25;
            // 
            // te_workid
            // 
            this.te_workid.Location = new System.Drawing.Point(576, 40);
            this.te_workid.Name = "te_workid";
            this.te_workid.Size = new System.Drawing.Size(161, 20);
            this.te_workid.TabIndex = 23;
            // 
            // te_name
            // 
            this.te_name.Location = new System.Drawing.Point(86, 40);
            this.te_name.Name = "te_name";
            this.te_name.Size = new System.Drawing.Size(161, 20);
            this.te_name.TabIndex = 22;
            // 
            // te_idcard
            // 
            this.te_idcard.Location = new System.Drawing.Point(86, 148);
            this.te_idcard.Name = "te_idcard";
            this.te_idcard.Size = new System.Drawing.Size(161, 20);
            this.te_idcard.TabIndex = 21;
            // 
            // te_familyphone
            // 
            this.te_familyphone.Location = new System.Drawing.Point(323, 112);
            this.te_familyphone.Name = "te_familyphone";
            this.te_familyphone.Size = new System.Drawing.Size(161, 20);
            this.te_familyphone.TabIndex = 19;
            // 
            // te_email
            // 
            this.te_email.Location = new System.Drawing.Point(576, 112);
            this.te_email.Name = "te_email";
            this.te_email.Size = new System.Drawing.Size(161, 20);
            this.te_email.TabIndex = 18;
            // 
            // te_phone
            // 
            this.te_phone.Location = new System.Drawing.Point(86, 112);
            this.te_phone.Name = "te_phone";
            this.te_phone.Size = new System.Drawing.Size(161, 20);
            this.te_phone.TabIndex = 17;
            // 
            // cbb_majorname
            // 
            this.cbb_majorname.Location = new System.Drawing.Point(323, 40);
            this.cbb_majorname.Name = "cbb_majorname";
            this.cbb_majorname.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_majorname.Size = new System.Drawing.Size(161, 20);
            this.cbb_majorname.TabIndex = 14;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(506, 151);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(48, 14);
            this.labelControl14.TabIndex = 13;
            this.labelControl14.Text = "微信号码";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(257, 151);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(42, 14);
            this.labelControl13.TabIndex = 12;
            this.labelControl13.Text = "QQ号码";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(21, 187);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(48, 14);
            this.labelControl12.TabIndex = 11;
            this.labelControl12.Text = "家庭地址";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(257, 115);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(48, 14);
            this.labelControl11.TabIndex = 10;
            this.labelControl11.Text = "家庭电话";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(506, 115);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(48, 14);
            this.labelControl10.TabIndex = 9;
            this.labelControl10.Text = "电子邮箱";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(21, 115);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 14);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "手机号码";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(257, 79);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 14);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "政治面貌";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(257, 43);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(48, 14);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "专业名称";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(21, 79);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 14);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "性别";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(506, 79);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "民族";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 151);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "身份证号";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 43);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "姓名";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(506, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "教师工号";
            // 
            // sbt_save
            // 
            this.sbt_save.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.sbt_save.Image = global::Student.Properties.Resources.Save_16x16;
            this.sbt_save.Location = new System.Drawing.Point(269, 249);
            this.sbt_save.Name = "sbt_save";
            this.sbt_save.Size = new System.Drawing.Size(71, 27);
            this.sbt_save.TabIndex = 1;
            this.sbt_save.Text = "保存";
            this.sbt_save.Click += new System.EventHandler(this.sbt_save_Click_1);
            // 
            // sbt_cancel
            // 
            this.sbt_cancel.Image = global::Student.Properties.Resources.Close_16x16;
            this.sbt_cancel.Location = new System.Drawing.Point(455, 249);
            this.sbt_cancel.Name = "sbt_cancel";
            this.sbt_cancel.Size = new System.Drawing.Size(70, 27);
            this.sbt_cancel.TabIndex = 2;
            this.sbt_cancel.Text = "取消";
            this.sbt_cancel.Click += new System.EventHandler(this.sbt_cancel_Click);
            // 
            // frmTEACHERADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 279);
            this.Controls.Add(this.sbt_cancel);
            this.Controls.Add(this.sbt_save);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmTEACHERADD";
            this.Text = "增加教师信息";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_nation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_political.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_sex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_micromesageno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_qqno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_familyaddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_workid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_idcard.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_familyphone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_majorname.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton sbt_save;
        private DevExpress.XtraEditors.SimpleButton sbt_cancel;
        private DevExpress.XtraEditors.TextEdit te_micromesageno;
        private DevExpress.XtraEditors.TextEdit te_qqno;
        private DevExpress.XtraEditors.TextEdit te_familyaddress;
        private DevExpress.XtraEditors.TextEdit te_workid;
        private DevExpress.XtraEditors.TextEdit te_name;
        private DevExpress.XtraEditors.TextEdit te_idcard;
        private DevExpress.XtraEditors.TextEdit te_familyphone;
        private DevExpress.XtraEditors.TextEdit te_email;
        private DevExpress.XtraEditors.TextEdit te_phone;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_majorname;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_nation;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_political;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_sex;
    }
}