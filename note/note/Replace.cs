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
    public partial class Replace : Form
    {
       
        int start = 0;
        int count = 0;

        private RichTextBox rich = new RichTextBox();
        public Replace()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void findNext_Click(object sender, EventArgs e)
        {
            string str1 = rich.Text;
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
                start = str1.IndexOf(subStr, start);
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
                        count = 0;
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

        private void Replace_Load(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            this.rich = form1.richTextBox1;
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            string str1 = rich.Text;
            string subStr = textBox1.Text;
            //string str = "" + rich.SelectionStart;
            //label1.Text = str;
            string newStr = newStr = str1.Substring(0, rich.SelectionStart);
            if (rich.SelectionStart + subStr.Length + 1 < str1.Length)
            {
                newStr+= newStr = str1.Substring(rich.SelectionStart+subStr.Length+1);
            }
            rich.Text = newStr;
            start++;
            findNext_Click(sender, e);
        }

        private void replaceAll_Click(object sender, EventArgs e)
        {
            string str1 = rich.Text;
            string subStr = textBox1.Text;
            string neStr = textBox2.Text;
            int pos = 0;
            while((pos = CheckedMatch(str1).IndexOf(CheckedMatch(subStr), pos)) != -1)
            {
                string front = str1.Substring(0, pos);
                
                string back = str1.Substring(pos + subStr.Length);
                str1 = front + neStr + back;
                pos += neStr.Length;
                
            }
            rich.Text = str1;
        }

        private String CheckedMatch(string str)
        {
            if (!checkBox1.Checked)
            {
                return str.ToLower();
            }
            return str;
        }
    }
}
