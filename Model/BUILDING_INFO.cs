/**  版本信息模板在安装目录下，可自行修改。
* BUILDING_INFO.cs
*
* 功 能： N/A
* 类 名： BUILDING_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:00   N/A    初版
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
	/// BUILDING_INFO:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BUILDING_INFO
	{
		public BUILDING_INFO()
		{}
		#region Model
		private decimal _buildingid;
		private string _buildingname;
		private int? _floors;
		private string _admin;
		/// <summary>
		/// 
		/// </summary>
		public decimal BUILDINGID
		{
			set{ _buildingid=value;}
			get{return _buildingid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BUILDINGNAME
		{
			set{ _buildingname=value;}
			get{return _buildingname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FLOORS
		{
			set{ _floors=value;}
			get{return _floors;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ADMIN
		{
			set{ _admin=value;}
			get{return _admin;}
		}
		#endregion Model

	}
}

