using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Musify_Web.Models.Interface;

namespace Musify_Web.Models.Repository
{
    public class SongRepository
    {
        private ISongContext context;

        public SongRepository(ISongContext context)
        {
            this.context = context;
        }

        public Song[] GetAllSongs()
        {
            return context.GetAllSongs().ToArray();
        }

        public Song GetSongById(int songId)
        {
            return context.GetSongById(songId);
        }

        public void Addsong(Song song)
        {
            context.Addsong(song);
        }

        public void DeleteSongById(int songId)
        {
            context.DeleteSongById(songId);
        }

        public Song UpdatesongById(Song song)
        {
            return context.UpdatesongById(song);
        }

        public Song GetSongByIdAndAlbum(int albumId, int songId)
        {
            return context.GetSongByIdAndAlbum(albumId, songId);
        }

    }
}