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
            DataSet ds = ProductDao.getAllLb();
            this.num_amount.Value = 1;

            for (int i=0; i < ds.Tables["ds"].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables["ds"].Rows[i]["class"]);
            }
            comboBox1.SelectedIndex = 0;
            curPageIndex = 0;
            Page page = PageQueryDao.getProducts_buy(curPageIndex);
            List<Product_buy> ls = (List<Product_buy>)page.ValueList;
            //init product  list view
            foreach (Product_buy p in ls)
            {
                AddProduct_buy(p);
            }
            ChangeClour(listView1);
            this.labelMsg.Text = String.Format("共{0:d}条记录, 每页{1:d}条, {2:d}/{3:d}页",
                                        page.TotalRecord, page.PageSize, page.CurPageIndex + 1, page.TotalPage);

            curPageIndex = page.CurPageIndex;
            totalPage = page.TotalPage;

        }
        private void AddProduct_buy(Product_buy p)
        {
            ListViewItem lvi = this.listView1.Items.Add(p.Id.ToString());
            lvi.SubItems.Add(p.Code);
            lvi.SubItems.Add(p.NameClass);
            lvi.SubItems.Add(p.Name.ToString());
           
            lvi.SubItems.Add(p.Price.ToString());
            lvi.SubItems.Add(p.Amount.ToString());
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
            List<Product_buy> ls = (List<Product_buy>)page.ValueList;
            foreach (Product_buy p in ls)
            {
                AddProduct_buy(p);
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
            List<Product_buy> ls = (List<Product_buy>)page.ValueList;
            foreach (Product_buy p in ls)
            {
                AddProduct_buy(p);
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
            List<Product_buy> ls = (List<Product_buy>)page.ValueList;
            foreach (Product_buy p in ls)
            {
                AddProduct_buy(p);
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
            if (!Validator.checkDouble(this.txt_price.Text) && !Validator.checkInteger(this.txt_price.Text))
            {
                strErrorMsg.Append("单价必须为数字\n");
            }
            if (!Validator.checkDouble(this.txt_saleprice.Text) && !Validator.checkInteger(this.txt_saleprice.Text))
            {
                strErrorMsg.Append("售价必须为数字\n");
            }
            if (strErrorMsg.Length > 0)
            {
                MessageBox.Show(strErrorMsg.ToString(), "出错提示");
                return;
            }
            Product_buy p = new Product_buy();
            p.Code = this.txt_code.Text.Trim();
            p.NameClass = this.comboBox1.SelectedItem.ToString();
            p.Name = this.txt_name.Text.Trim();
            p.Amount = Int32.Parse(this.num_amount.Text.Trim());
            p.Price = Double.Parse(this.txt_price.Text.Trim());
            p.Price_sale = Double.Parse(this.txt_saleprice.Text.Trim());
            p.BuyDate = DateTime.Now;
            p.Other = this.txt_other.Text.Trim();
            int id = ProductDao.insert(p);
            //
            p = ProductDao.getById(id);
            Insertroduct(p);
        }
        private void AddProduct(Product_buy p)
        {
            ListViewItem lvi = this.listView1.Items.Add(p.Id.ToString());
            lvi.SubItems.Add(p.Code.ToString());
            lvi.SubItems.Add(p.NameClass.ToString());
            lvi.SubItems.Add(p.Name.ToString());
            lvi.SubItems.Add(p.Price.ToString());
            lvi.SubItems.Add(p.Amount.ToString());
            
            lvi.SubItems.Add(p.Price_sale.ToString());
            lvi.SubItems.Add(p.BuyDate.ToString());
            lvi.SubItems.Add(p.Other.ToString());
        }
        private void Insertroduct(Product_buy p)
        {
            ListViewItem lvi = this.listView1.Items.Insert(0, new ListViewItem(p.Id.ToString()));
            lvi.SubItems.Add(p.Code.ToString());
            lvi.SubItems.Add(p.NameClass.ToString());
            lvi.SubItems.Add(p.Name.ToString());
            lvi.SubItems.Add(p.Price.ToString());
            lvi.SubItems.Add(p.Amount.ToString());

            lvi.SubItems.Add(p.Price_sale.ToString());
            lvi.SubItems.Add(p.BuyDate.ToString());
            lvi.SubItems.Add(p.Other.ToString());
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
            if (this.listView1.SelectedItems.Count <1)
            {
                MessageBox.Show("请选择要删除的数据");
                return;
            }
            ListViewItem lvi = this.listView1.SelectedItems[0];
            //int id = Int32.Parse(lvi.SubItems[0].Text);
            string code = lvi.SubItems[1].Text;
            if (ProductDao.getByCode_sale(code)!=null)
            {
                MessageBox.Show("此商品已经有售出，不能删除");
                return;
            }
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要删除吗?", "提示", messButton);
            if (dr == DialogResult.OK)
            {
                //ListViewItem lvi = this.listView1.SelectedItems[0];
                int id = Int32.Parse(lvi.SubItems[0].Text);
                ProductDao.deleteById(id);
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
            BuyEditForm buyEditForm = new BuyEditForm(id, this.listView1.SelectedIndices[0]);
            buyEditForm._form = this;
            buyEditForm.Owner = this;
            buyEditForm.ShowDialog();
        }
    }
}
