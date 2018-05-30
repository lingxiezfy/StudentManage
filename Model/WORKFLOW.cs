/**  版本信息模板在安装目录下，可自行修改。
* WORKFLOW.cs
*
* 功 能： N/A
* 类 名： WORKFLOW
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:36   N/A    初版
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
	/// WORKFLOW:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class WORKFLOW
	{
		public WORKFLOW()
		{}
		#region Model
		private int _workflowno;
		private string _workflowname;
		private DateTime? _createdate;
		private int _status;
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
		public string WORKFLOWNAME
		{
			set{ _workflowname=value;}
			get{return _workflowname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATEDATE
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int STATUS
		{
			set{ _status=value;}
			get{return _status;}
		}
		#endregion Model

	}
}

