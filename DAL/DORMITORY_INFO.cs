/**  版本信息模板在安装目录下，可自行修改。
* DORMITORY_INFO.cs
*
* 功 能： N/A
* 类 名： DORMITORY_INFO
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
	/// 数据访问类:DORMITORY_INFO
	/// </summary>
	public partial class DORMITORY_INFO
	{
		public DORMITORY_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal DORMITORY_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DORMITORY_INFO");
			strSql.Append(" where DORMITORY_ID=@DORMITORY_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@DORMITORY_ID", SqlDbType.Decimal)
			};
			parameters[0].Value = DORMITORY_ID;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(Student.Model.DORMITORY_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DORMITORY_INFO(");
			strSql.Append("BUILDINGID,DORMITORY_PLATE)");
			strSql.Append(" values (");
			strSql.Append("@BUILDINGID,@DORMITORY_PLATE)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@BUILDINGID", SqlDbType.Decimal,9),
					new SqlParameter("@DORMITORY_PLATE", SqlDbType.VarChar,50)};
			parameters[0].Value = model.BUILDINGID;
			parameters[1].Value = model.DORMITORY_PLATE;

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
		public bool Update(Student.Model.DORMITORY_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DORMITORY_INFO set ");
			strSql.Append("BUILDINGID=@BUILDINGID,");
			strSql.Append("DORMITORY_PLATE=@DORMITORY_PLATE");
			strSql.Append(" where DORMITORY_ID=@DORMITORY_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@BUILDINGID", SqlDbType.Decimal,9),
					new SqlParameter("@DORMITORY_PLATE", SqlDbType.VarChar,50),
					new SqlParameter("@DORMITORY_ID", SqlDbType.Decimal,9)};
			parameters[0].Value = model.BUILDINGID;
			parameters[1].Value = model.DORMITORY_PLATE;
			parameters[2].Value = model.DORMITORY_ID;

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
		public bool Delete(decimal DORMITORY_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DORMITORY_INFO ");
			strSql.Append(" where DORMITORY_ID=@DORMITORY_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@DORMITORY_ID", SqlDbType.Decimal)
			};
			parameters[0].Value = DORMITORY_ID;

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
		public bool DeleteList(string DORMITORY_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DORMITORY_INFO ");
			strSql.Append(" where DORMITORY_ID in ("+DORMITORY_IDlist + ")  ");
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
        /// 根据宿舍编号查找宿舍
		/// </summary>
		public Student.Model.DORMITORY_INFO GetModel(decimal DORMITORY_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DORMITORY_ID,BUILDINGID,DORMITORY_PLATE from DORMITORY_INFO ");
			strSql.Append(" where DORMITORY_ID=@DORMITORY_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@DORMITORY_ID", SqlDbType.Decimal)
			};
			parameters[0].Value = DORMITORY_ID;

			Student.Model.DORMITORY_INFO model=new Student.Model.DORMITORY_INFO();
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
        /// 根据门牌号查找宿舍
        /// </summary>
        public Student.Model.DORMITORY_INFO GetModel(string DORMITORY_PLATE)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 DORMITORY_ID,BUILDINGID,DORMITORY_PLATE from DORMITORY_INFO ");
            strSql.Append(" where DORMITORY_PLATE=@DORMITORY_PLATE");
            SqlParameter[] parameters = {
					new SqlParameter("@DORMITORY_PLATE", SqlDbType.VarChar,50)
			};
            parameters[0].Value = DORMITORY_PLATE;

            Student.Model.DORMITORY_INFO model = new Student.Model.DORMITORY_INFO();
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
		public Student.Model.DORMITORY_INFO DataRowToModel(DataRow row)
		{
			Student.Model.DORMITORY_INFO model=new Student.Model.DORMITORY_INFO();
			if (row != null)
			{
				if(row["DORMITORY_ID"]!=null && row["DORMITORY_ID"].ToString()!="")
				{
					model.DORMITORY_ID=decimal.Parse(row["DORMITORY_ID"].ToString());
				}
				if(row["BUILDINGID"]!=null && row["BUILDINGID"].ToString()!="")
				{
					model.BUILDINGID=decimal.Parse(row["BUILDINGID"].ToString());
				}
				if(row["DORMITORY_PLATE"]!=null)
				{
					model.DORMITORY_PLATE=row["DORMITORY_PLATE"].ToString();
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
            strSql.Append("select B.DORMITORY_ID,B.DORMITORY_PLATE,A.BUILDINGNAME ");
            strSql.Append(" from BUILDING_INFO A,DORMITORY_INFO B ");
            strSql.Append(" where A.BUILDINGID = B.BUILDINGID ");
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
			strSql.Append(" DORMITORY_ID,BUILDINGID,DORMITORY_PLATE ");
			strSql.Append(" FROM DORMITORY_INFO ");
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
			strSql.Append("select count(1) FROM DORMITORY_INFO ");
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
				strSql.Append("order by T.DORMITORY_ID desc");
			}
			strSql.Append(")AS Row, T.*  from DORMITORY_INFO T ");
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
			parameters[0].Value = "DORMITORY_INFO";
			parameters[1].Value = "DORMITORY_ID";
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

