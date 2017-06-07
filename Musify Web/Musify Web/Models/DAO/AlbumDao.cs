using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Musify_Web.Models.Interface;
using Musify_Web.Models.Repository;

namespace Musify_Web.Models.DAO
{
    public class AlbumDao : IAlbumContext
    {
        static SqlDataAccessObject sqlDao = new SqlDataAccessObject();
        SqlConnection conn = new SqlConnection(sqlDao.Connectionstring);

        static ArtistDao artistDao = new ArtistDao();
        ArtistRepository _artr = new ArtistRepository(artistDao);

        static SongDao songDao = new SongDao();
        SongRepository _sr = new SongRepository(songDao);


        public List<Album> GetAllAlbums()
        {
            List<Album> albums = new List<Album>();
            string query = "SELECT * FROM album";
            DataTable dt = sqlDao.Execute(query);

            foreach (DataRow dr in dt.Rows)
            {
                int id = (int)dr["id"];
                string name = dr["name"].ToString();
                DateTime release = Convert.ToDateTime(dr["release_date"].ToString());
                string imageBig = dr["image_big_url"].ToString();
                string imageSmall = dr["image_small_url"].ToString();
                int artistId = (int) dr["artist_id"];
                DateTime created = Convert.ToDateTime(dr["created_at"].ToString());
                DateTime updated = Convert.ToDateTime(dr["updated_at"].ToString());

                Artist artist = _artr.GetArtistById(artistId);
                List<Song> songs = GetSongAlbums(id);
                
                albums.Add(new Album(id, name, release, imageBig, imageSmall, artist, created, updated, songs));
            }

            return albums;
        }

        public List<Album> GetAlbumsByArtist(int selectedArtist)
        {
            List<Album> albums = new List<Album>();
            string query = "SELECT * FROM album as alb INNER JOIN artist AS art ON art.id = alb.artist_id AND alb.artist_id = @artistId";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add("@artistId", SqlDbType.Int).Value = selectedArtist;
            DataTable dt = sqlDao.Execute(command);

            foreach (DataRow dr in dt.Rows)
            {
                int id = (int)dr["id"];
                string name = dr["name"].ToString();
                DateTime release = Convert.ToDateTime(dr["release_date"].ToString());
                string imageBig = dr["image_big_url"].ToString();
                string imageSmall = dr["image_small_url"].ToString();
                int artistId = (int)dr["artist_id"];
                DateTime created = Convert.ToDateTime(dr["created_at"].ToString());
                DateTime updated = Convert.ToDateTime(dr["updated_at"].ToString());

                Artist artist = _artr.GetArtistById(artistId);
                List<Song> songs = GetSongAlbums(id);

                albums.Add(new Album(id, name, release, imageBig, imageSmall, artist, created, updated, songs));
            }

            return albums;
        }



        public Album GetAlbumById(int albumId)
        {
            List<Album> albums = GetAllAlbums();

            foreach (var album in albums)
            {
                if (album.Id == albumId)
                {
                    return album;
                }
            }

            return null;
        }

        public Album GetAlbumQueryById(int albumId)
        {
            string query = "SELECT * FROM album WHERE id = @Id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = albumId;
            DataTable dt = sqlDao.Execute(command);
            Album album;
            foreach (DataRow dr in dt.Rows)
            {
                int id = (int)dr["id"];
                string name = dr["name"].ToString();
                DateTime release = Convert.ToDateTime(dr["release_date"].ToString());
                string imageBig = dr["image_big_url"].ToString();
                string imageSmall = dr["image_small_url"].ToString();
                int artistId = (int)dr["artist_id"];
                DateTime created = Convert.ToDateTime(dr["created_at"].ToString());
                DateTime updated = Convert.ToDateTime(dr["updated_at"].ToString());

                Artist artist = _artr.GetArtistById(artistId);

                album = new Album(id, name, release, imageBig, imageSmall, artist, created, updated);

                return album;
            }

            return null;
        }

        public void AddAlbum(Album album)
        {
            string query =
                "INSERT INTO [album] (name, release_date, image_big_url, image_small_url, created_at, updated_at, artist_id) VALUES(@name, @release, @imageBig, @imageSmall, @created, @updated, @artistId)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = album.Name;
            command.Parameters.Add("@release", SqlDbType.Date).Value =  album.ReleaseDate;
            command.Parameters.Add("@imageBig", SqlDbType.VarChar).Value = album.ImageBigUrl;
            command.Parameters.Add("@imageSmall", SqlDbType.VarChar).Value = album.ImageSmallUrl;
            command.Parameters.Add("@created", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            command.Parameters.Add("@updated", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            command.Parameters.Add("@artistId", SqlDbType.Int).Value = album.Artist.Id;
            sqlDao.ExecuteNonQuery(command);
        }

        public void DeleteAlbumById(int albumId)
        {
            string query = "DELETE FROM [album] WHERE id = @Id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = albumId;

            sqlDao.ExecuteNonQuery(command);
        }

        public Album UpdateAlbumById(Album album)
        {
            Exceptions eh = new Exceptions();
            eh.WriteToFile("Name " + album.Name + " Release " + album.ReleaseDate + " Id " + album.Id);

            string query =
                "UPDATE [album] SET name = @name, release_date = @release, image_big_url = @image, image_small_url = @thumbnail, updated_at = @updated, artist_id = @artistId WHERE id = @id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add("@id", SqlDbType.Int).Value = album.Id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = album.Name;
            command.Parameters.Add("@release", SqlDbType.Date).Value = album.ReleaseDate;
            command.Parameters.Add("@image", SqlDbType.VarChar).Value = album.ImageBigUrl;
            command.Parameters.Add("@thumbnail", SqlDbType.VarChar).Value = album.ImageSmallUrl;
            command.Parameters.Add("@updated", SqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            command.Parameters.Add("@artistId", SqlDbType.Int).Value = album.Artist.Id;
            sqlDao.ExecuteNonQuery(command);

            return album;
        }

        public List<Song> GetSongAlbums(int id)
        {
            List<Song> songs = new List<Song>();
            string AlbumArtists = "SELECT * FROM song AS s INNER JOIN album AS alb ON alb.id = s.album_id AND alb.id = @albumId";
            SqlCommand command = new SqlCommand(AlbumArtists, conn);
            command.Parameters.Add("@albumId", SqlDbType.Int).Value = id;
            DataTable dt = sqlDao.Execute(command);

            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    int songId = (int) dr["id"];
                    string name = dr["name"].ToString();
                    int number = (int) dr["number"];
                    int duration = (int) dr["duration"];
                    string youtube = dr["youtube_url"].ToString();
                    string soundcloud = dr["soundcloud_url"].ToString();
                    string server = dr["server_url"].ToString();
                    int albumId = (int) dr["album_id"];
                    int artistId = (int) dr["album_artist_id"];
                    DateTime created = Convert.ToDateTime(dr["created_at"].ToString());
                    DateTime updated = Convert.ToDateTime(dr["updated_at"].ToString());
                    List<Artist> artists = new List<Artist>();
                    Album album = GetAlbumQueryById(albumId);
                    Artist artist = _artr.GetArtistById(artistId);
                    artists.Add(artist);
                    
                    string queryFeatured = "SELECT * FROM featured AS f INNER JOIN artist AS a ON a.id = f.artist_id INNER JOIN Song AS s ON s.id = f.song_id AND f.song_id = @Id";
                    SqlCommand commandF = new SqlCommand(queryFeatured, conn);
                    commandF.Parameters.Add("@Id", SqlDbType.Int).Value = songId;

                    DataTable dtF = sqlDao.Execute(commandF);

                    if (dtF.Rows.Count != 0)
                    {
                        foreach (DataRow drF in dtF.Rows)
                        {
                            int featuredId = (int) drF["artist_id"];
                            Artist featured = _artr.GetArtistById(featuredId);
                            artists.Add(featured);
                        }
                    }
                    
                    songs.Add(new Song(songId, name, number, duration, youtube, soundcloud, server, album, created, updated,
                        artists));
                }
            }
            return songs;
        }
    }
}