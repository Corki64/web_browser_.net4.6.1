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
          private ArrayList _tabList = new ArrayList();
          private ArrayList _webList = new ArrayList();
          private int _currentTab = 0;

          public GromBrowser()
          {
               InitializeComponent();
               windowTabs.Controls.Clear();
               CreateNewTab();
          }

          // Creates a new tab with a browser object set at DockStyle.Fill.
          private void CreateNewTab()
          {
               var newPage = new TabPage();
               newPage.Focus();
               _tabList.Add(newPage);
               windowTabs.TabPages.Add(newPage);
               var webPage = new System.Windows.Forms.WebBrowser();
               webPage.Navigate("www.google.com");
               _webList.Add(webPage);
               webPage.Parent = newPage;
               webPage.Dock = DockStyle.Fill;

               _currentTab++;
          }

          // Focus on current tab.
          private System.Windows.Forms.WebBrowser GetCurrentBrowser()
          {
               var thisTab = windowTabs.SelectedTab;
               var thisPage = (System.Windows.Forms.WebBrowser) _webList[_tabList.IndexOf(thisTab)];
               return thisPage;
          }

          // Tab name update.
          private void UpdateName(TabPage tabIn)
          {
               if (tabIn == null) throw new ArgumentNullException(nameof(tabIn));
               var thisTab = tabIn;
               var thisPage = (System.Windows.Forms.WebBrowser) _webList[_tabList.IndexOf(this._currentTab)];
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




















          // Loads history form.
          private void ManageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
          {
               var historyForm = new HistoryManagerForm();
               historyForm.ShowDialog();
          }

          // Loads the bookmark form.
          public void ManageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
          {
               var bookmarkForm = new BookmarkManagerForm();
               bookmarkForm.ShowDialog();
          }

          // Contents of about menu strip item as follows:
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
               CreateNewTab();
               NavigateToPage();
          }

          // Will closes open tabs.
          private void CloseCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
          {
               if (_currentTab < 2) return;
               var thisTab = windowTabs.SelectedTab;
               var thisPage = (System.Windows.Forms.WebBrowser) _webList[_tabList.IndexOf(thisTab)];
               _tabList.Remove(thisTab);
               windowTabs.TabPages.Remove(thisTab);
               _currentTab--;
          }

          // Adds bookmarks to bookmark database.
          private void Bookmark_Click(object sender, EventArgs e)
          {
               var thisTab = windowTabs.SelectedTab;
               var thisPage = (System.Windows.Forms.WebBrowser) _webList[_tabList.IndexOf(thisTab)];
               if (thisTab == null) throw new ArgumentNullException(nameof(thisTab));
               var newItem = new BookmarkItem {Url = urlTextBox.Text, Title = thisPage.DocumentTitle};

               // Checks to see if it the bookmark is already in the database.
               var currentBookMarks = BookmarkManager.GetBookmarkItems();
               if (!currentBookMarks.Contains(newItem))
               {
                    BookmarkManager.Add(newItem);
               }
          }

          // Checks to see if backwards is possible then navigates back.
          private void Back_Click(object sender, EventArgs e)
          {
               var thisPage = GetCurrentBrowser();
               if (thisPage.CanGoBack)
               {
                    thisPage.GoBack();
               }
          }

          // Checks to see if forward is possible then navigates forward.
          private void Forward_Click(object sender, EventArgs e)
          {
               var thisPage = GetCurrentBrowser();
               if (thisPage.CanGoForward)
               {
                    thisPage.GoForward();
               }
          }

          // Refreshes current page.
          private void BrowserRefresh_Click(object sender, EventArgs e)
          {
               var thisPage = GetCurrentBrowser();
               thisPage.Refresh();
          }

          // Opens save as dialog box.
          private void SavePageAsHTMLToolStripMenuItem_Click(object sender, EventArgs e)
          {
               var thisPage = GetCurrentBrowser();
               thisPage.ShowSaveAsDialog();
          }

          // Opens the print preview Dialog box.
          private void PrintPageToolStripMenuItem_Click(object sender, EventArgs e)
          {
               var thisPage = GetCurrentBrowser();
               thisPage.ShowPrintPreviewDialog();
          }

          // This function will allow us to hit enter from the address text box and go to web page entered.
          private void ToolStripSpringTextBox1_KeyPress(object sender, KeyPressEventArgs e)
          {
               if (e.KeyChar == (char)ConsoleKey.Enter)
               {
                    NavigateToPage();
                    e.Handled = true;
               }
          }

          // Automatically adds items to history database as sites are visited.
          private void AddHistoryItem()
          {
               var thisPage = GetCurrentBrowser();
               var newItem = new HistoryItem
               {
                    Date = DateTime.Now,
                    Title = thisPage.DocumentTitle,
                    Url = urlTextBox.Text
               };
               HistoryManager.AddHistoryItem(newItem);
          }

          // Will direct the user to desired web page and handles cases that may cause a failure to navigate.
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
                    _webList.Add(thisPage);
                    _tabList.Add(thisTab);
                    thisPage.Navigate(urlTextBox.Text);
                    AddHistoryItem();
               }
               catch (System.UriFormatException)
               {
                    return;
               }
          }

          private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
          {

          }
     }
}
