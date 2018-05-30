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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Student.DBUtility;//Please add references
namespace Student.DAL
{
	/// <summary>
	/// 数据访问类:WORKFLOW
	/// </summary>
	public partial class WORKFLOW
	{
		public WORKFLOW()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return SqlHelper.GetMaxID("WORKFLOWNO", "WORKFLOW"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int WORKFLOWNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WORKFLOW");
			strSql.Append(" where WORKFLOWNO=@WORKFLOWNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@WORKFLOWNO", SqlDbType.Int,4)			};
			parameters[0].Value = WORKFLOWNO;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Student.Model.WORKFLOW model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WORKFLOW(");
			strSql.Append("WORKFLOWNAME,CREATEDATE,STATUS)");
			strSql.Append(" values (");
			strSql.Append("@WORKFLOWNAME,@CREATEDATE,@STATUS)");
			SqlParameter[] parameters = {
					new SqlParameter("@WORKFLOWNAME", SqlDbType.VarChar,40),
					new SqlParameter("@CREATEDATE", SqlDbType.DateTime),
					new SqlParameter("@STATUS", SqlDbType.Int,4)};
			parameters[0].Value = model.WORKFLOWNAME;
			parameters[1].Value = model.CREATEDATE;
			parameters[2].Value = model.STATUS;

			int rows=SqlHelper.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Student.Model.WORKFLOW model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WORKFLOW set ");
			strSql.Append("WORKFLOWNAME=@WORKFLOWNAME,");
			strSql.Append("CREATEDATE=@CREATEDATE,");
			strSql.Append("STATUS=@STATUS");
			strSql.Append(" where WORKFLOWNO=@WORKFLOWNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@WORKFLOWNAME", SqlDbType.VarChar,40),
					new SqlParameter("@CREATEDATE", SqlDbType.DateTime),
					new SqlParameter("@STATUS", SqlDbType.Int,4),
					new SqlParameter("@WORKFLOWNO", SqlDbType.Int,4)};
			parameters[0].Value = model.WORKFLOWNAME;
			parameters[1].Value = model.CREATEDATE;
			parameters[2].Value = model.STATUS;
			parameters[3].Value = model.WORKFLOWNO;

			int rows=SqlHelper.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int WORKFLOWNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WORKFLOW ");
			strSql.Append(" where WORKFLOWNO=@WORKFLOWNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@WORKFLOWNO", SqlDbType.Int,4)			};
			parameters[0].Value = WORKFLOWNO;

			int rows=SqlHelper.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string WORKFLOWNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WORKFLOW ");
			strSql.Append(" where WORKFLOWNO in ("+WORKFLOWNOlist + ")  ");
			int rows=SqlHelper.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
        /// 根据工作流编号查找
		/// </summary>
		public Student.Model.WORKFLOW GetModel(int WORKFLOWNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 WORKFLOWNO,WORKFLOWNAME,CREATEDATE,case STATUS when 1 then '在用' else '未用' end as STATUS from WORKFLOW ");
			strSql.Append(" where WORKFLOWNO=@WORKFLOWNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@WORKFLOWNO", SqlDbType.Int,4)			};
			parameters[0].Value = WORKFLOWNO;

			Student.Model.WORKFLOW model=new Student.Model.WORKFLOW();
			DataSet ds=SqlHelper.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}

        /// <summary>
        /// 得到一个对象实体
        /// 根据工作流名称查找
        /// </summary>
        public Student.Model.WORKFLOW GetModel(string WORKFLOWNAME)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 WORKFLOWNO,WORKFLOWNAME,CREATEDATE,case STATUS when 1 then '在用' else '未用' end as STATUS from WORKFLOW ");
            strSql.Append(" where WORKFLOWNAME=@WORKFLOWNAME ");
            SqlParameter[] parameters = {
					new SqlParameter("@WORKFLOWNAME", SqlDbType.VarChar,40)			};
            parameters[0].Value = WORKFLOWNAME;

            Student.Model.WORKFLOW model = new Student.Model.WORKFLOW();
            DataSet ds = SqlHelper.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Student.Model.WORKFLOW DataRowToModel(DataRow row)
		{
			Student.Model.WORKFLOW model=new Student.Model.WORKFLOW();
			if (row != null)
			{
				if(row["WORKFLOWNO"]!=null && row["WORKFLOWNO"].ToString()!="")
				{
					model.WORKFLOWNO=int.Parse(row["WORKFLOWNO"].ToString());
				}
				if(row["WORKFLOWNAME"]!=null)
				{
					model.WORKFLOWNAME=row["WORKFLOWNAME"].ToString();
				}
				if(row["CREATEDATE"]!=null && row["CREATEDATE"].ToString()!="")
				{
					model.CREATEDATE=DateTime.Parse(row["CREATEDATE"].ToString());
				}
				if(row["STATUS"]!=null && row["STATUS"].ToString()!="")
				{
                    if (row["STATUS"].ToString() == "在用")
                    {
                        model.STATUS = 1;
                    }
                    else
                        model.STATUS = 0;
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select WORKFLOWNO,WORKFLOWNAME,CREATEDATE,case STATUS when 1 then '在用' else '未用' end as STATUS ");
			strSql.Append(" FROM WORKFLOW ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return SqlHelper.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" WORKFLOWNO,WORKFLOWNAME,CREATEDATE,STATUS ");
			strSql.Append(" FROM WORKFLOW ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return SqlHelper.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM WORKFLOW ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            object obj = SqlHelper.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.WORKFLOWNO desc");
			}
			strSql.Append(")AS Row, T.*  from WORKFLOW T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return SqlHelper.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "WORKFLOW";
			parameters[1].Value = "WORKFLOWNO";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return SqlHelper.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

