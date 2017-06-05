using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musify_Web.Models.ViewModel
{
    public class CreateSongViewModel
    {
        public string SongLength { get; set; }
        public Song Song { get; set; }
    }
}