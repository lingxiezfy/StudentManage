/**  版本信息模板在安装目录下，可自行修改。
* STUDENT_INFO.cs
*
* 功 能： N/A
* 类 名： STUDENT_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/11/23 星期三 12:46:00   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Student.Model
{
    /// <summary>
    /// STUDENT_INFO:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class STUDENT_INFO
    {
        public STUDENT_INFO()
        { }
        #region Model
        private string _stuno;
        private int? _classno;
        private string _name;
        private string _idcard;
        private string _sex;
        private string _nation;
        private string _political;
        private string _source;
        private DateTime? _intenteddate;
        private DateTime? _graduationdate;
        private string _phone;
        private string _email;
        private decimal? _dormitory_id;
        private string _fatherphone;
        private string _motherphone;
        private string _familyphone;
        private string _familyaddress;
        private string _zipcode;
        private string _qqno;
        private string _micromessageno;
        private byte[] _picture;
        private int? _status;
        /// <summary>
        /// 
        /// </summary>
        public string STUNO
        {
            set { _stuno = value; }
            get { return _stuno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CLASSNO
        {
            set { _classno = value; }
            get { return _classno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NAME
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IDCARD
        {
            set { _idcard = value; }
            get { return _idcard; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SEX
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NATION
        {
            set { _nation = value; }
            get { return _nation; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string POLITICAL
        {
            set { _political = value; }
            get { return _political; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SOURCE
        {
            set { _source = value; }
            get { return _source; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? INTENTEDDATE
        {
            set { _intenteddate = value; }
            get { return _intenteddate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? GRADUATIONDATE
        {
            set { _graduationdate = value; }
            get { return _graduationdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PHONE
        {
            set { _phone = value; }
            get { return _phone; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EMAIL
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? DORMITORY_ID
        {
            set { _dormitory_id = value; }
            get { return _dormitory_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FATHERPHONE
        {
            set { _fatherphone = value; }
            get { return _fatherphone; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MOTHERPHONE
        {
            set { _motherphone = value; }
            get { return _motherphone; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FAMILYPHONE
        {
            set { _familyphone = value; }
            get { return _familyphone; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FAMILYADDRESS
        {
            set { _familyaddress = value; }
            get { return _familyaddress; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZIPCODE
        {
            set { _zipcode = value; }
            get { return _zipcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QQNO
        {
            set { _qqno = value; }
            get { return _qqno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MICROMESSAGENO
        {
            set { _micromessageno = value; }
            get { return _micromessageno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public byte[] PICTURE
        {
            set { _picture = value; }
            get { return _picture; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? STATUS
        {
            set { _status = value; }
            get { return _status; }
        }
        #endregion Model

    }
}

