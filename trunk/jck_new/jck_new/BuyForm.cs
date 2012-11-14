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
    public partial class BuyForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {


        private int curPageIndex;
        private int totalPage;
        private ListViewItem curLvi;
        public BuyForm()
        {
            InitializeComponent();

            curPageIndex = 0;
            Page page = PageQueryDao.getProducts_buy(curPageIndex);
            List<Product_buy> ls = (List<Product_buy>)page.ValueList;
            //init product  list view
            foreach (Product_buy p in ls)
            {
                AddProduct_buy(p);
            }
        }
        private void AddProduct_buy(Product_buy p)
        {
            ListViewItem lvi = this.listView1.Items.Add(p.Id.ToString());
            lvi.SubItems.Add(p.Code);
            lvi.SubItems.Add(p.Name.ToString());
            lvi.SubItems.Add(p.Amount.ToString());
            lvi.SubItems.Add(p.Price.ToString());
            lvi.SubItems.Add(p.Price_sale.ToString());
            lvi.SubItems.Add(p.BuyDate.ToString());
            lvi.SubItems.Add(p.Other.ToString());
        }
    }
}
