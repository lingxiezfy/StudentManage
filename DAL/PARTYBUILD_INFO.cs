/**  版本信息模板在安装目录下，可自行修改。
* PARTYBUILD_INFO.cs
*
* 功 能： N/A
* 类 名： PARTYBUILD_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:17   N/A    初版
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
	/// 数据访问类:PARTYBUILD_INFO
	/// </summary>
	public partial class PARTYBUILD_INFO
	{
		public PARTYBUILD_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal RCD_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PARTYBUILD_INFO");
			strSql.Append(" where RCD_ID=@RCD_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@RCD_ID", SqlDbType.Decimal)
			};
			parameters[0].Value = RCD_ID;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(Student.Model.PARTYBUILD_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PARTYBUILD_INFO(");
			strSql.Append("CLASSNO,STUNO,TERMNO,STATUS,APPLICATIONTM,EXCELLENTTM,PREPARATIONTM,MEMBERTM,MEMO)");
			strSql.Append(" values (");
			strSql.Append("@CLASSNO,@STUNO,@TERMNO,@STATUS,@APPLICATIONTM,@EXCELLENTTM,@PREPARATIONTM,@MEMBERTM,@MEMO)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CLASSNO", SqlDbType.Int,4),
					new SqlParameter("@STUNO", SqlDbType.VarChar,10),
					new SqlParameter("@TERMNO", SqlDbType.Int,4),
					new SqlParameter("@STATUS", SqlDbType.Int,4),
					new SqlParameter("@APPLICATIONTM", SqlDbType.DateTime),
					new SqlParameter("@EXCELLENTTM", SqlDbType.DateTime),
					new SqlParameter("@PREPARATIONTM", SqlDbType.DateTime),
					new SqlParameter("@MEMBERTM", SqlDbType.DateTime),
					new SqlParameter("@MEMO", SqlDbType.VarChar,200)};
			parameters[0].Value = model.CLASSNO;
			parameters[1].Value = model.STUNO;
			parameters[2].Value = model.TERMNO;
			parameters[3].Value = model.STATUS;
			parameters[4].Value = model.APPLICATIONTM;
			parameters[5].Value = model.EXCELLENTTM;
			parameters[6].Value = model.PREPARATIONTM;
			parameters[7].Value = model.MEMBERTM;
			parameters[8].Value = model.MEMO;

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
		public bool Update(Student.Model.PARTYBUILD_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PARTYBUILD_INFO set ");
			strSql.Append("CLASSNO=@CLASSNO,");
			strSql.Append("STUNO=@STUNO,");
			strSql.Append("TERMNO=@TERMNO,");
			strSql.Append("STATUS=@STATUS,");
			strSql.Append("APPLICATIONTM=@APPLICATIONTM,");
			strSql.Append("EXCELLENTTM=@EXCELLENTTM,");
			strSql.Append("PREPARATIONTM=@PREPARATIONTM,");
			strSql.Append("MEMBERTM=@MEMBERTM,");
			strSql.Append("MEMO=@MEMO");
			strSql.Append(" where RCD_ID=@RCD_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@CLASSNO", SqlDbType.Int,4),
					new SqlParameter("@STUNO", SqlDbType.VarChar,10),
					new SqlParameter("@TERMNO", SqlDbType.Int,4),
					new SqlParameter("@STATUS", SqlDbType.Int,4),
					new SqlParameter("@APPLICATIONTM", SqlDbType.DateTime),
					new SqlParameter("@EXCELLENTTM", SqlDbType.DateTime),
					new SqlParameter("@PREPARATIONTM", SqlDbType.DateTime),
					new SqlParameter("@MEMBERTM", SqlDbType.DateTime),
					new SqlParameter("@MEMO", SqlDbType.VarChar,200),
					new SqlParameter("@RCD_ID", SqlDbType.Decimal,9)};
			parameters[0].Value = model.CLASSNO;
			parameters[1].Value = model.STUNO;
			parameters[2].Value = model.TERMNO;
			parameters[3].Value = model.STATUS;
			parameters[4].Value = model.APPLICATIONTM;
			parameters[5].Value = model.EXCELLENTTM;
			parameters[6].Value = model.PREPARATIONTM;
			parameters[7].Value = model.MEMBERTM;
			parameters[8].Value = model.MEMO;
			parameters[9].Value = model.RCD_ID;

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
		public bool Delete(decimal RCD_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PARTYBUILD_INFO ");
			strSql.Append(" where RCD_ID=@RCD_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@RCD_ID", SqlDbType.Decimal)
			};
			parameters[0].Value = RCD_ID;

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
		public bool DeleteList(string RCD_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PARTYBUILD_INFO ");
			strSql.Append(" where RCD_ID in ("+RCD_IDlist + ")  ");
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
		public Student.Model.PARTYBUILD_INFO GetModel(decimal RCD_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 RCD_ID,CLASSNO,STUNO,TERMNO,STATUS,APPLICATIONTM,EXCELLENTTM,PREPARATIONTM,MEMBERTM,MEMO from PARTYBUILD_INFO ");
			strSql.Append(" where RCD_ID=@RCD_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@RCD_ID", SqlDbType.Decimal)
			};
			parameters[0].Value = RCD_ID;

			Student.Model.PARTYBUILD_INFO model=new Student.Model.PARTYBUILD_INFO();
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
		public Student.Model.PARTYBUILD_INFO DataRowToModel(DataRow row)
		{
			Student.Model.PARTYBUILD_INFO model=new Student.Model.PARTYBUILD_INFO();
			if (row != null)
			{
				if(row["RCD_ID"]!=null && row["RCD_ID"].ToString()!="")
				{
					model.RCD_ID=decimal.Parse(row["RCD_ID"].ToString());
				}
				if(row["CLASSNO"]!=null && row["CLASSNO"].ToString()!="")
				{
					model.CLASSNO=int.Parse(row["CLASSNO"].ToString());
				}
				if(row["STUNO"]!=null)
				{
					model.STUNO=row["STUNO"].ToString();
				}
				if(row["TERMNO"]!=null && row["TERMNO"].ToString()!="")
				{
					model.TERMNO=int.Parse(row["TERMNO"].ToString());
				}
				if(row["STATUS"]!=null && row["STATUS"].ToString()!="")
				{
					model.STATUS=int.Parse(row["STATUS"].ToString());
				}
				if(row["APPLICATIONTM"]!=null && row["APPLICATIONTM"].ToString()!="")
				{
					model.APPLICATIONTM=DateTime.Parse(row["APPLICATIONTM"].ToString());
				}
				if(row["EXCELLENTTM"]!=null && row["EXCELLENTTM"].ToString()!="")
				{
					model.EXCELLENTTM=DateTime.Parse(row["EXCELLENTTM"].ToString());
				}
				if(row["PREPARATIONTM"]!=null && row["PREPARATIONTM"].ToString()!="")
				{
					model.PREPARATIONTM=DateTime.Parse(row["PREPARATIONTM"].ToString());
				}
				if(row["MEMBERTM"]!=null && row["MEMBERTM"].ToString()!="")
				{
					model.MEMBERTM=DateTime.Parse(row["MEMBERTM"].ToString());
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
			strSql.Append("select RCD_ID,CLASSNO,STUNO,TERMNO,STATUS,APPLICATIONTM,EXCELLENTTM,PREPARATIONTM,MEMBERTM,MEMO ");
			strSql.Append(" FROM PARTYBUILD_INFO ");
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
			strSql.Append(" RCD_ID,CLASSNO,STUNO,TERMNO,STATUS,APPLICATIONTM,EXCELLENTTM,PREPARATIONTM,MEMBERTM,MEMO ");
			strSql.Append(" FROM PARTYBUILD_INFO ");
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
			strSql.Append("select count(1) FROM PARTYBUILD_INFO ");
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
				strSql.Append("order by T.RCD_ID desc");
			}
			strSql.Append(")AS Row, T.*  from PARTYBUILD_INFO T ");
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
			parameters[0].Value = "PARTYBUILD_INFO";
			parameters[1].Value = "RCD_ID";
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

