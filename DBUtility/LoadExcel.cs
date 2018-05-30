using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using System.Reflection;


namespace CalcGateOpening
{
    class LoadExcel
    {
        
        public string strExcelPositionAndName;      //excel存储路径和文件名
        //public int removeRowNum;
        public System.Data.DataTable dataTable;

        public System.Data.DataTable ComposeDataSet()                                             //读取excel表
        {
            string excelStr = @"Provider=Microsoft.Ace.OleDb.12.0;Data Source=" + strExcelPositionAndName + ";Extended Properties='Excel 12.0 Xml; HDR=YES; IMEX=1'";
            OleDbConnection conn = new OleDbConnection(excelStr);
            conn.Open();
            System.Data.DataTable schemaTable = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, null);
            string tableName = schemaTable.Rows[0][2].ToString().Trim();                        //获取excel表中第一张表的表名  
            string excelSelcetStr = "select * from [" + tableName + "]";

            OleDbDataAdapter sda = new OleDbDataAdapter(excelSelcetStr, excelStr);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            return dt;
        }

        public System.Data.DataTable RemoveRow(System.Data.DataTable dt, int removeRowNumber)  // //删除表的前几行（如标题）
        {
            int removeRN = removeRowNumber;
            if (removeRN > 0)                                              
            {
                for (int i = 0; i < removeRN; i++)
                    dt.Rows.RemoveAt(i);
            }
            return dt;
        }
        
    }
}
