using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Musify_Web.Models.Interface;

namespace Musify_Web.Models.Repository
{
    public class SearchRepository
    {
        private ISearchContext context;

        public SearchRepository(ISearchContext context)
        {
            this.context = context;
        }

        public List<Genre> getGenresSearchResults(string content)
        {
            return context.getGenresSearchResults(content);
        }

        public List<Artist> getArtistsSearchResults(string content)
        {
            return context.getArtistsSearchResults(content);
        }

        public List<Album> getAlbumsSearchResults(string content)
        {
            return context.getAlbumsSearchResults(content);
        }

        public List<Song> getSongsSearchResults(string content)
        {
            return context.getSongsSearchResults(content);
        }
    }
}