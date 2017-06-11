using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Musify_Web.Models.Interface;

namespace Musify_Web.Models.DAO
{
    public class SearchDao : ISearchContext
    {
        static SqlDataAccessObject sqlDao = new SqlDataAccessObject();
        SqlConnection conn = new SqlConnection(sqlDao.Connectionstring);

        public List<Genre> getGenresSearchResults(string content)
        {
            List<Genre> genres = new List<Genre>();

            string genreQuery = "SELECT * FROM Genre AS g WHERE g.name LIKE @Content";
            SqlCommand gcmd = new SqlCommand(genreQuery, conn);
            gcmd.Parameters.Add("@Content", SqlDbType.VarChar).Value = "%" + content + "%";
            DataTable gdt = sqlDao.Execute(gcmd);

            if (gdt.Rows.Count != 0)
            {
                foreach (DataRow dr in gdt.Rows)
                {
                    int genreId = (int)dr["id"];
                    string genreName = dr["name"].ToString();
                    string genreImg = dr["image_url"].ToString();

                    genres.Add(new Genre(genreId, genreName, genreImg));
                }
            }

            return genres;
        }

        public List<Artist> getArtistsSearchResults(string content)
        {
            List<Artist> artists = new List<Artist>();

            string artistQuery = "SELECT * FROM Artist AS art WHERE art.name LIKE @Content";
            SqlCommand artcmd = new SqlCommand(artistQuery, conn);
            artcmd.Parameters.Add("@Content", SqlDbType.VarChar).Value = "%" + content + "%";
            DataTable artdt = sqlDao.Execute(artcmd);

            if (artdt.Rows != null)
            {
                foreach (DataRow dr in artdt.Rows)
                {
                    int artistId = (int)dr["id"];
                    string artistName = dr["name"].ToString();
                    string artistImg = dr["image_small_url"].ToString();

                    artists.Add(new Artist(artistId, artistName, artistImg));
                }
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

        public List<Album> getAlbumsSearchResults(string content)
        {
            List<Album> albums = new List<Album>();

            string albumQuery = "SELECT * FROM Album AS alb WHERE alb.name LIKE @Content";
            SqlCommand albcmd = new SqlCommand(albumQuery, conn);
            albcmd.Parameters.Add("@Content", SqlDbType.VarChar).Value = "%" + content + "%";
            DataTable albdt = sqlDao.Execute(albcmd);

            if (albdt.Rows.Count != 0)
            {
                foreach (DataRow dr in albdt.Rows)
                {
                    int albumId = (int)dr["id"];
                    string albumName = dr["name"].ToString();
                    string albumImg = dr["image_small_url"].ToString();

                    albums.Add(new Album(albumId, albumName, albumImg));
                }
            }

            return albums;
        }

        public List<Song> getSongsSearchResults(string content)
        {
            List<Song> songs = new List<Song>();

            string songQuery = "SELECT * FROM Song AS s WHERE s.name LIKE @Content";
            SqlCommand scmd = new SqlCommand(songQuery, conn);
            scmd.Parameters.Add("@Content", SqlDbType.VarChar).Value = "%" + content + "%";
            DataTable sdt = sqlDao.Execute(scmd);

            if (sdt.Rows.Count != 0)
            {
                foreach (DataRow dr in sdt.Rows)
                {
                    int songId = (int)dr["id"];
                    string songName = dr["name"].ToString();
                    int duration = (int) dr["duration"];

                    songs.Add(new Song(songId, songName, duration));
                }
            }

            return songs;
        }
    }
}