using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify_Application.Interface
{
    interface IArtistContext
    {
        void AddArtist(string name, string biography, string BigImage, string smallImage);
        List<Artist> AllArtists();
        Artist SearchArtistByName(string name);
        Artist SearchArtistById(int id);
        void UpdateArtist(int id, string name, string biography, string bigImage, string smallImage);
        void RefreshList();
        void DeleteArtistById(int id);
        void AddGenreToArtist(int artistId, int genreId);
        List<Genre> GetGenreOfArtist(int artistId);
    }
}
