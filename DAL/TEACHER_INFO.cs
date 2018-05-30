/**  版本信息模板在安装目录下，可自行修改。
* TEACHER_INFO.cs
*
* 功 能： N/A
* 类 名： TEACHER_INFO
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
	/// 数据访问类:TEACHER_INFO
	/// </summary>
	public partial class TEACHER_INFO
	{
		public TEACHER_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return SqlHelper.GetMaxID("TEACHERNO", "TEACHER_INFO"); 
		}

		/// <summary>
		/// 是否存在该记录
        /// 按编号查询
		/// </summary>
		public bool Exists(int TEACHERNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TEACHER_INFO");
			strSql.Append(" where TEACHERNO=@TEACHERNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@TEACHERNO", SqlDbType.Int,4)			};
			parameters[0].Value = TEACHERNO;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 是否存在该记录
        /// 按姓名查询
        /// </summary>
        public bool Exists(string NAME)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TEACHER_INFO");
            strSql.Append(" where NAME=@NAME ");
            SqlParameter[] parameters = {
					new SqlParameter("@NAME", SqlDbType.VarChar,20)			};
            parameters[0].Value = NAME;

            return SqlHelper.Exists(strSql.ToString(), parameters);
        }


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Student.Model.TEACHER_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TEACHER_INFO(");
			strSql.Append("WORKID,NAME,IDCARD,SEX,NATION,MAJORNO,POLITICAL,PHONE,EMAIL,FAMILYPHONE,FAMILYADDRESS,QQNO,MICROMESSAGENO)");
			strSql.Append(" values (");
			strSql.Append("@WORKID,@NAME,@IDCARD,@SEX,@NATION,@MAJORNO,@POLITICAL,@PHONE,@EMAIL,@FAMILYPHONE,@FAMILYADDRESS,@QQNO,@MICROMESSAGENO)");
			SqlParameter[] parameters = {
					new SqlParameter("@WORKID", SqlDbType.VarChar,5),
					new SqlParameter("@NAME", SqlDbType.VarChar,20),
					new SqlParameter("@IDCARD", SqlDbType.VarChar,18),
					new SqlParameter("@SEX", SqlDbType.VarChar,2),
					new SqlParameter("@NATION", SqlDbType.VarChar,20),
					new SqlParameter("@MAJORNO", SqlDbType.Int,4),
					new SqlParameter("@POLITICAL", SqlDbType.VarChar,20),
					new SqlParameter("@PHONE", SqlDbType.VarChar,20),
					new SqlParameter("@EMAIL", SqlDbType.VarChar,40),
					new SqlParameter("@FAMILYPHONE", SqlDbType.VarChar,20),
					new SqlParameter("@FAMILYADDRESS", SqlDbType.VarChar,200),
					new SqlParameter("@QQNO", SqlDbType.VarChar,20),
					new SqlParameter("@MICROMESSAGENO", SqlDbType.VarChar,20)};
			parameters[0].Value = model.WORKID;
			parameters[1].Value = model.NAME;
			parameters[2].Value = model.IDCARD;
			parameters[3].Value = model.SEX;
			parameters[4].Value = model.NATION;
			parameters[5].Value = model.MAJORNO;
			parameters[6].Value = model.POLITICAL;
			parameters[7].Value = model.PHONE;
			parameters[8].Value = model.EMAIL;
			parameters[9].Value = model.FAMILYPHONE;
			parameters[10].Value = model.FAMILYADDRESS;
			parameters[11].Value = model.QQNO;
			parameters[12].Value = model.MICROMESSAGENO;

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
		public bool Update(Student.Model.TEACHER_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TEACHER_INFO set ");
			strSql.Append("WORKID=@WORKID,");
			strSql.Append("NAME=@NAME,");
			strSql.Append("IDCARD=@IDCARD,");
			strSql.Append("SEX=@SEX,");
			strSql.Append("NATION=@NATION,");
			strSql.Append("MAJORNO=@MAJORNO,");
			strSql.Append("POLITICAL=@POLITICAL,");
			strSql.Append("PHONE=@PHONE,");
			strSql.Append("EMAIL=@EMAIL,");
			strSql.Append("FAMILYPHONE=@FAMILYPHONE,");
			strSql.Append("FAMILYADDRESS=@FAMILYADDRESS,");
			strSql.Append("QQNO=@QQNO,");
			strSql.Append("MICROMESSAGENO=@MICROMESSAGENO");
			strSql.Append(" where TEACHERNO=@TEACHERNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@WORKID", SqlDbType.VarChar,5),
					new SqlParameter("@NAME", SqlDbType.VarChar,20),
					new SqlParameter("@IDCARD", SqlDbType.VarChar,18),
					new SqlParameter("@SEX", SqlDbType.VarChar,2),
					new SqlParameter("@NATION", SqlDbType.VarChar,20),
					new SqlParameter("@MAJORNO", SqlDbType.Int,4),
					new SqlParameter("@POLITICAL", SqlDbType.VarChar,20),
					new SqlParameter("@PHONE", SqlDbType.VarChar,20),
					new SqlParameter("@EMAIL", SqlDbType.VarChar,40),
					new SqlParameter("@FAMILYPHONE", SqlDbType.VarChar,20),
					new SqlParameter("@FAMILYADDRESS", SqlDbType.VarChar,200),
					new SqlParameter("@QQNO", SqlDbType.VarChar,20),
					new SqlParameter("@MICROMESSAGENO", SqlDbType.VarChar,20),
					new SqlParameter("@TEACHERNO", SqlDbType.Int,4)};
			parameters[0].Value = model.WORKID;
			parameters[1].Value = model.NAME;
			parameters[2].Value = model.IDCARD;
			parameters[3].Value = model.SEX;
			parameters[4].Value = model.NATION;
			parameters[5].Value = model.MAJORNO;
			parameters[6].Value = model.POLITICAL;
			parameters[7].Value = model.PHONE;
			parameters[8].Value = model.EMAIL;
			parameters[9].Value = model.FAMILYPHONE;
			parameters[10].Value = model.FAMILYADDRESS;
			parameters[11].Value = model.QQNO;
			parameters[12].Value = model.MICROMESSAGENO;
			parameters[13].Value = model.TEACHERNO;

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
		public bool Delete(int TEACHERNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TEACHER_INFO ");
			strSql.Append(" where TEACHERNO=@TEACHERNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@TEACHERNO", SqlDbType.Int,4)			};
			parameters[0].Value = TEACHERNO;

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
		public bool DeleteList(string TEACHERNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TEACHER_INFO ");
			strSql.Append(" where TEACHERNO in ("+TEACHERNOlist + ")  ");
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
        /// 根据教师编号查找
		/// </summary>
		public Student.Model.TEACHER_INFO GetModel(int TEACHERNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 TEACHERNO,WORKID,NAME,IDCARD,SEX,NATION,MAJORNO,POLITICAL,PHONE,EMAIL,FAMILYPHONE,FAMILYADDRESS,QQNO,MICROMESSAGENO from TEACHER_INFO ");
			strSql.Append(" where TEACHERNO=@TEACHERNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@TEACHERNO", SqlDbType.Int,4)			};
			parameters[0].Value = TEACHERNO;

			Student.Model.TEACHER_INFO model=new Student.Model.TEACHER_INFO();
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
        /// 根据教师姓名查找
        /// </summary>
        public Student.Model.TEACHER_INFO GetModel(string NAME)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 TEACHERNO,WORKID,NAME,IDCARD,SEX,NATION,MAJORNO,POLITICAL,PHONE,EMAIL,FAMILYPHONE,FAMILYADDRESS,QQNO,MICROMESSAGENO from TEACHER_INFO ");
            strSql.Append(" where NAME=@NAME ");
            SqlParameter[] parameters = {
					new SqlParameter("@NAME", SqlDbType.VarChar,20)			};
            parameters[0].Value = NAME;

            Student.Model.TEACHER_INFO model = new Student.Model.TEACHER_INFO();
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
		public Student.Model.TEACHER_INFO DataRowToModel(DataRow row)
		{
			Student.Model.TEACHER_INFO model=new Student.Model.TEACHER_INFO();
			if (row != null)
			{
				if(row["TEACHERNO"]!=null && row["TEACHERNO"].ToString()!="")
				{
					model.TEACHERNO=int.Parse(row["TEACHERNO"].ToString());
				}
				if(row["WORKID"]!=null)
				{
					model.WORKID=row["WORKID"].ToString();
				}
				if(row["NAME"]!=null)
				{
					model.NAME=row["NAME"].ToString();
				}
				if(row["IDCARD"]!=null)
				{
					model.IDCARD=row["IDCARD"].ToString();
				}
				if(row["SEX"]!=null)
				{
					model.SEX=row["SEX"].ToString();
				}
				if(row["NATION"]!=null)
				{
					model.NATION=row["NATION"].ToString();
				}
				if(row["MAJORNO"]!=null && row["MAJORNO"].ToString()!="")
				{
					model.MAJORNO=int.Parse(row["MAJORNO"].ToString());
				}
				if(row["POLITICAL"]!=null)
				{
					model.POLITICAL=row["POLITICAL"].ToString();
				}
				if(row["PHONE"]!=null)
				{
					model.PHONE=row["PHONE"].ToString();
				}
				if(row["EMAIL"]!=null)
				{
					model.EMAIL=row["EMAIL"].ToString();
				}
				if(row["FAMILYPHONE"]!=null)
				{
					model.FAMILYPHONE=row["FAMILYPHONE"].ToString();
				}
				if(row["FAMILYADDRESS"]!=null)
				{
					model.FAMILYADDRESS=row["FAMILYADDRESS"].ToString();
				}
				if(row["QQNO"]!=null)
				{
					model.QQNO=row["QQNO"].ToString();
				}
				if(row["MICROMESSAGENO"]!=null)
				{
					model.MICROMESSAGENO=row["MICROMESSAGENO"].ToString();
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
            strSql.Append("select TEACHERNO,NAME,WORKID,B.MAJORNAME,SEX,PHONE,IDCARD,NATION, ");
            strSql.Append(" POLITICAL,EMAIL,FAMILYPHONE,FAMILYADDRESS,QQNO,MICROMESSAGENO ");
            strSql.Append(" from TEACHER_INFO A,MAJOR_INFO B ");
			strSql.Append(" where A.MAJORNO = B.MAJORNO ");
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
			strSql.Append(" TEACHERNO,WORKID,NAME,IDCARD,SEX,NATION,MAJORNO,POLITICAL,PHONE,EMAIL,FAMILYPHONE,FAMILYADDRESS,QQNO,MICROMESSAGENO ");
			strSql.Append(" FROM TEACHER_INFO ");
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
			strSql.Append("select count(1) FROM TEACHER_INFO ");
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
				strSql.Append("order by T.TEACHERNO desc");
			}
			strSql.Append(")AS Row, T.*  from TEACHER_INFO T ");
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
			parameters[0].Value = "TEACHER_INFO";
			parameters[1].Value = "TEACHERNO";
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

