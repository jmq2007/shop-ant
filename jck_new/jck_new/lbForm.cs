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
    public partial class LbForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public LbForm()
        {
            InitializeComponent();
            DataSet ds = ProductDao.getAllLb();
            if (ds.Tables["ds"].Rows.Count > 0)
            {
               
            }
            for (int i = 0; i < ds.Tables["ds"].Rows.Count; i++)
            {
                ListViewItem lvi = this.listView1.Items.Add(ds.Tables["ds"].Rows[i]["id"].ToString());
                lvi.SubItems.Add(ds.Tables["ds"].Rows[i]["class"].ToString());
            }


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int id = ProductDao.insert_lb(txt_lb.Text);
            ListViewItem lvi = this.listView1.Items.Add(id.ToString());
            lvi.SubItems.Add(txt_lb.Text);
        }

        private void MenuItem_del_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("请选择要删除的数据");
                return;
            }
            ListViewItem lvi = this.listView1.SelectedItems[0];
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要删除吗?", "提示", messButton);
            if (dr == DialogResult.OK)
            {
                //ListViewItem lvi = this.listView1.SelectedItems[0];
                int id = Int32.Parse(lvi.SubItems[0].Text);
                ProductDao.deleteLbById(id);
                lvi.Remove();
            }
            else
            {
            }
        }
    }
}
