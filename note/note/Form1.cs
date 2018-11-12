using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using note.CommandModel;

namespace note
{
    public partial class Form1 : Form
    {
        String pathFile="";

        Stack<Command> undoStack = new Stack<Command>();
        Stack<Command> redoStack = new Stack<Command>();

        String oldStr;
        Boolean flag = true;

        PrintDocument printDocument = new PrintDocument();
        PageSetupDialog pageSetupDialog = new PageSetupDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Form1Closing(object sender, FormClosedEventArgs e)
        {
            if (pathFile == "" && richTextBox1.Text == "") return;
            else if (pathFile != "")
            {
                using (FileStream fil = new FileStream(pathFile, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    byte[] by = new byte[1024 * 1024];
                    int num = fil.Read(by, 0, by.Length);
                    string str1 = Encoding.Default.GetString(by, 0, num);
                    if (str1 != richTextBox1.Text)
                    {
                        string information = MessageBox.Show("您确认保存文本吗？(Y/N)", "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information).ToString();
                        if (information == "Yes")
                        {
                            byte[] byt = new byte[1024];
                            string str = richTextBox1.Text;
                            byt = Encoding.Default.GetBytes(str);
                            fil.Write(byt, 0, byt.Length);
                            richTextBox1.Text = "";
                            pathFile = "";
                        }
                        else if (information == "No")
                        {
                            richTextBox1.Text = "";
                            
                        }
                        else
                        {
                            return;
                        }
                        string fileName = "Untitled";
                        this.Text = fileName;
                    }

                }
            }
            else
            {
                if (MessageBox.Show("您确认保存文本吗？(Y/N)", "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information).ToString() == "Yes")
                {
                    saveAsStripMenuItem1_Click(sender, e);
                }

            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            string information = MessageBox.Show("是否保存文本吗？(Y/N)", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information).ToString();
            if (information == "No")
            {
                return;
            }
            base.OnFormClosing(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                TextChangedCommand com = new TextChangedCommand(richTextBox1, richTextBox1.Text, oldStr);
                undoStack.Push(com);
                oldStr = richTextBox1.Text;
            }
            flag = true;

            toolStripLabel1.Text = "字数统计："+richTextBox1.Text.Length;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void newTextBox_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        
        private void newMenuItem1_Click(object sender, EventArgs e)
        {

            if (pathFile == "" && richTextBox1.Text == "") return;
            else if (pathFile != "")
            {
                using (FileStream fil = new FileStream(pathFile, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    byte[] by = new byte[1024 * 1024];
                    int num = fil.Read(by, 0, by.Length);
                    string str1 = Encoding.Default.GetString(by, 0, num);
                    if (str1 != richTextBox1.Text)
                    {
                        string information = MessageBox.Show("您确认保存文本吗？(Y/N)", "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information).ToString();
                        if ( information== "Yes")
                        {
                            byte[] byt = new byte[1024];
                            string str = richTextBox1.Text;
                            byt = Encoding.Default.GetBytes(str);
                            fil.Write(byt, 0, byt.Length);
                            richTextBox1.Text = "";
                            pathFile = "";
                        }
                        else if (information == "No")
                        {
                            richTextBox1.Text = "";
                            pathFile = "";
                        }
                        else
                        {
                            return;
                        }
                        string fileName = "Untitled";
                        this.Text = fileName;
                    }

                }
            }
            else
            {
                if (MessageBox.Show("您确认保存文本吗？(Y/N)", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information).ToString() == "Yes")
                {
                    saveAsStripMenuItem1_Click(sender, e);
                }
                
            }
        }

        private void openStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            op.Title = "open your file";

            op.Multiselect = true;

            string str = @"C:\Documents";
            op.InitialDirectory = str;

            op.Filter = "文本文件|*.txt|媒体文件|*.avi|图片文件|*.jpg|suoyou|*.*";

            op.ShowDialog();

            try
            {
                pathFile = op.FileName;
                using (FileStream fil = new FileStream(pathFile, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    byte[] by = new byte[1024 * 1024];
                    int num = fil.Read(by, 0, by.Length);
                    string str1 = Encoding.Default.GetString(by, 0, num);
                    richTextBox1.Text = str1;

                    string fileName = pathFile.Substring(pathFile.LastIndexOf("\\") + 1);
                    this.Text = fileName;
                }
            }
            catch
            {
                return;
            }
            
        }

        private void saveAsStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sav = new SaveFileDialog();
            sav.Title = "请选择要保存的位置";
            sav.Filter = "文本文件|*.txt";
            sav.InitialDirectory = @"C:\";
            sav.ShowDialog();
            string stt = sav.FileName;
            if (stt == "")
                return;
            using (FileStream fil = new FileStream(stt, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] byt = new byte[1024];
                string str = richTextBox1.Text;
                byt = Encoding.Default.GetBytes(str);
                fil.Write(byt, 0, byt.Length);

            }
            MessageBox.Show("OK");
        }

        private void saveStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream fil = new FileStream(pathFile, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] byt = new byte[1024];
                string str = richTextBox1.Text;
                byt = Encoding.Default.GetBytes(str);
                fil.Write(byt, 0, byt.Length);
            }
        }

        private void undoMenuItem2_Click(object sender, EventArgs e)
        {
            if (undoStack.Count == 0) return;

            flag = false;

            Command com = undoStack.Pop();
            com.undo();
            redoStack.Push(com);
        }

        private void restore_Click(object sender, EventArgs e)
        {
            if (redoStack.Count == 0) return;

            flag = false;

            Command com = redoStack.Pop();
            com.execute();

            undoStack.Push(com);
        }

        private void exitMenuItem1_Click(object sender, EventArgs e)
        {
            if (pathFile == "" && richTextBox1.Text == "") System.Environment.Exit(0); 
            else if (pathFile != "")
            {
                using (FileStream fil = new FileStream(pathFile, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    byte[] by = new byte[1024 * 1024];
                    int num = fil.Read(by, 0, by.Length);
                    string str1 = Encoding.Default.GetString(by, 0, num);
                    if (str1 != richTextBox1.Text)
                    {
                        string information = MessageBox.Show("您确认保存文本吗？(Y/N)", "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information).ToString();
                        if (information == "Yes")
                        {
                            byte[] byt = new byte[1024];
                            string str = richTextBox1.Text;
                            byt = Encoding.Default.GetBytes(str);
                            fil.Write(byt, 0, byt.Length);
                            richTextBox1.Text = "";
                            pathFile = "";
                        }
                        else if (information == "No")
                        {
                            richTextBox1.Text = "";
                            pathFile = "";
                        }
                        
                        string fileName = "Untitled";
                        this.Text = fileName;
                        
                    }
                   
                }
            }
            else
            {
                if (MessageBox.Show("您确认保存文本吗？(Y/N)", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information).ToString() == "Yes")
                {
                    saveAsStripMenuItem1_Click(sender, e);
                }

            }
            System.Environment.Exit(0);
        }

        private void cutStripMenuItem2_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Rtf, richTextBox1.SelectedRtf);
            richTextBox1.SelectedRtf = "";
        }

        private void copyStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Rtf, richTextBox1.SelectedRtf);
        }

        private void pasteStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void findStripMenuItem2_Click(object sender, EventArgs e)
        {
            Find find = new Find();
            find.Owner = this;
            find.Show();
        }

        private void replaceStripMenuItem2_Click(object sender, EventArgs e)
        {
            Replace r = new Replace();
            r.Owner = this;
            r.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void selectAllStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void timeStripMenuItem2_Click(object sender, EventArgs e)
        {
            string font = richTextBox1.Text.Substring(0, richTextBox1.SelectionStart);
            string back=richTextBox1.Text.Substring(richTextBox1.SelectionStart);
            richTextBox1.Text = font + DateTime.Now.ToString() + back;
        }

        private void wordWrap_Click(object sender, EventArgs e)
        {
            if (richTextBox1.WordWrap)
            {
                wordWrap.Checked = false;
                richTextBox1.WordWrap = false;
            }
            else
            {
                wordWrap.Checked = true;
                richTextBox1.WordWrap = true;
            }
        }

        private void fontScriptItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            fontDialog1.ShowDialog();
            if (richTextBox1.SelectionLength == 0)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
            else
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void startBar_Click(object sender, EventArgs e)
        {
            if (startBar.Checked)
            {
                toolStrip1.Visible = false;
                startBar.Checked = false;
            }
            else
            {
                toolStrip1.Visible = true;
                startBar.Checked = true;
            }
        }

        private void aboutScriptItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void pageStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            pageSetupDialog.Document = printDocument;
            pageSetupDialog.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            printDialog.ShowDialog();
        }
    }
}
