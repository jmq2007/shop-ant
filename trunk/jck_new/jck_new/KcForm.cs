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
        int flag = 0;//0全部或者1条件
        string key = "";
        int sIndex = 1;
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
            flag = 1;
            listView1.Items.Clear();
            curPageIndex = 0;

            Product_kc kc = new Product_kc();
            sIndex = this.comboBox1.SelectedIndex;
            key=this.textBox1.Text;
            switch (sIndex)
            {
                case 0: kc.Code = key; break;
                case 1: kc.Name = key; break;
                case 2: kc.NameClass = key; break;
            }
           
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

        private void btn_all_Click(object sender, EventArgs e)
        {
            flag = 0;
            listView1.Items.Clear();
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

        private void nextP_btn_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            curPageIndex++;
            Page page = new Page();
            if (flag == 0)
            {
                page = PageQueryDao.getProducts_kc(curPageIndex);
            }
            else
            {
                Product_kc kc = new Product_kc();
                switch (sIndex)
                {
                    case 0: kc.Code = key; break;
                    case 1: kc.Name = key; break;
                    case 2: kc.NameClass = key; break;
                }
                page = PageQueryDao.getProducts_kc(curPageIndex, kc);
            }
            List<Product_kc> ls = (List<Product_kc>)page.ValueList;
            foreach (Product_kc p in ls)
            {
                AddProduct_kc(p);
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
            Page page = new Page();
            if (flag == 0)
            {
                page = PageQueryDao.getProducts_kc(curPageIndex);
            }
            else
            {
                Product_kc kc = new Product_kc();
                switch (sIndex)
                {
                    case 0: kc.Code = key; break;
                    case 1: kc.Name = key; break;
                    case 2: kc.NameClass = key; break;
                }
                page = PageQueryDao.getProducts_kc(curPageIndex, kc);
            }
            List<Product_kc> ls = (List<Product_kc>)page.ValueList;
            foreach (Product_kc p in ls)
            {
                AddProduct_kc(p);
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
            //Page page = PageQueryDao.getProducts_kc(totalPage - 1);
            Page page = new Page();
            if (flag == 0)
            {
                page = PageQueryDao.getProducts_kc(totalPage - 1);
            }
            else
            {
                Product_kc kc = new Product_kc();
                switch (sIndex)
                {
                    case 0: kc.Code = key; break;
                    case 1: kc.Name = key; break;
                    case 2: kc.NameClass = key; break;
                }
                page = PageQueryDao.getProducts_kc(totalPage - 1, kc);
            }

            List<Product_kc> ls = (List<Product_kc>)page.ValueList;
            foreach (Product_kc p in ls)
            {
                AddProduct_kc(p);
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
            Page page = new Page();
            if (flag == 0)
            {
                page = PageQueryDao.getProducts_kc(0);
            }
            else
            {
                Product_kc kc = new Product_kc();
                switch (sIndex)
                {
                    case 0: kc.Code = key; break;
                    case 1: kc.Name = key; break;
                    case 2: kc.NameClass = key; break;
                }
                page = PageQueryDao.getProducts_kc(0, kc);
            }
            List<Product_kc> ls = (List<Product_kc>)page.ValueList;
            foreach (Product_kc p in ls)
            {
                AddProduct_kc(p);
                //Debug.WriteLine(p.Id);
            }
            ChangeClour(listView1);
            this.labelMsg.Text = String.Format("共{0:d}条记录, 每页{1:d}条, {2:d}/{3:d}页",
                                        page.TotalRecord, page.PageSize, page.CurPageIndex + 1, page.TotalPage);

            curPageIndex = page.CurPageIndex;
            totalPage = page.TotalPage;
        }
    }
}
