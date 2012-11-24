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
    public partial class KcForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private int curPageIndex;
        private int totalPage;
        private ListViewItem curLvi;
        public KcForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
            curPageIndex = 0;
            Page page = PageQueryDao.getProducts_kc(curPageIndex);
            List<Product_kc> ls = (List<Product_kc>)page.ValueList;
            //init product  list view
            foreach (Product_kc p in ls)
            {
                AddProduct_kc(p);
            }
            ChangeClour(listView1);
            this.labelMsg.Text = String.Format("共{0:d}条记录, 每页{1:d}条, {2:d}/{3:d}页",
                                        page.TotalRecord, page.PageSize, page.CurPageIndex + 1, page.TotalPage);

            curPageIndex = page.CurPageIndex;
            totalPage = page.TotalPage;
        }
        private void AddProduct_kc(Product_kc p)
        {
            ListViewItem lvi = this.listView1.Items.Add(p.Code.ToString());
           // lvi.SubItems.Add(p.Code);
            lvi.SubItems.Add(p.NameClass);
            lvi.SubItems.Add(p.Name.ToString());

            lvi.SubItems.Add(p.Price.ToString());
            lvi.SubItems.Add(p.Amount.ToString());
            lvi.SubItems.Add(p.Price_sale.ToString());
            lvi.SubItems.Add(p.BuyDate.ToString());
            lvi.SubItems.Add(p.Other.ToString());
            lvi.SubItems.Add(p.Amount_s.ToString());
        }

        private void ChangeClour(ListView listView)
        {
            for (int i = 0; i < listView.Items.Count; i++)
            {
                if (i % 2 == 0)
                {
                    listView.Items[i].BackColor = Color.WhiteSmoke;
                }
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            curPageIndex = 0;
            Product_kc kc = new Product_kc();
            kc.Code = this.textBox1.Text;
            Page page = PageQueryDao.getProducts_kc(curPageIndex,kc);
            List<Product_kc> ls = (List<Product_kc>)page.ValueList;
            //init product  list view
            foreach (Product_kc p in ls)
            {
                AddProduct_kc(p);
            }
            ChangeClour(listView1);
            this.labelMsg.Text = String.Format("共{0:d}条记录, 每页{1:d}条, {2:d}/{3:d}页",
                                        page.TotalRecord, page.PageSize, page.CurPageIndex + 1, page.TotalPage);

            curPageIndex = page.CurPageIndex;
            totalPage = page.TotalPage;
        }
    }
}
