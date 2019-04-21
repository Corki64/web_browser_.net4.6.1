using System.Collections.Generic;
using WebBrowser.Data;
using WebBrowser.Data.BrowserDBDataSetTableAdapters;

namespace WebBrowser.Logic
{
     public class BookmarkManager
     {
          public static BookmarksTableAdapter Adapter = new BookmarksTableAdapter();
          public static void Add(BookmarkItem itemIn)
          {
               Adapter.Insert(itemIn.Url, itemIn.Title, itemIn.Id);
          }

          public static List<BookmarkItem> GetBookmarkItems()
          {
               var results = new List<BookmarkItem>();
               using (var rows = Adapter.GetData())
               {
                    foreach (var row in rows)
                    {
                         var item = new BookmarkItem {Url = row.URL, Title = row.Title, Id = row.Id};

                         results.Add(item);
                    }
               }

               return results;
          }
     }
}