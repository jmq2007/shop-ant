namespace jck_new
{
    partial class SaleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_other = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_saleprice = new System.Windows.Forms.TextBox();
            this.num_amount = new System.Windows.Forms.NumericUpDown();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMsg = new System.Windows.Forms.Label();
            this.lastP_btn = new System.Windows.Forms.Button();
            this.nextP_btn = new System.Windows.Forms.Button();
            this.prevP_btn = new System.Windows.Forms.Button();
            this.firstP_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_del = new System.Windows.Forms.ToolStripMenuItem();
            this.search_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_amount)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_other
            // 
            this.txt_other.Location = new System.Drawing.Point(257, 44);
            this.txt_other.Name = "txt_other";
            this.txt_other.Size = new System.Drawing.Size(150, 21);
            this.txt_other.TabIndex = 37;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(556, 10);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 21);
            this.txt_price.TabIndex = 36;
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(54, 44);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(151, 21);
            this.txt_name.TabIndex = 35;
            // 
            // txt_saleprice
            // 
            this.txt_saleprice.Location = new System.Drawing.Point(257, 10);
            this.txt_saleprice.Name = "txt_saleprice";
            this.txt_saleprice.Size = new System.Drawing.Size(100, 21);
            this.txt_saleprice.TabIndex = 34;
            // 
            // num_amount
            // 
            this.num_amount.Location = new System.Drawing.Point(404, 8);
            this.num_amount.Name = "num_amount";
            this.num_amount.Size = new System.Drawing.Size(100, 21);
            this.num_amount.TabIndex = 33;
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(54, 10);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(100, 21);
            this.txt_code.TabIndex = 32;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(429, 42);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 31;
            this.add_btn.Text = "卖出";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "备注:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "单价:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "总价:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "数量:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "名称:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "条码:";
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Location = new System.Drawing.Point(12, 283);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(29, 12);
            this.labelMsg.TabIndex = 24;
            this.labelMsg.Text = "数量";
            // 
            // lastP_btn
            // 
            this.lastP_btn.Location = new System.Drawing.Point(547, 278);
            this.lastP_btn.Name = "lastP_btn";
            this.lastP_btn.Size = new System.Drawing.Size(25, 28);
            this.lastP_btn.TabIndex = 23;
            this.lastP_btn.Text = ">|";
            this.lastP_btn.UseVisualStyleBackColor = true;
            this.lastP_btn.Click += new System.EventHandler(this.lastP_btn_Click);
            // 
            // nextP_btn
            // 
            this.nextP_btn.Location = new System.Drawing.Point(516, 278);
            this.nextP_btn.Name = "nextP_btn";
            this.nextP_btn.Size = new System.Drawing.Size(25, 28);
            this.nextP_btn.TabIndex = 22;
            this.nextP_btn.Text = ">";
            this.nextP_btn.UseVisualStyleBackColor = true;
            this.nextP_btn.Click += new System.EventHandler(this.nextP_btn_Click);
            // 
            // prevP_btn
            // 
            this.prevP_btn.Location = new System.Drawing.Point(467, 278);
            this.prevP_btn.Name = "prevP_btn";
            this.prevP_btn.Size = new System.Drawing.Size(25, 28);
            this.prevP_btn.TabIndex = 21;
            this.prevP_btn.Text = "<";
            this.prevP_btn.UseVisualStyleBackColor = true;
            this.prevP_btn.Click += new System.EventHandler(this.prevP_btn_Click);
            // 
            // firstP_btn
            // 
            this.firstP_btn.Location = new System.Drawing.Point(436, 278);
            this.firstP_btn.Name = "firstP_btn";
            this.firstP_btn.Size = new System.Drawing.Size(25, 28);
            this.firstP_btn.TabIndex = 20;
            this.firstP_btn.Text = "|<";
            this.firstP_btn.UseVisualStyleBackColor = true;
            this.firstP_btn.Click += new System.EventHandler(this.firstP_btn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(660, 205);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "条码";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "类型";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "名称";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "单价";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "数量";
            this.columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "总价";
            this.columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "售出时间";
            this.columnHeader8.Width = 130;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "备注";
            this.columnHeader9.Width = 80;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_edit,
            this.MenuItem_del});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // MenuItem_edit
            // 
            this.MenuItem_edit.Name = "MenuItem_edit";
            this.MenuItem_edit.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_edit.Text = "编辑";
            this.MenuItem_edit.Click += new System.EventHandler(this.MenuItem_edit_Click);
            // 
            // MenuItem_del
            // 
            this.MenuItem_del.Name = "MenuItem_del";
            this.MenuItem_del.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_del.Text = "删除";
            this.MenuItem_del.Click += new System.EventHandler(this.MenuItem_del_Click);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(161, 8);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(45, 23);
            this.search_btn.TabIndex = 38;
            this.search_btn.Text = "查找";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 312);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.txt_other);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_saleprice);
            this.Controls.Add(this.num_amount);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.lastP_btn);
            this.Controls.Add(this.nextP_btn);
            this.Controls.Add(this.prevP_btn);
            this.Controls.Add(this.firstP_btn);
            this.Controls.Add(this.listView1);
            this.Name = "SaleForm";
            this.TabText = "销售";
            this.Text = "销售";
            ((System.ComponentModel.ISupportInitialize)(this.num_amount)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_other;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_saleprice;
        private System.Windows.Forms.NumericUpDown num_amount;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.Button lastP_btn;
        private System.Windows.Forms.Button nextP_btn;
        private System.Windows.Forms.Button prevP_btn;
        private System.Windows.Forms.Button firstP_btn;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_edit;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_del;
    }
}