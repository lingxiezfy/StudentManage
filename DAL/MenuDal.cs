using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.DBUtility;
using Student.Model;

namespace Student.DAL
{
    class MenuDal
    {
        public IList<MenuMdl> GetAllMenuList()
        {
            IList<MenuMdl> list = new List<MenuMdl>();
            //using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringProfile, CommandType.Text, "Select * From B_RBAC_FUNC ORDER BY FUNC_ID", new SqlParameter[0]))
            //{
            //    while (reader.Read())
            //    {
            //        MenuMdl item = new MenuMdl();
            //        item.Caption = reader["FUNC_DESC"].ToString();
            //        item.ID = int.Parse(reader["FUNC_ID"].ToString());
            //        item.Code = reader["FUNC_CDE"].ToString();
            //        item.Para = reader["FUNC_Para"].ToString();
            //        list.Add(item);
            //    }
            //}
            return list;
        }

        public IList<MenuMdl> GetUserWinMenu(string sOprCode)
        {
            IList<MenuMdl> list = new List<MenuMdl>();
            SqlParameter[] commandParameters = new SqlParameter[] { new SqlParameter("@sOprCode", SqlDbType.NVarChar, 50) };
            commandParameters[0].Value = sOprCode;
            //using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringProfile, CommandType.StoredProcedure, "Pro_GetUserWinMenu", commandParameters))
            //{
            //    while (reader.Read())
            //    {
            //        MenuMdl item = new MenuMdl();
            //        item.Caption = reader["FUNC_DESC"].ToString();
            //        item.ID = int.Parse(reader["FUNC_ID"].ToString());
            //        item.Code = reader["FUNC_CDE"].ToString();
            //        item.Para = reader["FUNC_Para"].ToString();
            //        list.Add(item);
            //    }
            //}
            return list;
        }
    }
}
