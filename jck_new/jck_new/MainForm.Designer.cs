namespace jck_new
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
            this.buy_btn = new System.Windows.Forms.ToolStripButton();
            this.huose_btn = new System.Windows.Forms.ToolStripButton();
            this.search_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.help_btn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.maintool.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockPanel1
            // 
            this.dockPanel1.ActiveAutoHideContent = null;
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.RightToLeftLayout = true;
            this.dockPanel1.Size = new System.Drawing.Size(752, 403);
            this.dockPanel1.TabIndex = 1;
            // 
            // maintool
            // 
            this.maintool.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.maintool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintool_btn,
            this.toolStripSeparator1,
            this.sale_btn,
            this.buy_btn,
            this.huose_btn,
            this.search_btn,
            this.toolStripSeparator2,
            this.help_btn});
            this.maintool.Location = new System.Drawing.Point(0, 0);
            this.maintool.Name = "maintool";
            this.maintool.Size = new System.Drawing.Size(752, 39);
            this.maintool.TabIndex = 4;
            this.maintool.Text = "toolStrip1";
            // 
            // maintool_btn
            // 
            this.maintool_btn.Image = ((System.Drawing.Image)(resources.GetObject("maintool_btn.Image")));
            this.maintool_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.maintool_btn.Name = "maintool_btn";
            this.maintool_btn.Size = new System.Drawing.Size(80, 36);
            this.maintool_btn.Text = "导航条";
            this.maintool_btn.Click += new System.EventHandler(this.maintool_btn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // sale_btn
            // 
            this.sale_btn.Image = ((System.Drawing.Image)(resources.GetObject("sale_btn.Image")));
            this.sale_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sale_btn.Name = "sale_btn";
            this.sale_btn.Size = new System.Drawing.Size(68, 36);
            this.sale_btn.Text = "销售";
            this.sale_btn.Click += new System.EventHandler(this.sale_btn_Click);
            // 
            // buy_btn
            // 
            this.buy_btn.Image = ((System.Drawing.Image)(resources.GetObject("buy_btn.Image")));
            this.buy_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buy_btn.Name = "buy_btn";
            this.buy_btn.Size = new System.Drawing.Size(68, 36);
            this.buy_btn.Text = "进货";
            this.buy_btn.Click += new System.EventHandler(this.buy_btn_Click);
            // 
            // huose_btn
            // 
            this.huose_btn.Image = ((System.Drawing.Image)(resources.GetObject("huose_btn.Image")));
            this.huose_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.huose_btn.Name = "huose_btn";
            this.huose_btn.Size = new System.Drawing.Size(92, 36);
            this.huose_btn.Text = "库存管理";
            // 
            // search_btn
            // 
            this.search_btn.Image = ((System.Drawing.Image)(resources.GetObject("search_btn.Image")));
            this.search_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(68, 36);
            this.search_btn.Text = "统计";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // help_btn
            // 
            this.help_btn.Image = ((System.Drawing.Image)(resources.GetObject("help_btn.Image")));
            this.help_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(68, 36);
            this.help_btn.Text = "帮助";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 381);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(752, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 403);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.maintool);
            this.Controls.Add(this.dockPanel1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "M销售系统";
            this.maintool.ResumeLayout(false);
            this.maintool.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton search_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton help_btn;
        private System.Windows.Forms.ToolStripButton huose_btn;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

