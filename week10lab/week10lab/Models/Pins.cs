using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week10lab.Models
{
    public class Pins
    {
        public int PinId { get; set; }
        public string WebLink { get; set; }
        public string ImageLink { get; set; }
        public string CommentText { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }



    }
}