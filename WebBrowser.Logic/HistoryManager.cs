using System.Collections.Generic;
using System.Runtime.InteropServices;
using WebBrowser.Data.BrowserDBDataSetTableAdapters;

namespace WebBrowser.Logic
{
     public class HistoryManager
     {

          public static void AddHistoryItem(HistoryItem itemIn)
          {
               var adapter = new HistoryTableAdapter();
               adapter.Insert(itemIn.Url, itemIn.Title, itemIn.Date);
          }

          public static List<HistoryItem> GetHistoryItems()
          {
               var adapter = new HistoryTableAdapter();
               var results = new List<HistoryItem>();
               var rows = adapter.GetData();

               foreach (var row in rows)
               {
                    var item = new HistoryItem {Id = row.Id, Url = row.URL, Title = row.Title, Date = row.Date};

                    results.Add(item);

               }

               return results;
          }
     }
}