/**  版本信息模板在安装目录下，可自行修改。
* CLASS_INFO.cs
*
* 功 能： N/A
* 类 名： CLASS_INFO
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
	/// 数据访问类:CLASS_INFO
	/// </summary>
	public partial class CLASS_INFO
	{
		public CLASS_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return SqlHelper.GetMaxID("CLASSNO", "CLASS_INFO"); 
		}

		/// <summary>
		/// 是否存在该记录
        /// 按编号查找
		/// </summary>
		public bool Exists(int CLASSNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CLASS_INFO");
			strSql.Append(" where CLASSNO=@CLASSNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@CLASSNO", SqlDbType.Int,4)			};
			parameters[0].Value = CLASSNO;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 是否存在该记录
        /// 按名称查找
        /// </summary>
        public bool Exists(string CLASSNAME)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CLASS_INFO");
            strSql.Append(" where CLASSNAME=@CLASSNAME ");
            SqlParameter[] parameters = {
					new SqlParameter("@CLASSNAME", SqlDbType.VarChar,10)			};
            parameters[0].Value = CLASSNAME;

            return SqlHelper.Exists(strSql.ToString(), parameters);
        }


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Student.Model.CLASS_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CLASS_INFO(");
			strSql.Append("MAJORDIRCTNO,CLASSNAME,TEACHERNO1,TEACHERNO2,TEACHERNO3)");
			strSql.Append(" values (");
			strSql.Append("@MAJORDIRCTNO,@CLASSNAME,@TEACHERNO1,@TEACHERNO2,@TEACHERNO3)");
			SqlParameter[] parameters = {
					new SqlParameter("@MAJORDIRCTNO", SqlDbType.Int,4),
					new SqlParameter("@CLASSNAME", SqlDbType.VarChar,10),
					new SqlParameter("@TEACHERNO1", SqlDbType.Int,4),
					new SqlParameter("@TEACHERNO2", SqlDbType.Int,4),
					new SqlParameter("@TEACHERNO3", SqlDbType.Int,4)};
			parameters[0].Value = model.MAJORDIRCTNO;
			parameters[1].Value = model.CLASSNAME;
			parameters[2].Value = model.TEACHERNO1;
			parameters[3].Value = model.TEACHERNO2;
			parameters[4].Value = model.TEACHERNO3;

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
		public bool Update(Student.Model.CLASS_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CLASS_INFO set ");
			strSql.Append("MAJORDIRCTNO=@MAJORDIRCTNO,");
			strSql.Append("CLASSNAME=@CLASSNAME,");
			strSql.Append("TEACHERNO1=@TEACHERNO1,");
			strSql.Append("TEACHERNO2=@TEACHERNO2,");
			strSql.Append("TEACHERNO3=@TEACHERNO3");
			strSql.Append(" where CLASSNO=@CLASSNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@MAJORDIRCTNO", SqlDbType.Int,4),
					new SqlParameter("@CLASSNAME", SqlDbType.VarChar,10),
					new SqlParameter("@TEACHERNO1", SqlDbType.Int,4),
					new SqlParameter("@TEACHERNO2", SqlDbType.Int,4),
					new SqlParameter("@TEACHERNO3", SqlDbType.Int,4),
					new SqlParameter("@CLASSNO", SqlDbType.Int,4)};
			parameters[0].Value = model.MAJORDIRCTNO;
			parameters[1].Value = model.CLASSNAME;
			parameters[2].Value = model.TEACHERNO1;
			parameters[3].Value = model.TEACHERNO2;
			parameters[4].Value = model.TEACHERNO3;
			parameters[5].Value = model.CLASSNO;

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
		public bool Delete(int CLASSNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CLASS_INFO ");
			strSql.Append(" where CLASSNO=@CLASSNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@CLASSNO", SqlDbType.Int,4)			};
			parameters[0].Value = CLASSNO;

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
		public bool DeleteList(string CLASSNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CLASS_INFO ");
			strSql.Append(" where CLASSNO in ("+CLASSNOlist + ")  ");
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
		public Student.Model.CLASS_INFO GetModel(int CLASSNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CLASSNO,MAJORDIRCTNO,CLASSNAME,TEACHERNO1,TEACHERNO2,TEACHERNO3 from CLASS_INFO ");
			strSql.Append(" where CLASSNO=@CLASSNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@CLASSNO", SqlDbType.Int,4)			};
			parameters[0].Value = CLASSNO;

			Student.Model.CLASS_INFO model=new Student.Model.CLASS_INFO();
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
        public Student.Model.CLASS_INFO GetModel(string CLASSNAME)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 CLASSNO,MAJORDIRCTNO,CLASSNAME,TEACHERNO1,TEACHERNO2,TEACHERNO3 from CLASS_INFO ");
            strSql.Append(" where CLASSNAME=@CLASSNAME ");
            SqlParameter[] parameters = {
					new SqlParameter("@CLASSNAME", SqlDbType.VarChar,10)			};
            parameters[0].Value = CLASSNAME;

            Student.Model.CLASS_INFO model = new Student.Model.CLASS_INFO();
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
		public Student.Model.CLASS_INFO DataRowToModel(DataRow row)
		{
			Student.Model.CLASS_INFO model=new Student.Model.CLASS_INFO();
			if (row != null)
			{
				if(row["CLASSNO"]!=null && row["CLASSNO"].ToString()!="")
				{
					model.CLASSNO=int.Parse(row["CLASSNO"].ToString());
				}
				if(row["MAJORDIRCTNO"]!=null && row["MAJORDIRCTNO"].ToString()!="")
				{
					model.MAJORDIRCTNO=int.Parse(row["MAJORDIRCTNO"].ToString());
				}
				if(row["CLASSNAME"]!=null)
				{
					model.CLASSNAME=row["CLASSNAME"].ToString();
				}
				if(row["TEACHERNO1"]!=null && row["TEACHERNO1"].ToString()!="")
				{
					model.TEACHERNO1=int.Parse(row["TEACHERNO1"].ToString());
				}
				if(row["TEACHERNO2"]!=null && row["TEACHERNO2"].ToString()!="")
				{
					model.TEACHERNO2=int.Parse(row["TEACHERNO2"].ToString());
				}
				if(row["TEACHERNO3"]!=null && row["TEACHERNO3"].ToString()!="")
				{
					model.TEACHERNO3=int.Parse(row["TEACHERNO3"].ToString());
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
            strSql.Append(" select A.CLASSNO,C.MAJORNAME,B.MAJORDIRCTNAME,A.CLASSNAME, ");
            strSql.Append(" D.NAME as HEADMASTER,E.NAME AS INSTRUCTOR,F.NAME AS ORGANIZER ");
            strSql.Append(" from CLASS_INFO A,MAJORDIRCT_INFO B,MAJOR_INFO C,TEACHER_INFO D, ");
            strSql.Append(" TEACHER_INFO E,TEACHER_INFO F ");
            strSql.Append(" where A.MAJORDIRCTNO = B.MAJORDIRCTNO and ");
            strSql.Append(" B.MAJORNO = C.MAJORNO and ");
            strSql.Append(" D.TEACHERNO = A.TEACHERNO1 and ");
            strSql.Append(" E.TEACHERNO = A.TEACHERNO2 and ");
            strSql.Append(" F.TEACHERNO = A.TEACHERNO3 ");

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
			strSql.Append(" CLASSNO,MAJORDIRCTNO,CLASSNAME,TEACHERNO1,TEACHERNO2,TEACHERNO3 ");
			strSql.Append(" FROM CLASS_INFO ");
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
			strSql.Append("select count(1) FROM CLASS_INFO ");
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
				strSql.Append("order by T.CLASSNO desc");
			}
			strSql.Append(")AS Row, T.*  from CLASS_INFO T ");
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
			parameters[0].Value = "CLASS_INFO";
			parameters[1].Value = "CLASSNO";
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

