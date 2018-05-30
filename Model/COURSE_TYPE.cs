/**  版本信息模板在安装目录下，可自行修改。
* COURSE_TYPE.cs
*
* 功 能： N/A
* 类 名： COURSE_TYPE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:13   N/A    初版
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
	/// COURSE_TYPE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class COURSE_TYPE
	{
		public COURSE_TYPE()
		{}
		#region Model
		private decimal _coursetypeno;
		private string _coursetypename;
		private string _memo;
		/// <summary>
		/// 
		/// </summary>
		public decimal COURSETYPENO
		{
			set{ _coursetypeno=value;}
			get{return _coursetypeno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COURSETYPENAME
		{
			set{ _coursetypename=value;}
			get{return _coursetypename;}
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

