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
    public partial class 单词查询 : Form
    {
        string NewWordBookPath;
        public 单词查询(string s)
        {
            InitializeComponent();
            NewWordBookPath = s;

        }

        Dictionary<string, string> dic = new Dictionary<string, string>();
        List<string> list = new List<string>();
        //string[] strarr = File.ReadAllLines(@"E:\桌面文件\英汉词典TXT格式.txt", Encoding.Default);
        //string[] strarr = File.ReadAllLines(@"英汉词典TXT格式.txt", Encoding.Default);
        static string s = System.Environment.CurrentDirectory + "\\" + "英汉词典TXT格式.txt";
        //static string s = Application.StartupPath + "\\" + "英汉词典TXT格式.txt";
        string[] strarr = File.ReadAllLines(@s, Encoding.Default);

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //判断是否点击了回车按钮
            if (e.KeyCode == Keys.Enter)
            {
                //我这是把上面的复制下来了，直接查出结果
                if (dic.Keys.Contains(textBox1.Text.Trim()))
                {
                    textBox2.Text = dic[textBox1.Text.Trim()];
                    linkLabel1.Visible = false;
                    Ltime = 0;
                }
                else
                {
                    label1.Text = "收索时间大于30秒已超时";
                    label2.Text = "对不起，系统不包含您输入的单词";
                    textBox2.Text = "";

                    linkLabel1.Visible = true;

                    linkLabel1.Text = "对不起请尝试使用（有道youdao）在线翻译:" + "\r\n\n\t";

                    timer.Stop();
                    Ltime = 0;
                    linkLabel1.BringToFront();
                }

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //文本框内若是没有数据，就不显示label1
            if (textBox1.Text == "")
            {
                label1.Text = "";
            }

            //开始查找，文本框内与泛型字典键相同就把数据显示出来
            if (dic.Keys.Contains(textBox1.Text.Trim()))
            {
                //用键值找到数据，显示在textBox2中
                textBox2.Text = dic[textBox1.Text.Trim()];

                //因为搜索到了结果，所以在线搜索不显示
                linkLabel1.Visible = false;
                label1.Text = "请输入单词：";
                timer.Stop();
                Ltime = 0;
                //
                ADD();
                //
            }
            else if (textBox1.Text == "")
            {
                textBox2.Text = "请输入要查询单词";
                linkLabel1.Visible = false;
                timer.Stop();
                Ltime = 0;
            }
            else
            {
                textBox2.Text = "正在搜索";
                //计时开始
                timer.Start();
            }
        }

        private void 单词查询_Load(object sender, EventArgs e)
        {
            Stime();
            label2.Text = "您查询的结果：";
            //遍历每一个行，每行都是两个元素，英文和中文,即添加文件到list中
            for (int i = 0; i < strarr.Length; i++)
            {
                //使用split方法移除单个空字符
                string[] strarr1 = strarr[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                //避免重复添加
                if (!dic.Keys.Contains(strarr1[0]))
                {
                    //将数组里的英文和中文填到泛型字典里
                    dic.Add(strarr1[0], strarr1[1]);
                    //将英文添加到泛型list里
                    //这样list内的数据都是dic内的键值
                    list.Add(strarr1[0]);
                }
            }

            //
            AutoCompleteStringCollection strings = new AutoCompleteStringCollection();
            // 所有list泛型的英文单词转换成数组 添加到 strings里
            strings.AddRange(list.ToArray());
            textBox1.AutoCompleteCustomSource = strings; //然后赋给文本框的 自动补全 所需的资源 属性
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource; //指定 CustomSource 为数据源
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest; //启动自动补全模式
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", "http://www.youdao.com/w/" + textBox1.Text.Trim());
            }
            catch
            {
                MessageBox.Show("通过其他方式已将查询关闭");
            }
        }
        //
        public void Stime()
        {
            timer = new Timer();
            //一秒间隔
            timer.Interval = 1000;
            timer.Tick += (s, e) =>
            {
                Ltime++;
                label1.Text = Ltime.ToString();//显示查询几秒

                if (Ltime >= 5)
                {
                    label1.Text = "搜索时间大于5秒已超时";
                    label2.Text = "对不起，系统不包含您输入的单词";
                    textBox2.Text = "";
                    //显示网站链接
                    linkLabel1.Visible = true;
                    linkLabel1.Text = "对不起请尝试使用（有道youdao）在线翻译:" + "\r\n\n\t" + textBox1.Text.Trim();
                    timer.Stop();
                    Ltime = 0;
                    //使linkWebSearch控件显示的网址在textbox控件上面
                    linkLabel1.BringToFront();
                }
                else//那就是5秒内显示出结果了
                {
                    linkLabel1.Visible = false;
                    label1.Text = Ltime.ToString();
                }
            };
        }

        //收藏单词的函数,先判断是否此单词已经出现，再进行添加
        private void ADD()
        {

            string path = @NewWordBookPath;
            //如果选中添加，再判断此单词是否已经添加过了，没有，就添加
            if (checkBox1.Checked)
            {
                //读取并判断有没有重复单词
                StreamReader sr = new StreamReader(path, Encoding.Default);
                String line;
                bool isNotContanins = true;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(textBox1.Text))
                    {
                        isNotContanins = false;
                        break;
                    }
                }
                sr.Close();
                //
                if (isNotContanins)
                {
                    string s = textBox1.Text + "   " + textBox2.Text;
                    FileStream fs = new FileStream(path, FileMode.Append);
                    StreamWriter sw = new StreamWriter(fs);
                    //开始写入
                    sw.WriteLine(s);
                    sw.Flush();
                    //关闭流
                    sw.Close();
                    fs.Close();
                }
            }
        }
        //定义个查找所用时间
        public int Ltime = 0;
        //定义个计时器
        public Timer timer;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            string path = @NewWordBookPath;
            //如果选中添加，就添加
            if (checkBox1.Checked)
            {
                ADD();
            }
            //先将文件中的所有内容保存到一个LIST中，不保存需要删除的文件，然后进行文件重写，达到删除的目的
            else
            {
                //读取并判断有没有重复单词
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                String line;
                List<string> list = new List<string>();
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(textBox1.Text))
                    {
                        continue;
                    }
                    list.Add(line);
                }
                sr.Close();
                //定义一个写入流，将值写入到txt文件中 
                using (StreamWriter writer = new StreamWriter(path))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        writer.WriteLine(list[i]);
                    }
                }
            }
           
        }

        
    }
}
