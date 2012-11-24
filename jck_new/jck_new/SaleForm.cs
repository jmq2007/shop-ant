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
        Product_buy product_buy_search;
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
            product_buy_search = ProductDao.getByCode(this.txt_code.Text);
            if (product_buy_search == null)
            {
                MessageBox.Show("sorry，未找到");
                return;
            }
            this.num_amount.Value = 1;
            this.txt_saleprice.Text = product_buy_search.Price_sale.ToString();
            this.txt_price.Text = product_buy_search.Price_sale.ToString();
            this.txt_name.Text = product_buy_search.Name;
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
            StringBuilder strErrorMsg = new StringBuilder();
            if (!Validator.checkRequired(this.txt_code.Text))
            {
                strErrorMsg.Append("条码不能为空\n");
            }
            if (!Validator.checkRequired(this.txt_name.Text))
            {
                strErrorMsg.Append("名称不能为空\n");
            }
            if (!Validator.checkInteger(this.num_amount.Text))
            {
                strErrorMsg.Append("数量必须为整数\n");
            }
            if (!Validator.checkDouble(this.txt_saleprice.Text) && !Validator.checkInteger(this.txt_saleprice.Text))
            {
                strErrorMsg.Append("单价必须为数字\n");
            }
            if (!Validator.checkDouble(this.txt_price.Text) && !Validator.checkInteger(this.txt_price.Text))
            {
                strErrorMsg.Append("总价必须为数字\n");
            }

            if (strErrorMsg.Length > 0)
            {
                MessageBox.Show(strErrorMsg.ToString(), "出错提示");
                return;
            }
            Product_sale p = new Product_sale();
            p.Code = this.txt_code.Text.Trim();
            p.Name = this.txt_name.Text.Trim();//
            p.NameClass = product_buy_search.NameClass;
            p.Amount = Int32.Parse(this.num_amount.Text.Trim());
            p.Price = Double.Parse(this.txt_price.Text.Trim());
            p.Price_sale = Double.Parse(this.txt_saleprice.Text.Trim());
            p.BuyDate = DateTime.Now;
            p.Other = this.txt_other.Text.Trim();
            int id = ProductDao.insert_sale(p);
            //
            p = ProductDao.getById_sale(id);
            AddProduct_sale(p);
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

        private void MenuItem_del_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("请选择要删除的数据");
                return;
            }
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要删除吗?", "提示", messButton);
            if (dr == DialogResult.OK)
            {
                ListViewItem lvi = this.listView1.SelectedItems[0];
                int id = Int32.Parse(lvi.SubItems[0].Text);
                ProductDao.deleteById_sale(id);
                lvi.Remove();
            }
            else
            {
            }
        }

        private void MenuItem_edit_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("请选择要编辑的数据");
                return;
            }
            ListViewItem lvi = this.listView1.SelectedItems[0];
            int id = Int32.Parse(lvi.SubItems[0].Text);
            SaleEditForm saleEditForm = new SaleEditForm(id,this.listView1.SelectedIndices[0]);
            saleEditForm._form = this;
            saleEditForm.Owner = this;
            saleEditForm.ShowDialog();
        }
    }
}
