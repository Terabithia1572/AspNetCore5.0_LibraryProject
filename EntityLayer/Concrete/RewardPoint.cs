using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    class RewardPoint
    {
        public int RewardId { get; set; }
        public DateTime date { get; set; }
      
        public decimal TotelPoint { get; set; }

        /*İlişkiler*/
        public int UserId { get; set; }
    }
}
