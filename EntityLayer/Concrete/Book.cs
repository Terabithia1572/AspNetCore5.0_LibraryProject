using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookImage { get; set; }
        public string BookDescription { get; set; }
        public string PrintDate { get; set; }
        public string NumberPage { get; set; }
        public bool BookStatus { get; set; }


        public ICollection<BookSummary> BookSummaries { get; set; }

        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }

        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }

    }
}
