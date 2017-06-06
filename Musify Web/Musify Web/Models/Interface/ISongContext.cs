using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify_Web.Models.Interface
{
    public interface ISongContext
    {
        List<Song> GetAllSongs();
        Song GetSongById(int songId);
        void Addsong(Song song);
        void DeleteSongById(int songId);
        Song UpdatesongById(Song song);
        Song GetSongByIdAndAlbum(int albumId, int songId);
    }
}
