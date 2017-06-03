using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Musify_Web.Models.Interface;

namespace Musify_Web.Models.Repository
{
    public class AlbumRepository
    {
        private IAlbumContext context;

        public AlbumRepository(IAlbumContext context)
        {
            this.context = context;
        }

        public List<Album> GetAllAlbums()
        {
            return context.GetAllAlbums();
        }
    }
}