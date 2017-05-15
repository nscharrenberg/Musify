using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Musify_Application.Interface;
using Musify_Application.Repository;

namespace Musify_Application.DAO
{
    class ArtistDao : IArtistContext
    {
        private readonly SqlDataAccessObject _sqlDao = new SqlDataAccessObject();
        readonly List<Artist> _artistList = new List<Artist>();

        public void AddArtist(string name, string biography, string bigImage, string smallImage)
        {
            string query = @"INSERT INTO [Artist] ([name], [BIO], [image_big_url], [image_small_url], [created_at], [updated_at]) values ('" + name + "', '" + biography + "', '" + bigImage + "', '" + smallImage + "' , '" + DateTime.Now.ToString("MM'/'dd'/'yyyy HH:mm:ss") + "', '" + DateTime.Now.ToString("MM'/'dd'/'yyyy HH:mm:ss") + "')";
            _sqlDao.ExecuteNonQuery(query);
        }

        public List<Artist> AllArtists()
        {
            string query = "SELECT * FROM [Artist]";
            DataTable dt = _sqlDao.Execute(query);
            
            foreach (DataRow dr in dt.Rows)
            {
                _artistList.Add(new Artist((int)dr["id"], dr["name"].ToString(), dr["BIO"].ToString(), dr["image_big_url"].ToString(), dr["image_small_url"].ToString()));
            }

            return _artistList;
        }

        public void RefreshList()
        {
            _artistList.Clear();
        }

        public Artist SearchArtistByName(string name)
        {
            foreach (var artist in _artistList)
            {
                if (artist.Name == name)
                {
                    return artist;
                }
            }

            return null;
        }

        public Artist SearchArtistById(int id)
        {
            foreach (var artist in _artistList)
            {
                if (artist.Id == id)
                {
                    return artist;
                }
            }

            return null;
        }

        public void UpdateArtist(int id, string name, string biography, string bigImage, string smallImage)
        {
            string query = "UPDATE [Artist] SET name = '" + name + "', BIO = '" + biography +
                           "', image_big_url = '" + bigImage + "', image_small_url = '" + smallImage +"' WHERE id = '" + id + "'";
            _sqlDao.ExecuteNonQuery(query);
        }

        public void AddGenreToArtist(int artistId, int genreId)
        {
            string query = "INSERT into [genre_artist] (genre_id, artist_id, created_at) VALUES ('" + genreId + "', '" +
                                 artistId + "', '" + DateTime.Now.ToString("MM'/'dd'/'yyyy HH:mm: ss") + "')";
            _sqlDao.ExecuteNonQuery(query);
        }

        public void DeleteArtistById(int id)
        {
            string query = "DELETE FROM [Artist] WHERE id = '" + id + "'";
            _sqlDao.ExecuteNonQuery(query);
        }

        public List<Genre> GetGenreOfArtist(int artistId)
        {
            string query =
                "SELECT * FROM [genre] as g INNER JOIN genre_artist as ga ON ga.genre_id = g.id INNER JOIN artist AS a ON a.id = ga.artist_id AND a.id = '" + artistId + "'";
            Artist selectedArtist = SearchArtistById(artistId);
            DataTable dt = _sqlDao.Execute(query);

            foreach (DataRow dr in dt.Rows)
            {
                selectedArtist.ArtistGenres.Add(new Genre((int)dr["id"], dr["name"].ToString(), dr["description"].ToString(), dr["image_url"].ToString()));
            }

            return selectedArtist.ArtistGenres;
        }

        public void CheckIfGenreExistsInCHeckListBox(CheckedListBox clb, int artistID)
        {
            for (int i = 0; i < clb.Items.Count; i++)
            {
                
            }
        }
    }
}
