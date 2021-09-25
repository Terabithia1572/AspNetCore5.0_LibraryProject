using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{

    public class Message
    {
        public int MessageId { get; set; }
        public string SenderMail { get; set; }
        public string RecaiverMail { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
