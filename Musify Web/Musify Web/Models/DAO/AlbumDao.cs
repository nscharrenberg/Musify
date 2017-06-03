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

        public List<Album> GetAllAlbums()
        {
            List<Album> albums = new List<Album>();
            string query = "SELECT * FROM album";
            DataTable dt = sqlDao.Execute(query);

            foreach (DataRow dr in dt.Rows)
            {
                int id = (int) dr["id"];
                string name = dr["name"].ToString();
                DateTime release = Convert.ToDateTime(dr["release_date"].ToString());
                string imageBig = dr["image_big_url"].ToString();
                string imageSmall = dr["image_small_url"].ToString();
                int artistId = (int) dr["artist_id"];
                DateTime created = Convert.ToDateTime(dr["created_at"].ToString());
                DateTime updated = Convert.ToDateTime(dr["updated_at"].ToString());

                Artist artist = _artr.GetArtistById(artistId);
                
                albums.Add(new Album(id, name, release, imageBig, imageSmall, artist, created, updated));
            }

            return albums;
        }
    }
}