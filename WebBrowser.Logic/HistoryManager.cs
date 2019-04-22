using System.Collections.Generic;
using System.Runtime.InteropServices;
using WebBrowser.Data;
using WebBrowser.Data.BrowserDBDataSetTableAdapters;

namespace WebBrowser.Logic
{
     public class HistoryManager
     {
          public static HistoryTableAdapter Adapter = new HistoryTableAdapter();

          public static void AddHistoryItem(HistoryItem itemIn)
          {
               Adapter.Insert(itemIn.Url, itemIn.Title, itemIn.Date);
          }

          public static List<HistoryItem> GetHistoryItems()
          {
               var results = new List<HistoryItem>();
               using (var rows = Adapter.GetData())
               {
                    foreach (var row in rows)
                    {
                         HistoryItem item = new HistoryItem { Id = row.Id, Url = row.URL, Title = row.Title, Date = row.Date };
                         results.Add(item);
                    }
               }
               return results;
          }
     }
}