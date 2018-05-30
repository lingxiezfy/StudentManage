/**  版本信息模板在安装目录下，可自行修改。
* MATERIAL_INFO.cs
*
* 功 能： N/A
* 类 名： MATERIAL_INFO
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/30 星期日 22:59:15   N/A    初版
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
	/// 数据访问类:MATERIAL_INFO
	/// </summary>
	public partial class MATERIAL_INFO
	{
		public MATERIAL_INFO()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal MATERIALNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MATERIAL_INFO");
			strSql.Append(" where MATERIALNO=@MATERIALNO");
			SqlParameter[] parameters = {
					new SqlParameter("@MATERIALNO", SqlDbType.Decimal)
			};
			parameters[0].Value = MATERIALNO;

			return SqlHelper.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public decimal Add(Student.Model.MATERIAL_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MATERIAL_INFO(");
			strSql.Append("MATERIALNAME,TEMPLATE,MEMO)");
			strSql.Append(" values (");
			strSql.Append("@MATERIALNAME,@TEMPLATE,@MEMO)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MATERIALNAME", SqlDbType.VarChar,50),
					new SqlParameter("@TEMPLATE", SqlDbType.Image),
					new SqlParameter("@MEMO", SqlDbType.VarChar,200)};
			parameters[0].Value = model.MATERIALNAME;
			parameters[1].Value = model.TEMPLATE;
			parameters[2].Value = model.MEMO;

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
        /// 有文件模板数据更新
		/// </summary>
		public bool Update(Student.Model.MATERIAL_INFO model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MATERIAL_INFO set ");
			strSql.Append("MATERIALNAME=@MATERIALNAME,");
			strSql.Append("TEMPLATE=@TEMPLATE,");
			strSql.Append("MEMO=@MEMO");
			strSql.Append(" where MATERIALNO=@MATERIALNO");
			SqlParameter[] parameters = {
					new SqlParameter("@MATERIALNAME", SqlDbType.VarChar,50),
					new SqlParameter("@TEMPLATE", SqlDbType.Image),
					new SqlParameter("@MEMO", SqlDbType.VarChar,200),
					new SqlParameter("@MATERIALNO", SqlDbType.Decimal,9)};
			parameters[0].Value = model.MATERIALNAME;
			parameters[1].Value = model.TEMPLATE;
			parameters[2].Value = model.MEMO;
			parameters[3].Value = model.MATERIALNO;

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
        /// 无文件模板数据更新
        /// </summary>
        public bool Update(Student.Model.MATERIAL_INFO model,int flag)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MATERIAL_INFO set ");
            strSql.Append("MATERIALNAME=@MATERIALNAME,");
            strSql.Append("MEMO=@MEMO");
            strSql.Append(" where MATERIALNO=@MATERIALNO");
            SqlParameter[] parameters = {
					new SqlParameter("@MATERIALNAME", SqlDbType.VarChar,50),
					new SqlParameter("@MEMO", SqlDbType.VarChar,200),
					new SqlParameter("@MATERIALNO", SqlDbType.Decimal,9)};
            parameters[0].Value = model.MATERIALNAME;
            parameters[1].Value = model.MEMO;
            parameters[2].Value = model.MATERIALNO;

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
		public bool Delete(decimal MATERIALNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MATERIAL_INFO ");
			strSql.Append(" where MATERIALNO=@MATERIALNO");
			SqlParameter[] parameters = {
					new SqlParameter("@MATERIALNO", SqlDbType.Decimal)
			};
			parameters[0].Value = MATERIALNO;

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
		public bool DeleteList(string MATERIALNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MATERIAL_INFO ");
			strSql.Append(" where MATERIALNO in ("+MATERIALNOlist + ")  ");
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
        /// 根据材料编号查询
		/// </summary>
		public Student.Model.MATERIAL_INFO GetModel(decimal MATERIALNO)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MATERIALNO,MATERIALNAME,TEMPLATE,MEMO from MATERIAL_INFO ");
			strSql.Append(" where MATERIALNO=@MATERIALNO");
			SqlParameter[] parameters = {
					new SqlParameter("@MATERIALNO", SqlDbType.Decimal)
			};
			parameters[0].Value = MATERIALNO;

			Student.Model.MATERIAL_INFO model=new Student.Model.MATERIAL_INFO();
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
        /// 根据材料名称查询
        /// </summary>
        public Student.Model.MATERIAL_INFO GetModel(string MATERIALNAME)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 MATERIALNO,MATERIALNAME,TEMPLATE,MEMO from MATERIAL_INFO ");
            strSql.Append(" where MATERIALNAME=@MATERIALNAME");
            SqlParameter[] parameters = {
					new SqlParameter("@MATERIALNAME", SqlDbType.VarChar,50)
			};
            parameters[0].Value = MATERIALNAME;

            Student.Model.MATERIAL_INFO model = new Student.Model.MATERIAL_INFO();
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
		public Student.Model.MATERIAL_INFO DataRowToModel(DataRow row)
		{
			Student.Model.MATERIAL_INFO model=new Student.Model.MATERIAL_INFO();
			if (row != null)
			{
				if(row["MATERIALNO"]!=null && row["MATERIALNO"].ToString()!="")
				{
					model.MATERIALNO=decimal.Parse(row["MATERIALNO"].ToString());
				}
				if(row["MATERIALNAME"]!=null)
				{
					model.MATERIALNAME=row["MATERIALNAME"].ToString();
				}
				if(row["TEMPLATE"]!=null && row["TEMPLATE"].ToString()!="")
				{
					model.TEMPLATE=(byte[])row["TEMPLATE"];
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
			strSql.Append("select MATERIALNO,MATERIALNAME,TEMPLATE,MEMO ");
			strSql.Append(" FROM MATERIAL_INFO ");
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
			strSql.Append(" MATERIALNO,MATERIALNAME,TEMPLATE,MEMO ");
			strSql.Append(" FROM MATERIAL_INFO ");
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
			strSql.Append("select count(1) FROM MATERIAL_INFO ");
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
				strSql.Append("order by T.MATERIALNO desc");
			}
			strSql.Append(")AS Row, T.*  from MATERIAL_INFO T ");
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
			parameters[0].Value = "MATERIAL_INFO";
			parameters[1].Value = "MATERIALNO";
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

