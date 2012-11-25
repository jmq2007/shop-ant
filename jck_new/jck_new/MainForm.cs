using System;
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
        private TjForm tjForm = new TjForm();
        private KcForm kcForm = new KcForm();
        private HelpForm helpForm = new HelpForm();
        private LbForm lbForm = new LbForm();

        #endregion
        public MainForm()
        {
            InitializeComponent();

            mainToolWin.Show(this.dockPanel1, DockState.DockLeft);
            saleForm.Show(this.dockPanel1);
            //buyForm.Show(this.dockPanel1);


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

        private void kc_btn_Click(object sender, EventArgs e)
        {
            if (kcForm == null || kcForm.IsDisposed)
                kcForm = new KcForm();
            kcForm.Show(this.dockPanel1);
        }

        private void tj_btn_Click(object sender, EventArgs e)
        {
            if (tjForm == null || tjForm.IsDisposed)
                tjForm = new TjForm();
            tjForm.Show(this.dockPanel1);
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            if (helpForm == null || helpForm.IsDisposed)
                helpForm = new HelpForm();
            helpForm.Show(this.dockPanel1);
        }

        private void lb_btn_Click(object sender, EventArgs e)
        {
            if (lbForm == null || lbForm.IsDisposed)
                lbForm = new LbForm();
            lbForm.Show(this.dockPanel1);
        }
    }
}
