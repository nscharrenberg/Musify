using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using Musify_Web.Models;
using Musify_Web.Repository.Interface;

namespace Musify_Web.Repository
{
    public class GenreRepository
    {
        private IGenreContext context;

        public GenreRepository(IGenreContext context)
        {
            this.context = context;
        }

        public Genre[] GetAllGenres()
        {
            return context.GetAllGenres().ToArray();
        }

        public Genre GetGenreById(int genreId)
        {
            return context.GetGenreById(genreId);
        }

        public Genre HideGenreById(int genreId)
        {
            return context.HideGenreById(genreId);
        }

        public Genre ShowGenreById(int genreId)
        {
            return context.ShowGenreById(genreId);
        }

        public void DeleteGenreById(int genreId)
        {
            context.DeleteGenreById(genreId);
        }

        public void AddGenre(Genre genre)
        {
            context.AddGenre(genre);
        }

        public Genre UpdateGenreById(Genre genre)
        {
            return context.UpdateGenreById(genre);
        }
    }
}