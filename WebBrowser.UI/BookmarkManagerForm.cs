using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
     public partial class BookmarkManagerForm : Form
     {
          public BookmarkManagerForm()
          {
               InitializeComponent();
          }

          private void BookmarkManagerForm_Load(object sender, EventArgs e)
          {
               var bookmarkItems = BookmarkManager.GetBookmarkItems();
               foreach (var item in bookmarkItems)
               {
                    bookmarkItemListBox.Items.Add("Name: " + item.Title + " URL: " + item.Url);
               }
          }
     }
}
