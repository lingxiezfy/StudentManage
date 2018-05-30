/**  版本信息模板在安装目录下，可自行修改。
* MAJORDIRCT_INFO.cs
*
* 功 能： N/A
* 类 名： MAJORDIRCT_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:15   N/A    初版
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
	/// MAJORDIRCT_INFO:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MAJORDIRCT_INFO
	{
		public MAJORDIRCT_INFO()
		{}
		#region Model
		private int _majordirctno;
		private int? _majorno;
		private string _majordirctname;
		/// <summary>
		/// 
		/// </summary>
		public int MAJORDIRCTNO
		{
			set{ _majordirctno=value;}
			get{return _majordirctno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MAJORNO
		{
			set{ _majorno=value;}
			get{return _majorno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MAJORDIRCTNAME
		{
			set{ _majordirctname=value;}
			get{return _majordirctname;}
		}
		#endregion Model

	}
}

