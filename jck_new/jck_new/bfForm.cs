using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Common;

namespace jck_new
{
    public partial class BfForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public BfForm()
        {
            InitializeComponent();
            label3.Text = ProductDao.getBak();
        }
        string lj = "";
        private void btn_copy_Click(object sender, EventArgs e)
        {
            if (lj == "")
            {
                MessageBox.Show("请选择目录","错误提示");
                return;
            }
            DateTime now = DateTime.Now;
            string sourcePath = Directory.GetCurrentDirectory() + "\\Database1.accdb";

            string targetPath = lj + "\\" + now.ToString("yyyy-MM-dd hhmmss") + "Database1.accdb";
            if (!System.IO.Directory.Exists(lj))
            {
                // 目录不存在，建立目录 
                System.IO.Directory.CreateDirectory(lj);
            }
            bool isrewrite = true; // true=覆盖已存在的同名文件,false则反之 
            ProductDao.updateBak(now.ToString());
            System.IO.File.Copy(sourcePath, targetPath, isrewrite);
            MessageBox.Show("备份成功", "提示");
            label3.Text = now.ToString();
        }

        private void btn_lj_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog bakFolder = new FolderBrowserDialog();
            bakFolder.Description = "选择所有数据库文件备份目录";
            if (bakFolder.ShowDialog(this) == DialogResult.OK)
            {
                lj = bakFolder.SelectedPath;
                txt_lj.Text = lj;
            }
        }
    }
}
