/**  版本信息模板在安装目录下，可自行修改。
* NODEMATERIALS.cs
*
* 功 能： N/A
* 类 名： NODEMATERIALS
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:16   N/A    初版
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
	/// 数据访问类:NODEMATERIALS
	/// </summary>
	public partial class NODEMATERIALS
	{
		public NODEMATERIALS()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal NODEMATERIALSNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from NODEMATERIALS");
			strSql.Append(" where NODEMATERIALSNO=@NODEMATERIALSNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@NODEMATERIALSNO", SqlDbType.Decimal,9)			};
			parameters[0].Value = NODEMATERIALSNO;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Student.Model.NODEMATERIALS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into NODEMATERIALS(");
			strSql.Append("NODENO,MATERIALNO,TEACHERNO,BEGINTIME,ENDTIME,MEMO)");
			strSql.Append(" values (");
			strSql.Append("@NODENO,@MATERIALNO,@TEACHERNO,@BEGINTIME,@ENDTIME,@MEMO)");
			SqlParameter[] parameters = {
					new SqlParameter("@NODENO", SqlDbType.Int,4),
					new SqlParameter("@MATERIALNO", SqlDbType.Decimal,9),
					new SqlParameter("@TEACHERNO", SqlDbType.Int,4),
					new SqlParameter("@BEGINTIME", SqlDbType.DateTime),
					new SqlParameter("@ENDTIME", SqlDbType.DateTime),
					new SqlParameter("@MEMO", SqlDbType.VarChar,200)};
			parameters[0].Value = model.NODENO;
			parameters[1].Value = model.MATERIALNO;
			parameters[2].Value = model.TEACHERNO;
			parameters[3].Value = model.BEGINTIME;
			parameters[4].Value = model.ENDTIME;
			parameters[5].Value = model.MEMO;

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
		public bool Update(Student.Model.NODEMATERIALS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update NODEMATERIALS set ");
			strSql.Append("NODENO=@NODENO,");
			strSql.Append("MATERIALNO=@MATERIALNO,");
			strSql.Append("TEACHERNO=@TEACHERNO,");
			strSql.Append("BEGINTIME=@BEGINTIME,");
			strSql.Append("ENDTIME=@ENDTIME,");
			strSql.Append("MEMO=@MEMO");
			strSql.Append(" where NODEMATERIALSNO=@NODEMATERIALSNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@NODENO", SqlDbType.Int,4),
					new SqlParameter("@MATERIALNO", SqlDbType.Decimal,9),
					new SqlParameter("@TEACHERNO", SqlDbType.Int,4),
					new SqlParameter("@BEGINTIME", SqlDbType.DateTime),
					new SqlParameter("@ENDTIME", SqlDbType.DateTime),
					new SqlParameter("@MEMO", SqlDbType.VarChar,200),
					new SqlParameter("@NODEMATERIALSNO", SqlDbType.Decimal,9)};
			parameters[0].Value = model.NODENO;
			parameters[1].Value = model.MATERIALNO;
			parameters[2].Value = model.TEACHERNO;
			parameters[3].Value = model.BEGINTIME;
			parameters[4].Value = model.ENDTIME;
			parameters[5].Value = model.MEMO;
			parameters[6].Value = model.NODEMATERIALSNO;

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
		public bool Delete(decimal NODEMATERIALSNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NODEMATERIALS ");
			strSql.Append(" where NODEMATERIALSNO=@NODEMATERIALSNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@NODEMATERIALSNO", SqlDbType.Decimal,9)			};
			parameters[0].Value = NODEMATERIALSNO;

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
		public bool DeleteList(string NODEMATERIALSNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NODEMATERIALS ");
			strSql.Append(" where NODEMATERIALSNO in ("+NODEMATERIALSNOlist + ")  ");
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
		public Student.Model.NODEMATERIALS GetModel(decimal NODEMATERIALSNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 NODEMATERIALSNO,NODENO,MATERIALNO,TEACHERNO,BEGINTIME,ENDTIME,MEMO from NODEMATERIALS ");
			strSql.Append(" where NODEMATERIALSNO=@NODEMATERIALSNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@NODEMATERIALSNO", SqlDbType.Decimal,9)			};
			parameters[0].Value = NODEMATERIALSNO;

			Student.Model.NODEMATERIALS model=new Student.Model.NODEMATERIALS();
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
		public Student.Model.NODEMATERIALS DataRowToModel(DataRow row)
		{
			Student.Model.NODEMATERIALS model=new Student.Model.NODEMATERIALS();
			if (row != null)
			{
				if(row["NODEMATERIALSNO"]!=null && row["NODEMATERIALSNO"].ToString()!="")
				{
					model.NODEMATERIALSNO=decimal.Parse(row["NODEMATERIALSNO"].ToString());
				}
				if(row["NODENO"]!=null && row["NODENO"].ToString()!="")
				{
					model.NODENO=int.Parse(row["NODENO"].ToString());
				}
				if(row["MATERIALNO"]!=null && row["MATERIALNO"].ToString()!="")
				{
					model.MATERIALNO=decimal.Parse(row["MATERIALNO"].ToString());
				}
				if(row["TEACHERNO"]!=null && row["TEACHERNO"].ToString()!="")
				{
					model.TEACHERNO=int.Parse(row["TEACHERNO"].ToString());
				}
				if(row["BEGINTIME"]!=null && row["BEGINTIME"].ToString()!="")
				{
					model.BEGINTIME=DateTime.Parse(row["BEGINTIME"].ToString());
				}
				if(row["ENDTIME"]!=null && row["ENDTIME"].ToString()!="")
				{
					model.ENDTIME=DateTime.Parse(row["ENDTIME"].ToString());
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
            strSql.Append("select A.NODEMATERIALSNO,D.NODENAME,C.MATERIALNAME,B.NAME,A.BEGINTIME,A.ENDTIME,A.MEMO ");
            strSql.Append(" from NODEMATERIALS A,TEACHER_INFO B,MATERIAL_INFO C,WORKNODE D ");
            strSql.Append(" where A.MATERIALNO = C.MATERIALNO and ");
            strSql.Append("A.TEACHERNO = B.TEACHERNO and ");
            strSql.Append("A.NODENO = D.NODENO ");

			if(strWhere.Trim()!="")
			{
				strSql.Append(" and " + strWhere);
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
			strSql.Append(" NODEMATERIALSNO,NODENO,MATERIALNO,TEACHERNO,BEGINTIME,ENDTIME,MEMO ");
			strSql.Append(" FROM NODEMATERIALS ");
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
			strSql.Append("select count(1) FROM NODEMATERIALS ");
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
				strSql.Append("order by T.NODEMATERIALSNO desc");
			}
			strSql.Append(")AS Row, T.*  from NODEMATERIALS T ");
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
			parameters[0].Value = "NODEMATERIALS";
			parameters[1].Value = "NODEMATERIALSNO";
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

