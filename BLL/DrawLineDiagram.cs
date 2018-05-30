using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraCharts;

namespace Student.BLL
{
    class DrawLineDiagram
    {
        Color[] COLORS = new Color[] { Color.Blue, Color.Orange };
        Color[] COLORS2 = new Color[] { Color.LightGreen, Color.LightPink };
        public DrawLineDiagram()
        { 
            
        }
        

        public void DrawDiagram(ChartControl chartControl, DataTable dt, string[] fieldN, string[] seriesN, string title)
        {
            for (int i = 0; i < fieldN.Count(); i++)
            {
                Series series = new Series(seriesN[i], ViewType.Line);
                series.DataSource = dt;
                series.ArgumentScaleType = ScaleType.DateTime;                                                         //x轴参数类型
                series.ArgumentDataMember = "RTIME";                                                                  //x轴获取指定字段的列
                series.ValueDataMembers.AddRange(fieldN[i]);                                                       //y轴获取指定字段的列
                ((LineSeriesView)series.View).Color = COLORS[i];
                chartControl.Series.Add(series);
            }

            XYDiagram diagram = (XYDiagram)chartControl.Diagram;
            diagram.Panes.Clear();
            diagram.AxisY.Title.Text = "";
            diagram.SecondaryAxesY.Clear();

            diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Hour;                            //最小刻度
            diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Day;                          //最小显示刻度

            if (dt.Rows.Count > 0 && !dt.Rows[dt.Rows.Count - 1].IsNull(fieldN[0]))
            {
                int i = 0;
                while (dt.Rows[i].IsNull(fieldN[0]))
                {
                    i++;
                }

                if (title.Contains("水量"))
                {
                    diagram.AxisY.WholeRange.MinValue = Convert.ToInt32(dt.Rows[i][fieldN[0]]) - 800;
                    diagram.AxisY.WholeRange.MaxValue = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][fieldN[0]]) + 2500;
                }
                else if(title.Contains("水位"))
                {
                    diagram.AxisY.WholeRange.MinValue = Convert.ToInt32(dt.Rows[i][fieldN[0]]) - 2;                                        //y轴起始刻度
                    diagram.AxisY.WholeRange.MaxValue = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][fieldN[0]]) + 0.5;
                }
                else if (title.Contains("流量"))
                {
                    diagram.AxisY.WholeRange.MinValue = Convert.ToInt32(dt.Rows[i][fieldN[0]]) - 7;                                        //y轴起始刻度
                    diagram.AxisY.WholeRange.MaxValue = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][fieldN[0]]) + 5;
                }
            }

            diagram.AxisX.DateTimeOptions.Format = DateTimeFormat.Custom;
            diagram.AxisX.DateTimeOptions.FormatString = "yyyy-MM-dd HH:mm";

            diagram.AxisX.Title.Visible = true;
            diagram.AxisY.Title.Visible = true;

            if (seriesN[0].Contains("水位"))
                diagram.AxisY.Title.Text = "水位(m)";
            else if(seriesN[0].Contains("流量"))
                diagram.AxisY.Title.Text = "当前流量(m³/s)";
            else if (seriesN[0].Contains("水量"))
                diagram.AxisY.Title.Text = "水量(m³)";
            diagram.AxisX.Title.Text = "监测时间";

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

        public void DrawDiagramForJzz(ChartControl chartControl, DataTable dt, string[] fieldN, string[] seriesN, string title)
        {
            for (int i = 0; i < fieldN.Count(); i++)
            {
                Series series = new Series(seriesN[i], ViewType.Spline);
                series.DataSource = dt;
                series.ArgumentScaleType = ScaleType.Auto;                                                         //x轴参数类型
                series.ArgumentDataMember = "JCTNAME";                                                             //x轴获取指定字段的列
                series.ValueDataMembers.AddRange(fieldN[i]);                                                       //y轴获取指定字段的列
                ((LineSeriesView)series.View).Color = COLORS[i];
                chartControl.Series.Add(series);
            }

            XYDiagram diagram = (XYDiagram)chartControl.Diagram;
            diagram.Panes.Clear();
            diagram.AxisY.WholeRange.MaxValue = 160;
            diagram.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.False;
            diagram.AxisY.WholeRange.MinValue = 0;
            diagram.AxisY.Title.Text = "";
            diagram.AxisY.Title.Text = "";
            diagram.SecondaryAxesY.Clear();

            //diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Hour;                            //最小刻度
            //diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Day;                          //最小显示刻度

            if (dt.Rows.Count > 0 && !dt.Rows[dt.Rows.Count - 1].IsNull(fieldN[0]))
            {
                int i = 0;
                while (dt.Rows[i].IsNull(fieldN[0]))
                {
                    i++;
                }

                if (title.Contains("水量"))
                {
                    diagram.AxisY.WholeRange.MinValue = Convert.ToInt32(dt.Rows[i][fieldN[0]]) - 800;
                    diagram.AxisY.WholeRange.MaxValue = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][fieldN[0]]) + 2500;
                }
                else if (title.Contains("水位"))
                {
                    diagram.AxisY.WholeRange.MinValue = Convert.ToInt32(dt.Rows[i][fieldN[0]]) - 2;                                        //y轴起始刻度
                    diagram.AxisY.WholeRange.MaxValue = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][fieldN[0]]) + 0.5;
                }
                else if (title.Contains("流量"))
                {
                    diagram.AxisY.WholeRange.MinValue = Convert.ToInt32(dt.Rows[i][fieldN[0]]) - 7;                                        //y轴起始刻度
                    diagram.AxisY.WholeRange.MaxValue = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][fieldN[0]]) + 5;
                }
            }
           

            //diagram.AxisX.DateTimeOptions.Format = DateTimeFormat.Custom;
            //diagram.AxisX.DateTimeOptions.FormatString = "yyyy-MM-dd HH:mm";

            //diagram.AxisX.Title.Visible = false;
            //diagram.AxisY.Title.Visible = true;

            if (seriesN[0].Contains("水位"))
                diagram.AxisY.Title.Text = "水位(m)";
            else if (seriesN[0].Contains("流量"))
                diagram.AxisY.Title.Text = "当前流量(m³/s)";
            else if (seriesN[0].Contains("水量"))
                diagram.AxisY.Title.Text = "水量(m³)";

            diagram.AxisX.Title.Text = "监测节点";

            diagram.AxisY.Title.Alignment = StringAlignment.Far;
            diagram.AxisY.Title.Visible = true;
            diagram.AxisY.Title.Font = new Font("宋体", 9.0f);
            diagram.AxisX.Title.Alignment = StringAlignment.Far;
            diagram.AxisX.Title.Visible = true;
            diagram.AxisX.Title.Font = new Font("宋体", 9.0f);
            

            ((XYDiagram)chartControl.Diagram).EnableAxisXZooming = false;                                           //允许x轴缩放
            ((XYDiagram)chartControl.Diagram).EnableAxisXScrolling = false;                                         //允许x轴移动
            ((XYDiagram)chartControl.Diagram).EnableAxisYZooming = true;                                           //允许y轴缩放
            ((XYDiagram)chartControl.Diagram).EnableAxisYScrolling = true;                                         //允许y轴移动
            //((XYDiagram)chartControl.Diagram).AxisX.VisualRange.Auto = false;
            ((XYDiagram)chartControl.Diagram).AxisX.Label.Angle = -30;
            chartControl.CrosshairOptions.ShowArgumentLabels = true;                                               //移动鼠标时动态显示Y轴数据标签
            chartControl.CrosshairOptions.ShowArgumentLine = true;                                                 //显示Y轴线
            chartControl.CrosshairOptions.ArgumentLineColor = Color.Blue;
            chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;                                 //增加示意图
            chartControl.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Left;

            chartControl.Titles.Add(new ChartTitle());                                                             //增加表名
            chartControl.Titles[0].Text = title;
        }

        public void Draw2PaneDiagram(ChartControl chartControl, DataTable dt, string[] fieldN, string[] seriesN,string axisXN, string title) //将图形分为两个窗格显示
        {
            for (int i = 0; i < fieldN.Count(); i++)
            {
                Series series = new Series(seriesN[i], ViewType.Line);
                series.DataSource = dt;
                series.ArgumentScaleType = ScaleType.DateTime;                                                         //x轴参数类型
                series.ArgumentDataMember = axisXN;                                                                  //x轴获取指定字段的列
                series.ValueDataMembers.AddRange(fieldN[i]);                                                       //y轴获取指定字段的列
                ((LineSeriesView)series.View).Color = COLORS[i];
                chartControl.Series.Add(series);
            }

            XYDiagram diagram = (XYDiagram)chartControl.Diagram;
            diagram.Panes.Clear();
            XYDiagramPane pane = new XYDiagramPane();
            diagram.Panes.Add(pane);

            for (int i = chartControl.Series.Count / 2; i < chartControl.Series.Count; i++)                     //将另一半折线放入另一窗格中
            {
                XYDiagramSeriesViewBase view = (XYDiagramSeriesViewBase)chartControl.Series[i].View;
                view.Pane = pane;
            }
            
            diagram.AxisX.SetVisibilityInPane(true, diagram.DefaultPane);                                       //设置默认显示的坐标轴
            diagram.PaneDistance = 5;
            diagram.PaneLayoutDirection = PaneLayoutDirection.Horizontal;                                       //水平方向放置

            diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Hour;                            //最小刻度
            diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Day;                          //最小显示刻度

            if (dt.Rows.Count > 0 && !dt.Rows[dt.Rows.Count - 1].IsNull(fieldN[0]))
            {
                int i = 0;
                while (dt.Rows[i].IsNull(fieldN[0]))
                {
                    i++;
                }
                if (Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][fieldN[0]]) - Convert.ToInt32(dt.Rows[i][fieldN[0]] )< 3) //如果两折线的值相差不大，那么缩小y轴范围
                {
                    diagram.AxisY.WholeRange.MinValue = Convert.ToInt32(dt.Rows[i][fieldN[0]]) - 2;                     //y轴起始刻度
                    diagram.AxisY.WholeRange.MaxValue = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][fieldN[0]]) + 1;
                }
                else
                {
                    diagram.AxisY.WholeRange.MinValue = Convert.ToInt32(dt.Rows[i][fieldN[0]]) - 7;                     
                    diagram.AxisY.WholeRange.MaxValue = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][fieldN[0]]) + 5;
                }
            }

            diagram.AxisX.DateTimeOptions.Format = DateTimeFormat.Custom;
            diagram.AxisX.DateTimeOptions.FormatString = "yyyy-MM-dd HH:mm";

            diagram.AxisX.Title.Visible = true;
            diagram.AxisY.Title.Visible = true;

            if (seriesN[0].Contains("水位"))
                diagram.AxisY.Title.Text = "水位(m)";
            else if (seriesN[0].Contains("流量"))
                diagram.AxisY.Title.Text = "流量(m³/s)";
            else if (seriesN[0].Contains("水量"))
                diagram.AxisY.Title.Text = "水量(m³)";
            diagram.AxisX.Title.Text = "监测时间";

            diagram.AxisY.Title.Alignment = StringAlignment.Far;
            diagram.AxisY.Title.Visible = true;
            diagram.AxisY.Title.Font = new Font("宋体", 9.0f);
            diagram.AxisX.Title.Alignment = StringAlignment.Far;
            diagram.AxisX.Title.Visible = true;
            diagram.AxisX.Title.Font = new Font("宋体", 9.0f);

            ((XYDiagram)chartControl.Diagram).EnableAxisXZooming = true;                                           //允许x轴缩放
            ((XYDiagram)chartControl.Diagram).EnableAxisXScrolling = true;                                         //允许x轴移动
            chartControl.CrosshairOptions.ShowArgumentLabels = true;                                               //移动鼠标时动态显示Y轴数据标签
            chartControl.CrosshairOptions.ShowArgumentLine = true;                                                 //显示Y轴线
            chartControl.CrosshairOptions.ArgumentLineColor = Color.Blue;
            chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;                                 //增加示意图
            chartControl.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Left;

            chartControl.Titles.Add(new ChartTitle());                                                             //增加表名
            chartControl.Titles[0].Text = title;
        }

        public void Draw2AxesYDiagram(ChartControl chartControl, DataTable dt, string[] fieldN, string[] seriesN, string axisXN, string title) //由于折线图之间的数值差异太大，因此使用多坐标
        {
            for (int i = 0; i < fieldN.Count(); i++)
            {
                Series series = new Series(seriesN[i], ViewType.Line);
                series.DataSource = dt;
                series.ArgumentScaleType = ScaleType.DateTime;                                                         //x轴参数类型
                series.ArgumentDataMember = axisXN;                                                                  //x轴获取指定字段的列
                series.ValueDataMembers.AddRange(fieldN[i]);                                                       //y轴获取指定字段的列
                ((LineSeriesView)series.View).Color = COLORS[i];
                chartControl.Series.Add(series);
            }
            /*
            double minV, maxV, minV2, maxV2, value;
            minV = maxV = Convert.ToDouble(dt.Rows[0][fieldN[0]]);
            minV2 = maxV2 = Convert.ToDouble(dt.Rows[0][fieldN[1]]);
            foreach (DataRow row in dt.Rows)
            {
                value = Convert.ToDouble(row[fieldN[0]]);
                if (minV > value) minV = value;
                if (maxV < value) maxV = value;

                value = Convert.ToDouble(row[fieldN[1]]);
                if (minV2 > value) minV2 = value;
                if (maxV2 < value) maxV2 = value;
            }
            */
            XYDiagram diagram = (XYDiagram)chartControl.Diagram;
            diagram.AxisY.WholeRange.Auto = true;
            //diagram.AxisY.WholeRange.SetMinMaxValues(minV, maxV);
            diagram.SecondaryAxesY.Clear();
                                                                                                             
            SecondaryAxisY secAxes = new SecondaryAxisY(chartControl.Series[1].Name);                       //增加第二辅助Y轴线
            secAxes.WholeRange.Auto = true;
            //secAxes.WholeRange.SetMinMaxValues(minV2, maxV2);
            
            ((XYDiagram)chartControl.Diagram).SecondaryAxesY.Add(secAxes);
            ((LineSeriesView)chartControl.Series[1].View).AxisY = secAxes;

            secAxes.Title.Text = chartControl.Series[1].Name + "(m³)";
            secAxes.Title.Alignment = StringAlignment.Far;                                                  //顶部对齐
            secAxes.Title.Visible = true;                                                                   //显示标题
            secAxes.Title.Font = new Font("宋体", 9.0f);
                        
            Color colorSecAxis = chartControl.Series[1].View.Color;                                                 //设置坐标的颜色和图表线条颜色一致

            secAxes.Title.TextColor = colorSecAxis;
            secAxes.Label.TextColor = colorSecAxis;
            secAxes.Color = colorSecAxis;

            diagram.AxisY.Title.Text = chartControl.Series[0].Name + "(m³)";
            diagram.AxisY.Title.Alignment = StringAlignment.Far;
            diagram.AxisY.Title.Visible = true;
            diagram.AxisY.Title.Font = new Font("宋体", 9.0f);

            Color colorAxisY = chartControl.Series[0].View.Color;
            diagram.AxisY.Title.TextColor = colorAxisY;
            diagram.AxisY.Label.TextColor = colorAxisY;
            diagram.AxisY.Color = colorAxisY;

            diagram.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            diagram.AxisX.Title.Text = "监测时间";
            diagram.AxisX.Title.Alignment = StringAlignment.Far;
            diagram.AxisX.Title.Visible = true;
            diagram.AxisX.Title.Font = new Font("宋体", 9.0f);
            
            diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Hour;                            //最小刻度
            diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Day;                          //最小显示刻度

            diagram.AxisX.DateTimeOptions.Format = DateTimeFormat.Custom;
            diagram.AxisX.DateTimeOptions.FormatString = "yyyy-MM-dd HH:mm";

            ((XYDiagram)chartControl.Diagram).EnableAxisXZooming = true;                                           //允许x轴缩放
            ((XYDiagram)chartControl.Diagram).EnableAxisXScrolling = true;                                         //允许x轴移动
            chartControl.CrosshairOptions.ShowArgumentLabels = true;                                               //移动鼠标时动态显示Y轴数据标签
            chartControl.CrosshairOptions.ShowArgumentLine = true;                                                 //显示Y轴线
            //chartControl.CrosshairOptions.ShowValueLabels = true;                                                  //移动鼠标时动态显示X轴数据标签
            //chartControl.CrosshairOptions.ShowValueLine = true;                                                    //显示X轴线
            //chartControl.CrosshairOptions.ValueLineColor = Color.Blue;
            chartControl.CrosshairOptions.ArgumentLineColor = Color.Blue;
            chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;                                 //增加示意图
            chartControl.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.Left;

            chartControl.Titles.Add(new ChartTitle());                                                             //增加表名
            chartControl.Titles[0].Text = title;
        }

        public void AddSeriesForJzz(ChartControl chartControl, DataTable dt, string[] fieldN, string[] seriesN)//增加普通折线图
        {
            for (int i = 0; i < fieldN.Count(); i++)
            {
                Series series = new Series(seriesN[i], ViewType.Line);
                series.DataSource = dt;
                series.ArgumentScaleType = ScaleType.Auto;                                                         //x轴参数类型
                series.ArgumentDataMember = "JCTNAME";                                                             //x轴获取指定字段的列
                series.ValueDataMembers.AddRange(fieldN[i]);                                                       //y轴获取指定字段的列
                ((LineSeriesView)series.View).Color = COLORS2[i];
                chartControl.Series.Add(series);
            }
        }

        public void AddSeries(ChartControl chartControl, DataTable dt, string[] fieldN, string[] seriesN)//增加普通折线图
        {
            for (int i = 0; i < fieldN.Count(); i++)
            {
                Series series = new Series(seriesN[i], ViewType.Line);
                series.DataSource = dt;
                series.ArgumentScaleType = ScaleType.DateTime;                                                         //x轴参数类型
                series.ArgumentDataMember = "RTIME";                                                                  //x轴获取指定字段的列
                series.ValueDataMembers.AddRange(fieldN[i]);                                                       //y轴获取指定字段的列
                ((LineSeriesView)series.View).Color = COLORS2[i];
                chartControl.Series.Add(series);
            }
        }

        public void Add2AxesYSeries(ChartControl chartControl, DataTable dt, string[] fieldN, string[] seriesN)//增加含有第二辅助Y轴的折线图
        {
            for (int i = 0; i < fieldN.Count(); i++)
            {
                Series series = new Series(seriesN[i], ViewType.Line);
                series.DataSource = dt;
                series.ArgumentScaleType = ScaleType.DateTime;                                                         //x轴参数类型
                series.ArgumentDataMember = "RTIME";                                                                  //x轴获取指定字段的列
                series.ValueDataMembers.AddRange(fieldN[i]);                                                       //y轴获取指定字段的列
                ((LineSeriesView)series.View).Color = COLORS2[i];
                chartControl.Series.Add(series);
            }

            XYDiagram diagram = (XYDiagram)chartControl.Diagram;
            diagram.AxisY.WholeRange.Auto = true;
            diagram.SecondaryAxesY.Clear();

            SecondaryAxisY secAxes = new SecondaryAxisY(chartControl.Series[2].Name);                       //增加第二辅助Y轴线
            secAxes.WholeRange.Auto = true;

            ((XYDiagram)chartControl.Diagram).SecondaryAxesY.Add(secAxes);
            ((LineSeriesView)chartControl.Series[2].View).AxisY = secAxes;

            secAxes.Title.Text = chartControl.Series[2].Name + "(m³)";
            secAxes.Title.Alignment = StringAlignment.Far;                                                  //顶部对齐
            secAxes.Title.Visible = true;                                                                   //显示标题
            secAxes.Title.Font = new Font("宋体", 9.0f);

            Color colorSecAxis = chartControl.Series[2].View.Color;                                                 //设置坐标的颜色和图表线条颜色一致

            secAxes.Title.TextColor = colorSecAxis;
            secAxes.Label.TextColor = colorSecAxis;
            secAxes.Color = colorSecAxis;

            //chartControl.CrosshairOptions.ShowValueLabels = true;                                                  //移动鼠标时动态显示X轴数据标签
            //chartControl.CrosshairOptions.ShowValueLine = true;                                                    //显示X轴线
            //chartControl.CrosshairOptions.ValueLineColor = Color.Blue;
        }

    }
}
