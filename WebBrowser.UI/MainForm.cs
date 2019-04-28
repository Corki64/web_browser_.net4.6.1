using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser;
using WebBrowser.Logic;
using WebBrowser = System.Windows.Forms.WebBrowser;

namespace WebBrowser.UI
{
     public partial class GromBrowser : Form
     {
          private ArrayList tabList = new ArrayList();
          private ArrayList webList = new ArrayList();
          private int currentTab = 0;

          public GromBrowser()
          {
               InitializeComponent();
               windowTabs.Controls.Clear();
               CreateNewTab();
               var webPage = GetCurrentBrowser();
          }

          // Creates a new tab with a browser object set at DockStyle.Fill.
          private void CreateNewTab()
          {
               var newPage = new TabPage("Loading");
               tabList.Add(newPage);
               windowTabs.TabPages.Add(newPage);
               var webPage = new System.Windows.Forms.WebBrowser();
               webList.Add(webPage);
               webPage.Parent = newPage;
               webPage.Dock = DockStyle.Fill;
               currentTab++;
          }

          // Focus on current tab.
          private System.Windows.Forms.WebBrowser GetCurrentBrowser()
          {
               var thisTab = windowTabs.SelectedTab;
               var thisPage = (System.Windows.Forms.WebBrowser) webList[tabList.IndexOf(thisTab)];
               return thisPage;
          }

          // Tab name update.
          private void UpdateName(TabPage tabIn)
          {
               if (tabIn == null) throw new ArgumentNullException(nameof(tabIn));
               var thisTab = tabIn;
               var thisPage = (System.Windows.Forms.WebBrowser) webList[tabList.IndexOf(this.currentTab)];
               thisTab.Text = thisPage.Document != null ? thisPage.DocumentTitle : "Loading";
          }

          // Updates all tab names.
          private void UpdateTabNames()
          {
               foreach (TabPage tab in windowTabs.TabPages)
               {
                    UpdateName(tab);
               }
          }

          private void Go_Click(object sender, EventArgs e)
          {
               NavigateToPage();
          }

          private void NavigateToPage()
          {
               if (string.IsNullOrEmpty(urlTextBox.Text) || urlTextBox.Text.Equals("about:blank"))
               {
                    MessageBox.Show("Invalid Address");
                    urlTextBox.Focus();
                    return;
               }

               if (!urlTextBox.Text.StartsWith("http://") && !urlTextBox.Text.StartsWith("https://"))
               {
                    urlTextBox.Text = "http://" + urlTextBox.Text;
               }

               try
               {
                    var thisPage = GetCurrentBrowser();
                    var thisTab = windowTabs.SelectedTab;
                    webList.Add(thisPage);
                    tabList.Add(thisTab);
                    thisPage.Navigate(urlTextBox.Text);
                    toolStripStatusLabel1.Text = "Page Loading";
                    AddHistoryItem();


               }
               catch (System.UriFormatException)
               {
                    return;
               }
          }

          private void AddHistoryItem()
          {
               var thisPage = GetCurrentBrowser();
               var newItem = new HistoryItem
               {
                    Date = DateTime.Now, Title = thisPage.DocumentTitle, Url = urlTextBox.Text
               };

               HistoryManager.AddHistoryItem(newItem);
          }






          private void ToolStripButton1_Click(object sender, EventArgs e)
          {

          }

          /**
           * This function will allow us to hit enter from the address text box and go to web page entered.
           */
          private void ToolStripSpringTextBox1_KeyPress(object sender, KeyPressEventArgs e)
          {
               if (e.KeyChar == (char) ConsoleKey.Enter)
               {
                    NavigateToPage();
                    e.Handled = true;
               }
          }

          // Will come back to this progress bar : once navigation restored
          private void WebBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
          {
               /**
                * This if statement will take care of a divide by zero error.
                */
               if (e.CurrentProgress > 0 && e.MaximumProgress > 0)
               {
                    if (toolStripProgressBar1.ProgressBar != null)
                         toolStripProgressBar1.ProgressBar.Value = (int) (e.CurrentProgress * 100 / e.MaximumProgress);
               }
          }

          //Once i can get a valid name for webBrowser instance than I can turn this on
          private void PrintPageToolStripMenuItem_Click(object sender, EventArgs e)
          {
               //webBrowser1.ShowPrintPreviewDialog();
          }



















          private void ManageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
          {
               var historyForm = new HistoryManagerForm();
               historyForm.ShowDialog();
          }

          public void ManageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
          {
               var bookmarkForm = new BookmarkManagerForm();
               bookmarkForm.ShowDialog();
          }

          private void CloseCurrentTabToolStripMenuItem_Click_1(object sender, EventArgs e)
          {
               windowTabs.TabPages.Remove(windowTabs.SelectedTab);
          }

          private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
          {
               MessageBox.Show(
                    "Welcome to the best browser ever built in this office. It is brought to you by Luis Cortez (lac0084@auburn.edu). I hope you enjoy your stay.");
          }

          // This function called to close the browser.
          private void ExitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          // Create new tab is working.
          private void NewTabToolStripMenuItemClick(object sender, EventArgs e)
          {
               NavigateToPage();
          }

          // Will closes open tabs.
          private void CloseCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
          {
               if (currentTab < 2) return;
               var thisTab = windowTabs.SelectedTab;
               var thisPage = (System.Windows.Forms.WebBrowser) webList[tabList.IndexOf(thisTab)];
               tabList.Remove(thisTab);
               windowTabs.TabPages.Remove(thisTab);
               currentTab--;
          }

          private void Bookmark_Click(object sender, EventArgs e)
          {
               var thisTab = windowTabs.SelectedTab;
               var thisPage = (System.Windows.Forms.WebBrowser) webList[tabList.IndexOf(thisTab)];
               if (thisTab == null) throw new ArgumentNullException(nameof(thisTab));
               thisTab.Text = thisPage.Document != null ? thisPage.DocumentTitle : "Loading";
               var newItem = new BookmarkItem {Url = urlTextBox.Text, Title = thisPage.DocumentTitle};
               BookmarkManager.Add(newItem);
          }

          private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
          {

          }

     }
}
