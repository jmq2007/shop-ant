﻿using System;
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
        public SaleForm()
        {
            InitializeComponent();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            Product_buy product_buy = ProductDao.getByCode(this.txt_code.Text);
            MessageBox.Show(product_buy.Name);
        }
    }
}
