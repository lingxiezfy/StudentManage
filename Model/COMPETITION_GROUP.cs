/**  版本信息模板在安装目录下，可自行修改。
* COMPETITION_GROUP.cs
*
* 功 能： N/A
* 类 名： COMPETITION_GROUP
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
	/// COMPETITION_GROUP:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class COMPETITION_GROUP
	{
		public COMPETITION_GROUP()
		{}
		#region Model
		private decimal _groupid;
		private decimal? _competitionid;
		private string _groupname;
		private string _charger;
		private DateTime? _buildtm;
		private int? _teacherno1;
		private int? _teacherno2;
		private string _reward;
		private int? _status;
		/// <summary>
		/// 
		/// </summary>
		public decimal GROUPID
		{
			set{ _groupid=value;}
			get{return _groupid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? COMPETITIONID
		{
			set{ _competitionid=value;}
			get{return _competitionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GROUPNAME
		{
			set{ _groupname=value;}
			get{return _groupname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CHARGER
		{
			set{ _charger=value;}
			get{return _charger;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BUILDTM
		{
			set{ _buildtm=value;}
			get{return _buildtm;}
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
		public string REWARD
		{
			set{ _reward=value;}
			get{return _reward;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? STATUS
		{
			set{ _status=value;}
			get{return _status;}
		}
		#endregion Model

	}
}

