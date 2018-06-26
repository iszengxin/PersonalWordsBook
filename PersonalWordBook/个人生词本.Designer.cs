namespace PersonalWordBook
{
    partial class 个人生词本
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "想快速添加单词？试试单词查询";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "单词查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "单词整理";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 个人生词本
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 427);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "个人生词本";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.个人生词本_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

