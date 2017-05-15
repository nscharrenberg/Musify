using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Musify_Application.Interface;

namespace Musify_Application.DAO
{
    class GenreDAO : IGenreContext
    {
        private SqlDataAccessObject sqlDAO = new SqlDataAccessObject();
        List<Genre> genreList = new List<Genre>();

        public void AddGenre(string name, string description, string image)
        {
            string query = @"INSERT INTO [genre] ([name], [description], [image_url], [created_at], [updated_at]) values ('" + name + "', '" + description + "', '" + image + "', '" + DateTime.Now.ToString("MM'/'dd'/'yyyy HH:mm:ss") + "', '" + DateTime.Now.ToString("MM'/'dd'/'yyyy HH:mm:ss") + "')";
            sqlDAO.ExecuteNonQuery(query);
        }

        public List<Genre> AllGenres()
        {
            string query = @"SELECT * FROM [genre]";
            DataTable dt = sqlDAO.Execute(query);
            
            foreach (DataRow dr in dt.Rows)
            {
                genreList.Add(new Genre((int)dr["id"], dr["name"].ToString(), dr["description"].ToString(), dr["image_url"].ToString()));
            }

            return genreList;
        }

        public void RefreshList()
        {
            genreList.Clear();
        }

        public Genre SearchGenreByName(string name)
        {
            foreach (var genre in genreList)
            {
                if (genre.Name == name)
                {
                    return genre;
                }
            }

            return null;
        }

        public Genre SearchGenreById(int id)
        {
            foreach (var genre in genreList)
            {
                if (genre.Id == id)
                {
                    return genre;
                }
            }

            return null;
        }

        public void UpdateGenre(int id, string name, string description, string image)
        {
            string query = "UPDATE [genre] SET name = '" + name + "', description = '" + description +
                           "', image_url = '" + image + "' WHERE id = '" + id + "'";
            sqlDAO.ExecuteNonQuery(query);
        }

        public void DeleteGenreById(int id)
        {
            string query = "DELETE FROM [genre] WHERE id = '" + id + "'";
            sqlDAO.ExecuteNonQuery(query);
        }
    }
}
