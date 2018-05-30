﻿/**  版本信息模板在安装目录下，可自行修改。
* STUDENTTRANSACTION_INFO.cs
*
* 功 能： N/A
* 类 名： STUDENTTRANSACTION_INFO
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
	/// STUDENTTRANSACTION_INFO:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class STUDENTTRANSACTION_INFO
	{
		public STUDENTTRANSACTION_INFO()
		{}
		#region Model
		private decimal _rcd_id;
		private string _stuno;
		private int? _type;
		private DateTime? _transactiontm;
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
		public string STUNO
		{
			set{ _stuno=value;}
			get{return _stuno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TYPE
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TRANSACTIONTM
		{
			set{ _transactiontm=value;}
			get{return _transactiontm;}
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
