using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace note
{
    public partial class Find : Form
    {
        string str;
        int start = 0;
        int count = 0;
        private RichTextBox rich =new RichTextBox();

        public Find()
        {
            InitializeComponent();
            
        }

        private void Find_Load(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            this.rich = form1.richTextBox1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string str1=rich.Text;
            string subStr = textBox1.Text;
            if (!checkBox1.Checked)
            {
                str1 = str1.ToLower();
                subStr = subStr.ToLower();
            }

            if (start >= rich.Text.Length)
            {
                MessageBox.Show("以查找到尾部");
                start = 0;
            }
            else
            {
                start = str1.IndexOf(subStr,start);
                if (start == -1)
                {
                    if (count == 0)
                    {
                        MessageBox.Show("没有该字符！");
                    }
                    else
                    {
                        MessageBox.Show("以查找到尾部！");
                        start = 0;
                    }
                }
                else
                {    
                    rich.Focus();
                    rich.SelectionStart = start;
                    rich.SelectionLength = subStr.Length;
                    start = start + subStr.Length;              
                 }
             }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
