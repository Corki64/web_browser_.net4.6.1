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
     public partial class HistoryManagerForm : Form
     {
          public HistoryManagerForm()
          {
               InitializeComponent();
          }

          private void HistoryManagerForm_Load(object sender, EventArgs e)
          {
               var historyItems = HistoryManager.GetHistoryItems();
               foreach (var item in historyItems)
               {
                    historyListBox.Items.Add("Date: " + item.Date + " Name: " + item.Title + " URL: " + item.Url);
               }
          }
     }
}
