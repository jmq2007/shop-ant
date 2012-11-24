namespace jck_new
{
    partial class KcForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_all = new System.Windows.Forms.Button();
            this.labelMsg = new System.Windows.Forms.Label();
            this.lastP_btn = new System.Windows.Forms.Button();
            this.nextP_btn = new System.Windows.Forms.Button();
            this.prevP_btn = new System.Windows.Forms.Button();
            this.firstP_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "条码",
            "名称",
            "类型"});
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "关键字:";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(310, 11);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(13, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(660, 205);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.columnHeader6.Text = "库存";
            this.columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "总价";
            this.columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "时间";
            this.columnHeader8.Width = 130;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "备注";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "售出";
            this.columnHeader1.Width = 40;
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(391, 11);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(75, 23);
            this.btn_all.TabIndex = 21;
            this.btn_all.Text = "所有";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Location = new System.Drawing.Point(15, 277);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(29, 12);
            this.labelMsg.TabIndex = 26;
            this.labelMsg.Text = "数量";
            // 
            // lastP_btn
            // 
            this.lastP_btn.Location = new System.Drawing.Point(550, 272);
            this.lastP_btn.Name = "lastP_btn";
            this.lastP_btn.Size = new System.Drawing.Size(25, 28);
            this.lastP_btn.TabIndex = 25;
            this.lastP_btn.Text = ">|";
            this.lastP_btn.UseVisualStyleBackColor = true;
            this.lastP_btn.Click += new System.EventHandler(this.lastP_btn_Click);
            // 
            // nextP_btn
            // 
            this.nextP_btn.Location = new System.Drawing.Point(519, 272);
            this.nextP_btn.Name = "nextP_btn";
            this.nextP_btn.Size = new System.Drawing.Size(25, 28);
            this.nextP_btn.TabIndex = 24;
            this.nextP_btn.Text = ">";
            this.nextP_btn.UseVisualStyleBackColor = true;
            this.nextP_btn.Click += new System.EventHandler(this.nextP_btn_Click);
            // 
            // prevP_btn
            // 
            this.prevP_btn.Location = new System.Drawing.Point(470, 272);
            this.prevP_btn.Name = "prevP_btn";
            this.prevP_btn.Size = new System.Drawing.Size(25, 28);
            this.prevP_btn.TabIndex = 23;
            this.prevP_btn.Text = "<";
            this.prevP_btn.UseVisualStyleBackColor = true;
            this.prevP_btn.Click += new System.EventHandler(this.prevP_btn_Click);
            // 
            // firstP_btn
            // 
            this.firstP_btn.Location = new System.Drawing.Point(439, 272);
            this.firstP_btn.Name = "firstP_btn";
            this.firstP_btn.Size = new System.Drawing.Size(25, 28);
            this.firstP_btn.TabIndex = 22;
            this.firstP_btn.Text = "|<";
            this.firstP_btn.UseVisualStyleBackColor = true;
            this.firstP_btn.Click += new System.EventHandler(this.firstP_btn_Click);
            // 
            // KcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 312);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.lastP_btn);
            this.Controls.Add(this.nextP_btn);
            this.Controls.Add(this.prevP_btn);
            this.Controls.Add(this.firstP_btn);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "KcForm";
            this.TabText = "库存";
            this.Text = "库存";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.Button lastP_btn;
        private System.Windows.Forms.Button nextP_btn;
        private System.Windows.Forms.Button prevP_btn;
        private System.Windows.Forms.Button firstP_btn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}