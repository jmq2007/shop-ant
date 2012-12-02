namespace jck_new
{
    partial class OutForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_out1 = new System.Windows.Forms.Button();
            this.btn_out2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_out3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_hy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(56, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 21);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(212, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(127, 21);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "到";
            // 
            // btn_out1
            // 
            this.btn_out1.Location = new System.Drawing.Point(56, 56);
            this.btn_out1.Name = "btn_out1";
            this.btn_out1.Size = new System.Drawing.Size(127, 23);
            this.btn_out1.TabIndex = 6;
            this.btn_out1.Text = "导出进货记录";
            this.btn_out1.UseVisualStyleBackColor = true;
            this.btn_out1.Click += new System.EventHandler(this.btn_out1_Click);
            // 
            // btn_out2
            // 
            this.btn_out2.Location = new System.Drawing.Point(212, 56);
            this.btn_out2.Name = "btn_out2";
            this.btn_out2.Size = new System.Drawing.Size(127, 23);
            this.btn_out2.TabIndex = 7;
            this.btn_out2.Text = "导出售出记录";
            this.btn_out2.UseVisualStyleBackColor = true;
            this.btn_out2.Click += new System.EventHandler(this.btn_out2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_out3);
            this.groupBox1.Controls.Add(this.btn_out1);
            this.groupBox1.Controls.Add(this.btn_out2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "按时间段";
            // 
            // btn_out3
            // 
            this.btn_out3.Location = new System.Drawing.Point(367, 56);
            this.btn_out3.Name = "btn_out3";
            this.btn_out3.Size = new System.Drawing.Size(127, 23);
            this.btn_out3.TabIndex = 8;
            this.btn_out3.Text = "导出利润记录";
            this.btn_out3.UseVisualStyleBackColor = true;
            this.btn_out3.Click += new System.EventHandler(this.btn_out3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_hy);
            this.groupBox2.Location = new System.Drawing.Point(13, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 127);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "按其他条件";
            // 
            // btn_hy
            // 
            this.btn_hy.Location = new System.Drawing.Point(55, 40);
            this.btn_hy.Name = "btn_hy";
            this.btn_hy.Size = new System.Drawing.Size(127, 23);
            this.btn_hy.TabIndex = 7;
            this.btn_hy.Text = "导出会员列表";
            this.btn_hy.UseVisualStyleBackColor = true;
            this.btn_hy.Click += new System.EventHandler(this.btn_hy_Click);
            // 
            // OutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 312);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OutForm";
            this.TabText = "导出数据到excel";
            this.Text = "导出数据到excel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_out1;
        private System.Windows.Forms.Button btn_out2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_out3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_hy;
    }
}