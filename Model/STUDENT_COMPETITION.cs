/**  版本信息模板在安装目录下，可自行修改。
* STUDENT_COMPETITION.cs
*
* 功 能： N/A
* 类 名： STUDENT_COMPETITION
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:27   N/A    初版
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
	/// STUDENT_COMPETITION:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class STUDENT_COMPETITION
	{
		public STUDENT_COMPETITION()
		{}
		#region Model
		private decimal _rcd_id;
		private decimal? _groupid;
		private string _stuno;
		private int? _groupno;
		private string _grade;
		private DateTime? _copetitiontm;
		private string _memo;
		/// <summary>
		/// 
		/// </summary>
		public decimal RCD_ID
		{
			set{ _rcd_id=value;}
			get{return _rcd_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? GROUPID
		{
			set{ _groupid=value;}
			get{return _groupid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STUNO
		{
			set{ _stuno=value;}
			get{return _stuno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GROUPNO
		{
			set{ _groupno=value;}
			get{return _groupno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GRADE
		{
			set{ _grade=value;}
			get{return _grade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? COPETITIONTM
		{
			set{ _copetitiontm=value;}
			get{return _copetitiontm;}
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

