namespace WebBrowser.UI
{
     partial class GromBrowser
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
               this.components = new System.ComponentModel.Container();
               this.menuStrip1 = new System.Windows.Forms.MenuStrip();
               this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.closeCurrentTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.savePageAsHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.printPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.exitWebBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.manageHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.manageBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.toolStrip1 = new System.Windows.Forms.ToolStrip();
               this.Back = new System.Windows.Forms.ToolStripButton();
               this.Forward = new System.Windows.Forms.ToolStripButton();
               this.Refresh = new System.Windows.Forms.ToolStripButton();
               this.toolStripSpringTextBox1 = new WebBrowser.UI.ToolStripSpringTextBox();
               this.Home = new System.Windows.Forms.ToolStripButton();
               this.Go = new System.Windows.Forms.ToolStripButton();
               this.Bookmark = new System.Windows.Forms.ToolStripButton();
               this.windowTabs = new System.Windows.Forms.TabControl();
               this.tabPage1 = new System.Windows.Forms.TabPage();
               this.webBrowser1 = new System.Windows.Forms.WebBrowser();
               this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
               this.statusStrip1 = new System.Windows.Forms.StatusStrip();
               this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
               this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
               this.menuStrip1.SuspendLayout();
               this.toolStrip1.SuspendLayout();
               this.windowTabs.SuspendLayout();
               this.tabPage1.SuspendLayout();
               this.statusStrip1.SuspendLayout();
               this.SuspendLayout();
               // 
               // menuStrip1
               // 
               this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
               this.menuStrip1.Location = new System.Drawing.Point(0, 0);
               this.menuStrip1.Name = "menuStrip1";
               this.menuStrip1.Size = new System.Drawing.Size(742, 24);
               this.menuStrip1.TabIndex = 0;
               this.menuStrip1.Text = "menuStrip1";
               // 
               // fileToolStripMenuItem
               // 
               this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem,
            this.closeCurrentTabToolStripMenuItem,
            this.savePageAsHTMLToolStripMenuItem,
            this.printPageToolStripMenuItem,
            this.exitWebBrowserToolStripMenuItem});
               this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
               this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
               this.fileToolStripMenuItem.Text = "File";
               // 
               // newTabToolStripMenuItem
               // 
               this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
               this.newTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
               this.newTabToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
               this.newTabToolStripMenuItem.Text = "New Tab";
               this.newTabToolStripMenuItem.Click += new System.EventHandler(this.newTabToolStripMenuItem_Click);
               // 
               // closeCurrentTabToolStripMenuItem
               // 
               this.closeCurrentTabToolStripMenuItem.Name = "closeCurrentTabToolStripMenuItem";
               this.closeCurrentTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
               this.closeCurrentTabToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
               this.closeCurrentTabToolStripMenuItem.Text = "Close Current Tab";
               // 
               // savePageAsHTMLToolStripMenuItem
               // 
               this.savePageAsHTMLToolStripMenuItem.Name = "savePageAsHTMLToolStripMenuItem";
               this.savePageAsHTMLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
               this.savePageAsHTMLToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
               this.savePageAsHTMLToolStripMenuItem.Text = "Save Page as HTML";
               // 
               // printPageToolStripMenuItem
               // 
               this.printPageToolStripMenuItem.Name = "printPageToolStripMenuItem";
               this.printPageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
               this.printPageToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
               this.printPageToolStripMenuItem.Text = "Print Page";
               this.printPageToolStripMenuItem.Click += new System.EventHandler(this.printPageToolStripMenuItem_Click);
               // 
               // exitWebBrowserToolStripMenuItem
               // 
               this.exitWebBrowserToolStripMenuItem.Name = "exitWebBrowserToolStripMenuItem";
               this.exitWebBrowserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
               this.exitWebBrowserToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
               this.exitWebBrowserToolStripMenuItem.Text = "Exit Web Browser";
               this.exitWebBrowserToolStripMenuItem.Click += new System.EventHandler(this.exitWebBrowserToolStripMenuItem_Click);
               // 
               // toolsToolStripMenuItem
               // 
               this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageHistoryToolStripMenuItem,
            this.manageBookmarksToolStripMenuItem});
               this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
               this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
               this.toolsToolStripMenuItem.Text = "Tools";
               // 
               // manageHistoryToolStripMenuItem
               // 
               this.manageHistoryToolStripMenuItem.Name = "manageHistoryToolStripMenuItem";
               this.manageHistoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
               this.manageHistoryToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
               this.manageHistoryToolStripMenuItem.Text = "Manage History";
               // 
               // manageBookmarksToolStripMenuItem
               // 
               this.manageBookmarksToolStripMenuItem.Name = "manageBookmarksToolStripMenuItem";
               this.manageBookmarksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
               this.manageBookmarksToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
               this.manageBookmarksToolStripMenuItem.Text = "Manage Bookmarks";
               // 
               // helpToolStripMenuItem
               // 
               this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
               this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
               this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
               this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
               this.helpToolStripMenuItem.Text = "Help";
               // 
               // aboutToolStripMenuItem
               // 
               this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
               this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
               this.aboutToolStripMenuItem.Text = "About";
               this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
               // 
               // toolStrip1
               // 
               this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Back,
            this.Forward,
            this.Refresh,
            this.toolStripSpringTextBox1,
            this.Home,
            this.Go,
            this.Bookmark});
               this.toolStrip1.Location = new System.Drawing.Point(0, 24);
               this.toolStrip1.Name = "toolStrip1";
               this.toolStrip1.Size = new System.Drawing.Size(742, 25);
               this.toolStrip1.Stretch = true;
               this.toolStrip1.TabIndex = 1;
               this.toolStrip1.Text = "toolStrip1";
               // 
               // Back
               // 
               this.Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.Back.Image = global::WebBrowser.UI.Properties.Resources.Backward_16x;
               this.Back.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.Back.Name = "Back";
               this.Back.Size = new System.Drawing.Size(23, 22);
               this.Back.Text = "toolStripButton2";
               // 
               // Forward
               // 
               this.Forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.Forward.Image = global::WebBrowser.UI.Properties.Resources.Forward_16x;
               this.Forward.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.Forward.Name = "Forward";
               this.Forward.Size = new System.Drawing.Size(23, 22);
               this.Forward.Text = "toolStripButton1";
               this.Forward.Click += new System.EventHandler(this.toolStripButton1_Click);
               // 
               // Refresh
               // 
               this.Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.Refresh.Image = global::WebBrowser.UI.Properties.Resources.Refresh_16x;
               this.Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.Refresh.Name = "Refresh";
               this.Refresh.Size = new System.Drawing.Size(23, 22);
               this.Refresh.Text = "toolStripButton3";
               // 
               // toolStripSpringTextBox1
               // 
               this.toolStripSpringTextBox1.Name = "toolStripSpringTextBox1";
               this.toolStripSpringTextBox1.Size = new System.Drawing.Size(561, 25);
               this.toolStripSpringTextBox1.Text = "http://";
               this.toolStripSpringTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripSpringTextBox1_KeyPress);
               // 
               // Home
               // 
               this.Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.Home.Image = global::WebBrowser.UI.Properties.Resources.Home_16x;
               this.Home.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.Home.Name = "Home";
               this.Home.Size = new System.Drawing.Size(23, 22);
               this.Home.Text = "toolStripButton4";
               // 
               // Go
               // 
               this.Go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.Go.Image = global::WebBrowser.UI.Properties.Resources.GoToTop_16x;
               this.Go.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.Go.Name = "Go";
               this.Go.Size = new System.Drawing.Size(23, 22);
               this.Go.Text = "toolStripButton5";
               this.Go.Click += new System.EventHandler(this.Go_Click);
               // 
               // Bookmark
               // 
               this.Bookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.Bookmark.Image = global::WebBrowser.UI.Properties.Resources.Bookmark_16x;
               this.Bookmark.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.Bookmark.Name = "Bookmark";
               this.Bookmark.Size = new System.Drawing.Size(23, 22);
               this.Bookmark.Text = "toolStripButton6";
               // 
               // windowTabs
               // 
               this.windowTabs.Controls.Add(this.tabPage1);
               this.windowTabs.Dock = System.Windows.Forms.DockStyle.Fill;
               this.windowTabs.Location = new System.Drawing.Point(0, 49);
               this.windowTabs.Name = "windowTabs";
               this.windowTabs.SelectedIndex = 0;
               this.windowTabs.Size = new System.Drawing.Size(742, 465);
               this.windowTabs.TabIndex = 2;
               this.windowTabs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.windowTabs_KeyDown);
               // 
               // tabPage1
               // 
               this.tabPage1.Controls.Add(this.webBrowser1);
               this.tabPage1.Location = new System.Drawing.Point(4, 22);
               this.tabPage1.Name = "tabPage1";
               this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
               this.tabPage1.Size = new System.Drawing.Size(734, 439);
               this.tabPage1.TabIndex = 0;
               this.tabPage1.Text = "tabPage1";
               this.tabPage1.UseVisualStyleBackColor = true;
               // 
               // webBrowser1
               // 
               this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.webBrowser1.Location = new System.Drawing.Point(3, 3);
               this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
               this.webBrowser1.Name = "webBrowser1";
               this.webBrowser1.Size = new System.Drawing.Size(728, 433);
               this.webBrowser1.TabIndex = 0;
               this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
               this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
               // 
               // contextMenuStrip1
               // 
               this.contextMenuStrip1.Name = "contextMenuStrip1";
               this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
               // 
               // statusStrip1
               // 
               this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
               this.statusStrip1.Location = new System.Drawing.Point(0, 492);
               this.statusStrip1.Name = "statusStrip1";
               this.statusStrip1.Size = new System.Drawing.Size(742, 22);
               this.statusStrip1.TabIndex = 3;
               this.statusStrip1.Text = "statusStrip1";
               // 
               // toolStripProgressBar1
               // 
               this.toolStripProgressBar1.Name = "toolStripProgressBar1";
               this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
               // 
               // toolStripStatusLabel1
               // 
               this.toolStripStatusLabel1.AutoToolTip = true;
               this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
               this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
               this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
               // 
               // GromBrowser
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoSize = true;
               this.ClientSize = new System.Drawing.Size(742, 514);
               this.Controls.Add(this.statusStrip1);
               this.Controls.Add(this.windowTabs);
               this.Controls.Add(this.toolStrip1);
               this.Controls.Add(this.menuStrip1);
               this.KeyPreview = true;
               this.MainMenuStrip = this.menuStrip1;
               this.Name = "GromBrowser";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
               this.Text = "Grom Browser";
               this.Load += new System.EventHandler(this.Form1_Load);
               this.menuStrip1.ResumeLayout(false);
               this.menuStrip1.PerformLayout();
               this.toolStrip1.ResumeLayout(false);
               this.toolStrip1.PerformLayout();
               this.windowTabs.ResumeLayout(false);
               this.tabPage1.ResumeLayout(false);
               this.statusStrip1.ResumeLayout(false);
               this.statusStrip1.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.MenuStrip menuStrip1;
          private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem closeCurrentTabToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem savePageAsHTMLToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem printPageToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem exitWebBrowserToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem manageHistoryToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem manageBookmarksToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
          private System.Windows.Forms.ToolStrip toolStrip1;
          private System.Windows.Forms.ToolStripButton Forward;
          private System.Windows.Forms.ToolStripButton Back;
          private System.Windows.Forms.ToolStripButton Refresh;
          private System.Windows.Forms.ToolStripButton Home;
          private System.Windows.Forms.ToolStripButton Go;
          private System.Windows.Forms.ToolStripButton Bookmark;
          private System.Windows.Forms.TabControl windowTabs;
          private ToolStripSpringTextBox toolStripSpringTextBox1;
          private System.Windows.Forms.TabPage tabPage1;
          private System.Windows.Forms.WebBrowser webBrowser1;
          private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
          private System.Windows.Forms.StatusStrip statusStrip1;
          private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
          private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
     }
}

