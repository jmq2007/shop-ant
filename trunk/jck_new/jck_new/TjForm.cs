using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;
using System.Windows.Forms.DataVisualization.Charting;

namespace jck_new
{
    public partial class TjForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public TjForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void btn_tj_Click(object sender, EventArgs e)
        {
            string key1 = dateTimePicker1.Text;
            string key2 = dateTimePicker2.Text;
            if (comboBox1.SelectedIndex == 0)
            {
                chart1.DataSource = ProductDao.tj_day(key1, key2);
            }
            else
            {
                chart1.DataSource = ProductDao.tj_mon(key1, key2);
            }
            
            chart1.Series[0].XValueMember = "日期";
            chart1.Series[0].YValueMembers = "金额";
            chart1.Series[1].XValueMember = "日期";
            chart1.Series[1].YValueMembers = "利润";
            //chart1.Series[0].ChartType = SeriesChartType.Line;
            //chart1.Series[0].IsValueShownAsLabel = true;
            chart1.DataBind();
        }
    }
}
