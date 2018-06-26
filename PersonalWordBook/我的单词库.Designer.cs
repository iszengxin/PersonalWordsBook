namespace PersonalWordBook
{
    partial class 我的单词库
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏英文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏词义ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消隐藏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(1, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(508, 556);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "顺序排序";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.添加ToolStripMenuItem,
            this.隐藏英文ToolStripMenuItem,
            this.隐藏中文ToolStripMenuItem,
            this.隐藏词义ToolStripMenuItem,
            this.取消隐藏ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 174);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.添加ToolStripMenuItem.Text = "添加";
            this.添加ToolStripMenuItem.Click += new System.EventHandler(this.添加ToolStripMenuItem_Click);
            // 
            // 隐藏英文ToolStripMenuItem
            // 
            this.隐藏英文ToolStripMenuItem.Name = "隐藏英文ToolStripMenuItem";
            this.隐藏英文ToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.隐藏英文ToolStripMenuItem.Text = "隐藏英文";
            this.隐藏英文ToolStripMenuItem.Click += new System.EventHandler(this.隐藏英文ToolStripMenuItem_Click);
            // 
            // 隐藏中文ToolStripMenuItem
            // 
            this.隐藏中文ToolStripMenuItem.Name = "隐藏中文ToolStripMenuItem";
            this.隐藏中文ToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.隐藏中文ToolStripMenuItem.Text = "隐藏中文";
            this.隐藏中文ToolStripMenuItem.Click += new System.EventHandler(this.隐藏中文ToolStripMenuItem_Click);
            // 
            // 隐藏词义ToolStripMenuItem
            // 
            this.隐藏词义ToolStripMenuItem.Name = "隐藏词义ToolStripMenuItem";
            this.隐藏词义ToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.隐藏词义ToolStripMenuItem.Text = "隐藏词性";
            this.隐藏词义ToolStripMenuItem.Click += new System.EventHandler(this.隐藏词性ToolStripMenuItem_Click);
            // 
            // 取消隐藏ToolStripMenuItem
            // 
            this.取消隐藏ToolStripMenuItem.Name = "取消隐藏ToolStripMenuItem";
            this.取消隐藏ToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.取消隐藏ToolStripMenuItem.Text = "取消隐藏";
            this.取消隐藏ToolStripMenuItem.Click += new System.EventHandler(this.取消隐藏ToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(547, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "导入文件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(547, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "导出文件";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "英文";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "词性";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "词义";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 我的单词库
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 560);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "我的单词库";
            this.Text = "我的单词库";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏英文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏中文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏词义ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消隐藏ToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}