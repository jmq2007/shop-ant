using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;

namespace jck_new
{
    public partial class MainToolWindow : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public MainToolWindow()
        {
            InitializeComponent();
            label_day_a.Text = ProductDao.dayAmount().ToString() + "件";
            label_day_p.Text = ProductDao.dayPrice().ToString() + "元";
            label_mo_a.Text = ProductDao.mAmount().ToString() + "件";
            label_mo_p.Text = ProductDao.mPrice().ToString() + "元";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            DataSet ds = ProductDao.searchByKey(this.txt_key.Text.Trim());
            string res = "";
            for (int i = 0; i < ds.Tables["ds"].Rows.Count; i++)
            {
                res = ds.Tables["ds"].Rows[i]["code"].ToString()+"||"
                    + ds.Tables["ds"].Rows[i]["p_name"].ToString() + "||"
                    + ds.Tables["ds"].Rows[i]["sale_price"].ToString() + "||"
                    +  "\r\n"+res ;
            }
            this.txt_res.Text = res;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_day_a.Text = ProductDao.dayAmount().ToString()+"件";
            label_day_p.Text = ProductDao.dayPrice().ToString() + "元";
            label_mo_a.Text = ProductDao.mAmount().ToString() + "件";
            label_mo_p.Text = ProductDao.mPrice().ToString() + "元";
        }
    }
}
