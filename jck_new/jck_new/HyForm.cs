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
    public partial class HyForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private int curPageIndex;
        private int totalPage;
        private ListViewItem curLvi;
        int flag = 0;//0全部或者1条件
        string key = "";
        int sIndex = 1;
        public HyForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            curPageIndex = 0;
            Page page = PageQueryDao.getMember(curPageIndex);
            List<Member> ls = (List<Member>)page.ValueList;
            //init product  list view
            foreach (Member p in ls)
            {
                AddMember(p);
            }
            ChangeClour(listView1);
            this.labelMsg.Text = String.Format("共{0:d}条记录, 每页{1:d}条, {2:d}/{3:d}页",
                                        page.TotalRecord, page.PageSize, page.CurPageIndex + 1, page.TotalPage);

            curPageIndex = page.CurPageIndex;
            totalPage = page.TotalPage;
        }
        private void AddMember(Member p)
        {
            ListViewItem lvi = this.listView1.Items.Add(p.Id.ToString());
            lvi.SubItems.Add(p.Username);
            lvi.SubItems.Add(p.Phone);
            lvi.SubItems.Add(p.Price.ToString());
            lvi.SubItems.Add(p.UserClass);
            lvi.SubItems.Add(p.CDate.ToString());
            lvi.SubItems.Add(p.Other.ToString());
        }

        private void ChangeClour(ListView listView)
        {
            for (int i = 0; i < listView.Items.Count; i++)
            {
                if (i % 2 == 0)
                {
                    listView.Items[i].BackColor = Color.WhiteSmoke;
                }
            }
        }
        private void add_btn_Click(object sender, EventArgs e)
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
            if (ProductDao.getMemberByPhone(this.txt_phone.Text.Trim()) > 0)
            {
                MessageBox.Show("用户已经存在", "提示");
                return;
            }
            Member p = new Member();
            p.Phone = this.txt_phone.Text.Trim();
            p.Username = this.txt_name.Text.Trim();
            p.UserClass = this.txt_class.Text.Trim();
            p.Other = this.txt_other.Text.Trim();
            p.CDate = DateTime.Now;
            p.Other = this.txt_other.Text.Trim();
            int id = ProductDao.insert_member(p);
            //
            p = ProductDao.getById_member(id);
            Insertroduct(p);
        }

        private void Insertroduct(Member p)
        {
            ListViewItem lvi = this.listView1.Items.Insert(0, new ListViewItem(p.Id.ToString()));
            lvi.SubItems.Add(p.Username.ToString());
            lvi.SubItems.Add(p.Phone.ToString());
            lvi.SubItems.Add("0");
            lvi.SubItems.Add(p.UserClass.ToString());
            lvi.SubItems.Add(p.CDate.ToString());
            lvi.SubItems.Add(p.Other.ToString());
        }
        private void nextP_btn_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            curPageIndex++;
            Page page = new Page();
            if (flag == 0)
            {
                page = PageQueryDao.getMember(curPageIndex);
            }
            else
            {
                Member kc = new Member();
                switch (sIndex)
                {
                    case 0: kc.Phone = key; break;
                    case 1: kc.Username = key; break;
                    case 2: kc.UserClass = key; break;
                }
                page = PageQueryDao.getMember(curPageIndex, kc);
            }
            List<Member> ls = (List<Member>)page.ValueList;
            foreach (Member p in ls)
            {
                AddMember(p);
                //Debug.WriteLine(p.Id);
            }
            ChangeClour(listView1);
            this.labelMsg.Text = String.Format("共{0:d}条记录, 每页{1:d}条, {2:d}/{3:d}页",
                                        page.TotalRecord, page.PageSize, page.CurPageIndex + 1, page.TotalPage);

            curPageIndex = page.CurPageIndex;
            totalPage = page.TotalPage;
        }

        private void prevP_btn_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            curPageIndex--;
            Page page = new Page();
            if (flag == 0)
            {
                page = PageQueryDao.getMember(curPageIndex);
            }
            else
            {
                Member kc = new Member();
                switch (sIndex)
                {
                    case 0: kc.Phone = key; break;
                    case 1: kc.Username = key; break;
                    case 2: kc.UserClass = key; break;
                }
                page = PageQueryDao.getMember(curPageIndex, kc);
            }
            List<Member> ls = (List<Member>)page.ValueList;
            foreach (Member p in ls)
            {
                AddMember(p);
                //Debug.WriteLine(p.Id);
            }
            ChangeClour(listView1);
            this.labelMsg.Text = String.Format("共{0:d}条记录, 每页{1:d}条, {2:d}/{3:d}页",
                                        page.TotalRecord, page.PageSize, page.CurPageIndex + 1, page.TotalPage);

            curPageIndex = page.CurPageIndex;
            totalPage = page.TotalPage;
        }

        private void lastP_btn_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            //Page page = PageQueryDao.getProducts_kc(totalPage - 1);
            Page page = new Page();
            if (flag == 0)
            {
                page = PageQueryDao.getMember(totalPage - 1);
            }
            else
            {
                Member kc = new Member();
                switch (sIndex)
                {
                    case 0: kc.Phone = key; break;
                    case 1: kc.Username = key; break;
                    case 2: kc.UserClass = key; break;
                }
                page = PageQueryDao.getMember(totalPage - 1, kc);
            }

            List<Member> ls = (List<Member>)page.ValueList;
            foreach (Member p in ls)
            {
                AddMember(p);
                //Debug.WriteLine(p.Id);
            }
            ChangeClour(listView1);
            this.labelMsg.Text = String.Format("共{0:d}条记录, 每页{1:d}条记录, {2:d}/{3:d}页",
                                        page.TotalRecord, page.PageSize, page.CurPageIndex + 1, page.TotalPage);

            curPageIndex = page.CurPageIndex;
            totalPage = page.TotalPage;
        }

        private void firstP_btn_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            Page page = new Page();
            if (flag == 0)
            {
                page = PageQueryDao.getMember(0);
            }
            else
            {
                Member kc = new Member();
                switch (sIndex)
                {
                    case 0: kc.Phone = key; break;
                    case 1: kc.Username = key; break;
                    case 2: kc.UserClass = key; break;
                }
                page = PageQueryDao.getMember(0, kc);
            }
            List<Member> ls = (List<Member>)page.ValueList;
            foreach (Member p in ls)
            {
                AddMember(p);
                //Debug.WriteLine(p.Id);
            }
            ChangeClour(listView1);
            this.labelMsg.Text = String.Format("共{0:d}条记录, 每页{1:d}条, {2:d}/{3:d}页",
                                        page.TotalRecord, page.PageSize, page.CurPageIndex + 1, page.TotalPage);

            curPageIndex = page.CurPageIndex;
            totalPage = page.TotalPage;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            flag = 1;
            listView1.Items.Clear();
            curPageIndex = 0;

            Member kc = new Member();
            sIndex = this.comboBox1.SelectedIndex;
            key = this.txt_key.Text;
            switch (sIndex)
            {
                case 0: kc.Phone = key; break;
                case 1: kc.Username = key; break;
                case 2: kc.UserClass = key; break;
            }

            Page page = page = PageQueryDao.getMember(curPageIndex, kc);
            List<Member> ls = (List<Member>)page.ValueList;
            //init product  list view
            foreach (Member p in ls)
            {
                AddMember(p);
            }
            ChangeClour(listView1);
            this.labelMsg.Text = String.Format("共{0:d}条记录, 每页{1:d}条, {2:d}/{3:d}页",
                                        page.TotalRecord, page.PageSize, page.CurPageIndex + 1, page.TotalPage);

            curPageIndex = page.CurPageIndex;
            totalPage = page.TotalPage;
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            flag = 0;
            listView1.Items.Clear();
            curPageIndex = 0;
            Page page = PageQueryDao.getMember(curPageIndex);
            List<Member> ls = (List<Member>)page.ValueList;
            //init product  list view
            foreach (Member p in ls)
            {
                AddMember(p);
            }
            ChangeClour(listView1);
            this.labelMsg.Text = String.Format("共{0:d}条记录, 每页{1:d}条, {2:d}/{3:d}页",
                                        page.TotalRecord, page.PageSize, page.CurPageIndex + 1, page.TotalPage);

            curPageIndex = page.CurPageIndex;
            totalPage = page.TotalPage;
        }

        private void MenuItem_edit_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("请选择要编辑的数据");
                return;
            }
            ListViewItem lvi = this.listView1.SelectedItems[0];
            int id = Int32.Parse(lvi.SubItems[0].Text);
            HyEditForm hyEditForm = new HyEditForm(id, this.listView1.SelectedIndices[0]);
            hyEditForm._form = this;
            hyEditForm.Owner = this;
            hyEditForm.ShowDialog();
        }

        private void MenuItem_del_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("请选择要删除的数据");
                return;
            }
            ListViewItem lvi = this.listView1.SelectedItems[0];
            //int id = Int32.Parse(lvi.SubItems[0].Text);
           // string code = lvi.SubItems[1].Text;
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要删除吗?", "提示", messButton);
            if (dr == DialogResult.OK)
            {
                //ListViewItem lvi = this.listView1.SelectedItems[0];
                int id = Int32.Parse(lvi.SubItems[0].Text);
                ProductDao.deleteById_member(id);
                lvi.Remove();
            }
            else
            {
            }
        }
    }
}
