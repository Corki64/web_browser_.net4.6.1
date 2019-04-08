namespace WebBrowser.UI
{
     partial class gromBrowser
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
               this.tabControl1 = new System.Windows.Forms.TabControl();
               this.tabPage1 = new System.Windows.Forms.TabPage();
               this.webBrowser1 = new System.Windows.Forms.WebBrowser();
               this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
               this.menuStrip1.SuspendLayout();
               this.toolStrip1.SuspendLayout();
               this.tabControl1.SuspendLayout();
               this.tabPage1.SuspendLayout();
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
               this.newTabToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
               this.newTabToolStripMenuItem.Text = "New Tab";
               // 
               // closeCurrentTabToolStripMenuItem
               // 
               this.closeCurrentTabToolStripMenuItem.Name = "closeCurrentTabToolStripMenuItem";
               this.closeCurrentTabToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
               this.closeCurrentTabToolStripMenuItem.Text = "Close Current Tab";
               // 
               // savePageAsHTMLToolStripMenuItem
               // 
               this.savePageAsHTMLToolStripMenuItem.Name = "savePageAsHTMLToolStripMenuItem";
               this.savePageAsHTMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
               this.savePageAsHTMLToolStripMenuItem.Text = "Save Page as HTML";
               // 
               // printPageToolStripMenuItem
               // 
               this.printPageToolStripMenuItem.Name = "printPageToolStripMenuItem";
               this.printPageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
               this.printPageToolStripMenuItem.Text = "Print Page";
               // 
               // exitWebBrowserToolStripMenuItem
               // 
               this.exitWebBrowserToolStripMenuItem.Name = "exitWebBrowserToolStripMenuItem";
               this.exitWebBrowserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
               this.manageHistoryToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
               this.manageHistoryToolStripMenuItem.Text = "Manage History";
               // 
               // manageBookmarksToolStripMenuItem
               // 
               this.manageBookmarksToolStripMenuItem.Name = "manageBookmarksToolStripMenuItem";
               this.manageBookmarksToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
               this.manageBookmarksToolStripMenuItem.Text = "Manage Bookmarks";
               // 
               // helpToolStripMenuItem
               // 
               this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
               this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
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
               // tabControl1
               // 
               this.tabControl1.Controls.Add(this.tabPage1);
               this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.tabControl1.Location = new System.Drawing.Point(0, 49);
               this.tabControl1.Name = "tabControl1";
               this.tabControl1.SelectedIndex = 0;
               this.tabControl1.Size = new System.Drawing.Size(742, 465);
               this.tabControl1.TabIndex = 2;
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
               // 
               // contextMenuStrip1
               // 
               this.contextMenuStrip1.Name = "contextMenuStrip1";
               this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
               // 
               // gromBrowser
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoSize = true;
               this.ClientSize = new System.Drawing.Size(742, 514);
               this.Controls.Add(this.tabControl1);
               this.Controls.Add(this.toolStrip1);
               this.Controls.Add(this.menuStrip1);
               this.MainMenuStrip = this.menuStrip1;
               this.Name = "gromBrowser";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
               this.Text = "Grom Browser";
               this.Load += new System.EventHandler(this.Form1_Load);
               this.menuStrip1.ResumeLayout(false);
               this.menuStrip1.PerformLayout();
               this.toolStrip1.ResumeLayout(false);
               this.toolStrip1.PerformLayout();
               this.tabControl1.ResumeLayout(false);
               this.tabPage1.ResumeLayout(false);
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
          private System.Windows.Forms.TabControl tabControl1;
          private ToolStripSpringTextBox toolStripSpringTextBox1;
          private System.Windows.Forms.TabPage tabPage1;
          private System.Windows.Forms.WebBrowser webBrowser1;
          private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
     }
}

