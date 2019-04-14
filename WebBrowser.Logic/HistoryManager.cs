using WebBrowser.Data.BrowserDBDataSetTableAdapters;

namespace WebBrowser.Logic
{
     public class HistoryManager
     {
          public static HistoryTableAdapter HistoryAdapter = new HistoryTableAdapter();

          public static void Add(HistoryItem itemIn)
          {
               HistoryAdapter.Insert(itemIn.Url, itemIn.Title, itemIn.Date);
          }
     }
}