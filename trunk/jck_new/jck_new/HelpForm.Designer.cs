namespace jck_new
{
    partial class HelpForm
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
            this.qq_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // qq_btn
            // 
            this.qq_btn.Image = global::jck_new.Properties.Resources._213;
            this.qq_btn.Location = new System.Drawing.Point(57, 38);
            this.qq_btn.Name = "qq_btn";
            this.qq_btn.Size = new System.Drawing.Size(155, 152);
            this.qq_btn.TabIndex = 0;
            this.qq_btn.Text = "联系开发者QQ";
            this.qq_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.qq_btn.UseVisualStyleBackColor = true;
            this.qq_btn.Click += new System.EventHandler(this.qq_btn_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.qq_btn);
            this.Name = "HelpForm";
            this.TabText = "帮助";
            this.Text = "帮助";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button qq_btn;
    }
}