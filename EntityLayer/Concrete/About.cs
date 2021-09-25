using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
  public  class About  // kendimizi ve projede belli baslı yerleri anlatma 
    {
        public int AboutId { get; set; }
        public string AboutName { get; set; }
        public string AboutDetail { get; set; }
        public string AboutImage { get; set; }
        public bool AboutStatus  { get; set; }
    }
}
