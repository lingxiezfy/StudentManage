/**  版本信息模板在安装目录下，可自行修改。
* PARTYBUILD_INFO.cs
*
* 功 能： N/A
* 类 名： PARTYBUILD_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:17   N/A    初版
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
	/// PARTYBUILD_INFO:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PARTYBUILD_INFO
	{
		public PARTYBUILD_INFO()
		{}
		#region Model
		private decimal _rcd_id;
		private int? _classno;
		private string _stuno;
		private int _termno;
		private int? _status;
		private DateTime? _applicationtm;
		private DateTime? _excellenttm;
		private DateTime? _preparationtm;
		private DateTime? _membertm;
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
		public int? CLASSNO
		{
			set{ _classno=value;}
			get{return _classno;}
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
		public int TERMNO
		{
			set{ _termno=value;}
			get{return _termno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? STATUS
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? APPLICATIONTM
		{
			set{ _applicationtm=value;}
			get{return _applicationtm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EXCELLENTTM
		{
			set{ _excellenttm=value;}
			get{return _excellenttm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PREPARATIONTM
		{
			set{ _preparationtm=value;}
			get{return _preparationtm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? MEMBERTM
		{
			set{ _membertm=value;}
			get{return _membertm;}
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

