﻿/**  版本信息模板在安装目录下，可自行修改。
* TERM_INFO.cs
*
* 功 能： N/A
* 类 名： TERM_INFO
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
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Student.Model;
namespace Student.BLL
{
	/// <summary>
	/// TERM_INFO
	/// </summary>
	public partial class TERM_INFO
	{
		private readonly Student.DAL.TERM_INFO dal=new Student.DAL.TERM_INFO();
		public TERM_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int TERMNO)
		{
			return dal.Exists(TERMNO);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Student.Model.TERM_INFO model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Student.Model.TERM_INFO model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int TERMNO)
		{
			
			return dal.Delete(TERMNO);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string TERMNOlist )
		{
			return dal.DeleteList(TERMNOlist );
		}

		/// <summary>
		/// 得到一个对象实体
        /// 根据学期编号查找
		/// </summary>
		public Student.Model.TERM_INFO GetModel(int TERMNO)
		{
			
			return dal.GetModel(TERMNO);
		}

        /// <summary>
        /// 得到一个对象实体
        /// 根据学期名称查找
        /// </summary>
        public Student.Model.TERM_INFO GetModel(string TERMNAME)
        {

            return dal.GetModel(TERMNAME);
        }

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Student.Model.TERM_INFO GetModelByCache(int TERMNO)
		{
			
			string CacheKey = "TERM_INFOModel-" + TERMNO;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(TERMNO);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Student.Model.TERM_INFO)objModel;
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
		public List<Student.Model.TERM_INFO> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Student.Model.TERM_INFO> DataTableToList(DataTable dt)
		{
			List<Student.Model.TERM_INFO> modelList = new List<Student.Model.TERM_INFO>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Student.Model.TERM_INFO model;
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
