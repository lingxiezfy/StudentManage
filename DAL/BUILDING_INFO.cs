/**  版本信息模板在安装目录下，可自行修改。
* BUILDING_INFO.cs
*
* 功 能： N/A
* 类 名： BUILDING_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:00   N/A    初版
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
	/// 数据访问类:BUILDING_INFO
	/// </summary>
	public partial class BUILDING_INFO
	{
		public BUILDING_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal BUILDINGID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BUILDING_INFO");
			strSql.Append(" where BUILDINGID=@BUILDINGID");
			SqlParameter[] parameters = {
					new SqlParameter("@BUILDINGID", SqlDbType.Decimal)
			};
			parameters[0].Value = BUILDINGID;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(Student.Model.BUILDING_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BUILDING_INFO(");
			strSql.Append("BUILDINGNAME,FLOORS,ADMIN)");
			strSql.Append(" values (");
			strSql.Append("@BUILDINGNAME,@FLOORS,@ADMIN)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@BUILDINGNAME", SqlDbType.VarChar,40),
					new SqlParameter("@FLOORS", SqlDbType.Int,4),
					new SqlParameter("@ADMIN", SqlDbType.VarChar,20)};
			parameters[0].Value = model.BUILDINGNAME;
			parameters[1].Value = model.FLOORS;
			parameters[2].Value = model.ADMIN;

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
		public bool Update(Student.Model.BUILDING_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BUILDING_INFO set ");
			strSql.Append("BUILDINGNAME=@BUILDINGNAME,");
			strSql.Append("FLOORS=@FLOORS,");
			strSql.Append("ADMIN=@ADMIN");
			strSql.Append(" where BUILDINGID=@BUILDINGID");
			SqlParameter[] parameters = {
					new SqlParameter("@BUILDINGNAME", SqlDbType.VarChar,40),
					new SqlParameter("@FLOORS", SqlDbType.Int,4),
					new SqlParameter("@ADMIN", SqlDbType.VarChar,20),
					new SqlParameter("@BUILDINGID", SqlDbType.Decimal,9)};
			parameters[0].Value = model.BUILDINGNAME;
			parameters[1].Value = model.FLOORS;
			parameters[2].Value = model.ADMIN;
			parameters[3].Value = model.BUILDINGID;

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
		public bool Delete(decimal BUILDINGID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BUILDING_INFO ");
			strSql.Append(" where BUILDINGID=@BUILDINGID");
			SqlParameter[] parameters = {
					new SqlParameter("@BUILDINGID", SqlDbType.Decimal)
			};
			parameters[0].Value = BUILDINGID;

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
		public bool DeleteList(string BUILDINGIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BUILDING_INFO ");
			strSql.Append(" where BUILDINGID in ("+BUILDINGIDlist + ")  ");
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
		public Student.Model.BUILDING_INFO GetModel(decimal BUILDINGID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 BUILDINGID,BUILDINGNAME,FLOORS,ADMIN from BUILDING_INFO ");
			strSql.Append(" where BUILDINGID=@BUILDINGID");
			SqlParameter[] parameters = {
					new SqlParameter("@BUILDINGID", SqlDbType.Decimal)
			};
			parameters[0].Value = BUILDINGID;

			Student.Model.BUILDING_INFO model=new Student.Model.BUILDING_INFO();
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
        public Student.Model.BUILDING_INFO GetModel(string BUILDINGNAME)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 BUILDINGID,BUILDINGNAME,FLOORS,ADMIN from BUILDING_INFO ");
            strSql.Append(" where BUILDINGNAME=@BUILDINGNAME");
            SqlParameter[] parameters = {
					new SqlParameter("@BUILDINGNAME", SqlDbType.VarChar,40)
			};
            parameters[0].Value = BUILDINGNAME;

            Student.Model.BUILDING_INFO model = new Student.Model.BUILDING_INFO();
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
		public Student.Model.BUILDING_INFO DataRowToModel(DataRow row)
		{
			Student.Model.BUILDING_INFO model=new Student.Model.BUILDING_INFO();
			if (row != null)
			{
				if(row["BUILDINGID"]!=null && row["BUILDINGID"].ToString()!="")
				{
					model.BUILDINGID=decimal.Parse(row["BUILDINGID"].ToString());
				}
				if(row["BUILDINGNAME"]!=null)
				{
					model.BUILDINGNAME=row["BUILDINGNAME"].ToString();
				}
				if(row["FLOORS"]!=null && row["FLOORS"].ToString()!="")
				{
					model.FLOORS=int.Parse(row["FLOORS"].ToString());
				}
				if(row["ADMIN"]!=null)
				{
					model.ADMIN=row["ADMIN"].ToString();
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
			strSql.Append("select BUILDINGID,BUILDINGNAME,FLOORS,ADMIN ");
			strSql.Append(" FROM BUILDING_INFO ");
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
			strSql.Append(" BUILDINGID,BUILDINGNAME,FLOORS,ADMIN ");
			strSql.Append(" FROM BUILDING_INFO ");
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
			strSql.Append("select count(1) FROM BUILDING_INFO ");
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
				strSql.Append("order by T.BUILDINGID desc");
			}
			strSql.Append(")AS Row, T.*  from BUILDING_INFO T ");
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
			parameters[0].Value = "BUILDING_INFO";
			parameters[1].Value = "BUILDINGID";
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

