using System;

namespace WebBrowser.Logic
{
     public class HistoryItem
     {
          public int Id { get; set; }
          public string Url { get; set; }
          public string Title { get; set; }
          public DateTime Date { get; set; }
     }
}