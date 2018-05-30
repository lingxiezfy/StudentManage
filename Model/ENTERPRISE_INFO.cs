/**  版本信息模板在安装目录下，可自行修改。
* ENTERPRISE_INFO.cs
*
* 功 能： N/A
* 类 名： ENTERPRISE_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:14   N/A    初版
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
	/// ENTERPRISE_INFO:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ENTERPRISE_INFO
	{
		public ENTERPRISE_INFO()
		{}
		#region Model
		private decimal _entno;
		private string _entname;
		private string _entaddress;
		private string _linker1;
		private string _phone1;
		private string _linker2;
		private string _phone2;
		private string _linker3;
		private string _phone3;
		private string _memo;
		private string _demand;
		/// <summary>
		/// 
		/// </summary>
		public decimal ENTNO
		{
			set{ _entno=value;}
			get{return _entno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ENTNAME
		{
			set{ _entname=value;}
			get{return _entname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ENTADDRESS
		{
			set{ _entaddress=value;}
			get{return _entaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LINKER1
		{
			set{ _linker1=value;}
			get{return _linker1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PHONE1
		{
			set{ _phone1=value;}
			get{return _phone1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LINKER2
		{
			set{ _linker2=value;}
			get{return _linker2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PHONE2
		{
			set{ _phone2=value;}
			get{return _phone2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LINKER3
		{
			set{ _linker3=value;}
			get{return _linker3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PHONE3
		{
			set{ _phone3=value;}
			get{return _phone3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MEMO
		{
			set{ _memo=value;}
			get{return _memo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DEMAND
		{
			set{ _demand=value;}
			get{return _demand;}
		}
		#endregion Model

	}
}

