using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SplashScreenControl;

namespace jck_new
{
    public partial class MainForm : Form
    {
        #region 属性字段

        private MainToolWindow mainToolWin = new MainToolWindow();
        private SaleForm saleForm = new SaleForm();
        public BuyForm buyForm = new BuyForm();//
        public TjForm tjForm = new TjForm();
        public KcForm kcForm = new KcForm();//
        public HelpForm helpForm = new HelpForm();
        public LbForm lbForm = new LbForm();
        public BfForm bfForm = new BfForm();//
        public OutForm outForm = new OutForm();//
        public LoginForm loginForm = new LoginForm();
        public LogoffForm logoffForm = new LogoffForm();
        public bool isLogin=false;

        #endregion
        public MainForm()
        {
            InitializeComponent();

            mainToolWin.Show(this.dockPanel1, DockState.DockLeft);
            saleForm.Show(this.dockPanel1);
        }

        #region 展示页
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            //this is where to call SplashScreen.EndDisplay
            //SplashScreen.SetTitleString("OnShown Override.");
            SplashScreen.SetCommentaryString("..进入系统.");
            System.Threading.Thread.Sleep(500);
            SplashScreen.EndDisplay();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //simulate delay during onload
            System.Threading.Thread.Sleep(500);

            SplashScreen.SetCommentaryString("..数据装载中.");
            System.Threading.Thread.Sleep(500);
        }
        #endregion

        #region 菜单按键

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
            if (!isLogin)
            {
                MessageBox.Show("请先以管理员身份登录", "提示");
                return;
            }
            if (buyForm == null || buyForm.IsDisposed)
                buyForm = new BuyForm();
            buyForm.Show(this.dockPanel1);
        }

        private void kc_btn_Click(object sender, EventArgs e)
        {
            if (!isLogin)
            {
                MessageBox.Show("请先以管理员身份登录", "提示");
                return;
            }

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

        private void bf_btn_Click(object sender, EventArgs e)
        {
            if (!isLogin)
            {
                MessageBox.Show("请先以管理员身份登录", "提示");
                return;
            }
            if (bfForm == null || bfForm.IsDisposed)
                bfForm = new BfForm();
            bfForm.Show(this.dockPanel1);
        }

        private void out_btn_Click(object sender, EventArgs e)
        {
            if (!isLogin)
            {
                MessageBox.Show("请先以管理员身份登录", "提示");
                return;
            }
            if (outForm == null || outForm.IsDisposed)
                outForm = new OutForm();
            outForm.Show(this.dockPanel1);
        }
        #endregion

        private void logon_btn_Click(object sender, EventArgs e)
        {
            if (!isLogin)
            {
                loginForm._form = this;
                loginForm.Owner = this;
                loginForm.ShowDialog();
            }
            else
            {
                logoffForm._form = this;
                logoffForm.Owner = this;
                logoffForm.ShowDialog();
            }

        }
    }
}
