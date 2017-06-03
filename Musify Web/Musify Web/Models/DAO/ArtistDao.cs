using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Musify_Web.Models.Interface;
using Musify_Web.Repository;
using Musify_Web.Repository.DAO;

namespace Musify_Web.Models.DAO
{
    public class ArtistDao : IArtistsContext
    {
        static SqlDataAccessObject sqlDao = new SqlDataAccessObject();
        SqlConnection conn = new SqlConnection(sqlDao.Connectionstring);

        static GenreDao genreDao = new GenreDao();
        GenreRepository _gr = new GenreRepository(genreDao);

        public List<Artist> GetAllArtists()
        {
            List<Artist> artists = new List<Artist>();
            string query = "SELECT * FROM artist";
            DataTable dt = sqlDao.Execute(query);

            foreach (DataRow dr in dt.Rows)
            {
                int id = (int)dr["id"];
                string name = dr["name"].ToString();
                string imageBig = dr["image_big_url"].ToString();
                string imageSmall = dr["image_small_url"].ToString();
                string biography = dr["BIO"].ToString();
                DateTime created = Convert.ToDateTime(dr["created_at"].ToString());
                DateTime updated = Convert.ToDateTime(dr["updated_at"].ToString());

                List<Genre> genres = GetGenreArtists(id);
                List<Album> albums = GetAlbumArtists(id);


                artists.Add(new Artist(id, name, imageBig, imageSmall, biography, created, updated, genres, albums));
            }

            return artists;
        }

        public List<Genre> GetGenreArtists(int artistId)
        {
            List<Genre> genres = new List<Genre>();
            string GenreArtists = "SELECT * FROM genre_artist AS ga INNER JOIN genre AS g  ON  g.id = ga.genre_id INNER JOIN artist AS a ON a.id = ga.artist_id AND a.id = @artistId";
            SqlCommand gaCommand = new SqlCommand(GenreArtists, conn);
            gaCommand.Parameters.Add("@artistId", SqlDbType.Int).Value = artistId;
            DataTable dt = sqlDao.Execute(gaCommand);

            foreach (DataRow dr in dt.Rows)
            {
                int id = (int)dr["id"];
                string name = dr["name"].ToString();
                string description = dr["description"].ToString();
                string image = dr["image_url"].ToString();
                bool gpublic = Convert.ToBoolean(dr["public"].ToString());
                DateTime created = Convert.ToDateTime(dr["created_at"].ToString());
                DateTime updated = Convert.ToDateTime(dr["updated_at"].ToString());

                genres.Add(new Genre(id, name, description, image, gpublic, created, updated));
            }

            return genres;
        }

        public List<Album> GetAlbumArtists(int id)
        {
            List<Album> albums = new List<Album>();
            string AlbumArtists = "SELECT * FROM album AS alb INNER JOIN artist AS art ON art.id = alb.artist_id AND art.id = @artistId";
            SqlCommand command = new SqlCommand(AlbumArtists, conn);
            command.Parameters.Add("@artistId", SqlDbType.Int).Value = id;
            DataTable dt = sqlDao.Execute(command);

            foreach (DataRow dr in dt.Rows)
            {
                int albumId = (int)dr["id"];
                string name = dr["name"].ToString();
                DateTime release = Convert.ToDateTime(dr["release_date"].ToString());
                string imageBig = dr["image_big_url"].ToString();
                string imageSmall = dr["image_small_url"].ToString();
                DateTime created = Convert.ToDateTime(dr["created_at"].ToString());
                DateTime updated = Convert.ToDateTime(dr["updated_at"].ToString());

                albums.Add(new Album(albumId, name, release, imageBig, imageSmall, created, updated));
            }

            return albums;
        }

        public Artist GetArtistById(int artistId)
        {
            List<Artist> artists = GetAllArtists();

            foreach (var artist in artists)
            {
                if (artist.Id == artistId)
                {
                    return artist;
                }
            }

            return null;
        }

        public void AddArtist(Artist artist)
        {
            string query =
                "INSERT INTO [artist] (name, BIO, image_big_url, image_small_url, created_at, updated_at) VALUES(@name, @biography, @imageBig, @imageSmall, @created, @updated)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@name", artist.Name);
            command.Parameters.AddWithValue("@biography", artist.Biography);
            command.Parameters.AddWithValue("@imageBig", artist.ImageBigUrl);
            command.Parameters.AddWithValue("@imageSmall", artist.ImageSmallUrl);
            command.Parameters.AddWithValue("@created", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            command.Parameters.AddWithValue("@updated", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            sqlDao.ExecuteNonQuery(command);
        }

        public void DeleteArtistById(int artistId)
        {
            SqlCommand command = sqlDao.GetSqlCommand("spDeleteArtist");
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = artistId;

            sqlDao.ExecuteNonQuery(command);
        }

        public Artist UpdateArtistById(Artist artist)
        {
            string query =
                "UPDATE [artist] SET name = @name, BIO = @biography, image_big_url = @image, image_small_url = @thumbnail, updated_at = @updated WHERE id = @id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add("@id", SqlDbType.Int).Value = artist.Id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = artist.Name;
            command.Parameters.Add("@biography", SqlDbType.VarChar).Value = artist.Biography;
            command.Parameters.Add("@image", SqlDbType.VarChar).Value = artist.ImageBigUrl;
            command.Parameters.Add("@thumbnail", SqlDbType.VarChar).Value = artist.ImageSmallUrl;
            command.Parameters.Add("@updated", SqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            sqlDao.ExecuteNonQuery(command);

            return artist;
        }

        public Artist SetUpdateTimeForArtistById(Artist artist)
        {
            string query =
                "UPDATE [artist] SET updated_at = @updated WHERE id = @id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add("@id", SqlDbType.Int).Value = artist.Id;
            command.Parameters.Add("@updated", SqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            sqlDao.ExecuteNonQuery(command);

            return artist;
        }

        public void AddGenreToArtist(int artist, int genre)
        {
            string query =
                "INSERT INTO [genre_artist] (genre_id, artist_id, created_at) VALUES(@genre, @artist, @created)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add("@genre", SqlDbType.Int).Value = genre;
            command.Parameters.Add("@artist", SqlDbType.Int).Value = artist;
            command.Parameters.Add("@created", SqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            sqlDao.ExecuteNonQuery(command);
        }

        public void RemoveGenreFromArtist(int artist, int genre)
        {
            string query = "DELETE FROM [genre_artist] WHERE genre_id = @genre AND artist_id = @artist";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@genre", SqlDbType.Int).Value = genre;
            command.Parameters.Add("@artist", SqlDbType.Int).Value = artist;
            sqlDao.ExecuteNonQuery(command);
        }
    }
}