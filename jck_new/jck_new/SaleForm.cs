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
    public partial class SaleForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private int curPageIndex;
        private int totalPage;
        private ListViewItem curLvi;
        public SaleForm()
        {
            InitializeComponent();
            curPageIndex = 0;
            Page page = PageQueryDao.getProducts_sale(curPageIndex);
            List<Product_sale> ls = (List<Product_sale>)page.ValueList;
            //init product  list view
            foreach (Product_sale p in ls)
            {
                AddProduct_sale(p);
            }
            ChangeClour(listView1);
            this.labelMsg.Text = String.Format("共{0:d}条记录, 每页{1:d}条, {2:d}/{3:d}页",
                                        page.TotalRecord, page.PageSize, page.CurPageIndex + 1, page.TotalPage);

            curPageIndex = page.CurPageIndex;
            totalPage = page.TotalPage;
        }
        private void AddProduct_sale(Product_sale p)
        {
            ListViewItem lvi = this.listView1.Items.Add(p.Id.ToString());
            lvi.SubItems.Add(p.Code);
            lvi.SubItems.Add(p.NameClass.ToString());
            lvi.SubItems.Add(p.Name.ToString());
            lvi.SubItems.Add(p.Price_sale.ToString());
            lvi.SubItems.Add(p.Amount.ToString());
            lvi.SubItems.Add(p.Price.ToString());
            lvi.SubItems.Add(p.BuyDate.ToString());
            lvi.SubItems.Add(p.Other.ToString());
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            Product_buy product_buy = ProductDao.getByCode(this.txt_code.Text);
            if (product_buy == null)
            {
                MessageBox.Show("sorry，未找到");
                return;
            }
            this.num_amount.Value = 1;
            this.txt_saleprice.Text = product_buy.Price.ToString();
            this.txt_price.Text = product_buy.Price.ToString();
            this.txt_name.Text = product_buy.Name;
        }
        private void nextP_btn_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            curPageIndex++;
            Page page = PageQueryDao.getProducts_buy(curPageIndex);
            List<Product_sale> ls = (List<Product_sale>)page.ValueList;
            foreach (Product_sale p in ls)
            {
                AddProduct_sale(p);
                //Debug.WriteLine(p.Id);
            }
            ChangeClour(listView1);
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
            List<Product_sale> ls = (List<Product_sale>)page.ValueList;
            foreach (Product_sale p in ls)
            {
                AddProduct_sale(p);
                //Debug.WriteLine(p.Id);
            }
            ChangeClour(listView1);
            this.labelMsg.Text = String.Format("共{0:d}条记录, 每页{1:d}条, {2:d}/{3:d}页",
                                        page.TotalRecord, page.PageSize, page.CurPageIndex + 1, page.TotalPage);

            curPageIndex = page.CurPageIndex;
            totalPage = page.TotalPage;
        }

        private void lastP_btn_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            Page page = PageQueryDao.getProducts_buy(totalPage - 1);
            List<Product_sale> ls = (List<Product_sale>)page.ValueList;
            foreach (Product_sale p in ls)
            {
                AddProduct_sale(p);
                //Debug.WriteLine(p.Id);
            }
            ChangeClour(listView1);
            this.labelMsg.Text = String.Format("共{0:d}条记录, 每页{1:d}条记录, {2:d}/{3:d}页",
                                        page.TotalRecord, page.PageSize, page.CurPageIndex + 1, page.TotalPage);

            curPageIndex = page.CurPageIndex;
            totalPage = page.TotalPage;
        }

        private void firstP_btn_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            Page page = PageQueryDao.getProducts_buy(0);
            List<Product_sale> ls = (List<Product_sale>)page.ValueList;
            foreach (Product_sale p in ls)
            {
                AddProduct_sale(p);
                //Debug.WriteLine(p.Id);
            }
            ChangeClour(listView1);
            this.labelMsg.Text = String.Format("共{0:d}条记录, 每页{1:d}条, {2:d}/{3:d}页",
                                        page.TotalRecord, page.PageSize, page.CurPageIndex + 1, page.TotalPage);

            curPageIndex = page.CurPageIndex;
            totalPage = page.TotalPage;
        }


        private void add_btn_Click(object sender, EventArgs e)
        {

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
    }
}
