/**  版本信息模板在安装目录下，可自行修改。
* WORKFLOWSET.cs
*
* 功 能： N/A
* 类 名： WORKFLOWSET
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:37   N/A    初版
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
	/// WORKFLOWSET:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class WORKFLOWSET
	{
		public WORKFLOWSET()
		{}
		#region Model
		private decimal _setno;
		private int? _nodeno;
		private int? _workflowno;
		private int? _nodeorder;
		private DateTime? _begintime;
		private DateTime? _endtime;
		/// <summary>
		/// 
		/// </summary>
		public decimal SETNO
		{
			set{ _setno=value;}
			get{return _setno;}
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
		public int? WORKFLOWNO
		{
			set{ _workflowno=value;}
			get{return _workflowno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? NODEORDER
		{
			set{ _nodeorder=value;}
			get{return _nodeorder;}
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
		#endregion Model

	}
}

