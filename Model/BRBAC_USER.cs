/**  版本信息模板在安装目录下，可自行修改。
* BRBAC_USER.cs
*
* 功 能： N/A
* 类 名： BRBAC_USER
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/5/19 星期四 10:33:02   N/A    初版
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
	/// BRBAC_USER:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BRBAC_USER
	{
		public BRBAC_USER()
		{}
		#region Model
		private decimal _user_id;
		private string _user_cde;
		private string _user_name;
		private string _user_pwd;
		private DateTime? _last_login_time;
		private string _auth_menu;
		/// <summary>
		/// 
		/// </summary>
		public decimal USER_ID
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USER_CDE
		{
			set{ _user_cde=value;}
			get{return _user_cde;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USER_NAME
		{
			set{ _user_name=value;}
			get{return _user_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USER_PWD
		{
			set{ _user_pwd=value;}
			get{return _user_pwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LAST_LOGIN_TIME
		{
			set{ _last_login_time=value;}
			get{return _last_login_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AUTH_MENU
		{
			set{ _auth_menu=value;}
			get{return _auth_menu;}
		}
		#endregion Model

	}
}

