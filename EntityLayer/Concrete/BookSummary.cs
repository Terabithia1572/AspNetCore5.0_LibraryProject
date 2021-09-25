using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
   public class BookSummary
    {
        public int SummaryId { get; set; }
        public string SummaryName { get; set; }
        public string SummaryDescription { get; set; }
        public DateTime SummaryDate { get; set; }
        public bool SummaryStatus { get; set; }
       
       
    }
}
