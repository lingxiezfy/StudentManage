/**  版本信息模板在安装目录下，可自行修改。
* DORMITORY_INFO.cs
*
* 功 能： N/A
* 类 名： DORMITORY_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:14   N/A    初版
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
	/// DORMITORY_INFO:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DORMITORY_INFO
	{
		public DORMITORY_INFO()
		{}
		#region Model
		private decimal _dormitory_id;
		private decimal? _buildingid;
		private string _dormitory_plate;
		/// <summary>
		/// 
		/// </summary>
		public decimal DORMITORY_ID
		{
			set{ _dormitory_id=value;}
			get{return _dormitory_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BUILDINGID
		{
			set{ _buildingid=value;}
			get{return _buildingid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DORMITORY_PLATE
		{
			set{ _dormitory_plate=value;}
			get{return _dormitory_plate;}
		}
		#endregion Model

	}
}

