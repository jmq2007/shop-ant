using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Common;
namespace jck_new
{
    public partial class OutForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public OutForm()
        {
            InitializeComponent();
        }

        private void btn_out1_Click(object sender, EventArgs e)
        {

            string key1 = dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string key2 = dateTimePicker2.Value.ToString("yyyy-MM-dd") + " 23:59:59";
            if (key1 == key2)
            {
                MessageBox.Show("请先选择时间段");
                return;
            }
            ExportExcel(ProductDao.outBuy(key1,key2));
        }

        protected void ExportExcel(System.Data.DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0) return;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                return;
            }
            System.Globalization.CultureInfo CurrentCI = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
            Microsoft.Office.Interop.Excel.Range range;
            long totalCount = dt.Rows.Count;
            long rowRead = 0;
            float percent = 0;
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
                range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, i + 1];
                range.Interior.ColorIndex = 15;
                range.Font.Bold = true;
            }
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = dt.Rows[r][i].ToString();
                }
                rowRead++;
                percent = ((float)(100 * rowRead)) / totalCount;
            }
            xlApp.Visible = true;
        }

        private void btn_out2_Click(object sender, EventArgs e)
        {
            string key1 = dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string key2 = dateTimePicker2.Value.ToString("yyyy-MM-dd") + " 23:59:59";
            ExportExcel(ProductDao.outSale(key1, key2));
        }

        private void btn_out3_Click(object sender, EventArgs e)
        {
            string key1 = dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string key2 = dateTimePicker2.Value.ToString("yyyy-MM-dd") + " 23:59:59";
            ExportExcel(ProductDao.tj_day(key1, key2).Tables["ds"]);
        }
    }
}
