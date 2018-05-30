/**  版本信息模板在安装目录下，可自行修改。
* WORKFLOWSET.cs
*
* 功 能： N/A
* 类 名： WORKFLOWSET
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:37   N/A    初版
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
	/// 数据访问类:WORKFLOWSET
	/// </summary>
	public partial class WORKFLOWSET
	{
		public WORKFLOWSET()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal SETNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WORKFLOWSET");
			strSql.Append(" where SETNO=@SETNO");
			SqlParameter[] parameters = {
					new SqlParameter("@SETNO", SqlDbType.Decimal)
			};
			parameters[0].Value = SETNO;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(Student.Model.WORKFLOWSET model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WORKFLOWSET(");
			strSql.Append("WORKFLOWNO,NODENO,NODEORDER,BEGINTIME,ENDTIME)");
			strSql.Append(" values (");
            strSql.Append("@WORKFLOWNO,@NODENO,@NODEORDER,@BEGINTIME,@ENDTIME)");
			SqlParameter[] parameters = {
					new SqlParameter("@WORKFLOWNO", SqlDbType.Int,4),
                    new SqlParameter("@NODENO", SqlDbType.Int,4),
					new SqlParameter("@NODEORDER", SqlDbType.Int,4),
					new SqlParameter("@BEGINTIME", SqlDbType.DateTime),
					new SqlParameter("@ENDTIME", SqlDbType.DateTime)};
			parameters[0].Value = model.WORKFLOWNO;
            parameters[1].Value = model.NODENO;
			parameters[2].Value = model.NODEORDER;
			parameters[3].Value = model.BEGINTIME;
			parameters[4].Value = model.ENDTIME;

			object obj = SqlHelper.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToDecimal(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Student.Model.WORKFLOWSET model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WORKFLOWSET set ");
			strSql.Append("NODENO=@NODENO,");
			strSql.Append("WORKFLOWNO=@WORKFLOWNO,");
			strSql.Append("NODEORDER=@NODEORDER,");
			strSql.Append("BEGINTIME=@BEGINTIME,");
			strSql.Append("ENDTIME=@ENDTIME");
			strSql.Append(" where SETNO=@SETNO");
			SqlParameter[] parameters = {
					new SqlParameter("@NODENO", SqlDbType.Int,4),
					new SqlParameter("@WORKFLOWNO", SqlDbType.Int,4),
					new SqlParameter("@NODEORDER", SqlDbType.Int,4),
					new SqlParameter("@BEGINTIME", SqlDbType.DateTime),
					new SqlParameter("@ENDTIME", SqlDbType.DateTime),
					new SqlParameter("@SETNO", SqlDbType.Decimal,9)};
			parameters[0].Value = model.NODENO;
			parameters[1].Value = model.WORKFLOWNO;
			parameters[2].Value = model.NODEORDER;
			parameters[3].Value = model.BEGINTIME;
			parameters[4].Value = model.ENDTIME;
			parameters[5].Value = model.SETNO;

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
        public bool Delete(decimal SETNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WORKFLOWSET ");
			strSql.Append(" where SETNO=@SETNO");
			SqlParameter[] parameters = {
					new SqlParameter("@SETNO", SqlDbType.Decimal)
			};
			parameters[0].Value = SETNO;

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
		public bool DeleteList(string SETNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WORKFLOWSET ");
			strSql.Append(" where SETNO in ("+SETNOlist + ")  ");
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
		/// </summary>
		public Student.Model.WORKFLOWSET GetModel(decimal SETNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SETNO,NODENO,WORKFLOWNO,NODEORDER,BEGINTIME,ENDTIME from WORKFLOWSET ");
			strSql.Append(" where SETNO=@SETNO");
			SqlParameter[] parameters = {
					new SqlParameter("@SETNO", SqlDbType.Decimal)
			};
			parameters[0].Value = SETNO;

			Student.Model.WORKFLOWSET model=new Student.Model.WORKFLOWSET();
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
		/// </summary>
		public Student.Model.WORKFLOWSET DataRowToModel(DataRow row)
		{
			Student.Model.WORKFLOWSET model=new Student.Model.WORKFLOWSET();
			if (row != null)
			{
				if(row["SETNO"]!=null && row["SETNO"].ToString()!="")
				{
					model.SETNO=decimal.Parse(row["SETNO"].ToString());
				}
				if(row["NODENO"]!=null && row["NODENO"].ToString()!="")
				{
					model.NODENO=int.Parse(row["NODENO"].ToString());
				}
				if(row["WORKFLOWNO"]!=null && row["WORKFLOWNO"].ToString()!="")
				{
					model.WORKFLOWNO=int.Parse(row["WORKFLOWNO"].ToString());
				}
				if(row["NODEORDER"]!=null && row["NODEORDER"].ToString()!="")
				{
					model.NODEORDER=int.Parse(row["NODEORDER"].ToString());
				}
				if(row["BEGINTIME"]!=null && row["BEGINTIME"].ToString()!="")
				{
					model.BEGINTIME=DateTime.Parse(row["BEGINTIME"].ToString());
				}
				if(row["ENDTIME"]!=null && row["ENDTIME"].ToString()!="")
				{
					model.ENDTIME=DateTime.Parse(row["ENDTIME"].ToString());
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
            strSql.Append("select SETNO,WORKNODE.NODENAME AS NODENAME,WORKFLOW.WORKFLOWNAME AS WORKFLOWNAME,NODEORDER,BEGINTIME,ENDTIME ");
			strSql.Append(" FROM WORKFLOWSET,WORKNODE,WORKFLOW ");
            strSql.Append(" where WORKFLOWSET.NODENO = WORKNODE.NODENO and WORKFLOWSET.WORKFLOWNO = WORKFLOW.WORKFLOWNO ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" AND "+strWhere);
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
			strSql.Append(" SETNO,NODENO,WORKFLOWNO,NODEORDER,BEGINTIME,ENDTIME ");
			strSql.Append(" FROM WORKFLOWSET ");
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
			strSql.Append("select count(1) FROM WORKFLOWSET ");
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
				strSql.Append("order by T.SETNO desc");
			}
			strSql.Append(")AS Row, T.*  from WORKFLOWSET T ");
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
			parameters[0].Value = "WORKFLOWSET";
			parameters[1].Value = "SETNO";
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

