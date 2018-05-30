/**  版本信息模板在安装目录下，可自行修改。
* ENTERPRISE_INFO.cs
*
* 功 能： N/A
* 类 名： ENTERPRISE_INFO
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
	/// 数据访问类:ENTERPRISE_INFO
	/// </summary>
	public partial class ENTERPRISE_INFO
	{
		public ENTERPRISE_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal ENTNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ENTERPRISE_INFO");
			strSql.Append(" where ENTNO=@ENTNO");
			SqlParameter[] parameters = {
					new SqlParameter("@ENTNO", SqlDbType.Decimal)
			};
			parameters[0].Value = ENTNO;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(Student.Model.ENTERPRISE_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ENTERPRISE_INFO(");
			strSql.Append("ENTNAME,ENTADDRESS,LINKER1,PHONE1,LINKER2,PHONE2,LINKER3,PHONE3,MEMO,DEMAND)");
			strSql.Append(" values (");
			strSql.Append("@ENTNAME,@ENTADDRESS,@LINKER1,@PHONE1,@LINKER2,@PHONE2,@LINKER3,@PHONE3,@MEMO,@DEMAND)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ENTNAME", SqlDbType.VarChar,200),
					new SqlParameter("@ENTADDRESS", SqlDbType.VarChar,200),
					new SqlParameter("@LINKER1", SqlDbType.VarChar,20),
					new SqlParameter("@PHONE1", SqlDbType.VarChar,20),
					new SqlParameter("@LINKER2", SqlDbType.VarChar,20),
					new SqlParameter("@PHONE2", SqlDbType.VarChar,20),
					new SqlParameter("@LINKER3", SqlDbType.VarChar,20),
					new SqlParameter("@PHONE3", SqlDbType.VarChar,20),
					new SqlParameter("@MEMO", SqlDbType.VarChar,200),
					new SqlParameter("@DEMAND", SqlDbType.VarChar,200)};
			parameters[0].Value = model.ENTNAME;
			parameters[1].Value = model.ENTADDRESS;
			parameters[2].Value = model.LINKER1;
			parameters[3].Value = model.PHONE1;
			parameters[4].Value = model.LINKER2;
			parameters[5].Value = model.PHONE2;
			parameters[6].Value = model.LINKER3;
			parameters[7].Value = model.PHONE3;
			parameters[8].Value = model.MEMO;
			parameters[9].Value = model.DEMAND;

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
		public bool Update(Student.Model.ENTERPRISE_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ENTERPRISE_INFO set ");
			strSql.Append("ENTNAME=@ENTNAME,");
			strSql.Append("ENTADDRESS=@ENTADDRESS,");
			strSql.Append("LINKER1=@LINKER1,");
			strSql.Append("PHONE1=@PHONE1,");
			strSql.Append("LINKER2=@LINKER2,");
			strSql.Append("PHONE2=@PHONE2,");
			strSql.Append("LINKER3=@LINKER3,");
			strSql.Append("PHONE3=@PHONE3,");
			strSql.Append("MEMO=@MEMO,");
			strSql.Append("DEMAND=@DEMAND");
			strSql.Append(" where ENTNO=@ENTNO");
			SqlParameter[] parameters = {
					new SqlParameter("@ENTNAME", SqlDbType.VarChar,200),
					new SqlParameter("@ENTADDRESS", SqlDbType.VarChar,200),
					new SqlParameter("@LINKER1", SqlDbType.VarChar,20),
					new SqlParameter("@PHONE1", SqlDbType.VarChar,20),
					new SqlParameter("@LINKER2", SqlDbType.VarChar,20),
					new SqlParameter("@PHONE2", SqlDbType.VarChar,20),
					new SqlParameter("@LINKER3", SqlDbType.VarChar,20),
					new SqlParameter("@PHONE3", SqlDbType.VarChar,20),
					new SqlParameter("@MEMO", SqlDbType.VarChar,200),
					new SqlParameter("@DEMAND", SqlDbType.VarChar,200),
					new SqlParameter("@ENTNO", SqlDbType.Decimal,9)};
			parameters[0].Value = model.ENTNAME;
			parameters[1].Value = model.ENTADDRESS;
			parameters[2].Value = model.LINKER1;
			parameters[3].Value = model.PHONE1;
			parameters[4].Value = model.LINKER2;
			parameters[5].Value = model.PHONE2;
			parameters[6].Value = model.LINKER3;
			parameters[7].Value = model.PHONE3;
			parameters[8].Value = model.MEMO;
			parameters[9].Value = model.DEMAND;
			parameters[10].Value = model.ENTNO;

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
		public bool Delete(decimal ENTNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ENTERPRISE_INFO ");
			strSql.Append(" where ENTNO=@ENTNO");
			SqlParameter[] parameters = {
					new SqlParameter("@ENTNO", SqlDbType.Decimal)
			};
			parameters[0].Value = ENTNO;

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
		public bool DeleteList(string ENTNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ENTERPRISE_INFO ");
			strSql.Append(" where ENTNO in ("+ENTNOlist + ")  ");
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
        /// 根据企业编号查询
		/// </summary>
		public Student.Model.ENTERPRISE_INFO GetModel(decimal ENTNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ENTNO,ENTNAME,ENTADDRESS,LINKER1,PHONE1,LINKER2,PHONE2,LINKER3,PHONE3,MEMO,DEMAND from ENTERPRISE_INFO ");
			strSql.Append(" where ENTNO=@ENTNO");
			SqlParameter[] parameters = {
					new SqlParameter("@ENTNO", SqlDbType.Decimal)
			};
			parameters[0].Value = ENTNO;

			Student.Model.ENTERPRISE_INFO model=new Student.Model.ENTERPRISE_INFO();
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
        /// 根据企业名称查询
        /// </summary>
        public Student.Model.ENTERPRISE_INFO GetModel(string ENTNAME)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ENTNO,ENTNAME,ENTADDRESS,LINKER1,PHONE1,LINKER2,PHONE2,LINKER3,PHONE3,MEMO,DEMAND from ENTERPRISE_INFO ");
            strSql.Append(" where ENTNAME=@ENTNAME");
            SqlParameter[] parameters = {
					new SqlParameter("@ENTNAME", SqlDbType.VarChar,200)
			};
            parameters[0].Value = ENTNAME;

            Student.Model.ENTERPRISE_INFO model = new Student.Model.ENTERPRISE_INFO();
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
		public Student.Model.ENTERPRISE_INFO DataRowToModel(DataRow row)
		{
			Student.Model.ENTERPRISE_INFO model=new Student.Model.ENTERPRISE_INFO();
			if (row != null)
			{
				if(row["ENTNO"]!=null && row["ENTNO"].ToString()!="")
				{
					model.ENTNO=decimal.Parse(row["ENTNO"].ToString());
				}
				if(row["ENTNAME"]!=null)
				{
					model.ENTNAME=row["ENTNAME"].ToString();
				}
				if(row["ENTADDRESS"]!=null)
				{
					model.ENTADDRESS=row["ENTADDRESS"].ToString();
				}
				if(row["LINKER1"]!=null)
				{
					model.LINKER1=row["LINKER1"].ToString();
				}
				if(row["PHONE1"]!=null)
				{
					model.PHONE1=row["PHONE1"].ToString();
				}
				if(row["LINKER2"]!=null)
				{
					model.LINKER2=row["LINKER2"].ToString();
				}
				if(row["PHONE2"]!=null)
				{
					model.PHONE2=row["PHONE2"].ToString();
				}
				if(row["LINKER3"]!=null)
				{
					model.LINKER3=row["LINKER3"].ToString();
				}
				if(row["PHONE3"]!=null)
				{
					model.PHONE3=row["PHONE3"].ToString();
				}
				if(row["MEMO"]!=null)
				{
					model.MEMO=row["MEMO"].ToString();
				}
				if(row["DEMAND"]!=null)
				{
					model.DEMAND=row["DEMAND"].ToString();
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
			strSql.Append("select ENTNO,ENTNAME,ENTADDRESS,LINKER1,PHONE1,LINKER2,PHONE2,LINKER3,PHONE3,MEMO,DEMAND ");
			strSql.Append(" FROM ENTERPRISE_INFO ");
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
			strSql.Append(" ENTNO,ENTNAME,ENTADDRESS,LINKER1,PHONE1,LINKER2,PHONE2,LINKER3,PHONE3,MEMO,DEMAND ");
			strSql.Append(" FROM ENTERPRISE_INFO ");
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
			strSql.Append("select count(1) FROM ENTERPRISE_INFO ");
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
				strSql.Append("order by T.ENTNO desc");
			}
			strSql.Append(")AS Row, T.*  from ENTERPRISE_INFO T ");
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
			parameters[0].Value = "ENTERPRISE_INFO";
			parameters[1].Value = "ENTNO";
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

