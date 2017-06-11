using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Musify_Web.Controllers;
using Musify_Web.Models;
using Musify_Web.Repository.Interface;

namespace Musify_Web.Repository.DAO
{
    public class GenreDao : IGenreContext
    {
        static SqlDataAccessObject sqlDao = new SqlDataAccessObject();
        
        SqlConnection conn = new SqlConnection(sqlDao.Connectionstring);

        Exceptions eh = new Exceptions();

        public List<Genre> GetAllGenres()
        {
            List<Genre> genres = new List<Genre>();
            string query = "SELECT * FROM genre";
            try
            {
                DataTable dt = sqlDao.Execute(query);
                foreach (DataRow dr in dt.Rows)
                {
                    int id = (int)dr["id"];
                    string name = dr["name"].ToString();
                    string description = dr["description"].ToString();
                    string image = dr["image_url"].ToString();
                    string date = dr["created_at"].ToString();
                    bool gpublic = Convert.ToBoolean(dr["public"].ToString());
                    DateTime created = Convert.ToDateTime(dr["created_at"].ToString());
                    DateTime updated = Convert.ToDateTime(dr["updated_at"].ToString());

                    List<Artist> artists = GetGenreArtists(id);

                    genres.Add(new Genre(id, name, description, image, gpublic, created, updated, artists));
                }
            }
            catch (SqlException ex)
            {
                eh.WriteToFile(ex.ToString());
            }
            catch (NullReferenceException ex)
            {
                eh.WriteToFile(ex.ToString());
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
            }

            return genres;
        }

        public List<Artist> GetGenreArtists(int genreId)
        {
            List<Artist> artists = new List<Artist>();
            string GenreArtists = "SELECT * FROM genre_artist AS ga INNER JOIN artist AS a ON a.id = ga.artist_id INNER JOIN genre AS g  ON  g.id = ga.genre_id AND g.id = @GenreId";
            try
            {
                SqlCommand gaCommand = new SqlCommand(GenreArtists, conn);
                gaCommand.Parameters.Add("@GenreId", SqlDbType.Int).Value = genreId;
                DataTable dtGa = sqlDao.Execute(gaCommand);

                foreach (DataRow drGa in dtGa.Rows)
                {
                    int artistId = (int) drGa["id"];
                    string artistName = drGa["name"].ToString();
                    string artistBigImage = drGa["image_big_url"].ToString();
                    string artistSmallImage = drGa["image_small_url"].ToString();
                    string artistBio = drGa["BIO"].ToString();
                    DateTime artistCreated = Convert.ToDateTime(drGa["created_at"].ToString());
                    DateTime artistUpdated = Convert.ToDateTime(drGa["updated_at"].ToString());

                    artists.Add(new Artist(artistId, artistName, artistBigImage, artistSmallImage, artistBio,
                        artistCreated, artistUpdated));
                }
            }
            catch (SqlException ex)
            {
                eh.WriteToFile(ex.ToString());
            }
            catch (NullReferenceException ex)
            {
                eh.WriteToFile(ex.ToString());
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
            }

            return artists;
        }

        public Genre GetGenreById(int genreId)
        {
            try
            {
                List<Genre> genres = GetAllGenres();
                foreach (var genre in genres)
                {
                    if (genre.Id == genreId)
                    {
                        return genre;
                    }
                }
            }
            catch (SqlException ex)
            {
                eh.WriteToFile(ex.ToString());
            }
            catch (NullReferenceException ex)
            {
                eh.WriteToFile(ex.ToString());
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
            }

            return null;
        }

        public Genre HideGenreById(int genreId)
        {
            Genre genre = new Genre();
            try
            {
                genre = GetGenreById(genreId);

                string query = "UPDATE genre SET [public] = 0 WHERE id = @genreId";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add("@genreId", SqlDbType.Int);
                command.Parameters["@genreId"].Value = genreId;
                sqlDao.ExecuteNonQuery(command);
            }
            catch (SqlException ex)
            {
                eh.WriteToFile(ex.ToString());
            }
            catch (NullReferenceException ex)
            {
                eh.WriteToFile(ex.ToString());
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
            }
            return genre;
        }

        public Genre ShowGenreById(int genreId)
        {
            Genre genre = GetGenreById(genreId);
            string query = "UPDATE genre SET [public] = 1 WHERE id = @genreId";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add("@genreId", SqlDbType.Int);
            command.Parameters["@genreId"].Value = genreId;
            sqlDao.ExecuteNonQuery(command);

            return genre;
        }

        public void DeleteGenreById(int genreId)
        {
            try
            {
                SqlCommand command = sqlDao.GetSqlCommand("spDeleteGenre");
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Id", SqlDbType.Int).Value = genreId;

                sqlDao.ExecuteNonQuery(command);
            }
            catch (SqlException ex)
            {
                eh.WriteToFile(ex.ToString());
            }
            catch (NullReferenceException ex)
            {
                eh.WriteToFile(ex.ToString());
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
            }
        }

        public void AddGenre(Genre genre)
        {
            string query =
                "INSERT INTO [genre] (name, description, image_url, [public], created_at, updated_at) VALUES(@name, @description, @image, @gpublic, @created, @updated)";
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@name", genre.Name);
                command.Parameters.AddWithValue("@description", genre.Description);
                command.Parameters.AddWithValue("@image", genre.ImageUrl);
                command.Parameters.AddWithValue("@gpublic", genre.Public);
                command.Parameters.AddWithValue("@created", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                command.Parameters.AddWithValue("@updated", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                sqlDao.ExecuteNonQuery(command);
            }
            catch (SqlException ex)
            {
                eh.WriteToFile(ex.ToString());
            }
            catch (NullReferenceException ex)
            {
                eh.WriteToFile(ex.ToString());
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
            }
        }

        public Genre UpdateGenreById(Genre genre)
        {
            string query =
                "UPDATE [GENRE] SET name = @name, description = @description, image_url = @image, [public] = @gpublic, updated_at = @updated WHERE id = @id";
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add("@id", SqlDbType.Int).Value = genre.Id;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = genre.Name;
                command.Parameters.Add("@description", SqlDbType.VarChar).Value = genre.Description;
                command.Parameters.Add("@image", SqlDbType.VarChar).Value = genre.ImageUrl;
                command.Parameters.Add("@gpublic", SqlDbType.VarChar).Value = genre.Public;
                command.Parameters.Add("@updated", SqlDbType.VarChar).Value =
                    DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

                sqlDao.ExecuteNonQuery(command);
            }
            catch (SqlException ex)
            {
                eh.WriteToFile(ex.ToString());
            }
            catch (NullReferenceException ex)
            {
                eh.WriteToFile(ex.ToString());
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
            }

            return genre;
        }
    }
}