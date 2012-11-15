namespace jck_new
{
    partial class BuyForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstP_btn = new System.Windows.Forms.Button();
            this.prevP_btn = new System.Windows.Forms.Button();
            this.nextP_btn = new System.Windows.Forms.Button();
            this.lastP_btn = new System.Windows.Forms.Button();
            this.labelMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.columnHeader8});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(627, 189);
            this.listView1.TabIndex = 0;
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
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "名称";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "数量";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "进价";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "售价";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "时间";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "备注";
            this.columnHeader8.Width = 100;
            // 
            // firstP_btn
            // 
            this.firstP_btn.Location = new System.Drawing.Point(435, 281);
            this.firstP_btn.Name = "firstP_btn";
            this.firstP_btn.Size = new System.Drawing.Size(25, 28);
            this.firstP_btn.TabIndex = 1;
            this.firstP_btn.Text = "|<";
            this.firstP_btn.UseVisualStyleBackColor = true;
            this.firstP_btn.Click += new System.EventHandler(this.firstP_btn_Click);
            // 
            // prevP_btn
            // 
            this.prevP_btn.Location = new System.Drawing.Point(466, 281);
            this.prevP_btn.Name = "prevP_btn";
            this.prevP_btn.Size = new System.Drawing.Size(25, 28);
            this.prevP_btn.TabIndex = 2;
            this.prevP_btn.Text = "<";
            this.prevP_btn.UseVisualStyleBackColor = true;
            this.prevP_btn.Click += new System.EventHandler(this.prevP_btn_Click);
            // 
            // nextP_btn
            // 
            this.nextP_btn.Location = new System.Drawing.Point(515, 281);
            this.nextP_btn.Name = "nextP_btn";
            this.nextP_btn.Size = new System.Drawing.Size(25, 28);
            this.nextP_btn.TabIndex = 3;
            this.nextP_btn.Text = ">";
            this.nextP_btn.UseVisualStyleBackColor = true;
            this.nextP_btn.Click += new System.EventHandler(this.nextP_btn_Click);
            // 
            // lastP_btn
            // 
            this.lastP_btn.Location = new System.Drawing.Point(546, 281);
            this.lastP_btn.Name = "lastP_btn";
            this.lastP_btn.Size = new System.Drawing.Size(25, 28);
            this.lastP_btn.TabIndex = 4;
            this.lastP_btn.Text = ">|";
            this.lastP_btn.UseVisualStyleBackColor = true;
            this.lastP_btn.Click += new System.EventHandler(this.lastP_btn_Click);
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Location = new System.Drawing.Point(11, 286);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(29, 12);
            this.labelMsg.TabIndex = 5;
            this.labelMsg.Text = "数量";
            // 
            // BuyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 317);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.lastP_btn);
            this.Controls.Add(this.nextP_btn);
            this.Controls.Add(this.prevP_btn);
            this.Controls.Add(this.firstP_btn);
            this.Controls.Add(this.listView1);
            this.Name = "BuyForm";
            this.TabText = "进货";
            this.Text = "进货";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button firstP_btn;
        private System.Windows.Forms.Button prevP_btn;
        private System.Windows.Forms.Button nextP_btn;
        private System.Windows.Forms.Button lastP_btn;
        private System.Windows.Forms.Label labelMsg;
    }
}