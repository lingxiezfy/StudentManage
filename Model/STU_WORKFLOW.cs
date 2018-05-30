/**  版本信息模板在安装目录下，可自行修改。
* STU_WORKFLOW.cs
*
* 功 能： N/A
* 类 名： STU_WORKFLOW
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/11/15 星期二 13:49:01   N/A    初版
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
	/// STU_WORKFLOW:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class STU_WORKFLOW
	{
		public STU_WORKFLOW()
		{}
		#region Model
		private decimal _execno;
		private decimal? _guidanceno;
		private int? _nodeno;
		private decimal? _grade;
		/// <summary>
		/// 
		/// </summary>
		public decimal EXECNO
		{
			set{ _execno=value;}
			get{return _execno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? GUIDANCENO
		{
			set{ _guidanceno=value;}
			get{return _guidanceno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? NODENO
		{
			set{ _nodeno=value;}
			get{return _nodeno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? GRADE
		{
			set{ _grade=value;}
			get{return _grade;}
		}
		#endregion Model

	}
}

