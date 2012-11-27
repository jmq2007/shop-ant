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

    public partial class LoginForm : Form
    {
        public MainForm _form { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                MessageBox.Show("请输入密码");
                return;
            }
            if (ProductDao.getLogin(" ", txt_password.Text.Trim()) > 0)
            {
                MessageBox.Show("登录成功", "恭喜");
                txt_password.Text = "";
                _form.toolStripStatusLabel1.Text = "已经登录";
                _form.isLogin = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("密码有误", "提示");
            }
        }
    }
}
