using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace week10lab.Models
{
    public class Pins
    {
        public int PinId { get; set; }
        [DataType(DataType.Url)]
        public string WebLink { get; set; }
        [DataType(DataType.ImageUrl)]
        public string ImageLink { get; set; }
        public string CommentText { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }



    }
}