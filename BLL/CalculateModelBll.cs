using Student.DBUtility;
using DevExpress.XtraCharts;
using Student.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Student.BLL
{
    class CalculateModelBll
    {

        /// <summary>
        /// 读入参数输入文件，返回文件内容
        /// </summary>
        /// <param name="ParaFileName"></param>
        /// <returns></returns>
        internal String ParseParaFile(string ParaFileName)
        {
            StreamReader reader = new StreamReader(ParaFileName, Encoding.Default);
            var Content = new StringBuilder();

            string line = null;
            while ((line = reader.ReadLine()) != null)
            {
                Content.AppendLine(line + ",");
            }

            reader.Close();
            return Content.ToString();
        }


        /// <summary>
        /// 打开参数输入文件，并将最大迭代次数和每次的子个体迭代数填入,再保存
        /// </summary>
        /// <param name="ParaFileName"></param>
        /// <param name="WaterLevel"></param>
        /// <param name="InstantFlow"></param>
        /// <returns></returns>
        public void ModelParaInputFile(string ParaFileName, int MaxIterationTime, int SonIterationTime)
        {
            var Content = new StringBuilder();

            Content.Append(MaxIterationTime.ToString() + "\r\n");
            Content.Append(SonIterationTime.ToString());            

            StreamWriter oWriter = new StreamWriter(ParaFileName, false, Encoding.Default);
            oWriter.Write(Content);
            oWriter.Close();
        }

      /// <summary>
        /// 打开输入文件，并将数值填入,再保存
      /// </summary>
      /// <param name="ParaFileName"></param>
      /// <param name="data"></param>
      /// <param name="num"></param>
        public void InputFile(string ParaFileName, double [] data, int num)
        {
            var Content = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                Content.Append(data[i].ToString() + "\r\n");
            }

            StreamWriter oWriter = new StreamWriter(ParaFileName, false, Encoding.Default);
            oWriter.Write(Content);
            oWriter.Close();
        }

        /// <summary>
        /// 创建卡拉贝利水库长系列来水过程的dataTable
        /// </summary>
        /// <param name="ParaFileName"></param>
        public DataSet createTable_klbl(string ParaFileName)
        {
            DataSet ds = new DataSet();
            DateTime yearMonth = DateTime.Parse("1958-7-1 00:00:00");

            using (DataTable dt = new DataTable("SKSJ"))
            {
                //创建列
                DataColumn dtc = new DataColumn("时间", typeof(DateTime));
                dt.Columns.Add(dtc);

                dtc = new DataColumn("水量", typeof(Int32));
                dt.Columns.Add(dtc);

                //读数据
                StreamReader reader = new StreamReader(ParaFileName, Encoding.Default);

                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    DataRow dr = dt.NewRow();

                    dr["时间"] = yearMonth;
                    dr["水量"] = Int32.Parse(line);
                    dt.Rows.Add(dr);
                    yearMonth = yearMonth.AddMonths(1);
                }

                reader.Close();

                ds.Tables.Add(dt);

                return ds;
            }
        }

             /// <summary>
        /// 创建卡浪吕克沟长系列来水过程的dataTable
        /// </summary>
        /// <param name="ParaFileName"></param>
        public DataSet createTable_kllk(string ParaFileName)
        {
            DataSet ds = new DataSet();
            DateTime yearMonth = DateTime.Parse("1958-7-1 00:00:00");

            using (DataTable dt = new DataTable("SKSJ"))
            {
                //创建列
                DataColumn dtc = new DataColumn("时间", typeof(DateTime));
                dt.Columns.Add(dtc);

                dtc = new DataColumn("水量", typeof(Double));
                dt.Columns.Add(dtc);

                //读数据
                StreamReader reader = new StreamReader(ParaFileName, Encoding.Default);

                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    DataRow dr = dt.NewRow();
                    
                    dr["时间"] = yearMonth;
                    dr["水量"] = Double.Parse(line);
                    dt.Rows.Add(dr);
                    yearMonth = yearMonth.AddMonths(1);
                }

                reader.Close();                      
               
                ds.Tables.Add(dt);

                return ds;
            }
        }


        /// <summary>
        /// 创建汇总灌区分水情况的的dataTable
        /// </summary>
        /// <param name="ParaFileName"></param>
        public DataSet createTable_All(string ParaFileName)
        {
            DataSet ds = new DataSet();
            DateTime yearMonth = DateTime.Parse("1958-7-1 00:00:00");
            string[] fields = {"时间", "灌区分水", "非农需水", "非农缺水", "非农放水", "调整后非农缺水", "非农余水", "灌溉缺水", "可蓄水量", "灌区蓄水", "水库供水", "月末库存", "地下水供水", "联合调度缺水", "超采水量" };

            using (DataTable dt = new DataTable("SKSJ"))
            {
                //创建列
                DataColumn dtc = new DataColumn(fields[0], typeof(DateTime));
                dt.Columns.Add(dtc);

                dtc = new DataColumn(fields[1], typeof(Double));
                dt.Columns.Add(dtc);

                dtc = new DataColumn(fields[2], typeof(Double));
                dt.Columns.Add(dtc);

                dtc = new DataColumn(fields[3], typeof(Double));
                dt.Columns.Add(dtc);

                dtc = new DataColumn(fields[4], typeof(Double));
                dt.Columns.Add(dtc);

                dtc = new DataColumn(fields[5], typeof(Double));
                dt.Columns.Add(dtc);

                dtc = new DataColumn(fields[6], typeof(Double));
                dt.Columns.Add(dtc);

                dtc = new DataColumn(fields[7], typeof(Double));
                dt.Columns.Add(dtc);

                dtc = new DataColumn(fields[8], typeof(Double));
                dt.Columns.Add(dtc);

                dtc = new DataColumn(fields[9], typeof(Double));
                dt.Columns.Add(dtc);

                dtc = new DataColumn(fields[10], typeof(Double));
                dt.Columns.Add(dtc);

                dtc = new DataColumn(fields[11], typeof(Double));
                dt.Columns.Add(dtc);

                dtc = new DataColumn(fields[12], typeof(Double));
                dt.Columns.Add(dtc);

                dtc = new DataColumn(fields[13], typeof(Double));
                dt.Columns.Add(dtc);

                dtc = new DataColumn(fields[14], typeof(Double));
                dt.Columns.Add(dtc);

             

                //读数据
                StreamReader reader = new StreamReader(ParaFileName, Encoding.Default);

                string line = reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    DataRow dr = dt.NewRow();
                    line = Regex.Replace(line.Trim(), "\\s+", " "); 
                    string[] str = line.Trim().Split(new Char[] {' '});
                    dr[fields[0]] = yearMonth;
                    dr[fields[1]] = Double.Parse(str[0]);
                    dr[fields[2]] = Double.Parse(str[1]);
                    dr[fields[3]] = Double.Parse(str[2]);
                    dr[fields[4]] = Double.Parse(str[3]);
                    dr[fields[5]] = Double.Parse(str[4]);
                    dr[fields[6]] = Double.Parse(str[5]);
                    dr[fields[7]] = Double.Parse(str[6]);
                    dr[fields[8]] = Double.Parse(str[7]);
                    dr[fields[9]] = Double.Parse(str[8]);
                    dr[fields[10]] = Double.Parse(str[9]);
                    dr[fields[11]] = Double.Parse(str[10]);
                    dr[fields[12]] = Double.Parse(str[11]);
                    dr[fields[13]] = Double.Parse(str[12]);
                    dr[fields[14]] = Double.Parse(str[13]);
                    
                    dt.Rows.Add(dr);
                    yearMonth = yearMonth.AddMonths(1);
                }

                reader.Close();

                ds.Tables.Add(dt);

                return ds;
            }
        }

       
        /// <summary>
        /// 画折线方法
        /// </summary>
        /// <param name="chartControl"></param>
        /// <param name="dt"></param>
        /// <param name="fieldN"></param>
        /// <param name="seriesN"></param>
        /// <param name="title"></param>
        public void DrawDiagram(ChartControl chartControl, DataTable dt, string[] fieldN, string[] seriesN, string title)
        {
            Color[] COLORS = new Color[] { Color.Blue, Color.Orange,Color.Black,Color.Crimson,Color.Brown,Color.BurlyWood,Color.Cyan };
            Color[] COLORS2 = new Color[] { Color.LightGreen, Color.LightPink };

            chartControl.ClearCache();
            //chartControl.Dispose();

            for (int i = 0; i < seriesN.Count(); i++)
            {
                Series series = new Series(seriesN[i], ViewType.Line);
                series.DataSource = dt;
                series.ArgumentScaleType = ScaleType.DateTime;                                                         //x轴参数类型
                series.ArgumentDataMember = "时间";                                                                  //x轴获取指定字段的列
                series.ValueDataMembers.AddRange(seriesN[i]);                                                       //y轴获取指定字段的列
                ((LineSeriesView)series.View).Color = COLORS[i];
                chartControl.Series.Add(series);
            }

            XYDiagram diagram = (XYDiagram)chartControl.Diagram;
            diagram.Panes.Clear();
            diagram.AxisY.Title.Text = "";
            diagram.SecondaryAxesY.Clear();

            diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Day;                            //最小刻度
            diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Month;                          //最小显示刻度

            diagram.AxisX.DateTimeOptions.Format = DateTimeFormat.Custom;
            diagram.AxisX.DateTimeOptions.FormatString = "yyyy-MM";
            diagram.AxisX.MinorCount = 1; 

            diagram.AxisX.Title.Visible = true;
            diagram.AxisY.Title.Visible = true;


            diagram.AxisX.Title.Text = "时间";

            diagram.AxisY.Title.Alignment = StringAlignment.Far;
            diagram.AxisY.Title.Visible = true;
            diagram.AxisY.Title.Font = new Font("宋体", 9.0f);
            diagram.AxisX.Title.Alignment = StringAlignment.Far;
            diagram.AxisX.Title.Visible = true;
            diagram.AxisX.Title.Font = new Font("宋体", 9.0f);

            ((XYDiagram)chartControl.Diagram).EnableAxisXZooming = true;                                           //允许x轴缩放
            ((XYDiagram)chartControl.Diagram).EnableAxisXScrolling = true;                                         //允许x轴移动
            ((XYDiagram)chartControl.Diagram).EnableAxisYScrolling = true;                                          // 允许 y轴移动
            ((XYDiagram)chartControl.Diagram).EnableAxisYZooming = true;                                          // 允许 y 轴缩放
            chartControl.CrosshairOptions.ShowArgumentLabels = true;                                               //移动鼠标时动态显示Y轴数据标签
            chartControl.CrosshairOptions.ShowArgumentLine = true;                                                 //显示Y轴线
            chartControl.CrosshairOptions.ArgumentLineColor = Color.Blue;
            chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;                                 //增加示意图
            chartControl.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Left;

            chartControl.Titles.Add(new ChartTitle());                                                             //增加表名
            chartControl.Titles[0].Text = title;
        }


        public void CallModel(string ExeFileName)
        {            
            using (Process process = new Process())
            {
                MyWaitDialogForm dialog = new MyWaitDialogForm();
                process.StartInfo.FileName = ExeFileName;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                //string output = process.StandardOutput.ReadToEnd();
                ////OutputInfo.AppendLine(output);

                //string err = process.StandardError.ReadToEnd();
                //if (!string.IsNullOrEmpty(err))
                //{
                //    OutputInfo.AppendLine("Error:" + err);
                //}
                process.WaitForExit();
                process.Close();
                dialog.Close();
            }            
        }

        /// <summary>
        /// 生成totalReport的dateset
        /// </summary>
        /// <param name="ParaFileName"></param>
        /// <returns></returns>
        public DataSet createTable_TotalReport(string ParaFileName)
        {
            DataSet ds = new DataSet();
            
            using (DataTable dt = new DataTable("SKSJ"))
            {
                //创建列
                DataColumn dtc = new DataColumn("灌区名称", typeof(String));
                dt.Columns.Add(dtc);

                dtc = new DataColumn("地下水用水总量", typeof(String));
                dt.Columns.Add(dtc);
                
                dtc = new DataColumn("年均地下水用水量", typeof(String));
                dt.Columns.Add(dtc);

                dtc = new DataColumn("年均可调节地下水量", typeof(String));
                dt.Columns.Add(dtc);

                dtc = new DataColumn("年均地表水用水总量", typeof(String));
                dt.Columns.Add(dtc);

                dtc = new DataColumn("年均地表水上限", typeof(String));
                dt.Columns.Add(dtc);

                dtc = new DataColumn("灌溉缺水总量", typeof(String));
                dt.Columns.Add(dtc);

                //读数据
                StreamReader reader = new StreamReader(ParaFileName, Encoding.Default);

                string line = null;
                int i = 0;
                string[] str1 = { "" }, str2 = { "" }, str3 = { "" }, str4 = { "" };
                while ((line = reader.ReadLine()) != null)
                {
                    i++;
                    if (i < 12)
                        continue;
                    line = Regex.Replace(line.Trim(), "\\s+", " ");
                    if(i == 12)
                    {                        
                        str1 = line.Trim().Split(new Char[] { ' ' });
                    }
                    if (i == 13)
                    {
                        str2 = line.Trim().Split(new Char[] { ' ' });
                    }
                    if (i == 14)
                    {
                        str3 = line.Trim().Split(new Char[] { ' ' });
                    }
                    if (i == 15)
                    {
                        str4 = line.Trim().Split(new Char[] { ' ' });
                        DataRow dr = dt.NewRow();
                        dr["灌区名称"] = "喀什市灌区";
                        dr["地下水用水总量"] = str1[1];
                        dr["年均地下水用水量"] = str2[1];
                        dr["年均可调节地下水量"] = str2[3];
                        dr["年均地表水用水总量"] = str3[1];
                        dr["年均地表水上限"] = str3[3];
                        dr["灌溉缺水总量"] = str4[1];
                        dt.Rows.Add(dr);
                    }


                    if (i == 17)
                    {
                        str1 = line.Trim().Split(new Char[] { ' ' });
                    }
                    if (i == 18)
                    {
                        str2 = line.Trim().Split(new Char[] { ' ' });
                    }
                    if (i == 19)
                    {
                        str3 = line.Trim().Split(new Char[] { ' ' });
                    }
                    if (i == 20)
                    {
                        str4 = line.Trim().Split(new Char[] { ' ' });
                        DataRow dr = dt.NewRow();
                        dr["灌区名称"] = "西克尔灌区";
                        dr["地下水用水总量"] = str1[1];
                        dr["年均地下水用水量"] = str2[1];
                        dr["年均可调节地下水量"] = str2[3];
                        dr["年均地表水用水总量"] = str3[1];
                        dr["年均地表水上限"] = str3[3];
                        dr["灌溉缺水总量"] = str4[1];
                        dt.Rows.Add(dr);
                    }

                    if (i == 22)
                    {
                        str1 = line.Trim().Split(new Char[] { ' ' });
                    }
                    if (i == 23)
                    {
                        str2 = line.Trim().Split(new Char[] { ' ' });
                    }
                    if (i == 24)
                    {
                        str3 = line.Trim().Split(new Char[] { ' ' });
                    }
                    if (i == 25)
                    {
                        str4 = line.Trim().Split(new Char[] { ' ' });
                        DataRow dr = dt.NewRow();
                        dr["灌区名称"] = "其它灌区";
                        dr["地下水用水总量"] = str1[1];
                        dr["年均地下水用水量"] = str2[1];
                        dr["年均可调节地下水量"] = str2[3];
                        dr["年均地表水用水总量"] = str3[1];
                        dr["年均地表水上限"] = str3[3];
                        dr["灌溉缺水总量"] = str4[1];
                        dt.Rows.Add(dr);
                    }
                }

                reader.Close();

                ds.Tables.Add(dt);

                return ds;
            }
        }
    }
}
