using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify_Web.Models.Interface
{
    public interface IAlbumContext
    {
        List<Album> GetAllAlbums();
        Album GetAlbumById(int albumId);
        void AddAlbum(Album album);
        void DeleteAlbumById(int albumId);
        Album UpdateAlbumById(Album album);
        List<Song> GetSongAlbums(int id);
    }
}
