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
    public partial class HyEditForm : Form
    {
        Member member;
        int lId = 0;
        public HyForm _form { get; set; }
        public HyEditForm(int id, int id2)
        {
            member = ProductDao.getById_member(id);
            InitializeComponent();
            lId = id2;
            this.txt_phone.Text = member.Phone;
            this.txt_name.Text = member.Username;
            this.txt_class.Text = member.UserClass.ToString();
            this.txt_other.Text = member.Other.ToString();
            this.dateTimePicker1.Value = member.CDate;
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            StringBuilder strErrorMsg = new StringBuilder();
            if (!Validator.checkInteger(this.txt_phone.Text.Trim()))
            {
                strErrorMsg.Append("手机必须为数字\n");
            }
            if (!Validator.checkRequired(this.txt_name.Text))
            {
                strErrorMsg.Append("名称不能为空\n");
            }
            if (strErrorMsg.Length > 0)
            {
                MessageBox.Show(strErrorMsg.ToString(), "出错提示");
                return;
            }
            Member newMember = new Member();
            newMember.Id = member.Id;
            // newProduct.Name = product.Name;

            newMember.Username = this.txt_name.Text;
            newMember.UserClass = this.txt_class.Text;
            newMember.Phone = this.txt_phone.Text;
            newMember.CDate = this.dateTimePicker1.Value;
            newMember.Other = this.txt_other.Text;
            ProductDao.update_member(newMember);
            MessageBox.Show("保存成功", "提示");

            ListViewItem lvi = _form.listView1.Items[lId];//.Add(newProduct.Id.ToString());
            lvi.Text = newMember.Id.ToString();
            lvi.SubItems[1].Text = newMember.Username;
            lvi.SubItems[2].Text = newMember.Phone.ToString();
            lvi.SubItems[3].Text = member.Price.ToString();
            lvi.SubItems[4].Text = newMember.UserClass.ToString();
            lvi.SubItems[5].Text = newMember.CDate.ToString();
            lvi.SubItems[6].Text = newMember.Other.ToString();
            this.Close();
        }

        private void btn_canel_Click(object sender, EventArgs e)
        {

        }
    }
}
