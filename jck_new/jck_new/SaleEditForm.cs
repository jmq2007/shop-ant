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
    public partial class SaleEditForm : Form
    {
        Product_sale product;
        public SaleForm _form { get; set; }
        int lId = 0;
        public SaleEditForm(int id,int id2)
        {
            product = ProductDao.getById_sale(id);

            InitializeComponent();
            DataTable dt = ProductDao.phoneAuto().Tables["ds"];
            string[] str_txt = new string[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str_txt[i] = dt.Rows[i]["phone"].ToString();
            }
            this.txt_phone.AutoCompleteCustomSource.AddRange(str_txt);
            this.txt_phone.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.txt_phone.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

           
            lId = id2;
            this.txt_code.Text = product.Code;
            this.txt_name.Text = product.Name;
            this.txt_saleprice.Text = product.Price_sale.ToString();
            this.num_amount.Value = product.Amount;
            this.txt_price.Text = product.Price.ToString();
            this.txt_other.Text = product.Other;
            this.dateTimePicker1.Value = product.BuyDate;
            this.txt_phone.Text = product.Phone;
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
                strErrorMsg.Append("总价必须为数字\n");
            }
            if (!Validator.checkInteger(this.txt_phone.Text))
            {
                strErrorMsg.Append("手机必须为数字\n");
            }
            if (strErrorMsg.Length > 0)
            {
                MessageBox.Show(strErrorMsg.ToString(), "出错提示");
                return;
            }
            Product_sale newProduct = new Product_sale();
            newProduct.Id = product.Id;
            newProduct.Code = product.Code;
            newProduct.Name = product.Name;

            newProduct.Price_sale = Double.Parse(this.txt_saleprice.Text);
            newProduct.Amount = Int32.Parse(this.num_amount.Text.Trim());
            newProduct.Price = Double.Parse(this.txt_price.Text);
            newProduct.NameClass = product.NameClass;
            newProduct.BuyDate = this.dateTimePicker1.Value;
            newProduct.Other = this.txt_other.Text;
            newProduct.Phone = this.txt_phone.Text.Trim();
            ProductDao.update_sale(newProduct);
            MessageBox.Show("保存成功", "提示");

            ListViewItem lvi = _form.listView1.Items[lId];//.Add(newProduct.Id.ToString());
            lvi.Text = newProduct.Id.ToString();
            lvi.SubItems[1].Text=newProduct.Code;
            lvi.SubItems[2].Text =(newProduct.NameClass.ToString());
            lvi.SubItems[3].Text = (newProduct.Name.ToString());
            lvi.SubItems[4].Text=newProduct.Price_sale.ToString();
            lvi.SubItems[5].Text=newProduct.Amount.ToString();
            lvi.SubItems[6].Text=newProduct.Price.ToString();
            lvi.SubItems[7].Text=newProduct.BuyDate.ToString();
            lvi.SubItems[8].Text=newProduct.Other.ToString();
            this.Close();
        }

        private void btn_canel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
