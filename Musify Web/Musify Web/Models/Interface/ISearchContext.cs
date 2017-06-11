using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify_Web.Models.Interface
{
    public interface ISearchContext
    {
        List<Genre> getGenresSearchResults(string content);
        List<Artist> getArtistsSearchResults(string content);
        List<Album> getAlbumsSearchResults(string content);
        List<Song> getSongsSearchResults(string content);
    }
}
