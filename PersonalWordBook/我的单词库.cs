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
    public partial class 我的单词库 : Form
    {
        private void initListView()
        {
            float totalColumnWidth = 10.0F;  //1.0+2.0+1.0 = 4.0

            //设置第一列所占百分比
            float colPercentage0 = 3 / totalColumnWidth;
            listView1.Columns[0].Width = (int)(colPercentage0 * listView1.ClientRectangle.Width);

            //设置第二列所占百分比
            float colPercentage1 = 2 / totalColumnWidth;
            listView1.Columns[1].Width = (int)(colPercentage1 * listView1.ClientRectangle.Width);

            //设置第三列所占百分比
            float colPercentage2 = 5 / totalColumnWidth;
            listView1.Columns[2].Width = (int)(colPercentage2 * listView1.ClientRectangle.Width);
        }
        public 我的单词库()
        {
            InitializeComponent();
            initListView();
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                item.BackColor = Color.Blue;
                listView1.Items.Remove(item);
            }
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            手动添加窗体 form = new 手动添加窗体();
            form.ShowDialog();
            addToListView(form.S1, form.S2, form.S3);
        }

        private void 隐藏英文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Columns[0].Width = 0;
        }

        private void 隐藏中文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Columns[2].Width = 0;
        }

        private void 隐藏词性ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Columns[1].Width = 0;
        }

        private void 取消隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initListView();
        }
        public void addToListView(string s1, string s2, string s3)
        {
            ListViewItem l = new ListViewItem();
            l.Text = s1;
            l.SubItems.Add(s2);
            l.SubItems.Add(s3);
            listView1.Items.Add(l);
        }

        //排序
        private void button1_Click(object sender, EventArgs e)
        {
            //将Listview中数据添加到list中
            List<string> list = new List<string>();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                string s = null;
                ListViewItem item = listView1.Items[i];
                for (int j = 0; j < item.SubItems.Count; j++)
                {
                    s += item.SubItems[j].Text + "    ";
                }
                list.Add(s);
            }
            if (button1.Text.ToString().Equals("顺序排序"))
            {
                list.Sort();
                refreshListview(list);
                button1.Text = "随机排序";
            }
            else
            {
                List<string> list2 = new List<string>();
                Random rd = new Random();
                for (int i = 0; i < list.Count; i++)
                {
                    int index = rd.Next(list2.Count + 1);
                    list2.Insert(index, list[i]);
                }
                refreshListview(list2);
                button1.Text = "顺序排序";
            }                               
        }
        //导入文件
        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                List<string> list = new List<string>();
                Dictionary<string, string> dic = new Dictionary<string, string>();
                //将listview中的数据添加到DIC中
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    string s1 = null, s2 = null;
                    ListViewItem item = listView1.Items[i];
                    for (int j = 1; j < item.SubItems.Count; j++)
                    {
                        // s += item.SubItems[j].Text + " ";
                        s1 = item.SubItems[0].Text;
                        s2 += item.SubItems[j].Text + "  ";
                    }
                    dic.Add(s1, s2);
                }

                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    listView1.Items.Clear();
                }
                //获得文件路径  
                string localFilePath = openFileDialog1.FileName.ToString();

                //读取文件，添加到DIC中

                StreamReader sr = new StreamReader(localFilePath, Encoding.UTF8);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    //处理每行数据
                    string[] strarr1 = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (strarr1.Length == 2)
                    {
                        int index = strarr1[1].IndexOf(".");
                        string str = strarr1[1].Substring(0, index + 1);
                        string s = strarr1[1].Substring(index + 1);
                        //添加处理后的数据
                        //addToListView(strarr1[0],str,s);
                        //list.Add(strarr1[0]+" "+str+" "+s);
                        if (!dic.Keys.Contains(strarr1[0]))
                        {
                            //将数组里的英文和中文填到泛型字典里
                            dic.Add(strarr1[0], str + " " + s);
                        }
                    }
                    else
                    {
                        if (!dic.Keys.Contains(strarr1[0]))
                        {
                            //将数组里的英文和中文填到泛型字典里
                            dic.Add(strarr1[0], strarr1[1] + " " + strarr1[2]);
                        }
                    }

                }
                // List<string> li=list.Distinct().ToList<string>();
                //refreshListview(list);    
                //将DIC内的键对值添加到list中
                foreach (string s in dic.Keys)
                {
                    list.Add(string.Format("{0} {1}", s, dic[s]));
                }
                refreshListview(list);
                sr.Close();
            } 
        }
        public string fileNameExt { get; set; }
        //导出文件
        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter myStream;
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string str;
                str = saveFileDialog1.FileName;
                myStream = new StreamWriter(saveFileDialog1.FileName);
                //将Listview中数据添加到list中
                List<string> list = new List<string>();
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    string s = null;
                    ListViewItem item = listView1.Items[i];
                    for (int j = 0; j < item.SubItems.Count; j++)
                    {
                        s += item.SubItems[j].Text + "  ";
                    }
                    list.Add(s);
                }
                //写入文件 
                for (int i = 0; i < list.Count; i++)
                {
                    myStream.WriteLine(list[i], Encoding.UTF8);
                }
                myStream.Flush();
                myStream.Close();
            }
        }
        //用list的值更新listview
        private void refreshListview(List<string> list)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items.Clear();
            }
            //重新添加
            for (int i = 0; i < list.Count; i++)
            {
                string line = list[i].ToString();
                //使用split方法移除单个空字符
                string[] strarr1 = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                
                if (strarr1.Length == 2)
                {
                    int index = strarr1[1].IndexOf(".");
                    string str = strarr1[1].Substring(0, index + 1);
                    string s = strarr1[1].Substring(index + 1);
                    //添加处理后的数据
                    addToListView(strarr1[0], str, s);
                }
                else
                {
                    addToListView(strarr1[0], strarr1[1], strarr1[2]);
                }

            }
        }
    }
}
