﻿namespace jck_new
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.maintool = new System.Windows.Forms.ToolStrip();
            this.maintool_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sale_btn = new System.Windows.Forms.ToolStripButton();
            this.tj_btn = new System.Windows.Forms.ToolStripButton();
            this.lb_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.buy_btn = new System.Windows.Forms.ToolStripButton();
            this.kc_btn = new System.Windows.Forms.ToolStripButton();
            this.hy_btn = new System.Windows.Forms.ToolStripButton();
            this.out_btn = new System.Windows.Forms.ToolStripButton();
            this.bf_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.logon_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.help_btn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.maintool.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockPanel1
            // 
            this.dockPanel1.ActiveAutoHideContent = null;
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.RightToLeftLayout = true;
            this.dockPanel1.Size = new System.Drawing.Size(904, 402);
            this.dockPanel1.TabIndex = 1;
            // 
            // maintool
            // 
            this.maintool.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.maintool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintool_btn,
            this.toolStripSeparator1,
            this.sale_btn,
            this.tj_btn,
            this.lb_btn,
            this.toolStripSeparator4,
            this.buy_btn,
            this.kc_btn,
            this.hy_btn,
            this.out_btn,
            this.bf_btn,
            this.toolStripSeparator2,
            this.logon_btn,
            this.toolStripSeparator3,
            this.help_btn});
            this.maintool.Location = new System.Drawing.Point(0, 0);
            this.maintool.Name = "maintool";
            this.maintool.Size = new System.Drawing.Size(904, 39);
            this.maintool.TabIndex = 4;
            this.maintool.Text = "toolStrip1";
            // 
            // maintool_btn
            // 
            this.maintool_btn.Image = global::jck_new.Properties.Resources.onebit_01;
            this.maintool_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.maintool_btn.Name = "maintool_btn";
            this.maintool_btn.Size = new System.Drawing.Size(80, 36);
            this.maintool_btn.Text = "搜索栏";
            this.maintool_btn.Click += new System.EventHandler(this.maintool_btn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // sale_btn
            // 
            this.sale_btn.Image = global::jck_new.Properties.Resources.onebit_20;
            this.sale_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sale_btn.Name = "sale_btn";
            this.sale_btn.Size = new System.Drawing.Size(68, 36);
            this.sale_btn.Text = "销售";
            this.sale_btn.Click += new System.EventHandler(this.sale_btn_Click);
            // 
            // tj_btn
            // 
            this.tj_btn.Image = global::jck_new.Properties.Resources.onebit_02;
            this.tj_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tj_btn.Name = "tj_btn";
            this.tj_btn.Size = new System.Drawing.Size(68, 36);
            this.tj_btn.Text = "统计";
            this.tj_btn.Click += new System.EventHandler(this.tj_btn_Click);
            // 
            // lb_btn
            // 
            this.lb_btn.Image = global::jck_new.Properties.Resources.onebit_03;
            this.lb_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lb_btn.Name = "lb_btn";
            this.lb_btn.Size = new System.Drawing.Size(68, 36);
            this.lb_btn.Text = "类别";
            this.lb_btn.Click += new System.EventHandler(this.lb_btn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // buy_btn
            // 
            this.buy_btn.Image = global::jck_new.Properties.Resources.onebit_44;
            this.buy_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buy_btn.Name = "buy_btn";
            this.buy_btn.Size = new System.Drawing.Size(68, 36);
            this.buy_btn.Text = "进货";
            this.buy_btn.Click += new System.EventHandler(this.buy_btn_Click);
            // 
            // kc_btn
            // 
            this.kc_btn.Image = global::jck_new.Properties.Resources.onebit_14;
            this.kc_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kc_btn.Name = "kc_btn";
            this.kc_btn.Size = new System.Drawing.Size(68, 36);
            this.kc_btn.Text = "库存";
            this.kc_btn.Click += new System.EventHandler(this.kc_btn_Click);
            // 
            // hy_btn
            // 
            this.hy_btn.Image = global::jck_new.Properties.Resources.onebit_18;
            this.hy_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hy_btn.Name = "hy_btn";
            this.hy_btn.Size = new System.Drawing.Size(68, 36);
            this.hy_btn.Text = "会员";
            this.hy_btn.Click += new System.EventHandler(this.hy_btn_Click);
            // 
            // out_btn
            // 
            this.out_btn.Image = global::jck_new.Properties.Resources.onebit_13;
            this.out_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.out_btn.Name = "out_btn";
            this.out_btn.Size = new System.Drawing.Size(68, 36);
            this.out_btn.Text = "导出";
            this.out_btn.Click += new System.EventHandler(this.out_btn_Click);
            // 
            // bf_btn
            // 
            this.bf_btn.Image = global::jck_new.Properties.Resources.onebit_12;
            this.bf_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bf_btn.Name = "bf_btn";
            this.bf_btn.Size = new System.Drawing.Size(68, 36);
            this.bf_btn.Text = "备份";
            this.bf_btn.Click += new System.EventHandler(this.bf_btn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // logon_btn
            // 
            this.logon_btn.Image = global::jck_new.Properties.Resources.onebit_23;
            this.logon_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logon_btn.Name = "logon_btn";
            this.logon_btn.Size = new System.Drawing.Size(68, 36);
            this.logon_btn.Text = "登录";
            this.logon_btn.Click += new System.EventHandler(this.logon_btn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // help_btn
            // 
            this.help_btn.Image = ((System.Drawing.Image)(resources.GetObject("help_btn.Image")));
            this.help_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(68, 36);
            this.help_btn.Text = "帮助";
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(904, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "未登录";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 402);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.maintool);
            this.Controls.Add(this.dockPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "销售系统 v1.2 默默King专用 测试版";
            this.maintool.ResumeLayout(false);
            this.maintool.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private System.Windows.Forms.ToolStrip maintool;
        private System.Windows.Forms.ToolStripButton maintool_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton sale_btn;
        private System.Windows.Forms.ToolStripButton buy_btn;
        private System.Windows.Forms.ToolStripButton tj_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton help_btn;
        private System.Windows.Forms.ToolStripButton kc_btn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton bf_btn;
        private System.Windows.Forms.ToolStripButton out_btn;
        private System.Windows.Forms.ToolStripButton lb_btn;
        private System.Windows.Forms.ToolStripButton logon_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton hy_btn;
    }
}

