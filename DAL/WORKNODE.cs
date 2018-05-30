/**  版本信息模板在安装目录下，可自行修改。
* WORKNODE.cs
*
* 功 能： N/A
* 类 名： WORKNODE
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:37   N/A    初版
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
	/// 数据访问类:WORKNODE
	/// </summary>
	public partial class WORKNODE
	{
		public WORKNODE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return SqlHelper.GetMaxID("NODENO", "WORKNODE"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int NODENO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WORKNODE");
			strSql.Append(" where NODENO=@NODENO ");
			SqlParameter[] parameters = {
					new SqlParameter("@NODENO", SqlDbType.Int,4)			};
			parameters[0].Value = NODENO;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Student.Model.WORKNODE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WORKNODE(");
			strSql.Append("NODENAME,MEMO)");
			strSql.Append(" values (");
			strSql.Append("@NODENAME,@MEMO)");
			SqlParameter[] parameters = {
					new SqlParameter("@NODENAME", SqlDbType.VarChar,40),
					new SqlParameter("@MEMO", SqlDbType.VarChar,200)};
			parameters[0].Value = model.NODENAME;
			parameters[1].Value = model.MEMO;

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
		public bool Update(Student.Model.WORKNODE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WORKNODE set ");
			strSql.Append("NODENAME=@NODENAME,");
			strSql.Append("MEMO=@MEMO");
			strSql.Append(" where NODENO=@NODENO ");
			SqlParameter[] parameters = {
					new SqlParameter("@NODENAME", SqlDbType.VarChar,40),
					new SqlParameter("@MEMO", SqlDbType.VarChar,200),
					new SqlParameter("@NODENO", SqlDbType.Int,4)};
			parameters[0].Value = model.NODENAME;
			parameters[1].Value = model.MEMO;
			parameters[2].Value = model.NODENO;

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
		public bool Delete(int NODENO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WORKNODE ");
			strSql.Append(" where NODENO=@NODENO ");
			SqlParameter[] parameters = {
					new SqlParameter("@NODENO", SqlDbType.Int,4)			};
			parameters[0].Value = NODENO;

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
		public bool DeleteList(string NODENOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WORKNODE ");
			strSql.Append(" where NODENO in ("+NODENOlist + ")  ");
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
        /// 根据编号查询
		/// </summary>
		public Student.Model.WORKNODE GetModel(int NODENO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 NODENO,NODENAME,MEMO from WORKNODE ");
			strSql.Append(" where NODENO=@NODENO ");
			SqlParameter[] parameters = {
					new SqlParameter("@NODENO", SqlDbType.Int,4)			};
			parameters[0].Value = NODENO;

			Student.Model.WORKNODE model=new Student.Model.WORKNODE();
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
        /// 根据名称查询
        /// </summary>
        public Student.Model.WORKNODE GetModel(string NODENAME)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 NODENO,NODENAME,MEMO from WORKNODE ");
            strSql.Append(" where NODENAME=@NODENAME ");
            SqlParameter[] parameters = {
					new SqlParameter("@NODENAME", SqlDbType.VarChar,40)			};
            parameters[0].Value = NODENAME;

            Student.Model.WORKNODE model = new Student.Model.WORKNODE();
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
		public Student.Model.WORKNODE DataRowToModel(DataRow row)
		{
			Student.Model.WORKNODE model=new Student.Model.WORKNODE();
			if (row != null)
			{
				if(row["NODENO"]!=null && row["NODENO"].ToString()!="")
				{
					model.NODENO=int.Parse(row["NODENO"].ToString());
				}
				if(row["NODENAME"]!=null)
				{
					model.NODENAME=row["NODENAME"].ToString();
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
			strSql.Append("select NODENO,NODENAME,MEMO ");
			strSql.Append(" FROM WORKNODE ");
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
			strSql.Append(" NODENO,NODENAME,MEMO ");
			strSql.Append(" FROM WORKNODE ");
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
			strSql.Append("select count(1) FROM WORKNODE ");
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
				strSql.Append("order by T.NODENO desc");
			}
			strSql.Append(")AS Row, T.*  from WORKNODE T ");
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
			parameters[0].Value = "WORKNODE";
			parameters[1].Value = "NODENO";
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

