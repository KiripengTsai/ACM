namespace note
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newScriptMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.restore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.findStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.timeStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.fontScriptItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.startBar = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutScriptItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.pageStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.Location = new System.Drawing.Point(1, 48);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(728, 349);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newScriptMenuItem1,
            this.openStripMenuItem,
            this.saveStripMenuItem1,
            this.toolStripMenuItem1,
            this.exitMenuItem1,
            this.toolStripSeparator4,
            this.pageStripMenuItem2,
            this.toolStripMenuItem2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newScriptMenuItem1
            // 
            this.newScriptMenuItem1.Name = "newScriptMenuItem1";
            this.newScriptMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.newScriptMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.newScriptMenuItem1.Text = "New";
            this.newScriptMenuItem1.Click += new System.EventHandler(this.newMenuItem1_Click);
            // 
            // openStripMenuItem
            // 
            this.openStripMenuItem.Name = "openStripMenuItem";
            this.openStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openStripMenuItem.Text = "Open";
            this.openStripMenuItem.Click += new System.EventHandler(this.openStripMenuItem_Click);
            // 
            // saveStripMenuItem1
            // 
            this.saveStripMenuItem1.Name = "saveStripMenuItem1";
            this.saveStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.saveStripMenuItem1.Text = "Save";
            this.saveStripMenuItem1.Click += new System.EventHandler(this.saveStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem1.Text = "Save As";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.saveAsStripMenuItem1_Click);
            // 
            // exitMenuItem1
            // 
            this.exitMenuItem1.Name = "exitMenuItem1";
            this.exitMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.exitMenuItem1.Text = "Exit";
            this.exitMenuItem1.Click += new System.EventHandler(this.exitMenuItem1_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenuItem2,
            this.restore,
            this.toolStripSeparator1,
            this.cutStripMenuItem2,
            this.copyStripMenuItem,
            this.pasteStripMenuItem,
            this.deleteStripMenuItem2,
            this.toolStripSeparator2,
            this.findStripMenuItem2,
            this.replaceStripMenuItem2,
            this.toolStripSeparator3,
            this.selectAllStripMenuItem2,
            this.timeStripMenuItem2});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // undoMenuItem2
            // 
            this.undoMenuItem2.Name = "undoMenuItem2";
            this.undoMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.undoMenuItem2.Text = "Undo";
            this.undoMenuItem2.Click += new System.EventHandler(this.undoMenuItem2_Click);
            // 
            // restore
            // 
            this.restore.Name = "restore";
            this.restore.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.restore.Size = new System.Drawing.Size(216, 26);
            this.restore.Text = "Redo";
            this.restore.Click += new System.EventHandler(this.restore_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // cutStripMenuItem2
            // 
            this.cutStripMenuItem2.Name = "cutStripMenuItem2";
            this.cutStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.cutStripMenuItem2.Text = "Cut";
            this.cutStripMenuItem2.Click += new System.EventHandler(this.cutStripMenuItem2_Click);
            // 
            // copyStripMenuItem
            // 
            this.copyStripMenuItem.Name = "copyStripMenuItem";
            this.copyStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.copyStripMenuItem.Text = "Copy";
            this.copyStripMenuItem.Click += new System.EventHandler(this.copyStripMenuItem_Click);
            // 
            // pasteStripMenuItem
            // 
            this.pasteStripMenuItem.Name = "pasteStripMenuItem";
            this.pasteStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pasteStripMenuItem.Text = "Paste";
            this.pasteStripMenuItem.Click += new System.EventHandler(this.pasteStripMenuItem_Click);
            // 
            // deleteStripMenuItem2
            // 
            this.deleteStripMenuItem2.Name = "deleteStripMenuItem2";
            this.deleteStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.deleteStripMenuItem2.Text = "Delete";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // findStripMenuItem2
            // 
            this.findStripMenuItem2.Name = "findStripMenuItem2";
            this.findStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.findStripMenuItem2.Text = "Find...";
            this.findStripMenuItem2.Click += new System.EventHandler(this.findStripMenuItem2_Click);
            // 
            // replaceStripMenuItem2
            // 
            this.replaceStripMenuItem2.Name = "replaceStripMenuItem2";
            this.replaceStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replaceStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.replaceStripMenuItem2.Text = "Replace";
            this.replaceStripMenuItem2.Click += new System.EventHandler(this.replaceStripMenuItem2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(213, 6);
            // 
            // selectAllStripMenuItem2
            // 
            this.selectAllStripMenuItem2.Name = "selectAllStripMenuItem2";
            this.selectAllStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.selectAllStripMenuItem2.Text = "Select All";
            this.selectAllStripMenuItem2.Click += new System.EventHandler(this.selectAllStripMenuItem2_Click);
            // 
            // timeStripMenuItem2
            // 
            this.timeStripMenuItem2.Name = "timeStripMenuItem2";
            this.timeStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.timeStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.timeStripMenuItem2.Text = "Time/Date";
            this.timeStripMenuItem2.Click += new System.EventHandler(this.timeStripMenuItem2_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrap,
            this.fontScriptItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // wordWrap
            // 
            this.wordWrap.Name = "wordWrap";
            this.wordWrap.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.wordWrap.Size = new System.Drawing.Size(253, 26);
            this.wordWrap.Text = "Word Wrap";
            this.wordWrap.Click += new System.EventHandler(this.wordWrap_Click);
            // 
            // fontScriptItem
            // 
            this.fontScriptItem.Name = "fontScriptItem";
            this.fontScriptItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fontScriptItem.Size = new System.Drawing.Size(253, 26);
            this.fontScriptItem.Text = "Font";
            this.fontScriptItem.Click += new System.EventHandler(this.fontScriptItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startBar});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutScriptItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 400);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(729, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked_1);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Enabled = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // startBar
            // 
            this.startBar.Name = "startBar";
            this.startBar.Size = new System.Drawing.Size(216, 26);
            this.startBar.Text = "Status Bar";
            this.startBar.Click += new System.EventHandler(this.startBar_Click);
            // 
            // aboutScriptItem
            // 
            this.aboutScriptItem.Name = "aboutScriptItem";
            this.aboutScriptItem.Size = new System.Drawing.Size(216, 26);
            this.aboutScriptItem.Text = "About";
            this.aboutScriptItem.Click += new System.EventHandler(this.aboutScriptItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(213, 6);
            // 
            // pageStripMenuItem2
            // 
            this.pageStripMenuItem2.Name = "pageStripMenuItem2";
            this.pageStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.pageStripMenuItem2.Text = "Page Setup";
            this.pageStripMenuItem2.Click += new System.EventHandler(this.pageStripMenuItem2_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem2.Text = "Print";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 425);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "untitled";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newScriptMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem undoMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem restore;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cutStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem copyStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem findStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem replaceStripMenuItem2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem selectAllStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem timeStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem wordWrap;
        private System.Windows.Forms.ToolStripMenuItem fontScriptItem;
        private System.Windows.Forms.ToolStripMenuItem startBar;
        private System.Windows.Forms.ToolStripMenuItem aboutScriptItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem pageStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

