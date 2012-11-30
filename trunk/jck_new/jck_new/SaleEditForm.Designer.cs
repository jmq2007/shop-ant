namespace jck_new
{
    partial class SaleEditForm
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
            this.txt_other = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_saleprice = new System.Windows.Forms.TextBox();
            this.num_amount = new System.Windows.Forms.NumericUpDown();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.but_save = new System.Windows.Forms.Button();
            this.btn_canel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_other
            // 
            this.txt_other.Location = new System.Drawing.Point(53, 208);
            this.txt_other.Multiline = true;
            this.txt_other.Name = "txt_other";
            this.txt_other.Size = new System.Drawing.Size(150, 63);
            this.txt_other.TabIndex = 49;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(53, 120);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(150, 21);
            this.txt_price.TabIndex = 48;
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(53, 39);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(150, 21);
            this.txt_name.TabIndex = 47;
            // 
            // txt_saleprice
            // 
            this.txt_saleprice.Enabled = false;
            this.txt_saleprice.Location = new System.Drawing.Point(53, 66);
            this.txt_saleprice.Name = "txt_saleprice";
            this.txt_saleprice.Size = new System.Drawing.Size(150, 21);
            this.txt_saleprice.TabIndex = 46;
            // 
            // num_amount
            // 
            this.num_amount.Location = new System.Drawing.Point(53, 93);
            this.num_amount.Name = "num_amount";
            this.num_amount.Size = new System.Drawing.Size(150, 21);
            this.num_amount.TabIndex = 45;
            // 
            // txt_code
            // 
            this.txt_code.Enabled = false;
            this.txt_code.Location = new System.Drawing.Point(53, 12);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(150, 21);
            this.txt_code.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 43;
            this.label6.Text = "备注:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 42;
            this.label5.Text = "单价:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 41;
            this.label4.Text = "总价:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 40;
            this.label3.Text = "数量:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 39;
            this.label2.Text = "名称:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 38;
            this.label1.Text = "条码:";
            // 
            // but_save
            // 
            this.but_save.Location = new System.Drawing.Point(47, 277);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(75, 23);
            this.but_save.TabIndex = 50;
            this.but_save.Text = "修改";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // btn_canel
            // 
            this.btn_canel.Location = new System.Drawing.Point(128, 277);
            this.btn_canel.Name = "btn_canel";
            this.btn_canel.Size = new System.Drawing.Size(75, 23);
            this.btn_canel.TabIndex = 51;
            this.btn_canel.Text = "取消";
            this.btn_canel.UseVisualStyleBackColor = true;
            this.btn_canel.Click += new System.EventHandler(this.btn_canel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 52;
            this.label7.Text = "时间:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 21);
            this.dateTimePicker1.TabIndex = 53;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(53, 175);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(150, 21);
            this.txt_phone.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 54;
            this.label8.Text = "手机:";
            // 
            // SaleEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 333);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_canel);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.txt_other);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_saleprice);
            this.Controls.Add(this.num_amount);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SaleEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑窗口";
            ((System.ComponentModel.ISupportInitialize)(this.num_amount)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Button btn_canel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label8;
    }
}