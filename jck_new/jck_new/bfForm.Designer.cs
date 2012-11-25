namespace jck_new
{
    partial class BfForm
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
            this.btn_copy = new System.Windows.Forms.Button();
            this.txt_lj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_lj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(381, 6);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(75, 23);
            this.btn_copy.TabIndex = 0;
            this.btn_copy.Text = "备份";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // txt_lj
            // 
            this.txt_lj.Location = new System.Drawing.Point(78, 8);
            this.txt_lj.Name = "txt_lj";
            this.txt_lj.Size = new System.Drawing.Size(196, 21);
            this.txt_lj.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "存放路径:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "最近一次备份时间:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "未备份过";
            // 
            // btn_lj
            // 
            this.btn_lj.Location = new System.Drawing.Point(280, 6);
            this.btn_lj.Name = "btn_lj";
            this.btn_lj.Size = new System.Drawing.Size(95, 23);
            this.btn_lj.TabIndex = 5;
            this.btn_lj.Text = "选择保存路径";
            this.btn_lj.UseVisualStyleBackColor = true;
            this.btn_lj.Click += new System.EventHandler(this.btn_lj_Click);
            // 
            // BfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 312);
            this.Controls.Add(this.btn_lj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_lj);
            this.Controls.Add(this.btn_copy);
            this.Name = "BfForm";
            this.TabText = "数据库备份";
            this.Text = "数据库备份";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.TextBox txt_lj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_lj;
    }
}