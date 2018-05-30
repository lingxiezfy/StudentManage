/**  版本信息模板在安装目录下，可自行修改。
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
using System.Text;
using System.Data.SqlClient;
using Student.DBUtility;//Please add references
namespace Student.DAL
{
	/// <summary>
	/// 数据访问类:STUDENT_JOBSTATUS
	/// </summary>
	public partial class STUDENT_JOBSTATUS
	{
		public STUDENT_JOBSTATUS()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal STATUSNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from STUDENT_JOBSTATUS");
			strSql.Append(" where STATUSNO=@STATUSNO");
			SqlParameter[] parameters = {
					new SqlParameter("@STATUSNO", SqlDbType.Decimal)
			};
			parameters[0].Value = STATUSNO;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(Student.Model.STUDENT_JOBSTATUS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into STUDENT_JOBSTATUS(");
			strSql.Append("STUNO,ENTNO,JOBTITLE,SALARY,STATUS,STATUSTIME,IF_CURRENT,MEMO)");
			strSql.Append(" values (");
			strSql.Append("@STUNO,@ENTNO,@JOBTITLE,@SALARY,@STATUS,@STATUSTIME,@IF_CURRENT,@MEMO)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@STUNO", SqlDbType.VarChar,10),
					new SqlParameter("@ENTNO", SqlDbType.Decimal,9),
					new SqlParameter("@JOBTITLE", SqlDbType.VarChar,100),
					new SqlParameter("@SALARY", SqlDbType.Int,4),
					new SqlParameter("@STATUS", SqlDbType.VarChar,200),
					new SqlParameter("@STATUSTIME", SqlDbType.DateTime),
					new SqlParameter("@IF_CURRENT", SqlDbType.Int,4),
					new SqlParameter("@MEMO", SqlDbType.VarChar,2000)};
			parameters[0].Value = model.STUNO;
			parameters[1].Value = model.ENTNO;
			parameters[2].Value = model.JOBTITLE;
			parameters[3].Value = model.SALARY;
			parameters[4].Value = model.STATUS;
			parameters[5].Value = model.STATUSTIME;
			parameters[6].Value = model.IF_CURRENT;
			parameters[7].Value = model.MEMO;

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
		public bool Update(Student.Model.STUDENT_JOBSTATUS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update STUDENT_JOBSTATUS set ");
			strSql.Append("STUNO=@STUNO,");
			strSql.Append("ENTNO=@ENTNO,");
			strSql.Append("JOBTITLE=@JOBTITLE,");
			strSql.Append("SALARY=@SALARY,");
			strSql.Append("STATUS=@STATUS,");
			strSql.Append("STATUSTIME=@STATUSTIME,");
			strSql.Append("IF_CURRENT=@IF_CURRENT,");
			strSql.Append("MEMO=@MEMO");
			strSql.Append(" where STATUSNO=@STATUSNO");
			SqlParameter[] parameters = {
					new SqlParameter("@STUNO", SqlDbType.VarChar,10),
					new SqlParameter("@ENTNO", SqlDbType.Decimal,9),
					new SqlParameter("@JOBTITLE", SqlDbType.VarChar,100),
					new SqlParameter("@SALARY", SqlDbType.Int,4),
					new SqlParameter("@STATUS", SqlDbType.VarChar,200),
					new SqlParameter("@STATUSTIME", SqlDbType.DateTime),
					new SqlParameter("@IF_CURRENT", SqlDbType.Int,4),
					new SqlParameter("@MEMO", SqlDbType.VarChar,2000),
					new SqlParameter("@STATUSNO", SqlDbType.Decimal,9)};
			parameters[0].Value = model.STUNO;
			parameters[1].Value = model.ENTNO;
			parameters[2].Value = model.JOBTITLE;
			parameters[3].Value = model.SALARY;
			parameters[4].Value = model.STATUS;
			parameters[5].Value = model.STATUSTIME;
			parameters[6].Value = model.IF_CURRENT;
			parameters[7].Value = model.MEMO;
			parameters[8].Value = model.STATUSNO;

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
		public bool Delete(decimal STATUSNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from STUDENT_JOBSTATUS ");
			strSql.Append(" where STATUSNO=@STATUSNO");
			SqlParameter[] parameters = {
					new SqlParameter("@STATUSNO", SqlDbType.Decimal)
			};
			parameters[0].Value = STATUSNO;

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
		public bool DeleteList(string STATUSNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from STUDENT_JOBSTATUS ");
			strSql.Append(" where STATUSNO in ("+STATUSNOlist + ")  ");
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
		public Student.Model.STUDENT_JOBSTATUS GetModel(decimal STATUSNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 STATUSNO,STUNO,ENTNO,JOBTITLE,SALARY,STATUS,STATUSTIME,IF_CURRENT,MEMO from STUDENT_JOBSTATUS ");
			strSql.Append(" where STATUSNO=@STATUSNO");
			SqlParameter[] parameters = {
					new SqlParameter("@STATUSNO", SqlDbType.Decimal)
			};
			parameters[0].Value = STATUSNO;

			Student.Model.STUDENT_JOBSTATUS model=new Student.Model.STUDENT_JOBSTATUS();
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
		public Student.Model.STUDENT_JOBSTATUS DataRowToModel(DataRow row)
		{
			Student.Model.STUDENT_JOBSTATUS model=new Student.Model.STUDENT_JOBSTATUS();
			if (row != null)
			{
				if(row["STATUSNO"]!=null && row["STATUSNO"].ToString()!="")
				{
					model.STATUSNO=decimal.Parse(row["STATUSNO"].ToString());
				}
				if(row["STUNO"]!=null)
				{
					model.STUNO=row["STUNO"].ToString();
				}
				if(row["ENTNO"]!=null && row["ENTNO"].ToString()!="")
				{
					model.ENTNO=decimal.Parse(row["ENTNO"].ToString());
				}
				if(row["JOBTITLE"]!=null)
				{
					model.JOBTITLE=row["JOBTITLE"].ToString();
				}
				if(row["SALARY"]!=null && row["SALARY"].ToString()!="")
				{
					model.SALARY=int.Parse(row["SALARY"].ToString());
				}
				if(row["STATUS"]!=null)
				{
					model.STATUS=row["STATUS"].ToString();
				}
				if(row["STATUSTIME"]!=null && row["STATUSTIME"].ToString()!="")
				{
					model.STATUSTIME=DateTime.Parse(row["STATUSTIME"].ToString());
				}
				if(row["IF_CURRENT"]!=null && row["IF_CURRENT"].ToString()!="")
				{
					model.IF_CURRENT=int.Parse(row["IF_CURRENT"].ToString());
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
            strSql.Append("select STATUSNO,B.STUNO,B.NAME,C.ENTNAME,JOBTITLE, ");
            strSql.Append(" SALARY,A.STATUS ,STATUSTIME, ");
            strSql.Append(" case IF_CURRENT when 1 then '已就业' else '未就业' end As IF_CURRENT,A.MEMO ");
            strSql.Append(" FROM STUDENT_JOBSTATUS A,STUDENT_INFO B,ENTERPRISE_INFO C ");
            strSql.Append(" where A.STUNO = B.STUNO ");
            strSql.Append(" and A.ENTNO = C.ENTNO ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(strWhere);
			}
			return SqlHelper.Query(strSql.ToString());
		}

        /// <summary>
        /// 获得数据列表
        /// 只取每个学生最后一条记录
        /// </summary>
        public DataSet GetList(string strWhere,int flag)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select STATUSNO,B.STUNO,B.NAME,C.ENTNAME,JOBTITLE, ");
            strSql.Append(" SALARY,A.STATUS ,STATUSTIME, ");
            strSql.Append(" case IF_CURRENT when 1 then '已就业' else '未就业' end As IF_CURRENT,A.MEMO ");
            strSql.Append(" FROM STUDENT_JOBSTATUS A,STUDENT_INFO B,ENTERPRISE_INFO C ");
            strSql.Append(" where A.STUNO = B.STUNO ");
            strSql.Append(" and A.ENTNO = C.ENTNO ");
            strSql.Append(" and STATUSNO = (select MAX(statusno) from STUDENT_JOBSTATUS D ");
            strSql.Append("  where B.STUNO = D.STUNO) ");
            if (strWhere.Trim() != "")
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
			strSql.Append(" STATUSNO,STUNO,ENTNO,JOBTITLE,SALARY,STATUS,STATUSTIME,IF_CURRENT,MEMO ");
			strSql.Append(" FROM STUDENT_JOBSTATUS ");
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
			strSql.Append("select count(1) FROM STUDENT_JOBSTATUS ");
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
				strSql.Append("order by T.STATUSNO desc");
			}
			strSql.Append(")AS Row, T.*  from STUDENT_JOBSTATUS T ");
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
			parameters[0].Value = "STUDENT_JOBSTATUS";
			parameters[1].Value = "STATUSNO";
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

