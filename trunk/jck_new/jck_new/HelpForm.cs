using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jck_new
{
    public partial class HelpForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void qq_btn_Click(object sender, EventArgs e)
        {
            string qq="703309819";
            System.Diagnostics.Process.Start("tencent://message/?uin=" + qq + "&Site=hexun.com/banvyouhun&Menu=yes");
        }
    }
}
