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
    public partial class LogoffForm : Form
    {
        public MainForm _form { get; set; }
        public LogoffForm()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (this.txt_np.Text != this.txt_np2.Text)
            {
                MessageBox.Show("两次输入密码不一致","提示");
                return;
            }
            if (this.txt_np.Text == "" || this.txt_np2.Text == "")
            {
                MessageBox.Show("密码不能为空", "提示");
                return;
            }

            if (ProductDao.getLogin(" ", txt_password.Text.Trim()) > 0)
            {
                ProductDao.update_password(this.txt_np.Text.Trim());
                this.txt_password.Text = "";
                this.txt_np.Text = "";
                this.txt_np2.Text = "";
                MessageBox.Show("密码修改成功", "恭喜");
            }
            else
            {
                MessageBox.Show("原密码有误", "提示");
            }
        }

        private void btn_logoff_Click(object sender, EventArgs e)
        {
            _form.toolStripStatusLabel1.Text = "未登录";
            _form.isLogin = false;
            if (_form.outForm != null || !_form.outForm.IsDisposed)
            {
                _form.outForm.Close();
            }
            if (_form.bfForm != null || !_form.bfForm.IsDisposed)
            {
                _form.bfForm.Close();
            }
            if (_form.kcForm != null || !_form.kcForm.IsDisposed)
            {
                _form.kcForm.Close();
            }
            if (_form.buyForm != null || !_form.buyForm.IsDisposed)
            {
                _form.buyForm.Close();
            }
            this.Close();

        }
    }
}
