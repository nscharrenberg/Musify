using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musify_Application.Interface
{
    interface IGenreContext
    {
        void AddGenre(string name, string description, string image);
        List<Genre> AllGenres();
        Genre SearchGenreByName(string name);
        Genre SearchGenreById(int id);
        void UpdateGenre(int id, string name, string description, string image);
        void RefreshList();
        void DeleteGenreById(int id);
    }
}
