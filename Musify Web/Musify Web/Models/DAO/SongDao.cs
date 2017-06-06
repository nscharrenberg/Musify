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
    public class SongDao : ISongContext
    {
        static SqlDataAccessObject sqlDao = new SqlDataAccessObject();
        SqlConnection conn = new SqlConnection(sqlDao.Connectionstring);

        static AlbumDao albumDao = new AlbumDao();
        AlbumRepository _albr = new AlbumRepository(albumDao);

        static ArtistDao artistDao = new ArtistDao();
        ArtistRepository _artr = new ArtistRepository(artistDao);

        public List<Song> GetAllSongs()
        {
            List<Song> songs = new List<Song>();
            string query = "SELECT * FROM Song";
            DataTable dt = sqlDao.Execute(query);

            foreach (DataRow dr in dt.Rows)
            {
                int id = (int)dr["id"];
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

                Album album = _albr.GetAlbumById(albumId);
                List<Artist> artists = new List<Artist>();
                Artist artist = _artr.GetArtistById(artistId);
                artists.Add(artist);

                string queryFeatured = "SELECT * FROM featured WHERE song_id = @Id";
                SqlCommand command = new SqlCommand(queryFeatured, conn);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                DataTable dtF = sqlDao.Execute(command);

                foreach (DataRow drF in dtF.Rows)
                {
                    int featuredId = (int) drF["artist_id"];
                    Artist featured = _artr.GetArtistById(featuredId);
                    artists.Add(featured);
                }

                songs.Add(new Song(id, name, number,duration,youtube,soundcloud,server, album,created,updated, artists));
            }

            return songs;
        }

        public Song GetSongById(int songId)
        {
            List<Song> songs = GetAllSongs();

            foreach (var song in songs)
            {
                if (song.Id == songId)
                {
                    return song;
                }
            }

            return null;
        }

        public Song GetSongByIdAndAlbum(int albumId, int songId)
        {
            List<Song> songs = _albr.GetSongAlbums(albumId);

            foreach (var song in songs)
            {
                if (song.Id == songId)
                {
                    return song;
                }
            }

            return null;
        }

        public void Addsong(Song song)
        {
            string query =
                "INSERT INTO [song] (name, number, duration, youtube_url, soundcloud_url, server_url, album_id, created_at, updated_at) VALUES(@name, @number, @duration, @youtube, @soundcloud, @server, @album, @created, @updated)";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = song.Name;
            command.Parameters.Add("@number", SqlDbType.Int).Value = song.Number;
            command.Parameters.Add("@duration", SqlDbType.Int).Value = song.Duration;
            command.Parameters.Add("@youtube", SqlDbType.VarChar).Value = song.YoutubeUrl;
            command.Parameters.Add("@soundcloud", SqlDbType.VarChar).Value = song.SoundcloudUrl;
            command.Parameters.Add("@server", SqlDbType.VarChar).Value = song.ServerUrl;
            command.Parameters.Add("@album", SqlDbType.Int).Value = song.Album.Id;
            command.Parameters.Add("@created", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            command.Parameters.Add("@updated", SqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            sqlDao.ExecuteNonQuery(command);
        }

        public void DeleteSongById(int songId)
        {
            string query = "DELETE FROM [Song] WHERE id = @Id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = songId;

            sqlDao.ExecuteNonQuery(command);
        }

        public Song UpdatesongById(Song song)
        {
            string query =
                "UPDATE [song] SET name = @name, number = @number, duration = @duration, youtube_url = @youtube, soundcloud_url = @soundcloud, server_url = @server, album_id = @album, updated_at = @updated WHERE id = @id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add("@id", SqlDbType.Int).Value = song.Id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = song.Name;
            command.Parameters.Add("@number", SqlDbType.Int).Value = song.Number;
            command.Parameters.Add("@duration", SqlDbType.Int).Value = song.Duration;
            command.Parameters.Add("@youtube", SqlDbType.VarChar).Value = song.YoutubeUrl;
            command.Parameters.Add("@soundcloud", SqlDbType.VarChar).Value = song.SoundcloudUrl;
            command.Parameters.Add("@server", SqlDbType.VarChar).Value = song.ServerUrl;
            command.Parameters.Add("@album", SqlDbType.Int).Value = song.Album.Id;
            command.Parameters.Add("@updated", SqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            sqlDao.ExecuteNonQuery(command);

            return song;
        }
    }
}