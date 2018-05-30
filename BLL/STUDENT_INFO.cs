/**  版本信息模板在安装目录下，可自行修改。
* STUDENT_INFO.cs
*
* 功 能： N/A
* 类 名： STUDENT_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:34   N/A    初版
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
	/// STUDENT_INFO
	/// </summary>
	public partial class STUDENT_INFO
	{
		private readonly Student.DAL.STUDENT_INFO dal=new Student.DAL.STUDENT_INFO();
		public STUDENT_INFO()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string STUNO)
		{
			return dal.Exists(STUNO);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Student.Model.STUDENT_INFO model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Student.Model.STUDENT_INFO model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string STUNO)
		{
			
			return dal.Delete(STUNO);
		}

		/// <summary>
		/// 得到一个对象实体
        /// 根据学号查找
		/// </summary>
		public Student.Model.STUDENT_INFO GetModel(string STUNO,string flag)
		{

            return dal.GetModel(STUNO,flag);
		}

        /// <summary>
        /// 得到一个对象实体
        /// 根据姓名查找
        /// </summary>
        public Student.Model.STUDENT_INFO GetModel(string STUNAME, int flag)
        {

            return dal.GetModel(STUNAME, flag);
        }

		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
        /// <summary>
        /// 取得入学年份列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetInYearList()
        {
            return dal.GetInYearList();
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
		public List<Student.Model.STUDENT_INFO> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Student.Model.STUDENT_INFO> DataTableToList(DataTable dt)
		{
			List<Student.Model.STUDENT_INFO> modelList = new List<Student.Model.STUDENT_INFO>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Student.Model.STUDENT_INFO model;
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
        /// 创建学年-班级-学生列表，分配指导教师专用
        /// </summary>
        /// <param name="termno"></param>
        /// <param name="workflowno"></param>
        /// <returns></returns>
        public DataSet GetStudentNodeList(int termno, int workflowno)
        {
            return dal.GetStudentNodeList(termno,workflowno);
        }

        /// <summary>
        /// 创建学年-班级-学生列表
        /// </summary>
        /// <param name="termno"></param>
        /// <param name="workflowno"></param>
        /// <returns></returns>
        public DataSet GetStudentNodeList()
        {
            return dal.GetStudentNodeList();
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

