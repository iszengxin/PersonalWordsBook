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
    public partial class 请选择生词本的位置cs : Form
    {
        string str;
        public string NewWordBookPath
        {
            get { return str; }
        }

        public 请选择生词本的位置cs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                str = saveFileDialog1.FileName;
            }
            this.Close();
        }

        
    }
}
