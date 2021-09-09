using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _14_EF_MVC_Model.Models
{
    [Bind(Exclude = "Price")]
    public class Album
    {
        public string AlbumTitle { get; set; }        
        public decimal Price { get; set; }
        public Artist Artist { get; set; }

        public string DateString { get; set; }

    }
}