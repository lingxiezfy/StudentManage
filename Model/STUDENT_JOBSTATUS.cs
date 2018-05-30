/**  版本信息模板在安装目录下，可自行修改。
* STUDENT_JOBSTATUS.cs
*
* 功 能： N/A
* 类 名： STUDENT_JOBSTATUS
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/12/5 星期一 11:54:21   N/A    初版
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
	/// STUDENT_JOBSTATUS:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class STUDENT_JOBSTATUS
	{
		public STUDENT_JOBSTATUS()
		{}
		#region Model
		private decimal _statusno;
		private string _stuno;
		private decimal? _entno;
		private string _jobtitle;
		private int? _salary;
		private string _status;
		private DateTime? _statustime;
		private int? _if_current;
		private string _memo;
		/// <summary>
		/// 
		/// </summary>
		public decimal STATUSNO
		{
			set{ _statusno=value;}
			get{return _statusno;}
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
		public decimal? ENTNO
		{
			set{ _entno=value;}
			get{return _entno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JOBTITLE
		{
			set{ _jobtitle=value;}
			get{return _jobtitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SALARY
		{
			set{ _salary=value;}
			get{return _salary;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STATUS
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? STATUSTIME
		{
			set{ _statustime=value;}
			get{return _statustime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IF_CURRENT
		{
			set{ _if_current=value;}
			get{return _if_current;}
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

