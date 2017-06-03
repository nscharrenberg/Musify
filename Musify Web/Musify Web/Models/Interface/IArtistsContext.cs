using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify_Web.Models.Interface
{
    public interface IArtistsContext
    {

        List<Artist> GetAllArtists();
        List<Genre> GetGenreArtists(int artistId);
        Artist GetArtistById(int artistId);
        void AddArtist(Artist artist);
        void DeleteArtistById(int artistId);
        Artist UpdateArtistById(Artist artist);
        Artist SetUpdateTimeForArtistById(Artist artist);
        void AddGenreToArtist(int artist, int genre);
        void RemoveGenreFromArtist(int artist, int genre);

    }
}
