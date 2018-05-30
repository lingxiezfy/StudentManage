/**  版本信息模板在安装目录下，可自行修改。
* COURSE_TYPE.cs
*
* 功 能： N/A
* 类 名： COURSE_TYPE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:13   N/A    初版
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
	/// 数据访问类:COURSE_TYPE
	/// </summary>
	public partial class COURSE_TYPE
	{
		public COURSE_TYPE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
        /// 根据编号查找
		/// </summary>
		public bool Exists(decimal COURSETYPENO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from COURSE_TYPE");
			strSql.Append(" where COURSETYPENO=@COURSETYPENO");
			SqlParameter[] parameters = {
					new SqlParameter("@COURSETYPENO", SqlDbType.Decimal)
			};
			parameters[0].Value = COURSETYPENO;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 是否存在该记录
        /// 根据名称查找
        /// </summary>
        public bool Exists(string COURSETYPENAME)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from COURSE_TYPE");
            strSql.Append(" where COURSETYPENAME=@COURSETYPENAME");
            SqlParameter[] parameters = {
					new SqlParameter("@COURSETYPENAME", SqlDbType.VarChar,100)
			};
            parameters[0].Value = COURSETYPENAME;

            return SqlHelper.Exists(strSql.ToString(), parameters);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(Student.Model.COURSE_TYPE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into COURSE_TYPE(");
			strSql.Append("COURSETYPENAME,MEMO)");
			strSql.Append(" values (");
			strSql.Append("@COURSETYPENAME,@MEMO)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@COURSETYPENAME", SqlDbType.VarChar,100),
					new SqlParameter("@MEMO", SqlDbType.VarChar,400)};
			parameters[0].Value = model.COURSETYPENAME;
			parameters[1].Value = model.MEMO;

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
		public bool Update(Student.Model.COURSE_TYPE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update COURSE_TYPE set ");
			strSql.Append("COURSETYPENAME=@COURSETYPENAME,");
			strSql.Append("MEMO=@MEMO");
			strSql.Append(" where COURSETYPENO=@COURSETYPENO");
			SqlParameter[] parameters = {
					new SqlParameter("@COURSETYPENAME", SqlDbType.VarChar,100),
					new SqlParameter("@MEMO", SqlDbType.VarChar,400),
					new SqlParameter("@COURSETYPENO", SqlDbType.Decimal,9)};
			parameters[0].Value = model.COURSETYPENAME;
			parameters[1].Value = model.MEMO;
			parameters[2].Value = model.COURSETYPENO;

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
		public bool Delete(decimal COURSETYPENO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from COURSE_TYPE ");
			strSql.Append(" where COURSETYPENO=@COURSETYPENO");
			SqlParameter[] parameters = {
					new SqlParameter("@COURSETYPENO", SqlDbType.Decimal)
			};
			parameters[0].Value = COURSETYPENO;

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
		public bool DeleteList(string COURSETYPENOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from COURSE_TYPE ");
			strSql.Append(" where COURSETYPENO in ("+COURSETYPENOlist + ")  ");
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
		public Student.Model.COURSE_TYPE GetModel(decimal COURSETYPENO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 COURSETYPENO,COURSETYPENAME,MEMO from COURSE_TYPE ");
			strSql.Append(" where COURSETYPENO=@COURSETYPENO");
			SqlParameter[] parameters = {
					new SqlParameter("@COURSETYPENO", SqlDbType.Decimal)
			};
			parameters[0].Value = COURSETYPENO;

			Student.Model.COURSE_TYPE model=new Student.Model.COURSE_TYPE();
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
        public Student.Model.COURSE_TYPE GetModel(string COURSETYPENAME)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 COURSETYPENO,COURSETYPENAME,MEMO from COURSE_TYPE ");
            strSql.Append(" where COURSETYPENAME=@COURSETYPENAME");
            SqlParameter[] parameters = {
					new SqlParameter("@COURSETYPENAME", SqlDbType.VarChar,100)
			};
            parameters[0].Value = COURSETYPENAME;

            Student.Model.COURSE_TYPE model = new Student.Model.COURSE_TYPE();
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
		public Student.Model.COURSE_TYPE DataRowToModel(DataRow row)
		{
			Student.Model.COURSE_TYPE model=new Student.Model.COURSE_TYPE();
			if (row != null)
			{
				if(row["COURSETYPENO"]!=null && row["COURSETYPENO"].ToString()!="")
				{
					model.COURSETYPENO=decimal.Parse(row["COURSETYPENO"].ToString());
				}
				if(row["COURSETYPENAME"]!=null)
				{
					model.COURSETYPENAME=row["COURSETYPENAME"].ToString();
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
			strSql.Append("select COURSETYPENO,COURSETYPENAME,MEMO ");
			strSql.Append(" FROM COURSE_TYPE ");
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
			strSql.Append(" COURSETYPENO,COURSETYPENAME,MEMO ");
			strSql.Append(" FROM COURSE_TYPE ");
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
			strSql.Append("select count(1) FROM COURSE_TYPE ");
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
				strSql.Append("order by T.COURSETYPENO desc");
			}
			strSql.Append(")AS Row, T.*  from COURSE_TYPE T ");
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
			parameters[0].Value = "COURSE_TYPE";
			parameters[1].Value = "COURSETYPENO";
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

