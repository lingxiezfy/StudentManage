/**  版本信息模板在安装目录下，可自行修改。
* STUDENT_INFO.cs
*
* 功 能： N/A
* 类 名： STUDENT_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:34   N/A    初版
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
	/// 数据访问类:STUDENT_INFO
	/// </summary>
	public partial class STUDENT_INFO
	{
		public STUDENT_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string STUNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from STUDENT_INFO");
			strSql.Append(" where STUNO=@STUNO ");
			SqlParameter[] parameters = {
					new SqlParameter("@STUNO", SqlDbType.VarChar,10)			};
			parameters[0].Value = STUNO;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Student.Model.STUDENT_INFO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into STUDENT_INFO(");
            strSql.Append("STUNO,CLASSNO,NAME,IDCARD,SEX,NATION,POLITICAL,SOURCE,INTENTEDDATE,GRADUATIONDATE,PHONE,EMAIL,DORMITORY_ID,FATHERPHONE,MOTHERPHONE,FAMILYPHONE,FAMILYADDRESS,ZIPCODE,QQNO,MICROMESSAGENO,PICTURE,STATUS)");
            strSql.Append(" values (");
            strSql.Append("@STUNO,@CLASSNO,@NAME,@IDCARD,@SEX,@NATION,@POLITICAL,@SOURCE,@INTENTEDDATE,@GRADUATIONDATE,@PHONE,@EMAIL,@DORMITORY_ID,@FATHERPHONE,@MOTHERPHONE,@FAMILYPHONE,@FAMILYADDRESS,@ZIPCODE,@QQNO,@MICROMESSAGENO,@PICTURE,@STATUS)");
            SqlParameter[] parameters = {
					new SqlParameter("@STUNO", SqlDbType.VarChar,10),
					new SqlParameter("@CLASSNO", SqlDbType.Int,4),
					new SqlParameter("@NAME", SqlDbType.VarChar,20),
					new SqlParameter("@IDCARD", SqlDbType.VarChar,18),
					new SqlParameter("@SEX", SqlDbType.VarChar,2),
					new SqlParameter("@NATION", SqlDbType.VarChar,20),
					new SqlParameter("@POLITICAL", SqlDbType.VarChar,20),
					new SqlParameter("@SOURCE", SqlDbType.VarChar,100),
					new SqlParameter("@INTENTEDDATE", SqlDbType.DateTime),
					new SqlParameter("@GRADUATIONDATE", SqlDbType.DateTime),
					new SqlParameter("@PHONE", SqlDbType.VarChar,20),
					new SqlParameter("@EMAIL", SqlDbType.VarChar,40),
					new SqlParameter("@DORMITORY_ID", SqlDbType.Decimal,9),
					new SqlParameter("@FATHERPHONE", SqlDbType.VarChar,20),
					new SqlParameter("@MOTHERPHONE", SqlDbType.VarChar,20),
					new SqlParameter("@FAMILYPHONE", SqlDbType.VarChar,20),
					new SqlParameter("@FAMILYADDRESS", SqlDbType.VarChar,200),
					new SqlParameter("@ZIPCODE", SqlDbType.VarChar,6),
					new SqlParameter("@QQNO", SqlDbType.VarChar,20),
					new SqlParameter("@MICROMESSAGENO", SqlDbType.VarChar,20),
					new SqlParameter("@PICTURE", SqlDbType.Image),
					new SqlParameter("@STATUS", SqlDbType.Int,4)};
            parameters[0].Value = model.STUNO;
            parameters[1].Value = model.CLASSNO;
            parameters[2].Value = model.NAME;
            parameters[3].Value = model.IDCARD;
            parameters[4].Value = model.SEX;
            parameters[5].Value = model.NATION;
            parameters[6].Value = model.POLITICAL;
            parameters[7].Value = model.SOURCE;
            parameters[8].Value = model.INTENTEDDATE;
            parameters[9].Value = model.GRADUATIONDATE;
            parameters[10].Value = model.PHONE;
            parameters[11].Value = model.EMAIL;
            parameters[12].Value = model.DORMITORY_ID;
            parameters[13].Value = model.FATHERPHONE;
            parameters[14].Value = model.MOTHERPHONE;
            parameters[15].Value = model.FAMILYPHONE;
            parameters[16].Value = model.FAMILYADDRESS;
            parameters[17].Value = model.ZIPCODE;
            parameters[18].Value = model.QQNO;
            parameters[19].Value = model.MICROMESSAGENO;
            parameters[20].Value = model.PICTURE;
            parameters[21].Value = model.STATUS;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(Student.Model.STUDENT_INFO model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update STUDENT_INFO set ");
            strSql.Append("CLASSNO=@CLASSNO,");
            strSql.Append("NAME=@NAME,");
            strSql.Append("IDCARD=@IDCARD,");
            strSql.Append("SEX=@SEX,");
            strSql.Append("NATION=@NATION,");
            strSql.Append("POLITICAL=@POLITICAL,");
            strSql.Append("SOURCE=@SOURCE,");
            strSql.Append("INTENTEDDATE=@INTENTEDDATE,");
            strSql.Append("GRADUATIONDATE=@GRADUATIONDATE,");
            strSql.Append("PHONE=@PHONE,");
            strSql.Append("EMAIL=@EMAIL,");
            strSql.Append("DORMITORY_ID=@DORMITORY_ID,");
            strSql.Append("FATHERPHONE=@FATHERPHONE,");
            strSql.Append("MOTHERPHONE=@MOTHERPHONE,");
            strSql.Append("FAMILYPHONE=@FAMILYPHONE,");
            strSql.Append("FAMILYADDRESS=@FAMILYADDRESS,");
            strSql.Append("ZIPCODE=@ZIPCODE,");
            strSql.Append("QQNO=@QQNO,");
            strSql.Append("MICROMESSAGENO=@MICROMESSAGENO,");
            strSql.Append("PICTURE=@PICTURE,");
            strSql.Append("STATUS=@STATUS");
            strSql.Append(" where STUNO=@STUNO ");
            SqlParameter[] parameters = {
					new SqlParameter("@CLASSNO", SqlDbType.Int,4),
					new SqlParameter("@NAME", SqlDbType.VarChar,20),
					new SqlParameter("@IDCARD", SqlDbType.VarChar,18),
					new SqlParameter("@SEX", SqlDbType.VarChar,2),
					new SqlParameter("@NATION", SqlDbType.VarChar,20),
					new SqlParameter("@POLITICAL", SqlDbType.VarChar,20),
					new SqlParameter("@SOURCE", SqlDbType.VarChar,100),
					new SqlParameter("@INTENTEDDATE", SqlDbType.DateTime),
					new SqlParameter("@GRADUATIONDATE", SqlDbType.DateTime),
					new SqlParameter("@PHONE", SqlDbType.VarChar,20),
					new SqlParameter("@EMAIL", SqlDbType.VarChar,40),
					new SqlParameter("@DORMITORY_ID", SqlDbType.Decimal,9),
					new SqlParameter("@FATHERPHONE", SqlDbType.VarChar,20),
					new SqlParameter("@MOTHERPHONE", SqlDbType.VarChar,20),
					new SqlParameter("@FAMILYPHONE", SqlDbType.VarChar,20),
					new SqlParameter("@FAMILYADDRESS", SqlDbType.VarChar,200),
					new SqlParameter("@ZIPCODE", SqlDbType.VarChar,6),
					new SqlParameter("@QQNO", SqlDbType.VarChar,20),
					new SqlParameter("@MICROMESSAGENO", SqlDbType.VarChar,20),
					new SqlParameter("@PICTURE", SqlDbType.Image),
					new SqlParameter("@STATUS", SqlDbType.Int,4),
					new SqlParameter("@STUNO", SqlDbType.VarChar,10)};
            parameters[0].Value = model.CLASSNO;
            parameters[1].Value = model.NAME;
            parameters[2].Value = model.IDCARD;
            parameters[3].Value = model.SEX;
            parameters[4].Value = model.NATION;
            parameters[5].Value = model.POLITICAL;
            parameters[6].Value = model.SOURCE;
            parameters[7].Value = model.INTENTEDDATE;
            parameters[8].Value = model.GRADUATIONDATE;
            parameters[9].Value = model.PHONE;
            parameters[10].Value = model.EMAIL;
            parameters[11].Value = model.DORMITORY_ID;
            parameters[12].Value = model.FATHERPHONE;
            parameters[13].Value = model.MOTHERPHONE;
            parameters[14].Value = model.FAMILYPHONE;
            parameters[15].Value = model.FAMILYADDRESS;
            parameters[16].Value = model.ZIPCODE;
            parameters[17].Value = model.QQNO;
            parameters[18].Value = model.MICROMESSAGENO;
            parameters[19].Value = model.PICTURE;
            parameters[20].Value = model.STATUS;
            parameters[21].Value = model.STUNO;

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
        public bool Delete(string STUNO)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from STUDENT_INFO ");
            strSql.Append(" where STUNO=@STUNO ");
            SqlParameter[] parameters = {
					new SqlParameter("@STUNO", SqlDbType.VarChar,10)			};
            parameters[0].Value = STUNO;

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string STUNOlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from STUDENT_INFO ");
            strSql.Append(" where STUNO in (" + STUNOlist + ")  ");
            int rows = SqlHelper.ExecuteSql(strSql.ToString());
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
        /// 根据学生学号查询
		/// </summary>
		public Student.Model.STUDENT_INFO GetModel(string STUNO,string flag)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 STUNO,CLASSNO,NAME,IDCARD,SEX,NATION,POLITICAL,SOURCE,INTENTEDDATE,GRADUATIONDATE,PHONE,EMAIL,DORMITORY_ID,FATHERPHONE,MOTHERPHONE,FAMILYPHONE,FAMILYADDRESS,ZIPCODE,QQNO,MICROMESSAGENO,PICTURE,STATUS from STUDENT_INFO ");
            strSql.Append(" where STUNO=@STUNO");
			SqlParameter[] parameters = {
					new SqlParameter("@STUNO", SqlDbType.VarChar,10)
			};
            parameters[0].Value = STUNO;

			Student.Model.STUDENT_INFO model=new Student.Model.STUDENT_INFO();
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
        /// 根据学生姓名查询
        /// </summary>
        public Student.Model.STUDENT_INFO GetModel(string NAME,int flag)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 STUNO,CLASSNO,NAME,IDCARD,SEX,NATION,POLITICAL,SOURCE,INTENTEDDATE,GRADUATIONDATE,PHONE,EMAIL,DORMITORY_ID,FATHERPHONE,MOTHERPHONE,FAMILYPHONE,FAMILYADDRESS,ZIPCODE,QQNO,MICROMESSAGENO,PICTURE,STATUS from STUDENT_INFO ");
            strSql.Append(" where NAME=@NAME");
            SqlParameter[] parameters = {
					new SqlParameter("@NAME", SqlDbType.VarChar,20)
			};
            parameters[0].Value = NAME;

            Student.Model.STUDENT_INFO model = new Student.Model.STUDENT_INFO();
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
		public Student.Model.STUDENT_INFO DataRowToModel(DataRow row)
		{
			Student.Model.STUDENT_INFO model=new Student.Model.STUDENT_INFO();
			if (row != null)
			{
				if(row["STUNO"]!=null)
				{
					model.STUNO=row["STUNO"].ToString();
				}
				if(row["CLASSNO"]!=null && row["CLASSNO"].ToString()!="")
				{
					model.CLASSNO=int.Parse(row["CLASSNO"].ToString());
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
				if(row["POLITICAL"]!=null)
				{
					model.POLITICAL=row["POLITICAL"].ToString();
				}
				if(row["SOURCE"]!=null)
				{
					model.SOURCE=row["SOURCE"].ToString();
				}
				if(row["INTENTEDDATE"]!=null && row["INTENTEDDATE"].ToString()!="")
				{
					model.INTENTEDDATE=DateTime.Parse(row["INTENTEDDATE"].ToString());
				}
				if(row["GRADUATIONDATE"]!=null && row["GRADUATIONDATE"].ToString()!="")
				{
					model.GRADUATIONDATE=DateTime.Parse(row["GRADUATIONDATE"].ToString());
				}
				if(row["PHONE"]!=null)
				{
					model.PHONE=row["PHONE"].ToString();
				}
				if(row["EMAIL"]!=null)
				{
					model.EMAIL=row["EMAIL"].ToString();
				}
				if(row["DORMITORY_ID"]!=null && row["DORMITORY_ID"].ToString()!="")
				{
					model.DORMITORY_ID=decimal.Parse(row["DORMITORY_ID"].ToString());
				}
				if(row["FATHERPHONE"]!=null)
				{
					model.FATHERPHONE=row["FATHERPHONE"].ToString();
				}
				if(row["MOTHERPHONE"]!=null)
				{
					model.MOTHERPHONE=row["MOTHERPHONE"].ToString();
				}
				if(row["FAMILYPHONE"]!=null)
				{
					model.FAMILYPHONE=row["FAMILYPHONE"].ToString();
				}
				if(row["FAMILYADDRESS"]!=null)
				{
					model.FAMILYADDRESS=row["FAMILYADDRESS"].ToString();
				}
				if(row["ZIPCODE"]!=null)
				{
					model.ZIPCODE=row["ZIPCODE"].ToString();
				}
				if(row["QQNO"]!=null)
				{
					model.QQNO=row["QQNO"].ToString();
				}
				if(row["MICROMESSAGENO"]!=null)
				{
					model.MICROMESSAGENO=row["MICROMESSAGENO"].ToString();
				}
				if(row["PICTURE"]!=null && row["PICTURE"].ToString()!="")
				{
					model.PICTURE=(byte[])row["PICTURE"];
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
            strSql.Append("select A.STUNO,A.NAME,C.CLASSNAME,B.DORMITORY_PLATE,D.MAJORDIRCTNAME, ");
            strSql.Append(" case status when 1 then '正常' ");
            strSql.Append(" when 2 then '休学' ");
            strSql.Append(" when 3 then '退学' ");
            strSql.Append(" when 4 then '毕业' ");
            strSql.Append(" end AS STATUS, ");
            strSql.Append(" IDCARD,SEX,NATION,POLITICAL,SOURCE,INTENTEDDATE,GRADUATIONDATE, ");
            strSql.Append(" PHONE,EMAIL,FATHERPHONE,MOTHERPHONE,FAMILYPHONE,FAMILYADDRESS, ");
            strSql.Append(" ZIPCODE,QQNO,MICROMESSAGENO,PICTURE ");
            strSql.Append(" from STUDENT_INFO A,DORMITORY_INFO B,CLASS_INFO C,MAJORDIRCT_INFO D ");
            strSql.Append(" where A.DORMITORY_ID = B.DORMITORY_ID ");
            strSql.Append(" and A.CLASSNO = C.CLASSNO ");
            strSql.Append(" and C.MAJORDIRCTNO = D.MAJORDIRCTNO ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(strWhere);
			}
			return SqlHelper.Query(strSql.ToString());
		}

        /// <summary>
        /// 取的所有的入学年份
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetInYearList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct '20' + left(STUNO,2) AS InYear");
            strSql.Append(" FROM STUDENT_INFO ");

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
			strSql.Append(" STUNO,CLASSNO,NAME,IDCARD,SEX,NATION,POLITICAL,SOURCE,INTENTEDDATE,GRADUATIONDATE,PHONE,EMAIL,DORMITORY_ID,FATHERPHONE,MOTHERPHONE,FAMILYPHONE,FAMILYADDRESS,ZIPCODE,QQNO,MICROMESSAGENO,PICTURE,STATUS ");
			strSql.Append(" FROM STUDENT_INFO ");
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
			strSql.Append("select count(1) FROM STUDENT_INFO ");
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
			strSql.Append(")AS Row, T.*  from STUDENT_INFO T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return SqlHelper.Query(strSql.ToString());
		}

        /// <summary>
        /// 创建学年-班级-学生列表，分配指导教师功能专用
        /// </summary>
        /// <param name="termno"></param>
        /// <param name="workflowno"></param>
        /// <returns></returns>
        public DataSet GetStudentNodeList(int termno,int workflowno)
        {
            SqlParameter[] commandParameters = new SqlParameter[] { 
                new SqlParameter("@TERMNO", SqlDbType.Int),
					new SqlParameter("@WORKFLOWNO", SqlDbType.Int)                   
                };
            commandParameters[0].Value = termno;
            commandParameters[1].Value = workflowno;
            return SqlHelper.RunProcedure("Pro_CreateClassStucture_WorkFlow", commandParameters, "tb");
        }

        /// <summary>
        /// 创建学年-班级-学生列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetStudentNodeList()
        {
            SqlParameter[] commandParameters = new SqlParameter[] {                 
                };
            return SqlHelper.RunProcedure("Pro_CreateClassStucture", commandParameters, "tb");
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
			parameters[0].Value = "STUDENT_INFO";
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

