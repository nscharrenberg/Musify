using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Musify_Application.Interface;

namespace Musify_Application.Repository
{
    class GenreRepository
    {
        private IGenreContext context;

        public GenreRepository(IGenreContext context)
        {
            this.context = context;
        }

        public void AddGenre(string name, string description, string image)
        {
            context.AddGenre(name, description, image);
        }

        public Genre[] AllGenres()
        {
           return context.AllGenres().ToArray();
        }

        public Genre SearchGenre(string name)
        {
            return context.SearchGenreByName(name);
        }

        public Genre SearchGenreById(int id)
        {
            return context.SearchGenreById(id);
        }

        public void UpdateGenre(int id, string name, string description, string image)
        {
            context.UpdateGenre(id, name, description, image);
        }

        public void RefreshList()
        {
            context.RefreshList();
        }

        public void DeleteGenreById(int id)
        {
            context.DeleteGenreById(id);
        }
    }
}
