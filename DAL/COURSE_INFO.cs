/**  版本信息模板在安装目录下，可自行修改。
* COURSE_INFO.cs
*
* 功 能： N/A
* 类 名： COURSE_INFO
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
	/// 数据访问类:COURSE_INFO
	/// </summary>
	public partial class COURSE_INFO
	{
		public COURSE_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal COURSENO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from COURSE_INFO");
			strSql.Append(" where COURSENO=@COURSENO ");
			SqlParameter[] parameters = {
					new SqlParameter("@COURSENO", SqlDbType.Decimal,9)			};
			parameters[0].Value = COURSENO;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Student.Model.COURSE_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into COURSE_INFO(");
			strSql.Append("COURSETYPENO,COURSENAME,TOTALHOUR,THEORYHOUR,EXPERIMENTHOUR,CREDIT,MEMO)");
			strSql.Append(" values (");
			strSql.Append("@COURSETYPENO,@COURSENAME,@TOTALHOUR,@THEORYHOUR,@EXPERIMENTHOUR,@CREDIT,@MEMO)");
			SqlParameter[] parameters = {
					new SqlParameter("@COURSETYPENO", SqlDbType.Decimal,9),
					new SqlParameter("@COURSENAME", SqlDbType.VarChar,100),
					new SqlParameter("@TOTALHOUR", SqlDbType.Int,4),
					new SqlParameter("@THEORYHOUR", SqlDbType.Int,4),
					new SqlParameter("@EXPERIMENTHOUR", SqlDbType.Int,4),
					new SqlParameter("@CREDIT", SqlDbType.Float,8),
					new SqlParameter("@MEMO", SqlDbType.VarChar,500)};
			parameters[0].Value = model.COURSETYPENO;
			parameters[1].Value = model.COURSENAME;
			parameters[2].Value = model.TOTALHOUR;
			parameters[3].Value = model.THEORYHOUR;
			parameters[4].Value = model.EXPERIMENTHOUR;
			parameters[5].Value = model.CREDIT;
			parameters[6].Value = model.MEMO;

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
		public bool Update(Student.Model.COURSE_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update COURSE_INFO set ");
			strSql.Append("COURSETYPENO=@COURSETYPENO,");
			strSql.Append("COURSENAME=@COURSENAME,");
			strSql.Append("TOTALHOUR=@TOTALHOUR,");
			strSql.Append("THEORYHOUR=@THEORYHOUR,");
			strSql.Append("EXPERIMENTHOUR=@EXPERIMENTHOUR,");
			strSql.Append("CREDIT=@CREDIT,");
			strSql.Append("MEMO=@MEMO");
			strSql.Append(" where COURSENO=@COURSENO ");
			SqlParameter[] parameters = {
					new SqlParameter("@COURSETYPENO", SqlDbType.Decimal,9),
					new SqlParameter("@COURSENAME", SqlDbType.VarChar,100),
					new SqlParameter("@TOTALHOUR", SqlDbType.Int,4),
					new SqlParameter("@THEORYHOUR", SqlDbType.Int,4),
					new SqlParameter("@EXPERIMENTHOUR", SqlDbType.Int,4),
					new SqlParameter("@CREDIT", SqlDbType.Float,8),
					new SqlParameter("@MEMO", SqlDbType.VarChar,500),
					new SqlParameter("@COURSENO", SqlDbType.Decimal,9)};
			parameters[0].Value = model.COURSETYPENO;
			parameters[1].Value = model.COURSENAME;
			parameters[2].Value = model.TOTALHOUR;
			parameters[3].Value = model.THEORYHOUR;
			parameters[4].Value = model.EXPERIMENTHOUR;
			parameters[5].Value = model.CREDIT;
			parameters[6].Value = model.MEMO;
			parameters[7].Value = model.COURSENO;

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
		public bool Delete(decimal COURSENO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from COURSE_INFO ");
			strSql.Append(" where COURSENO=@COURSENO ");
			SqlParameter[] parameters = {
					new SqlParameter("@COURSENO", SqlDbType.Decimal,9)			};
			parameters[0].Value = COURSENO;

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
		public bool DeleteList(string COURSENOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from COURSE_INFO ");
			strSql.Append(" where COURSENO in ("+COURSENOlist + ")  ");
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
		public Student.Model.COURSE_INFO GetModel(decimal COURSENO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 COURSENO,COURSETYPENO,COURSENAME,TOTALHOUR,THEORYHOUR,EXPERIMENTHOUR,CREDIT,MEMO from COURSE_INFO ");
			strSql.Append(" where COURSENO=@COURSENO ");
			SqlParameter[] parameters = {
					new SqlParameter("@COURSENO", SqlDbType.Decimal,9)			};
			parameters[0].Value = COURSENO;

			Student.Model.COURSE_INFO model=new Student.Model.COURSE_INFO();
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
        public Student.Model.COURSE_INFO GetModel(string COURSENAME)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 COURSENO,COURSETYPENO,COURSENAME,TOTALHOUR,THEORYHOUR,EXPERIMENTHOUR,CREDIT,MEMO from COURSE_INFO ");
            strSql.Append(" where COURSENAME=@COURSENAME ");
            SqlParameter[] parameters = {
					new SqlParameter("@COURSENAME", SqlDbType.VarChar,100)			};
            parameters[0].Value = COURSENAME;

            Student.Model.COURSE_INFO model = new Student.Model.COURSE_INFO();
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
		public Student.Model.COURSE_INFO DataRowToModel(DataRow row)
		{
			Student.Model.COURSE_INFO model=new Student.Model.COURSE_INFO();
			if (row != null)
			{
				if(row["COURSENO"]!=null && row["COURSENO"].ToString()!="")
				{
					model.COURSENO=decimal.Parse(row["COURSENO"].ToString());
				}
				if(row["COURSETYPENO"]!=null && row["COURSETYPENO"].ToString()!="")
				{
					model.COURSETYPENO=decimal.Parse(row["COURSETYPENO"].ToString());
				}
				if(row["COURSENAME"]!=null)
				{
					model.COURSENAME=row["COURSENAME"].ToString();
				}
				if(row["TOTALHOUR"]!=null && row["TOTALHOUR"].ToString()!="")
				{
					model.TOTALHOUR=int.Parse(row["TOTALHOUR"].ToString());
				}
				if(row["THEORYHOUR"]!=null && row["THEORYHOUR"].ToString()!="")
				{
					model.THEORYHOUR=int.Parse(row["THEORYHOUR"].ToString());
				}
				if(row["EXPERIMENTHOUR"]!=null && row["EXPERIMENTHOUR"].ToString()!="")
				{
					model.EXPERIMENTHOUR=int.Parse(row["EXPERIMENTHOUR"].ToString());
				}
				if(row["CREDIT"]!=null && row["CREDIT"].ToString()!="")
				{
					model.CREDIT=decimal.Parse(row["CREDIT"].ToString());
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
            strSql.Append("select COURSENO,COURSENAME,B.COURSETYPENAME,TOTALHOUR,THEORYHOUR,EXPERIMENTHOUR,CREDIT,A.MEMO ");
            strSql.Append(" FROM COURSE_INFO A,COURSE_TYPE B");
            strSql.Append(" WHERE A.COURSETYPENO = B.COURSETYPENO ");
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
			strSql.Append(" COURSENO,COURSETYPENO,COURSENAME,TOTALHOUR,THEORYHOUR,EXPERIMENTHOUR,CREDIT,MEMO ");
			strSql.Append(" FROM COURSE_INFO ");
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
			strSql.Append("select count(1) FROM COURSE_INFO ");
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
				strSql.Append("order by T.COURSENO desc");
			}
			strSql.Append(")AS Row, T.*  from COURSE_INFO T ");
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
			parameters[0].Value = "COURSE_INFO";
			parameters[1].Value = "COURSENO";
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

