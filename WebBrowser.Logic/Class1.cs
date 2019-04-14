using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Logic
{
    public class HistoryItem
    {
          public int Id { get; set; }
          public String Url { get; set; }
          public String Title { get; set; }
          public DateTime Date { get; set; }
     }

    
}
