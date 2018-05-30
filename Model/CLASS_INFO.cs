/**  版本信息模板在安装目录下，可自行修改。
* CLASS_INFO.cs
*
* 功 能： N/A
* 类 名： CLASS_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:01   N/A    初版
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
	/// CLASS_INFO:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CLASS_INFO
	{
		public CLASS_INFO()
		{}
		#region Model
		private int _classno;
		private int? _majordirctno;
		private string _classname;
		private int? _teacherno1;
		private int? _teacherno2;
		private int? _teacherno3;
		/// <summary>
		/// 
		/// </summary>
		public int CLASSNO
		{
			set{ _classno=value;}
			get{return _classno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MAJORDIRCTNO
		{
			set{ _majordirctno=value;}
			get{return _majordirctno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLASSNAME
		{
			set{ _classname=value;}
			get{return _classname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TEACHERNO1
		{
			set{ _teacherno1=value;}
			get{return _teacherno1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TEACHERNO2
		{
			set{ _teacherno2=value;}
			get{return _teacherno2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TEACHERNO3
		{
			set{ _teacherno3=value;}
			get{return _teacherno3;}
		}
		#endregion Model

	}
}

