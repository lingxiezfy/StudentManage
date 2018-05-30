/**  版本信息模板在安装目录下，可自行修改。
* TERM_INFO.cs
*
* 功 能： N/A
* 类 名： TERM_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:36   N/A    初版
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
	/// TERM_INFO:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TERM_INFO
	{
		public TERM_INFO()
		{}
		#region Model
		private int _termno;
		private string _termname;
		private DateTime? _begintime;
		private DateTime? _endtime;
		private int? _flag;
		/// <summary>
		/// 
		/// </summary>
		public int TERMNO
		{
			set{ _termno=value;}
			get{return _termno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TERMNAME
		{
			set{ _termname=value;}
			get{return _termname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BEGINTIME
		{
			set{ _begintime=value;}
			get{return _begintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ENDTIME
		{
			set{ _endtime=value;}
			get{return _endtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FLAG
		{
			set{ _flag=value;}
			get{return _flag;}
		}
		#endregion Model

	}
}

