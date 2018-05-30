/**  版本信息模板在安装目录下，可自行修改。
* NODEMATERIALS.cs
*
* 功 能： N/A
* 类 名： NODEMATERIALS
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:16   N/A    初版
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
	/// NODEMATERIALS:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class NODEMATERIALS
	{
		public NODEMATERIALS()
		{}
		#region Model
		private decimal _nodematerialsno;
		private int? _nodeno;
		private decimal? _materialno;
		private int? _teacherno;
		private DateTime? _begintime;
		private DateTime? _endtime;
		private string _memo;
		/// <summary>
		/// 
		/// </summary>
		public decimal NODEMATERIALSNO
		{
			set{ _nodematerialsno=value;}
			get{return _nodematerialsno;}
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
		public decimal? MATERIALNO
		{
			set{ _materialno=value;}
			get{return _materialno;}
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
		public string MEMO
		{
			set{ _memo=value;}
			get{return _memo;}
		}
		#endregion Model

	}
}

