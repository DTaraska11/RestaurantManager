using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RestaurantManager
{
    public partial class Statistics : Form
    {
        Boolean all;
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            comboBox_type.SelectedIndex = 0;
            initialChart("line",true);
            chart1.Titles.Add("Restaurant Statistics");
            chart1.ChartAreas[0].AxisX.Title = "Date";//设置X轴的标题
            chart1.ChartAreas[0].AxisY.Title = "Data";//设置Y轴的标题
         
        }

        void initialChart(string type, Boolean showAll)
        {
            string sql;
            chart1.Series.Clear();//清理掉默认的图表   然后重新添加
                       
            DataTable ds = new DataTable();
            if (showAll)
            {
                 sql = "select * from statistics";
            }
            else sql = "SELECT * FROM statistics WHERE DATE BETWEEN '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'";

            MySqlConnection MySqlCon = new MySqlConnection(MySQLConnection1.SqlCon);
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, MySqlCon);
            MySQLConnection1.OpenConn();
            sda.Fill(ds);
            if (type == "line")
            {
                
               
                Series ss = new Series("income");   //这里 dt1 ,dt2 任意取名称，但要唯一
                ss.Points.DataBind(ds.AsEnumerable(), "date", "income", "");
                ss.XValueType = ChartValueType.DateTime; //设置X轴
                ss.ChartType = SeriesChartType.Spline;   //设置Y轴为折线
                chart1.Series.Add(ss);

                if (checkBox_cost.Checked)
                {
                    Series ss1 = new Series("cost");   //这里 dt1 ,dt2 任意取名称，但要唯一
                    ss1.Points.DataBind(ds.AsEnumerable(), "date", "cost", "");
                    ss1.XValueType = ChartValueType.DateTime; //设置X轴
                    ss1.ChartType = SeriesChartType.Spline;   //设置Y轴为折线
                    chart1.Series.Add(ss1);
                }
            }
            else if (type == "pie")
            {
      

                Series s = chart1.Series.Add("饼图");
           //    
                //设置图标名称
                //s.ChartArea = "ChartArea" + j;
                //图表类型   折线  柱状 圆形
                s.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                s.BorderWidth = 3;
                s.ShadowOffset = 1;
                s.IsValueShownAsLabel = true;//是否在图表上显示数据的值
                s.XValueType = ChartValueType.Int32;
                s.MarkerStyle = MarkerStyle.Circle;//数据点样式
                List<string> xData1 = new List<string>();//声明两个集合将数据先放在集合中
                List<string> yData1 = new List<string>();
                for (int i = 0; i < ds.Rows.Count; i++)//
                {
                    //将数据先放在集合中
                    xData1.Add(ds.Rows[i]["date"].ToString());
                    yData1.Add(ds.Rows[i]["income"].ToString());
                }
                //循环结束后，绑定数据源
                chart1.Series[0].Points.DataBindXY(xData1, yData1);
            }
            //  chart2.Series.Add(ss);

            //第二条数据
         


            ////第三条数据
            //string sql2 = "SELECT * FROM APiece WHERE APiece.Piece_PId=3";
            //DataTable ds2 = new DataTable();
            //SqlDataAdapter sda2 = new SqlDataAdapter(sql2, con);
            //sda2.Fill(ds2);
            //Chart1.DataSource = ds2;
            //Series ss3 = new Series("产品3");
            //ss3.Points.DataBind(ds2.AsEnumerable(), "Piece_Time", "Piece_Level", "");
            //ss3.XValueType = ChartValueType.DateTime; //设置X轴
            //ss3.ChartType = SeriesChartType.Spline;   //设置Y轴为折线
            //Chart1.Series.Add(ss3);



        }



        static DataTable ConvertDataTable(DataTable source)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("month");
            var columns = (from x in source.Rows.Cast<DataRow>() select x[1].ToString()).Distinct();
            foreach (var item in columns) dt.Columns.Add(item);
            var data = from x in source.Rows.Cast<DataRow>()
                       group x by x[0] into g
                       select new { Key = g.Key.ToString(), Items = g };
            data.ToList().ForEach(x =>
            {
                string[] array = new string[dt.Columns.Count];
                array[0] = x.Key;
                for (int i = 1; i < dt.Columns.Count; i++)
                    array[i] = (from y in x.Items
                                where y[1].ToString() == dt.Columns[i].ToString()
                                select y[2].ToString())
                               .SingleOrDefault();
                dt.Rows.Add(array);
            });
            return dt;
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_type.SelectedIndex == 0)
            {
                initialChart("line", all);
                checkBox_cost.Enabled = true;
            }
            else if (comboBox_type.SelectedIndex == 1)
            {
                initialChart("pie", all);
                checkBox_cost.Enabled = false;
            }
        }

        private void checkBox_cost_CheckedChanged(object sender, EventArgs e)
        {
            initialChart("line", all);
        }

        private void checkBox_3D_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_3D.Checked && comboBox_type.SelectedIndex == 0)
            {
                chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
                initialChart("line", all);
            }
            else if (!checkBox_3D.Checked && comboBox_type.SelectedIndex == 0)
            {
                chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = false;
                initialChart("line", all);
            }
            else if (checkBox_3D.Checked && comboBox_type.SelectedIndex == 1)
            {
                initialChart("pie", all);
                chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            }
            else
            {
                initialChart("pie", all);
                chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = false; }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (checkBox_3D.Checked && comboBox_type.SelectedIndex == 0)
            {
                chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
                initialChart("line", all);
            }
            else if (!checkBox_3D.Checked && comboBox_type.SelectedIndex == 0)
            {
                chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = false;
                initialChart("line", all);
            }
            else if (checkBox_3D.Checked && comboBox_type.SelectedIndex == 1)
            {
                initialChart("pie", all);
                chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            }
            else
            {
                initialChart("pie", all);
                chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = false;
            }
        }
    

        private void checkBox_all_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_all.Checked)
            {
                all = true;
            }
            else all = false;
        }
    }
}
