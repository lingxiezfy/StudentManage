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
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Student.Model;
namespace Student.BLL
{
	/// <summary>
	/// COMPETITION_GROUP
	/// </summary>
	public partial class COMPETITION_GROUP
	{
		private readonly Student.DAL.COMPETITION_GROUP dal=new Student.DAL.COMPETITION_GROUP();
		public COMPETITION_GROUP()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal GROUPID)
		{
			return dal.Exists(GROUPID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Student.Model.COMPETITION_GROUP model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Student.Model.COMPETITION_GROUP model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal GROUPID)
		{
			
			return dal.Delete(GROUPID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string GROUPIDlist )
		{
			return dal.DeleteList(GROUPIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Student.Model.COMPETITION_GROUP GetModel(decimal GROUPID)
		{
			
			return dal.GetModel(GROUPID);
		}

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Student.Model.COMPETITION_GROUP GetModel(string GROUPNAME)
        {

            return dal.GetModel(GROUPNAME);
        }

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Student.Model.COMPETITION_GROUP GetModelByCache(decimal GROUPID)
		{
			
			string CacheKey = "COMPETITION_GROUPModel-" + GROUPID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(GROUPID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Student.Model.COMPETITION_GROUP)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Student.Model.COMPETITION_GROUP> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Student.Model.COMPETITION_GROUP> DataTableToList(DataTable dt)
		{
			List<Student.Model.COMPETITION_GROUP> modelList = new List<Student.Model.COMPETITION_GROUP>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Student.Model.COMPETITION_GROUP model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

