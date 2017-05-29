using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Musify_Web.Models;

namespace Musify_Web.Repository.Interface
{
    public interface IGenreContext
    {
        List<Genre> GetAllGenres();
        Genre GetGenreById(int genreId);
        Genre HideGenreById(int genreId);
        Genre ShowGenreById(int genreId);
        void DeleteGenreById(int genreId);
        void AddGenre(Genre genre);
        Genre UpdateGenreById(Genre genre);
    }
}
