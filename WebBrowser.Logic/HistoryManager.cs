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
               List<HistoryItem> results = new List<HistoryItem>();
               BrowserDBDataSet.HistoryDataTable rows = Adapter.GetData();

               foreach (BrowserDBDataSet.HistoryRow row in rows)
               {
                    HistoryItem item = new HistoryItem {Id = row.Id, Url = row.URL, Title = row.Title, Date = row.Date};
                    results.Add(item);
               }

               return results;
          }
     }
}