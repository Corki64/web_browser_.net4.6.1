using System.Collections.Generic;
using System.Runtime.InteropServices;
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
               var rows = Adapter.GetData();

               foreach (var row in rows)
               {
                    var item = new HistoryItem {Id = row.Id, Url = row.URL, Title = row.Title, Date = row.Date};
                    results.Add(item);
               }

               return results;
          }
     }
}