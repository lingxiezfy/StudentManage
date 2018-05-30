/**  版本信息模板在安装目录下，可自行修改。
* COMPETITION_TYPE.cs
*
* 功 能： N/A
* 类 名： COMPETITION_TYPE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:06   N/A    初版
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
	/// 数据访问类:COMPETITION_TYPE
	/// </summary>
	public partial class COMPETITION_TYPE
	{
		public COMPETITION_TYPE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal COMPETITIONID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from COMPETITION_TYPE");
			strSql.Append(" where COMPETITIONID=@COMPETITIONID");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPETITIONID", SqlDbType.Decimal)
			};
			parameters[0].Value = COMPETITIONID;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(Student.Model.COMPETITION_TYPE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into COMPETITION_TYPE(");
			strSql.Append("COMPETITION_NAME,RANK,HOSTUNIT,COMPETITION_TM,MEMO)");
			strSql.Append(" values (");
			strSql.Append("@COMPETITION_NAME,@RANK,@HOSTUNIT,@COMPETITION_TM,@MEMO)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPETITION_NAME", SqlDbType.VarChar,200),
					new SqlParameter("@RANK", SqlDbType.Int,4),
					new SqlParameter("@HOSTUNIT", SqlDbType.VarChar,100),
					new SqlParameter("@COMPETITION_TM", SqlDbType.VarChar,200),
					new SqlParameter("@MEMO", SqlDbType.VarChar,200)};
			parameters[0].Value = model.COMPETITION_NAME;
			parameters[1].Value = model.RANK;
			parameters[2].Value = model.HOSTUNIT;
			parameters[3].Value = model.COMPETITION_TM;
			parameters[4].Value = model.MEMO;

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
		public bool Update(Student.Model.COMPETITION_TYPE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update COMPETITION_TYPE set ");
			strSql.Append("COMPETITION_NAME=@COMPETITION_NAME,");
			strSql.Append("RANK=@RANK,");
			strSql.Append("HOSTUNIT=@HOSTUNIT,");
			strSql.Append("COMPETITION_TM=@COMPETITION_TM,");
			strSql.Append("MEMO=@MEMO");
			strSql.Append(" where COMPETITIONID=@COMPETITIONID");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPETITION_NAME", SqlDbType.VarChar,200),
					new SqlParameter("@RANK", SqlDbType.Int,4),
					new SqlParameter("@HOSTUNIT", SqlDbType.VarChar,100),
					new SqlParameter("@COMPETITION_TM", SqlDbType.VarChar,200),
					new SqlParameter("@MEMO", SqlDbType.VarChar,200),
					new SqlParameter("@COMPETITIONID", SqlDbType.Decimal,9)};
			parameters[0].Value = model.COMPETITION_NAME;
			parameters[1].Value = model.RANK;
			parameters[2].Value = model.HOSTUNIT;
			parameters[3].Value = model.COMPETITION_TM;
			parameters[4].Value = model.MEMO;
			parameters[5].Value = model.COMPETITIONID;

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
		public bool Delete(decimal COMPETITIONID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from COMPETITION_TYPE ");
			strSql.Append(" where COMPETITIONID=@COMPETITIONID");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPETITIONID", SqlDbType.Decimal)
			};
			parameters[0].Value = COMPETITIONID;

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
		public bool DeleteList(string COMPETITIONIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from COMPETITION_TYPE ");
			strSql.Append(" where COMPETITIONID in ("+COMPETITIONIDlist + ")  ");
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
		public Student.Model.COMPETITION_TYPE GetModel(decimal COMPETITIONID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 COMPETITIONID,COMPETITION_NAME,RANK,HOSTUNIT,COMPETITION_TM,MEMO from COMPETITION_TYPE ");
			strSql.Append(" where COMPETITIONID=@COMPETITIONID");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPETITIONID", SqlDbType.Decimal)
			};
			parameters[0].Value = COMPETITIONID;

			Student.Model.COMPETITION_TYPE model=new Student.Model.COMPETITION_TYPE();
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
        public Student.Model.COMPETITION_TYPE GetModel(string COMPETITION_NAME)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 COMPETITIONID,COMPETITION_NAME,RANK,HOSTUNIT,COMPETITION_TM,MEMO from COMPETITION_TYPE ");
            strSql.Append(" where COMPETITION_NAME=@COMPETITION_NAME");
            SqlParameter[] parameters = {
					new SqlParameter("@COMPETITION_NAME", SqlDbType.VarChar,200)
			};
            parameters[0].Value = COMPETITION_NAME;

            Student.Model.COMPETITION_TYPE model = new Student.Model.COMPETITION_TYPE();
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
		public Student.Model.COMPETITION_TYPE DataRowToModel(DataRow row)
		{
			Student.Model.COMPETITION_TYPE model=new Student.Model.COMPETITION_TYPE();
			if (row != null)
			{
				if(row["COMPETITIONID"]!=null && row["COMPETITIONID"].ToString()!="")
				{
					model.COMPETITIONID=decimal.Parse(row["COMPETITIONID"].ToString());
				}
				if(row["COMPETITION_NAME"]!=null)
				{
					model.COMPETITION_NAME=row["COMPETITION_NAME"].ToString();
				}
				if(row["RANK"]!=null && row["RANK"].ToString()!="")
				{
					model.RANK=int.Parse(row["RANK"].ToString());
				}
				if(row["HOSTUNIT"]!=null)
				{
					model.HOSTUNIT=row["HOSTUNIT"].ToString();
				}
				if(row["COMPETITION_TM"]!=null)
				{
					model.COMPETITION_TM=row["COMPETITION_TM"].ToString();
				}
				if(row["MEMO"]!=null)
				{
					model.MEMO=row["MEMO"].ToString();
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
			strSql.Append("select COMPETITIONID,COMPETITION_NAME,RANK,HOSTUNIT,COMPETITION_TM,MEMO ");
			strSql.Append(" FROM COMPETITION_TYPE ");
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
			strSql.Append(" COMPETITIONID,COMPETITION_NAME,RANK,HOSTUNIT,COMPETITION_TM,MEMO ");
			strSql.Append(" FROM COMPETITION_TYPE ");
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
			strSql.Append("select count(1) FROM COMPETITION_TYPE ");
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
				strSql.Append("order by T.COMPETITIONID desc");
			}
			strSql.Append(")AS Row, T.*  from COMPETITION_TYPE T ");
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
			parameters[0].Value = "COMPETITION_TYPE";
			parameters[1].Value = "COMPETITIONID";
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

