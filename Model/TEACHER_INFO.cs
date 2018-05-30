/**  版本信息模板在安装目录下，可自行修改。
* TEACHER_INFO.cs
*
* 功 能： N/A
* 类 名： TEACHER_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:35   N/A    初版
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
	/// TEACHER_INFO:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TEACHER_INFO
	{
		public TEACHER_INFO()
		{}
		#region Model
		private int _teacherno;
		private string _workid;
		private string _name;
		private string _idcard;
		private string _sex;
		private string _nation;
		private int? _majorno;
		private string _political;
		private string _phone;
		private string _email;
		private string _familyphone;
		private string _familyaddress;
		private string _qqno;
		private string _micromessageno;
		/// <summary>
		/// 
		/// </summary>
		public int TEACHERNO
		{
			set{ _teacherno=value;}
			get{return _teacherno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WORKID
		{
			set{ _workid=value;}
			get{return _workid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NAME
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IDCARD
		{
			set{ _idcard=value;}
			get{return _idcard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SEX
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NATION
		{
			set{ _nation=value;}
			get{return _nation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MAJORNO
		{
			set{ _majorno=value;}
			get{return _majorno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string POLITICAL
		{
			set{ _political=value;}
			get{return _political;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PHONE
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EMAIL
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FAMILYPHONE
		{
			set{ _familyphone=value;}
			get{return _familyphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FAMILYADDRESS
		{
			set{ _familyaddress=value;}
			get{return _familyaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QQNO
		{
			set{ _qqno=value;}
			get{return _qqno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MICROMESSAGENO
		{
			set{ _micromessageno=value;}
			get{return _micromessageno;}
		}
		#endregion Model

	}
}

