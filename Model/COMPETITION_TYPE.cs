/**  版本信息模板在安装目录下，可自行修改。
* COMPETITION_TYPE.cs
*
* 功 能： N/A
* 类 名： COMPETITION_TYPE
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
	/// COMPETITION_TYPE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class COMPETITION_TYPE
	{
		public COMPETITION_TYPE()
		{}
		#region Model
		private decimal _competitionid;
		private string _competition_name;
		private int? _rank;
		private string _hostunit;
		private string _competition_tm;
		private string _memo;
		/// <summary>
		/// 
		/// </summary>
		public decimal COMPETITIONID
		{
			set{ _competitionid=value;}
			get{return _competitionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMPETITION_NAME
		{
			set{ _competition_name=value;}
			get{return _competition_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RANK
		{
			set{ _rank=value;}
			get{return _rank;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HOSTUNIT
		{
			set{ _hostunit=value;}
			get{return _hostunit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMPETITION_TM
		{
			set{ _competition_tm=value;}
			get{return _competition_tm;}
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

