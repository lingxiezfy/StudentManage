/**  版本信息模板在安装目录下，可自行修改。
* TERM_INFO.cs
*
* 功 能： N/A
* 类 名： TERM_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:36   N/A    初版
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
	/// 数据访问类:TERM_INFO
	/// </summary>
	public partial class TERM_INFO
	{
		public TERM_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return SqlHelper.GetMaxID("TERMNO", "TERM_INFO"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int TERMNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TERM_INFO");
			strSql.Append(" where TERMNO=@TERMNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@TERMNO", SqlDbType.Int,4)			};
			parameters[0].Value = TERMNO;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Student.Model.TERM_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TERM_INFO(");
			strSql.Append("TERMNAME,BEGINTIME,ENDTIME,FLAG)");
			strSql.Append(" values (");
			strSql.Append("@TERMNAME,@BEGINTIME,@ENDTIME,@FLAG)");
			SqlParameter[] parameters = {
					new SqlParameter("@TERMNAME", SqlDbType.VarChar,20),
					new SqlParameter("@BEGINTIME", SqlDbType.DateTime),
					new SqlParameter("@ENDTIME", SqlDbType.DateTime),
					new SqlParameter("@FLAG", SqlDbType.Int,4)};
			parameters[0].Value = model.TERMNAME;
			parameters[1].Value = model.BEGINTIME;
			parameters[2].Value = model.ENDTIME;
			parameters[3].Value = model.FLAG;

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
		public bool Update(Student.Model.TERM_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TERM_INFO set ");
			strSql.Append("TERMNAME=@TERMNAME,");
			strSql.Append("BEGINTIME=@BEGINTIME,");
			strSql.Append("ENDTIME=@ENDTIME,");
			strSql.Append("FLAG=@FLAG");
			strSql.Append(" where TERMNO=@TERMNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@TERMNAME", SqlDbType.VarChar,20),
					new SqlParameter("@BEGINTIME", SqlDbType.DateTime),
					new SqlParameter("@ENDTIME", SqlDbType.DateTime),
					new SqlParameter("@FLAG", SqlDbType.Int,4),
					new SqlParameter("@TERMNO", SqlDbType.Int,4)};
			parameters[0].Value = model.TERMNAME;
			parameters[1].Value = model.BEGINTIME;
			parameters[2].Value = model.ENDTIME;
			parameters[3].Value = model.FLAG;
			parameters[4].Value = model.TERMNO;

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
		public bool Delete(int TERMNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TERM_INFO ");
			strSql.Append(" where TERMNO=@TERMNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@TERMNO", SqlDbType.Int,4)			};
			parameters[0].Value = TERMNO;

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
		public bool DeleteList(string TERMNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TERM_INFO ");
			strSql.Append(" where TERMNO in ("+TERMNOlist + ")  ");
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
        /// 根据学期编号查找
		/// </summary>
		public Student.Model.TERM_INFO GetModel(int TERMNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 TERMNO,TERMNAME,BEGINTIME,ENDTIME,FLAG from TERM_INFO ");
			strSql.Append(" where TERMNO=@TERMNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@TERMNO", SqlDbType.Int,4)			};
			parameters[0].Value = TERMNO;

			Student.Model.TERM_INFO model=new Student.Model.TERM_INFO();
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
        /// 根据学期名称查找
        /// </summary>
        public Student.Model.TERM_INFO GetModel(string TERMNAME)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 TERMNO,TERMNAME,BEGINTIME,ENDTIME,FLAG from TERM_INFO ");
            strSql.Append(" where TERMNAME=@TERMNAME ");
            SqlParameter[] parameters = {
					new SqlParameter("@TERMNAME", SqlDbType.VarChar,20)			};
            parameters[0].Value = TERMNAME;

            Student.Model.TERM_INFO model = new Student.Model.TERM_INFO();
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
		public Student.Model.TERM_INFO DataRowToModel(DataRow row)
		{
			Student.Model.TERM_INFO model=new Student.Model.TERM_INFO();
			if (row != null)
			{
				if(row["TERMNO"]!=null && row["TERMNO"].ToString()!="")
				{
					model.TERMNO=int.Parse(row["TERMNO"].ToString());
				}
				if(row["TERMNAME"]!=null)
				{
					model.TERMNAME=row["TERMNAME"].ToString();
				}
				if(row["BEGINTIME"]!=null && row["BEGINTIME"].ToString()!="")
				{
					model.BEGINTIME=DateTime.Parse(row["BEGINTIME"].ToString());
				}
				if(row["ENDTIME"]!=null && row["ENDTIME"].ToString()!="")
				{
					model.ENDTIME=DateTime.Parse(row["ENDTIME"].ToString());
				}
				if(row["FLAG"]!=null && row["FLAG"].ToString()!="")
				{
					model.FLAG=int.Parse(row["FLAG"].ToString());
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
			strSql.Append("select TERMNO,TERMNAME,BEGINTIME,ENDTIME,case FLAG when 1 then  '当前学期' else ' ' end as FLAG ");
			strSql.Append(" FROM TERM_INFO ");
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
			strSql.Append(" TERMNO,TERMNAME,BEGINTIME,ENDTIME,FLAG ");
			strSql.Append(" FROM TERM_INFO ");
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
			strSql.Append("select count(1) FROM TERM_INFO ");
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
				strSql.Append("order by T.TERMNO desc");
			}
			strSql.Append(")AS Row, T.*  from TERM_INFO T ");
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
			parameters[0].Value = "TERM_INFO";
			parameters[1].Value = "TERMNO";
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

