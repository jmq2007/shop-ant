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
            this.labelMsg.Text = String.Format("共{0:d}条记录, 每页{1:d}条, {2:d}/{3:d}页",
                                        page.TotalRecord, page.PageSize, page.CurPageIndex + 1, page.TotalPage);

            curPageIndex = page.CurPageIndex;
            totalPage = page.TotalPage;
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

        private void nextP_btn_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            curPageIndex++;
            Page page = PageQueryDao.getProducts_buy(curPageIndex);
            List<Product_buy> ls = (List<Product_buy>)page.ValueList;
            foreach (Product_buy p in ls)
            {
                AddProduct_buy(p);
                //Debug.WriteLine(p.Id);
            }

            this.labelMsg.Text = String.Format("共{0:d}条记录, 每页{1:d}条, {2:d}/{3:d}页",
                                        page.TotalRecord, page.PageSize, page.CurPageIndex + 1, page.TotalPage);

            curPageIndex = page.CurPageIndex;
            totalPage = page.TotalPage;
        }

        private void prevP_btn_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            curPageIndex--;
            Page page = PageQueryDao.getProducts_buy(curPageIndex);
            List<Product_buy> ls = (List<Product_buy>)page.ValueList;
            foreach (Product_buy p in ls)
            {
                AddProduct_buy(p);
                //Debug.WriteLine(p.Id);
            }

            this.labelMsg.Text = String.Format("共{0:d}条记录, 每页{1:d}条, {2:d}/{3:d}页",
                                        page.TotalRecord, page.PageSize, page.CurPageIndex + 1, page.TotalPage);

            curPageIndex = page.CurPageIndex;
            totalPage = page.TotalPage;
        }

        private void lastP_btn_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            Page page = PageQueryDao.getProducts_buy(totalPage - 1);
            List<Product_buy> ls = (List<Product_buy>)page.ValueList;
            foreach (Product_buy p in ls)
            {
                AddProduct_buy(p);
                //Debug.WriteLine(p.Id);
            }

            this.labelMsg.Text = String.Format("共{0:d}条记录, 每页{1:d}条记录, {2:d}/{3:d}页",
                                        page.TotalRecord, page.PageSize, page.CurPageIndex + 1, page.TotalPage);

            curPageIndex = page.CurPageIndex;
            totalPage = page.TotalPage;
        }

        private void firstP_btn_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            Page page = PageQueryDao.getProducts_buy(0);
            List<Product_buy> ls = (List<Product_buy>)page.ValueList;
            foreach (Product_buy p in ls)
            {
                AddProduct_buy(p);
                //Debug.WriteLine(p.Id);
            }

            this.labelMsg.Text = String.Format("共{0:d}条记录, 每页{1:d}条, {2:d}/{3:d}页",
                                        page.TotalRecord, page.PageSize, page.CurPageIndex + 1, page.TotalPage);

            curPageIndex = page.CurPageIndex;
            totalPage = page.TotalPage;
        }
    }
}
