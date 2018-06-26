using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalWordBook
{
    public partial class 个人生词本 : Form
    {
        string path;
        public 个人生词本()
        {
            InitializeComponent();
            请选择生词本的位置cs form = new 请选择生词本的位置cs();
            form.ShowDialog();            
            path = form.NewWordBookPath;
            FileStream fs = new FileStream(@path, FileMode.Create);
            fs.Close();
            this.Text = "个人生词本";
        }

        //引入单词查询窗口
        private void button1_Click(object sender, EventArgs e)
        {
            单词查询 form = new 单词查询(path);
            form.Show();
        }

        //引入 我的单词库窗口
        private void button2_Click(object sender, EventArgs e)
        {
            我的单词库 form = new 我的单词库();
            form.Show();
        }

        private void 个人生词本_Load(object sender, EventArgs e)
        {

        }
    }
}
