/**  版本信息模板在安装目录下，可自行修改。
* STU_MATERIALS.cs
*
* 功 能： N/A
* 类 名： STU_MATERIALS
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/11/15 星期二 13:49:00   N/A    初版
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
	/// STU_MATERIALS:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class STU_MATERIALS
	{
		public STU_MATERIALS()
		{}
		#region Model
		private int _turnoverno;
		private decimal? _execno;
		private decimal _materialno;
		private int? _if_turnover;
		private DateTime? _turnovertm;
		/// <summary>
		/// 
		/// </summary>
		public int TURNOVERNO
		{
			set{ _turnoverno=value;}
			get{return _turnoverno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? EXECNO
		{
			set{ _execno=value;}
			get{return _execno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal MATERIALNO
		{
			set{ _materialno=value;}
			get{return _materialno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IF_TURNOVER
		{
			set{ _if_turnover=value;}
			get{return _if_turnover;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TURNOVERTM
		{
			set{ _turnovertm=value;}
			get{return _turnovertm;}
		}
		#endregion Model

	}
}

