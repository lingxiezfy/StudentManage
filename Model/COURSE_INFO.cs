/**  版本信息模板在安装目录下，可自行修改。
* COURSE_INFO.cs
*
* 功 能： N/A
* 类 名： COURSE_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:06   N/A    初版
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
	/// COURSE_INFO:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class COURSE_INFO
	{
		public COURSE_INFO()
		{}
		#region Model
		private decimal _courseno;
		private decimal? _coursetypeno;
		private string _coursename;
		private int? _totalhour;
		private int? _theoryhour;
		private int? _experimenthour;
		private decimal? _credit;
		private string _memo;
		/// <summary>
		/// 
		/// </summary>
		public decimal COURSENO
		{
			set{ _courseno=value;}
			get{return _courseno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? COURSETYPENO
		{
			set{ _coursetypeno=value;}
			get{return _coursetypeno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COURSENAME
		{
			set{ _coursename=value;}
			get{return _coursename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TOTALHOUR
		{
			set{ _totalhour=value;}
			get{return _totalhour;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? THEORYHOUR
		{
			set{ _theoryhour=value;}
			get{return _theoryhour;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EXPERIMENTHOUR
		{
			set{ _experimenthour=value;}
			get{return _experimenthour;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CREDIT
		{
			set{ _credit=value;}
			get{return _credit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MEMO
		{
			set{ _memo=value;}
			get{return _memo;}
		}
		#endregion Model

	}
}

