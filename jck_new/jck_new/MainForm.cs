﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace jck_new
{
    public partial class MainForm : Form
    {
        #region 属性字段

        private MainToolWindow mainToolWin = new MainToolWindow();
        private SaleForm saleForm = new SaleForm();
        private BuyForm buyForm = new BuyForm();

        #endregion
        public MainForm()
        {
            InitializeComponent();

            mainToolWin.Show(this.dockPanel1, DockState.DockLeft);
            saleForm.Show(this.dockPanel1);
            buyForm.Show(this.dockPanel1);
        }

        private void maintool_btn_Click(object sender, EventArgs e)
        {
            if (mainToolWin == null || mainToolWin.IsDisposed)
                mainToolWin = new MainToolWindow();
            mainToolWin.Show(this.dockPanel1, DockState.DockLeft);
        }

        private void sale_btn_Click(object sender, EventArgs e)
        {
            if (saleForm == null || saleForm.IsDisposed)
               saleForm = new SaleForm();
            saleForm.Show(this.dockPanel1);
        }

        private void buy_btn_Click(object sender, EventArgs e)
        {
            if (buyForm == null || buyForm.IsDisposed)
                buyForm = new BuyForm();
            buyForm.Show(this.dockPanel1);
        }
    }
}
