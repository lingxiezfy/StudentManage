﻿/**  版本信息模板在安装目录下，可自行修改。
* MAJORDIRCT_INFO.cs
*
* 功 能： N/A
* 类 名： MAJORDIRCT_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:15   N/A    初版
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
	/// 数据访问类:MAJORDIRCT_INFO
	/// </summary>
	public partial class MAJORDIRCT_INFO
	{
		public MAJORDIRCT_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return SqlHelper.GetMaxID("MAJORDIRCTNO", "MAJORDIRCT_INFO"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MAJORDIRCTNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MAJORDIRCT_INFO");
			strSql.Append(" where MAJORDIRCTNO=@MAJORDIRCTNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@MAJORDIRCTNO", SqlDbType.Int,4)			};
			parameters[0].Value = MAJORDIRCTNO;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Student.Model.MAJORDIRCT_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MAJORDIRCT_INFO(");
			strSql.Append("MAJORNO,MAJORDIRCTNAME)");
			strSql.Append(" values (");
			strSql.Append("@MAJORNO,@MAJORDIRCTNAME)");
			SqlParameter[] parameters = {
					new SqlParameter("@MAJORNO", SqlDbType.Int,4),
					new SqlParameter("@MAJORDIRCTNAME", SqlDbType.VarChar,30)};
			parameters[0].Value = model.MAJORNO;
			parameters[1].Value = model.MAJORDIRCTNAME;

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
		public bool Update(Student.Model.MAJORDIRCT_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MAJORDIRCT_INFO set ");
			strSql.Append("MAJORNO=@MAJORNO,");
			strSql.Append("MAJORDIRCTNAME=@MAJORDIRCTNAME");
			strSql.Append(" where MAJORDIRCTNO=@MAJORDIRCTNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@MAJORNO", SqlDbType.Int,4),
					new SqlParameter("@MAJORDIRCTNAME", SqlDbType.VarChar,30),
					new SqlParameter("@MAJORDIRCTNO", SqlDbType.Int,4)};
			parameters[0].Value = model.MAJORNO;
			parameters[1].Value = model.MAJORDIRCTNAME;
			parameters[2].Value = model.MAJORDIRCTNO;

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
		public bool Delete(int MAJORDIRCTNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MAJORDIRCT_INFO ");
			strSql.Append(" where MAJORDIRCTNO=@MAJORDIRCTNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@MAJORDIRCTNO", SqlDbType.Int,4)			};
			parameters[0].Value = MAJORDIRCTNO;

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
		public bool DeleteList(string MAJORDIRCTNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MAJORDIRCT_INFO ");
			strSql.Append(" where MAJORDIRCTNO in ("+MAJORDIRCTNOlist + ")  ");
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
        /// 根据专业方向编号查询
		/// </summary>
		public Student.Model.MAJORDIRCT_INFO GetModel(int MAJORDIRCTNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MAJORDIRCTNO,MAJORNO,MAJORDIRCTNAME from MAJORDIRCT_INFO ");
			strSql.Append(" where MAJORDIRCTNO=@MAJORDIRCTNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@MAJORDIRCTNO", SqlDbType.Int,4)			};
			parameters[0].Value = MAJORDIRCTNO;

			Student.Model.MAJORDIRCT_INFO model=new Student.Model.MAJORDIRCT_INFO();
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
        /// 根据专业方向名称查询
        /// </summary>
        public Student.Model.MAJORDIRCT_INFO GetModel(string MAJORDIRCTNAME)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 MAJORDIRCTNO,MAJORNO,MAJORDIRCTNAME from MAJORDIRCT_INFO ");
            strSql.Append(" where MAJORDIRCTNAME=@MAJORDIRCTNAME ");
            SqlParameter[] parameters = {
					new SqlParameter("@MAJORDIRCTNAME", SqlDbType.VarChar,30)			};
            parameters[0].Value = MAJORDIRCTNAME;

            Student.Model.MAJORDIRCT_INFO model = new Student.Model.MAJORDIRCT_INFO();
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
		public Student.Model.MAJORDIRCT_INFO DataRowToModel(DataRow row)
		{
			Student.Model.MAJORDIRCT_INFO model=new Student.Model.MAJORDIRCT_INFO();
			if (row != null)
			{
				if(row["MAJORDIRCTNO"]!=null && row["MAJORDIRCTNO"].ToString()!="")
				{
					model.MAJORDIRCTNO=int.Parse(row["MAJORDIRCTNO"].ToString());
				}
				if(row["MAJORNO"]!=null && row["MAJORNO"].ToString()!="")
				{
					model.MAJORNO=int.Parse(row["MAJORNO"].ToString());
				}
				if(row["MAJORDIRCTNAME"]!=null)
				{
					model.MAJORDIRCTNAME=row["MAJORDIRCTNAME"].ToString();
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
			strSql.Append("select A.MAJORDIRCTNO,B.MAJORNAME,A.MAJORDIRCTNAME ");
            strSql.Append(" FROM MAJORDIRCT_INFO A,MAJOR_INFO B ");
            strSql.Append(" where A.MAJORNO = B.MAJORNO ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(strWhere);
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
			strSql.Append(" MAJORDIRCTNO,MAJORNO,MAJORDIRCTNAME ");
			strSql.Append(" FROM MAJORDIRCT_INFO ");
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
			strSql.Append("select count(1) FROM MAJORDIRCT_INFO ");
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
				strSql.Append("order by T.MAJORDIRCTNO desc");
			}
			strSql.Append(")AS Row, T.*  from MAJORDIRCT_INFO T ");
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
			parameters[0].Value = "MAJORDIRCT_INFO";
			parameters[1].Value = "MAJORDIRCTNO";
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

