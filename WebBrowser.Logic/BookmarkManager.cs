using System.Collections.Generic;
using WebBrowser.Data;
using WebBrowser.Data.BrowserDBDataSetTableAdapters;

namespace WebBrowser.Logic
{
     public class BookmarkManager
     {
          public static void Add(BookmarkItem itemIn)
          {
               var adapter = new BookmarksTableAdapter();
               adapter.Insert(itemIn.Url, itemIn.Title, itemIn.Id);
          }

          public static List<BookmarkItem> GetBookmarkItems()
          {
               var adapter = new BookmarksTableAdapter();
               var results = new List<BookmarkItem>();
               var rows = adapter.GetData();

               foreach (var row in rows)
               {
                    var item = new BookmarkItem {Url = row.URL, Title = row.Title, Id = row.Id};

                    results.Add(item);
               }
               return results;
          }
     }
}