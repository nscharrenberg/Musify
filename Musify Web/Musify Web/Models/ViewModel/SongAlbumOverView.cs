using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musify_Web.Models.ViewModel
{
    public class SongAlbumOverView
    {
        public List<Song> Songs { get; set; }
        public Album Album { get; set; }
    }
}