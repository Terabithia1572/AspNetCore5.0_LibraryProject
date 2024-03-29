﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
   public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public string Telephone { get; set; }
        public string Education { get; set; }

        public ICollection<BookSummary> BookSummaries { get; set; }

    }
}
