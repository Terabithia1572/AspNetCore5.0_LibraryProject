using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
   public class Contact
    {
        public int ContactId { get; set; }
        public string UserName { get; set; }
        public string UserSurName { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public bool  ContactStatus { get; set; }
    }
}
