﻿/**  版本信息模板在安装目录下，可自行修改。
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
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Student.Model;
namespace Student.BLL
{
	/// <summary>
	/// STUDENT_JOBSTATUS
	/// </summary>
	public partial class STUDENT_JOBSTATUS
	{
		private readonly Student.DAL.STUDENT_JOBSTATUS dal=new Student.DAL.STUDENT_JOBSTATUS();
		public STUDENT_JOBSTATUS()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal STATUSNO)
		{
			return dal.Exists(STATUSNO);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(Student.Model.STUDENT_JOBSTATUS model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Student.Model.STUDENT_JOBSTATUS model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal STATUSNO)
		{
			
			return dal.Delete(STATUSNO);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string STATUSNOlist )
		{
			return dal.DeleteList(STATUSNOlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Student.Model.STUDENT_JOBSTATUS GetModel(decimal STATUSNO)
		{
			
			return dal.GetModel(STATUSNO);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Student.Model.STUDENT_JOBSTATUS GetModelByCache(decimal STATUSNO)
		{
			
			string CacheKey = "STUDENT_JOBSTATUSModel-" + STATUSNO;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(STATUSNO);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Student.Model.STUDENT_JOBSTATUS)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

        /// <summary>
        /// 获得数据列表
        /// 只取每个学生的最后一条记录
        /// </summary>
        public DataSet GetList(string strWhere,int flag)
        {
            return dal.GetList(strWhere,flag);
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
		public List<Student.Model.STUDENT_JOBSTATUS> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Student.Model.STUDENT_JOBSTATUS> DataTableToList(DataTable dt)
		{
			List<Student.Model.STUDENT_JOBSTATUS> modelList = new List<Student.Model.STUDENT_JOBSTATUS>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Student.Model.STUDENT_JOBSTATUS model;
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

