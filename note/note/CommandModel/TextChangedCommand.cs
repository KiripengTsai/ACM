using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace note.CommandModel
{
    class TextChangedCommand: Command
    {
        private RichTextBox ctr1;
        private String newStr;
        private String oldStr;
        public TextChangedCommand(RichTextBox ctrl, String newStr, String oldStr)
        {
            this.ctr1 = ctrl;
            this.newStr = newStr;
            this.oldStr = oldStr;
        }

        public void execute()
        {
            this.ctr1.Text = newStr;
            this.ctr1.SelectionStart = this.ctr1.Text.Length;
        }

        public void undo()
        {
            this.ctr1.Text = oldStr;
            this.ctr1.SelectionStart = this.ctr1.Text.Length;
        }
    }
}
