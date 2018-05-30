/**  版本信息模板在安装目录下，可自行修改。
* BRBAC_USER.cs
*
* 功 能： N/A
* 类 名： BRBAC_USER
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/5/19 星期四 10:33:02   N/A    初版
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
	/// 数据访问类:BRBAC_USER
	/// </summary>
	public partial class BRBAC_USER
	{
		public BRBAC_USER()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal USER_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BRBAC_USER");
			strSql.Append(" where USER_ID=@USER_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@USER_ID", SqlDbType.Decimal)
			};
			parameters[0].Value = USER_ID;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(Student.Model.BRBAC_USER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BRBAC_USER(");
			strSql.Append("USER_CDE,USER_NAME,USER_PWD,LAST_LOGIN_TIME,AUTH_MENU)");
			strSql.Append(" values (");
			strSql.Append("@USER_CDE,@USER_NAME,@USER_PWD,@LAST_LOGIN_TIME,@AUTH_MENU)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@USER_CDE", SqlDbType.VarChar,30),
					new SqlParameter("@USER_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@USER_PWD", SqlDbType.VarChar,50),
					new SqlParameter("@LAST_LOGIN_TIME", SqlDbType.DateTime),
					new SqlParameter("@AUTH_MENU", SqlDbType.VarChar,1000)};
			parameters[0].Value = model.USER_CDE;
			parameters[1].Value = model.USER_NAME;
			parameters[2].Value = model.USER_PWD;
			parameters[3].Value = model.LAST_LOGIN_TIME;
			parameters[4].Value = model.AUTH_MENU;

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
		public bool Update(Student.Model.BRBAC_USER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BRBAC_USER set ");
			strSql.Append("USER_CDE=@USER_CDE,");
			strSql.Append("USER_NAME=@USER_NAME,");
			strSql.Append("USER_PWD=@USER_PWD,");
			strSql.Append("LAST_LOGIN_TIME=@LAST_LOGIN_TIME,");
			strSql.Append("AUTH_MENU=@AUTH_MENU");
			strSql.Append(" where USER_ID=@USER_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@USER_CDE", SqlDbType.VarChar,30),
					new SqlParameter("@USER_NAME", SqlDbType.VarChar,50),
					new SqlParameter("@USER_PWD", SqlDbType.VarChar,50),
					new SqlParameter("@LAST_LOGIN_TIME", SqlDbType.DateTime),
					new SqlParameter("@AUTH_MENU", SqlDbType.VarChar,1000),
					new SqlParameter("@USER_ID", SqlDbType.Decimal,9)};
			parameters[0].Value = model.USER_CDE;
			parameters[1].Value = model.USER_NAME;
			parameters[2].Value = model.USER_PWD;
			parameters[3].Value = model.LAST_LOGIN_TIME;
			parameters[4].Value = model.AUTH_MENU;
			parameters[5].Value = model.USER_ID;

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
		public bool Delete(decimal USER_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BRBAC_USER ");
			strSql.Append(" where USER_ID=@USER_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@USER_ID", SqlDbType.Decimal)
			};
			parameters[0].Value = USER_ID;

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
		public bool DeleteList(string USER_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BRBAC_USER ");
			strSql.Append(" where USER_ID in ("+USER_IDlist + ")  ");
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
		public Student.Model.BRBAC_USER GetModel(decimal USER_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 USER_ID,USER_CDE,USER_NAME,USER_PWD,LAST_LOGIN_TIME,AUTH_MENU from BRBAC_USER ");
			strSql.Append(" where USER_ID=@USER_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@USER_ID", SqlDbType.Decimal)
			};
			parameters[0].Value = USER_ID;

			Student.Model.BRBAC_USER model=new Student.Model.BRBAC_USER();
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
		public Student.Model.BRBAC_USER DataRowToModel(DataRow row)
		{
			Student.Model.BRBAC_USER model=new Student.Model.BRBAC_USER();
			if (row != null)
			{
				if(row["USER_ID"]!=null && row["USER_ID"].ToString()!="")
				{
					model.USER_ID=decimal.Parse(row["USER_ID"].ToString());
				}
				if(row["USER_CDE"]!=null)
				{
					model.USER_CDE=row["USER_CDE"].ToString();
				}
				if(row["USER_NAME"]!=null)
				{
					model.USER_NAME=row["USER_NAME"].ToString();
				}
				if(row["USER_PWD"]!=null)
				{
					model.USER_PWD=row["USER_PWD"].ToString();
				}
				if(row["LAST_LOGIN_TIME"]!=null && row["LAST_LOGIN_TIME"].ToString()!="")
				{
					model.LAST_LOGIN_TIME=DateTime.Parse(row["LAST_LOGIN_TIME"].ToString());
				}
				if(row["AUTH_MENU"]!=null)
				{
					model.AUTH_MENU=row["AUTH_MENU"].ToString();
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
			strSql.Append("select USER_ID,USER_CDE,USER_NAME,USER_PWD,LAST_LOGIN_TIME,AUTH_MENU ");
			strSql.Append(" FROM BRBAC_USER ");
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
			strSql.Append(" USER_ID,USER_CDE,USER_NAME,USER_PWD,LAST_LOGIN_TIME,AUTH_MENU ");
			strSql.Append(" FROM BRBAC_USER ");
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
			strSql.Append("select count(1) FROM BRBAC_USER ");
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
				strSql.Append("order by T.USER_ID desc");
			}
			strSql.Append(")AS Row, T.*  from BRBAC_USER T ");
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
			parameters[0].Value = "BRBAC_USER";
			parameters[1].Value = "USER_ID";
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

