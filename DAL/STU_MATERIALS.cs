/**  版本信息模板在安装目录下，可自行修改。
* STU_MATERIALS.cs
*
* 功 能： N/A
* 类 名： STU_MATERIALS
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/11/15 星期二 13:49:00   N/A    初版
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
	/// 数据访问类:STU_MATERIALS
	/// </summary>
	public partial class STU_MATERIALS
	{
		public STU_MATERIALS()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return SqlHelper.GetMaxID("TURNOVERNO", "STU_MATERIALS"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int TURNOVERNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from STU_MATERIALS");
			strSql.Append(" where TURNOVERNO=@TURNOVERNO");
			SqlParameter[] parameters = {
					new SqlParameter("@TURNOVERNO", SqlDbType.Int,4)
			};
			parameters[0].Value = TURNOVERNO;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Student.Model.STU_MATERIALS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into STU_MATERIALS(");
			strSql.Append("EXECNO,MATERIALNO,IF_TURNOVER,TURNOVERTM)");
			strSql.Append(" values (");
			strSql.Append("@EXECNO,@MATERIALNO,@IF_TURNOVER,@TURNOVERTM)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@EXECNO", SqlDbType.Decimal,9),
					new SqlParameter("@MATERIALNO", SqlDbType.Decimal,9),
					new SqlParameter("@IF_TURNOVER", SqlDbType.Int,4),
					new SqlParameter("@TURNOVERTM", SqlDbType.DateTime)};
			parameters[0].Value = model.EXECNO;
			parameters[1].Value = model.MATERIALNO;
			parameters[2].Value = model.IF_TURNOVER;
			parameters[3].Value = model.TURNOVERTM;

			object obj = SqlHelper.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(Student.Model.STU_MATERIALS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update STU_MATERIALS set ");
			strSql.Append("EXECNO=@EXECNO,");
			strSql.Append("MATERIALNO=@MATERIALNO,");
			strSql.Append("IF_TURNOVER=@IF_TURNOVER,");
			strSql.Append("TURNOVERTM=@TURNOVERTM");
			strSql.Append(" where TURNOVERNO=@TURNOVERNO");
			SqlParameter[] parameters = {
					new SqlParameter("@EXECNO", SqlDbType.Decimal,9),
					new SqlParameter("@MATERIALNO", SqlDbType.Decimal,9),
					new SqlParameter("@IF_TURNOVER", SqlDbType.Int,4),
					new SqlParameter("@TURNOVERTM", SqlDbType.DateTime),
					new SqlParameter("@TURNOVERNO", SqlDbType.Int,4)};
			parameters[0].Value = model.EXECNO;
			parameters[1].Value = model.MATERIALNO;
			parameters[2].Value = model.IF_TURNOVER;
			parameters[3].Value = model.TURNOVERTM;
			parameters[4].Value = model.TURNOVERNO;

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
        /// 根据编号更新是否提交材料
        /// </summary>
        public bool Update(decimal turnoverno,DateTime dt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update STU_MATERIALS set ");
            strSql.Append("IF_TURNOVER=1,");
            strSql.Append("TURNOVERTM=@TURNOVERTM");
            strSql.Append(" where TURNOVERNO=@TURNOVERNO");
            SqlParameter[] parameters = {
					new SqlParameter("@TURNOVERTM", SqlDbType.DateTime),
					new SqlParameter("@TURNOVERNO", SqlDbType.Int,4)};
            parameters[0].Value = dt;
            parameters[1].Value = turnoverno;

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
		public bool Delete(int TURNOVERNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from STU_MATERIALS ");
			strSql.Append(" where TURNOVERNO=@TURNOVERNO");
			SqlParameter[] parameters = {
					new SqlParameter("@TURNOVERNO", SqlDbType.Int,4)
			};
			parameters[0].Value = TURNOVERNO;

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
		public bool DeleteList(string TURNOVERNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from STU_MATERIALS ");
			strSql.Append(" where TURNOVERNO in ("+TURNOVERNOlist + ")  ");
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
		public Student.Model.STU_MATERIALS GetModel(int TURNOVERNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 TURNOVERNO,EXECNO,MATERIALNO,IF_TURNOVER,TURNOVERTM from STU_MATERIALS ");
			strSql.Append(" where TURNOVERNO=@TURNOVERNO");
			SqlParameter[] parameters = {
					new SqlParameter("@TURNOVERNO", SqlDbType.Int,4)
			};
			parameters[0].Value = TURNOVERNO;

			Student.Model.STU_MATERIALS model=new Student.Model.STU_MATERIALS();
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
		public Student.Model.STU_MATERIALS DataRowToModel(DataRow row)
		{
			Student.Model.STU_MATERIALS model=new Student.Model.STU_MATERIALS();
			if (row != null)
			{
				if(row["TURNOVERNO"]!=null && row["TURNOVERNO"].ToString()!="")
				{
					model.TURNOVERNO=int.Parse(row["TURNOVERNO"].ToString());
				}
				if(row["EXECNO"]!=null && row["EXECNO"].ToString()!="")
				{
					model.EXECNO=decimal.Parse(row["EXECNO"].ToString());
				}
				if(row["MATERIALNO"]!=null && row["MATERIALNO"].ToString()!="")
				{
					model.MATERIALNO=decimal.Parse(row["MATERIALNO"].ToString());
				}
				if(row["IF_TURNOVER"]!=null && row["IF_TURNOVER"].ToString()!="")
				{
					model.IF_TURNOVER=int.Parse(row["IF_TURNOVER"].ToString());
				}
				if(row["TURNOVERTM"]!=null && row["TURNOVERTM"].ToString()!="")
				{
					model.TURNOVERTM=DateTime.Parse(row["TURNOVERTM"].ToString());
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
            strSql.Append("select TURNOVERNO,D.NODENAME,B.MATERIALNAME, ");
            strSql.Append(" case IF_TURNOVER  ");
            strSql.Append(" when 0 then '×' ");
            strSql.Append(" when 1 then '√' end IF_TURNOVER, ");
            strSql.Append(" TURNOVERTM  ");
            strSql.Append(" FROM STU_MATERIALS A,MATERIAL_INFO B,STU_WORKFLOW C,WORKNODE D ");
            strSql.Append(" where A.EXECNO = C.EXECNO ");
            strSql.Append(" and A.MATERIALNO = B.MATERIALNO ");
            strSql.Append(" and C.NODENO = D.NODENO ");

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
			strSql.Append(" TURNOVERNO,EXECNO,MATERIALNO,IF_TURNOVER,TURNOVERTM ");
			strSql.Append(" FROM STU_MATERIALS ");
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
            strSql.Append("select count(1) FROM STU_MATERIALS,STU_WORKFLOW ");
            strSql.Append(" where STU_MATERIALS.EXECNO = STU_WORKFLOW.EXECNO ");
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
				strSql.Append("order by T.TURNOVERNO desc");
			}
			strSql.Append(")AS Row, T.*  from STU_MATERIALS T ");
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
			parameters[0].Value = "STU_MATERIALS";
			parameters[1].Value = "TURNOVERNO";
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

