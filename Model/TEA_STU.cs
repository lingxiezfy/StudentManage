/**  版本信息模板在安装目录下，可自行修改。
* TEA_STU.cs
*
* 功 能： N/A
* 类 名： TEA_STU
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
	/// TEA_STU:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TEA_STU
	{
		public TEA_STU()
		{}
		#region Model
		private decimal _guidanceno;
		private string _stuno;
		private int? _teacherno;
		private int _workflowno;
		private int _termno;
		/// <summary>
		/// 
		/// </summary>
		public decimal GUIDANCENO
		{
			set{ _guidanceno=value;}
			get{return _guidanceno;}
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
		public int? TEACHERNO
		{
			set{ _teacherno=value;}
			get{return _teacherno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int WORKFLOWNO
		{
			set{ _workflowno=value;}
			get{return _workflowno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int TERMNO
		{
			set{ _termno=value;}
			get{return _termno;}
		}
		#endregion Model

	}
}

