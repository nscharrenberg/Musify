using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Musify_Web.Models;
using Musify_Web.Models.DAO;
using Musify_Web.Models.Repository;
using Musify_Web.Models.ViewModel;

namespace Musify_Web.Controllers
{
    public class AlbumController : Controller
    {
        static SqlDataAccessObject sqlDao = new SqlDataAccessObject();
        SqlConnection conn = new SqlConnection(sqlDao.Connectionstring);

        static AlbumDao _albumDao = new AlbumDao();
        private AlbumRepository _albr = new AlbumRepository(_albumDao);

        static ArtistDao artistDao = new ArtistDao();
        ArtistRepository _artr = new ArtistRepository(artistDao);

        private static SearchDao sDao = new SearchDao();
        private SearchRepository _sr = new SearchRepository(sDao);

        Exceptions eh = new Exceptions();

        // GET: Album
        [Route("admin/Albums")]
        public ActionResult AllAlbums()
        {

            try
            {
                Album[] albumList = _albr.GetAllAlbums();
                return View(albumList);
            }
            catch (SqlException ex)
            {
                eh.WriteToFile(ex.ToString());
                return RedirectToAction("SqlException", "Error", new { msg = ex.Message});
            }
            catch (NullReferenceException ex)
            {
                eh.WriteToFile(ex.ToString());
                return RedirectToAction("DatabaseException", "Error");
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
                return View();
            }

        }

        // GET: Album/Details/5
        [Route("admin/Albums/Details")]
        public ActionResult Details(int id)
        {
            try
            {
                return View(_albr.GetAlbumById(id));
            }
            catch (SqlException ex)
            {
                eh.WriteToFile(ex.ToString());
                return RedirectToAction("SqlException", "Error", new { msg = ex.Message });
            }
            catch (NullReferenceException ex)
            {
                eh.WriteToFile(ex.ToString());
                return RedirectToAction("DatabaseException", "Error");
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
                return View();
            }
        }

        // GET: Album/Create
        [Route("admin/artists/{artistId}/Albums/Create")]
        public ActionResult Create(int artistId)
        {
            return View(new Album());
        }

        // POST: Album/Create
        [Route("admin/artists/{artistId}/Albums/Create")]
        [HttpPost]
        public ActionResult Create(int artistId, Album album)
        {

            try
            {
                Artist artist = _artr.GetArtistById(artistId);
                Album newAlbum = new Album(album.Name, album.ReleaseDate, album.ImageBigUrl, album.ImageSmallUrl, artist, album.CreatedAt, album.UpdatedAt);

                eh.WriteToFile(album.Name + ' ' + album.ReleaseDate.ToString("yyyy/MM/dd") + ' ' + artist.Name);

                _albr.AddAlbum(newAlbum);

                return RedirectToAction("Genres", "Artists", new {id = artistId});
            }
            catch (SqlException ex)
            {
                eh.WriteToFile(ex.ToString());
                return RedirectToAction("SqlException", "Error", new { msg = ex.Message });
            }
            catch (NullReferenceException ex)
            {
                eh.WriteToFile(ex.ToString());
                return RedirectToAction("DatabaseException", "Error");
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
                return View();
            }
        }

        // GET: Album/Edit/5
        [Route("admin/artists/{artistId}/Albums/{albumId}/Edit")]
        public ActionResult Edit(int albumId)
        {
            try
            {
                Album album = _albr.GetAlbumQueryById(albumId);

                if (album == null)
                {
                    return HttpNotFound();
                }

                return View(album);
            }
            catch (SqlException ex)
            {
                eh.WriteToFile(ex.ToString());
                return RedirectToAction("SqlException", "Error", new { msg = ex.Message });
            }
            catch (NullReferenceException ex)
            {
                eh.WriteToFile(ex.ToString());
                return RedirectToAction("DatabaseException", "Error");
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
                return View();
            }
        }

        // POST: Album/Edit/5
        [Route("admin/artists/{artistId}/Albums/{albumId}/Edit")]
        [HttpPost]
        public ActionResult Edit(Album album)
        {
            try
            {
                _albr.UpdateAlbumById(album);

                return RedirectToAction("Genres", "Artists", new { id = album.Artist.Id });
            }
            catch (SqlException ex)
            {
                eh.WriteToFile(ex.ToString());
                return RedirectToAction("SqlException", "Error", new { msg = ex.Message });
            }
            catch (NullReferenceException ex)
            {
                eh.WriteToFile(ex.ToString());
                return RedirectToAction("DatabaseException", "Error");
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
                return View();
            }
        }

        // GET: Album/Delete/5
        [Route("admin/artists/{artistId}/Albums/{albumId}/Delete")]
        public ActionResult Delete(int artistId, int albumId)
        {
            try
            {

                Album album = _albr.GetAlbumQueryById(albumId);

                if (album == null)
                {
                    return HttpNotFound();
                }

                return View(album);
            }
            catch (SqlException ex)
            {
                eh.WriteToFile(ex.ToString());
                return RedirectToAction("SqlException", "Error", new { msg = ex.Message });
            }
            catch (NullReferenceException ex)
            {
                eh.WriteToFile(ex.ToString());
                return RedirectToAction("DatabaseException", "Error");
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
                return View();
            }
        }

        // POST: Album/Delete/5
        [Route("admin/artists/{artistId}/Albums/{albumId}/Delete")]
        [HttpPost]
        public ActionResult Delete(int artistId, int albumId, FormCollection collection)
        {

            try
            {
                _albr.DeleteAlbumById(albumId);

                return RedirectToAction("Genres","Artists", new { id = artistId });
            }
            catch (SqlException ex)
            {
                eh.WriteToFile(ex.ToString());
                return RedirectToAction("SqlException", "Error", new { msg = ex.Message });
            }
            catch (NullReferenceException ex)
            {
                eh.WriteToFile(ex.ToString());
                return RedirectToAction("DatabaseException", "Error");
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
                return View();
            }
        }

        [Route("admin/Artists/Songs/{id}")]
        public ActionResult Songs(int id)
        {
            try
            {
                //Album album = _albr.GetAlbumById(id);
                List<Song> songs = _albr.GetSongAlbums(id);
                if (songs == null)
                {
                    return HttpNotFound();
                }

                return View(songs);
            }
            catch (SqlException ex)
            {
                eh.WriteToFile(ex.ToString());
                return RedirectToAction("SqlException", "Error", new { msg = ex.Message });
            }
            catch (NullReferenceException ex)
            {
                eh.WriteToFile(ex.ToString());
                return RedirectToAction("DatabaseException", "Error");
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
                return View();
            }
        }

        [Route("Artists/Album/{id}")]
        public ActionResult ClientAlbumOverview(int id)
        {
            try
            {
                SongAlbumOverView saov = new SongAlbumOverView()
                {
                    Songs = _albr.GetSongAlbums(id),
                    Album = _albr.GetAlbumQueryById(id)
                };

                return View(saov);
            }
            catch (SqlException ex)
            {
                eh.WriteToFile(ex.ToString());
                return RedirectToAction("SqlException", "Error", new { msg = ex.Message });
            }
            catch (NullReferenceException ex)
            {
                eh.WriteToFile(ex.ToString());
                return RedirectToAction("DatabaseException", "Error");
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
                return View();
            }
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult AutoComplete(string content)
        {
            var result = new List<KeyValuePair<string, string>>();

            IList<SelectListItem> List = new List<SelectListItem>();

            List<Album> albums = _sr.getAlbumsSearchResults(content);
            foreach (var item in albums)
            {
                List.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString() });
            }

            foreach (var item in List)
            {
                result.Add(new KeyValuePair<string, string>(item.Value, item.Text));
            }

            var results3 = result.Where(s => s.Value.ToLower().Contains(content.ToLower())).Select(w => w).ToList();

            return Json(results3, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult GetAlbumById(int id)
        {
            int album = id;

            return Json(album);

        }
    }
}
