/**  版本信息模板在安装目录下，可自行修改。
* STU_WORKFLOW.cs
*
* 功 能： N/A
* 类 名： STU_WORKFLOW
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/11/15 星期二 13:49:01   N/A    初版
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
	/// 数据访问类:STU_WORKFLOW
	/// </summary>
	public partial class STU_WORKFLOW
	{
		public STU_WORKFLOW()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal EXECNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from STU_WORKFLOW");
			strSql.Append(" where EXECNO=@EXECNO");
			SqlParameter[] parameters = {
					new SqlParameter("@EXECNO", SqlDbType.Decimal)
			};
			parameters[0].Value = EXECNO;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(Student.Model.STU_WORKFLOW model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into STU_WORKFLOW(");
			strSql.Append("GUIDANCENO,NODENO,GRADE)");
			strSql.Append(" values (");
			strSql.Append("@GUIDANCENO,@NODENO,@GRADE)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@GUIDANCENO", SqlDbType.Decimal,9),
					new SqlParameter("@NODENO", SqlDbType.Int,4),
					new SqlParameter("@GRADE", SqlDbType.Float,8)};
			parameters[0].Value = model.GUIDANCENO;
			parameters[1].Value = model.NODENO;
			parameters[2].Value = model.GRADE;

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
		public bool Update(Student.Model.STU_WORKFLOW model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update STU_WORKFLOW set ");
			strSql.Append("GUIDANCENO=@GUIDANCENO,");
			strSql.Append("NODENO=@NODENO,");
			strSql.Append("GRADE=@GRADE");
			strSql.Append(" where EXECNO=@EXECNO");
			SqlParameter[] parameters = {
					new SqlParameter("@GUIDANCENO", SqlDbType.Decimal,9),
					new SqlParameter("@NODENO", SqlDbType.Int,4),
					new SqlParameter("@GRADE", SqlDbType.Float,8),
					new SqlParameter("@EXECNO", SqlDbType.Decimal,9)};
			parameters[0].Value = model.GUIDANCENO;
			parameters[1].Value = model.NODENO;
			parameters[2].Value = model.GRADE;
			parameters[3].Value = model.EXECNO;

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
        /// 根据execno更新成绩
        /// </summary>
        public bool Update(float grade,decimal execno)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update STU_WORKFLOW set ");
            strSql.Append("GRADE=@GRADE ");
            strSql.Append(" where EXECNO=@EXECNO");
            SqlParameter[] parameters = {
					new SqlParameter("@GRADE", SqlDbType.Float,8),
					new SqlParameter("@EXECNO", SqlDbType.Decimal,9)};
            parameters[0].Value = grade;
            parameters[1].Value = execno;

            int rows = SqlHelper.ExecuteSql(strSql.ToString(), parameters);
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
        /// 根据execno更新成绩与实习单位
        /// </summary>
        public bool Update(float grade, decimal execno,decimal entno)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update STU_WORKFLOW set ");
            strSql.Append("GRADE=@GRADE, ");
            strSql.Append("ENTNO=@ENTNO ");
            strSql.Append(" where EXECNO=@EXECNO");
            SqlParameter[] parameters = {
					new SqlParameter("@GRADE", SqlDbType.Float,8),
                    new SqlParameter("@ENTNO", SqlDbType.Decimal,9),
					new SqlParameter("@EXECNO", SqlDbType.Decimal,9)};
            parameters[0].Value = grade;
            parameters[1].Value = entno;
            parameters[2].Value = execno;

            int rows = SqlHelper.ExecuteSql(strSql.ToString(), parameters);
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
		public bool Delete(decimal EXECNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from STU_WORKFLOW ");
			strSql.Append(" where EXECNO=@EXECNO");
			SqlParameter[] parameters = {
					new SqlParameter("@EXECNO", SqlDbType.Decimal)
			};
			parameters[0].Value = EXECNO;

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
		public bool DeleteList(string EXECNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from STU_WORKFLOW ");
			strSql.Append(" where EXECNO in ("+EXECNOlist + ")  ");
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
		public Student.Model.STU_WORKFLOW GetModel(decimal EXECNO)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select B.EXECNO,TERMNAME,A.STUNO,C.NAME as STUNAME,D.NAME as TEANAME, ");
            strSql.Append(" F.WORKFLOWNAME,G.NODENAME,B.GRADE ");
            strSql.Append(" from TEA_STU A,STU_WORKFLOW B,STUDENT_INFO C,TEACHER_INFO D, ");
            strSql.Append(" TERM_INFO E,WORKFLOW F,WORKNODE G,CLASS_INFO H ");
            strSql.Append(" where A.GUIDANCENO = B.GUIDANCENO ");
            strSql.Append(" and A.STUNO = C.STUNO ");
            strSql.Append(" and A.TEACHERNO = D.TEACHERNO ");
            strSql.Append(" and A.TERMNO = E.TERMNO ");
            strSql.Append(" and A.WORKFLOWNO = F.WORKFLOWNO ");
            strSql.Append(" and B.NODENO = G.NODENO ");
            strSql.Append("and C.CLASSNO = H.CLASSNO  ");
			strSql.Append(" and B.EXECNO=@EXECNO");
			SqlParameter[] parameters = {
					new SqlParameter("@EXECNO", SqlDbType.Decimal)
			};
			parameters[0].Value = EXECNO;

			Student.Model.STU_WORKFLOW model=new Student.Model.STU_WORKFLOW();
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
		public Student.Model.STU_WORKFLOW DataRowToModel(DataRow row)
		{
			Student.Model.STU_WORKFLOW model=new Student.Model.STU_WORKFLOW();
			if (row != null)
			{
				if(row["EXECNO"]!=null && row["EXECNO"].ToString()!="")
				{
					model.EXECNO=decimal.Parse(row["EXECNO"].ToString());
				}
				if(row["GUIDANCENO"]!=null && row["GUIDANCENO"].ToString()!="")
				{
					model.GUIDANCENO=decimal.Parse(row["GUIDANCENO"].ToString());
				}
				if(row["NODENO"]!=null && row["NODENO"].ToString()!="")
				{
					model.NODENO=int.Parse(row["NODENO"].ToString());
				}
				if(row["GRADE"]!=null && row["GRADE"].ToString()!="")
				{
					model.GRADE=decimal.Parse(row["GRADE"].ToString());
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
            strSql.Append("select B.EXECNO,TERMNAME,A.STUNO,C.NAME as STUNAME,D.NAME as TEANAME, ");
            strSql.Append(" F.WORKFLOWNAME,G.NODENAME,I.ENTNAME,B.GRADE ");
            strSql.Append(" from TEA_STU A,STU_WORKFLOW B,STUDENT_INFO C,TEACHER_INFO D, ");
            strSql.Append(" TERM_INFO E,WORKFLOW F,WORKNODE G,CLASS_INFO H,ENTERPRISE_INFO I ");
            strSql.Append(" where A.GUIDANCENO = B.GUIDANCENO ");
            strSql.Append(" and A.STUNO = C.STUNO ");
            strSql.Append(" and A.TEACHERNO = D.TEACHERNO ");
            strSql.Append(" and A.TERMNO = E.TERMNO ");
            strSql.Append(" and A.WORKFLOWNO = F.WORKFLOWNO ");
            strSql.Append(" and B.NODENO = G.NODENO ");
            strSql.Append("and C.CLASSNO = H.CLASSNO  ");
            strSql.Append("and I.ENTNO = B.ENTNO  ");
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
			strSql.Append(" EXECNO,GUIDANCENO,NODENO,GRADE ");
			strSql.Append(" FROM STU_WORKFLOW ");
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
            strSql.Append("select COUNT(1) from stu_workflow,TEA_STU ");
            strSql.Append("where stu_workflow.GUIDANCENO = tea_stu.GUIDANCENO ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(strWhere);
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
				strSql.Append("order by T.EXECNO desc");
			}
			strSql.Append(")AS Row, T.*  from STU_WORKFLOW T ");
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
			parameters[0].Value = "STU_WORKFLOW";
			parameters[1].Value = "EXECNO";
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

