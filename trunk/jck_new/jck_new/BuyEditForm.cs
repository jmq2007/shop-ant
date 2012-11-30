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
    public partial class BuyEditForm : Form
    {
        Product_buy product;
        public BuyForm _form { get; set; }
        int lId = 0;
        public BuyEditForm(int id, int id2)
        {
            
            product = ProductDao.getById(id);
            InitializeComponent();
            lId = id2;
            this.txt_code.Text = product.Code;
            this.txt_name.Text = product.Name;
            this.txt_saleprice.Text = product.Price_sale.ToString();
            this.num_amount.Value = product.Amount;
            this.txt_price.Text = product.Price.ToString();
            this.txt_other.Text = product.Other;
            this.dateTimePicker1.Value = product.BuyDate;

            DataSet ds = ProductDao.getAllLb();
            int j = 0;
            for (int i = 0; i < ds.Tables["ds"].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables["ds"].Rows[i]["class"]);
                if (ds.Tables["ds"].Rows[i]["class"].ToString() == product.NameClass)
                {
                    j = i;
                }
            }
            comboBox1.SelectedIndex = j;
        }

        private void but_save_Click(object sender, EventArgs e)
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
                strErrorMsg.Append("售价必须为数字\n");
            }

            if (strErrorMsg.Length > 0)
            {
                MessageBox.Show(strErrorMsg.ToString(), "出错提示");
                return;
            }
            Product_buy newProduct = new Product_buy();
            newProduct.Id = product.Id;
            newProduct.Code = product.Code;
           // newProduct.Name = product.Name;

            newProduct.Name = this.txt_name.Text;
            newProduct.NameClass = this.comboBox1.SelectedItem.ToString();
            newProduct.Price_sale = Double.Parse(this.txt_saleprice.Text);
            newProduct.Amount = Int32.Parse(this.num_amount.Text.Trim());
            newProduct.Price = Double.Parse(this.txt_price.Text);
            //newProduct.NameClass = product.NameClass;
            newProduct.BuyDate = this.dateTimePicker1.Value;
            newProduct.Other = this.txt_other.Text;
            ProductDao.update(newProduct);
            MessageBox.Show("保存成功", "提示");

            ListViewItem lvi = _form.listView1.Items[lId];//.Add(newProduct.Id.ToString());
            lvi.Text = newProduct.Id.ToString();
            lvi.SubItems[1].Text = newProduct.Code;
            lvi.SubItems[2].Text = (newProduct.NameClass.ToString());
            lvi.SubItems[3].Text = (newProduct.Name.ToString());
            lvi.SubItems[4].Text = newProduct.Price_sale.ToString();
            lvi.SubItems[5].Text = newProduct.Amount.ToString();
            lvi.SubItems[6].Text = newProduct.Price.ToString();
            lvi.SubItems[7].Text = newProduct.BuyDate.ToString();
            lvi.SubItems[8].Text = newProduct.Other.ToString();
            this.Close();
        }

        private void btn_canel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
