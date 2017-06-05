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

        public Album[] GetAllAlbums()
        {
            return context.GetAllAlbums().ToArray();
        }

        public Album GetAlbumById(int albumId)
        {
            return context.GetAlbumById(albumId);
        }

        public void AddAlbum(Album album)
        {
            context.AddAlbum(album);
        }

        public void DeleteAlbumById(int albumId)
        {
            context.DeleteAlbumById(albumId);
        }

        public Album UpdateAlbumById(Album album)
        {
            return context.UpdateAlbumById(album);
        }

        public List<Song> GetSongAlbums(int id)
        {
            return context.GetSongAlbums(id);
        }
    }
}