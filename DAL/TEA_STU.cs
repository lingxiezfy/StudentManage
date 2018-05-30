/**  版本信息模板在安装目录下，可自行修改。
* TEA_STU.cs
*
* 功 能： N/A
* 类 名： TEA_STU
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:35   N/A    初版
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
	/// 数据访问类:TEA_STU
	/// </summary>
	public partial class TEA_STU
	{
		public TEA_STU()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal GUIDANCENO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TEA_STU");
			strSql.Append(" where GUIDANCENO=@GUIDANCENO");
			SqlParameter[] parameters = {
					new SqlParameter("@GUIDANCENO", SqlDbType.Decimal)
			};
			parameters[0].Value = GUIDANCENO;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(Student.Model.TEA_STU model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TEA_STU(");
			strSql.Append("STUNO,TEACHERNO,WORKFLOWNO,TERMNO)");
			strSql.Append(" values (");
			strSql.Append("@STUNO,@TEACHERNO,@WORKFLOWNO,@TERMNO)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@STUNO", SqlDbType.VarChar,10),
					new SqlParameter("@TEACHERNO", SqlDbType.Int,4),
					new SqlParameter("@WORKFLOWNO", SqlDbType.Int,4),
					new SqlParameter("@TERMNO", SqlDbType.Int,4)};
			parameters[0].Value = model.STUNO;
			parameters[1].Value = model.TEACHERNO;
			parameters[2].Value = model.WORKFLOWNO;
			parameters[3].Value = model.TERMNO;

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
		public bool Update(Student.Model.TEA_STU model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TEA_STU set ");
			strSql.Append("STUNO=@STUNO,");
			strSql.Append("TEACHERNO=@TEACHERNO,");
			strSql.Append("WORKFLOWNO=@WORKFLOWNO,");
			strSql.Append("TERMNO=@TERMNO");
			strSql.Append(" where GUIDANCENO=@GUIDANCENO");
			SqlParameter[] parameters = {
					new SqlParameter("@STUNO", SqlDbType.VarChar,10),
					new SqlParameter("@TEACHERNO", SqlDbType.Int,4),
					new SqlParameter("@WORKFLOWNO", SqlDbType.Int,4),
					new SqlParameter("@TERMNO", SqlDbType.Int,4),
					new SqlParameter("@GUIDANCENO", SqlDbType.Decimal,9)};
			parameters[0].Value = model.STUNO;
			parameters[1].Value = model.TEACHERNO;
			parameters[2].Value = model.WORKFLOWNO;
			parameters[3].Value = model.TERMNO;
			parameters[4].Value = model.GUIDANCENO;

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
		public bool Delete(decimal GUIDANCENO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TEA_STU ");
			strSql.Append(" where GUIDANCENO=@GUIDANCENO");
			SqlParameter[] parameters = {
					new SqlParameter("@GUIDANCENO", SqlDbType.Decimal)
			};
			parameters[0].Value = GUIDANCENO;

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
		public bool DeleteList(string GUIDANCENOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TEA_STU ");
			strSql.Append(" where GUIDANCENO in ("+GUIDANCENOlist + ")  ");
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
		public Student.Model.TEA_STU GetModel(decimal GUIDANCENO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 GUIDANCENO,STUNO,TEACHERNO,WORKFLOWNO,TERMNO from TEA_STU ");
			strSql.Append(" where GUIDANCENO=@GUIDANCENO");
			SqlParameter[] parameters = {
					new SqlParameter("@GUIDANCENO", SqlDbType.Decimal)
			};
			parameters[0].Value = GUIDANCENO;

			Student.Model.TEA_STU model=new Student.Model.TEA_STU();
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
		public Student.Model.TEA_STU DataRowToModel(DataRow row)
		{
			Student.Model.TEA_STU model=new Student.Model.TEA_STU();
			if (row != null)
			{
				if(row["GUIDANCENO"]!=null && row["GUIDANCENO"].ToString()!="")
				{
					model.GUIDANCENO=decimal.Parse(row["GUIDANCENO"].ToString());
				}
				if(row["STUNO"]!=null)
				{
					model.STUNO=row["STUNO"].ToString();
				}
				if(row["TEACHERNO"]!=null && row["TEACHERNO"].ToString()!="")
				{
					model.TEACHERNO=int.Parse(row["TEACHERNO"].ToString());
				}
				if(row["WORKFLOWNO"]!=null && row["WORKFLOWNO"].ToString()!="")
				{
					model.WORKFLOWNO=int.Parse(row["WORKFLOWNO"].ToString());
				}
				if(row["TERMNO"]!=null && row["TERMNO"].ToString()!="")
				{
					model.TERMNO=int.Parse(row["TERMNO"].ToString());
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
            strSql.Append("select GUIDANCENO,D.TERMNAME,B.STUNO, B.NAME as studentname,C.NAME as teachername,E.WORKFLOWNAME ");
            strSql.Append(" from TEA_STU A,STUDENT_INFO B,TEACHER_INFO C,TERM_INFO D,WORKFLOW E ");
            strSql.Append(" where A.STUNO = B.STUNO  ");
            strSql.Append(" and A.TEACHERNO = C.TEACHERNO ");
            strSql.Append(" and A.TERMNO = D.TERMNO ");
            strSql.Append(" and A.WORKFLOWNO = E.WORKFLOWNO ");
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
			strSql.Append(" GUIDANCENO,STUNO,TEACHERNO,WORKFLOWNO,TERMNO ");
			strSql.Append(" FROM TEA_STU ");
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
			strSql.Append("select count(1) FROM TEA_STU ");
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
				strSql.Append("order by T.GUIDANCENO desc");
			}
			strSql.Append(")AS Row, T.*  from TEA_STU T ");
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
			parameters[0].Value = "TEA_STU";
			parameters[1].Value = "GUIDANCENO";
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

