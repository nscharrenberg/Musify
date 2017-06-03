using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Musify_Web.Models.ViewModel
{
    public class ArtistViewModel
    {
        public int SelecterGenre { get; set; }
        public Artist Artist { get; set; }
        public IEnumerable<SelectListItem> Genres { get; set; }
        
    } 
}