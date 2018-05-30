/**  版本信息模板在安装目录下，可自行修改。
* COMPETITION_GROUP.cs
*
* 功 能： N/A
* 类 名： COMPETITION_GROUP
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:01   N/A    初版
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
	/// 数据访问类:COMPETITION_GROUP
	/// </summary>
	public partial class COMPETITION_GROUP
	{
		public COMPETITION_GROUP()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal GROUPID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from COMPETITION_GROUP");
			strSql.Append(" where GROUPID=@GROUPID ");
			SqlParameter[] parameters = {
					new SqlParameter("@GROUPID", SqlDbType.Decimal,9)			};
			parameters[0].Value = GROUPID;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Student.Model.COMPETITION_GROUP model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into COMPETITION_GROUP(");
			strSql.Append("GROUPID,COMPETITIONID,GROUPNAME,CHARGER,BUILDTM,TEACHERNO1,TEACHERNO2,REWARD,STATUS)");
			strSql.Append(" values (");
			strSql.Append("@GROUPID,@COMPETITIONID,@GROUPNAME,@CHARGER,@BUILDTM,@TEACHERNO1,@TEACHERNO2,@REWARD,@STATUS)");
			SqlParameter[] parameters = {
					new SqlParameter("@GROUPID", SqlDbType.Decimal,9),
					new SqlParameter("@COMPETITIONID", SqlDbType.Decimal,9),
					new SqlParameter("@GROUPNAME", SqlDbType.VarChar,50),
					new SqlParameter("@CHARGER", SqlDbType.VarChar,40),
					new SqlParameter("@BUILDTM", SqlDbType.DateTime),
					new SqlParameter("@TEACHERNO1", SqlDbType.Int,4),
					new SqlParameter("@TEACHERNO2", SqlDbType.Int,4),
					new SqlParameter("@REWARD", SqlDbType.VarChar,200),
					new SqlParameter("@STATUS", SqlDbType.Int,4)};
			parameters[0].Value = model.GROUPID;
			parameters[1].Value = model.COMPETITIONID;
			parameters[2].Value = model.GROUPNAME;
			parameters[3].Value = model.CHARGER;
			parameters[4].Value = model.BUILDTM;
			parameters[5].Value = model.TEACHERNO1;
			parameters[6].Value = model.TEACHERNO2;
			parameters[7].Value = model.REWARD;
			parameters[8].Value = model.STATUS;

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
		public bool Update(Student.Model.COMPETITION_GROUP model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update COMPETITION_GROUP set ");
			strSql.Append("COMPETITIONID=@COMPETITIONID,");
			strSql.Append("GROUPNAME=@GROUPNAME,");
			strSql.Append("CHARGER=@CHARGER,");
			strSql.Append("BUILDTM=@BUILDTM,");
			strSql.Append("TEACHERNO1=@TEACHERNO1,");
			strSql.Append("TEACHERNO2=@TEACHERNO2,");
			strSql.Append("REWARD=@REWARD,");
			strSql.Append("STATUS=@STATUS");
			strSql.Append(" where GROUPID=@GROUPID ");
			SqlParameter[] parameters = {
					new SqlParameter("@COMPETITIONID", SqlDbType.Decimal,9),
					new SqlParameter("@GROUPNAME", SqlDbType.VarChar,50),
					new SqlParameter("@CHARGER", SqlDbType.VarChar,40),
					new SqlParameter("@BUILDTM", SqlDbType.DateTime),
					new SqlParameter("@TEACHERNO1", SqlDbType.Int,4),
					new SqlParameter("@TEACHERNO2", SqlDbType.Int,4),
					new SqlParameter("@REWARD", SqlDbType.VarChar,200),
					new SqlParameter("@STATUS", SqlDbType.Int,4),
					new SqlParameter("@GROUPID", SqlDbType.Decimal,9)};
			parameters[0].Value = model.COMPETITIONID;
			parameters[1].Value = model.GROUPNAME;
			parameters[2].Value = model.CHARGER;
			parameters[3].Value = model.BUILDTM;
			parameters[4].Value = model.TEACHERNO1;
			parameters[5].Value = model.TEACHERNO2;
			parameters[6].Value = model.REWARD;
			parameters[7].Value = model.STATUS;
			parameters[8].Value = model.GROUPID;

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
		public bool Delete(decimal GROUPID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from COMPETITION_GROUP ");
			strSql.Append(" where GROUPID=@GROUPID ");
			SqlParameter[] parameters = {
					new SqlParameter("@GROUPID", SqlDbType.Decimal,9)			};
			parameters[0].Value = GROUPID;

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
		public bool DeleteList(string GROUPIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from COMPETITION_GROUP ");
			strSql.Append(" where GROUPID in ("+GROUPIDlist + ")  ");
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
		public Student.Model.COMPETITION_GROUP GetModel(decimal GROUPID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 GROUPID,COMPETITIONID,GROUPNAME,CHARGER,BUILDTM,TEACHERNO1,TEACHERNO2,REWARD,STATUS from COMPETITION_GROUP ");
			strSql.Append(" where GROUPID=@GROUPID ");
			SqlParameter[] parameters = {
					new SqlParameter("@GROUPID", SqlDbType.Decimal,9)			};
			parameters[0].Value = GROUPID;

			Student.Model.COMPETITION_GROUP model=new Student.Model.COMPETITION_GROUP();
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
        public Student.Model.COMPETITION_GROUP GetModel(string GROUPNAME)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 GROUPID,COMPETITIONID,GROUPNAME,CHARGER,BUILDTM,TEACHERNO1,TEACHERNO2,REWARD,STATUS from COMPETITION_GROUP ");
            strSql.Append(" where GROUPNAME=@GROUPNAME ");
            SqlParameter[] parameters = {
					new SqlParameter("@GROUPNAME", SqlDbType.VarChar,50)			};
            parameters[0].Value = GROUPNAME;

            Student.Model.COMPETITION_GROUP model = new Student.Model.COMPETITION_GROUP();
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
		public Student.Model.COMPETITION_GROUP DataRowToModel(DataRow row)
		{
			Student.Model.COMPETITION_GROUP model=new Student.Model.COMPETITION_GROUP();
			if (row != null)
			{
				if(row["GROUPID"]!=null && row["GROUPID"].ToString()!="")
				{
					model.GROUPID=decimal.Parse(row["GROUPID"].ToString());
				}
				if(row["COMPETITIONID"]!=null && row["COMPETITIONID"].ToString()!="")
				{
					model.COMPETITIONID=decimal.Parse(row["COMPETITIONID"].ToString());
				}
				if(row["GROUPNAME"]!=null)
				{
					model.GROUPNAME=row["GROUPNAME"].ToString();
				}
				if(row["CHARGER"]!=null)
				{
					model.CHARGER=row["CHARGER"].ToString();
				}
				if(row["BUILDTM"]!=null && row["BUILDTM"].ToString()!="")
				{
					model.BUILDTM=DateTime.Parse(row["BUILDTM"].ToString());
				}
				if(row["TEACHERNO1"]!=null && row["TEACHERNO1"].ToString()!="")
				{
					model.TEACHERNO1=int.Parse(row["TEACHERNO1"].ToString());
				}
				if(row["TEACHERNO2"]!=null && row["TEACHERNO2"].ToString()!="")
				{
					model.TEACHERNO2=int.Parse(row["TEACHERNO2"].ToString());
				}
				if(row["REWARD"]!=null)
				{
					model.REWARD=row["REWARD"].ToString();
				}
				if(row["STATUS"]!=null && row["STATUS"].ToString()!="")
				{
					model.STATUS=int.Parse(row["STATUS"].ToString());
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
			strSql.Append("select GROUPID,COMPETITIONID,GROUPNAME,CHARGER,BUILDTM,TEACHERNO1,TEACHERNO2,REWARD,STATUS ");
			strSql.Append(" FROM COMPETITION_GROUP ");
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
			strSql.Append(" GROUPID,COMPETITIONID,GROUPNAME,CHARGER,BUILDTM,TEACHERNO1,TEACHERNO2,REWARD,STATUS ");
			strSql.Append(" FROM COMPETITION_GROUP ");
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
			strSql.Append("select count(1) FROM COMPETITION_GROUP ");
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
				strSql.Append("order by T.GROUPID desc");
			}
			strSql.Append(")AS Row, T.*  from COMPETITION_GROUP T ");
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
			parameters[0].Value = "COMPETITION_GROUP";
			parameters[1].Value = "GROUPID";
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

