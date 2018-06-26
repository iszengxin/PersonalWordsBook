using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalWordBook
{
    public partial class 手动添加窗体 : Form
    {
        private string s1 = null, s2 = null, s3 = null;
        public 手动添加窗体()
        {
            InitializeComponent();
        }
        public string S1
        {
            get
            {
                return s1;
            }
            set
            {
                if (value == null)
                    s1 = string.Empty;
                else
                    s1 = value;
            }
        }
        public string S2
        {
            get
            {
                return s2;
            }
            set
            {
                if (value == null)
                    s2 = string.Empty;
                else
                    s2 = value;
            }
        }
        public string S3
        {
            get
            {
                return s3;
            }
            set
            {
                if (value == null)
                    s3 = string.Empty;
                else
                    s3 = value;
            }
        } 
        

        private void button1_Click(object sender, EventArgs e)
        {
            S1 = textBox1.Text.ToString();
            S2 = textBox2.Text.ToString();
            S3 = textBox3.Text.ToString();
            this.Close();
        }
    }
}
