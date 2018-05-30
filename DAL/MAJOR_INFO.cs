/**  版本信息模板在安装目录下，可自行修改。
* MAJOR_INFO.cs
*
* 功 能： N/A
* 类 名： MAJOR_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:14   N/A    初版
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
	/// 数据访问类:MAJOR_INFO
	/// </summary>
	public partial class MAJOR_INFO
	{
		public MAJOR_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return SqlHelper.GetMaxID("MAJORNO", "MAJOR_INFO"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MAJORNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MAJOR_INFO");
			strSql.Append(" where MAJORNO=@MAJORNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@MAJORNO", SqlDbType.Int,4)			};
			parameters[0].Value = MAJORNO;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Student.Model.MAJOR_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MAJOR_INFO(");
			strSql.Append("DEPARTMENTNO,MAJORNAME)");
			strSql.Append(" values (");
			strSql.Append("@DEPARTMENTNO,@MAJORNAME)");
			SqlParameter[] parameters = {
					new SqlParameter("@DEPARTMENTNO", SqlDbType.Int,4),
					new SqlParameter("@MAJORNAME", SqlDbType.VarChar,30)};
			parameters[0].Value = model.DEPARTMENTNO;
			parameters[1].Value = model.MAJORNAME;

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
		public bool Update(Student.Model.MAJOR_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MAJOR_INFO set ");
			strSql.Append("DEPARTMENTNO=@DEPARTMENTNO,");
			strSql.Append("MAJORNAME=@MAJORNAME");
			strSql.Append(" where MAJORNO=@MAJORNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@DEPARTMENTNO", SqlDbType.Int,4),
					new SqlParameter("@MAJORNAME", SqlDbType.VarChar,30),
					new SqlParameter("@MAJORNO", SqlDbType.Int,4)};
			parameters[0].Value = model.DEPARTMENTNO;
			parameters[1].Value = model.MAJORNAME;
			parameters[2].Value = model.MAJORNO;

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
		public bool Delete(int MAJORNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MAJOR_INFO ");
			strSql.Append(" where MAJORNO=@MAJORNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@MAJORNO", SqlDbType.Int,4)			};
			parameters[0].Value = MAJORNO;

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
		public bool DeleteList(string MAJORNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MAJOR_INFO ");
			strSql.Append(" where MAJORNO in ("+MAJORNOlist + ")  ");
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
		public Student.Model.MAJOR_INFO GetModel(int MAJORNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MAJORNO,DEPARTMENTNO,MAJORNAME from MAJOR_INFO ");
			strSql.Append(" where MAJORNO=@MAJORNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@MAJORNO", SqlDbType.Int,4)			};
			parameters[0].Value = MAJORNO;

			Student.Model.MAJOR_INFO model=new Student.Model.MAJOR_INFO();
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
        public Student.Model.MAJOR_INFO GetModel(string MAJORNAME)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 MAJORNO,DEPARTMENTNO,MAJORNAME from MAJOR_INFO ");
            strSql.Append(" where MAJORNAME=@MAJORNAME ");
            SqlParameter[] parameters = {
					new SqlParameter("@MAJORNAME", SqlDbType.VarChar,30)			};
            parameters[0].Value = MAJORNAME;

            Student.Model.MAJOR_INFO model = new Student.Model.MAJOR_INFO();
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
		public Student.Model.MAJOR_INFO DataRowToModel(DataRow row)
		{
			Student.Model.MAJOR_INFO model=new Student.Model.MAJOR_INFO();
			if (row != null)
			{
				if(row["MAJORNO"]!=null && row["MAJORNO"].ToString()!="")
				{
					model.MAJORNO=int.Parse(row["MAJORNO"].ToString());
				}
				if(row["DEPARTMENTNO"]!=null && row["DEPARTMENTNO"].ToString()!="")
				{
					model.DEPARTMENTNO=int.Parse(row["DEPARTMENTNO"].ToString());
				}
				if(row["MAJORNAME"]!=null)
				{
					model.MAJORNAME=row["MAJORNAME"].ToString();
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
			strSql.Append("select MAJORNO,DEPARTMENTNAME,MAJORNAME ");
			strSql.Append(" FROM MAJOR_INFO,DEPARTMENT_INFO ");
            strSql.Append(" where MAJOR_INFO.DEPARTMENTNO = DEPARTMENT_INFO.DEPARTMENTNO ");
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
			strSql.Append(" MAJORNO,DEPARTMENTNO,MAJORNAME ");
            strSql.Append(" FROM MAJOR_INFO,DEPARTMENT_INFO ");
			if(strWhere.Trim()!="")
			{
                strSql.Append(" where MAJOR_INFO.DEPARTMENTNO = DEPARTMENT_INFO.DEPARTMENTNO " + strWhere);
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
			strSql.Append("select count(1) FROM MAJOR_INFO ");
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
				strSql.Append("order by T.MAJORNO desc");
			}
			strSql.Append(")AS Row, T.*  from MAJOR_INFO T ");
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
			parameters[0].Value = "MAJOR_INFO";
			parameters[1].Value = "MAJORNO";
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

