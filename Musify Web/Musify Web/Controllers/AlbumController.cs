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
            return View(_albr.GetAlbumById(id));
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
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
                return View();
            }
        }

        // GET: Album/Edit/5
        [Route("admin/artists/{artistId}/Albums/{albumId}/Edit")]
        public ActionResult Edit(int artistId, int albumId)
        {
            try
            {
                Album album = _albr.GetAlbumById(albumId);

                if (album == null)
                {
                    return HttpNotFound();
                }

                return View(album);
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
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

                Album album = _albr.GetAlbumById(albumId);

                if (album == null)
                {
                    return HttpNotFound();
                }

                return View(album);
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
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
            catch
            {
                return View();
            }
        }

        [Route("admin/Artists/Songs/{id}")]
        public ActionResult Songs(int id)
        {
            try
            {
                Album album = _albr.GetAlbumById(id);
                if (album == null)
                {
                    return HttpNotFound();
                }

                return View(album);
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
                return View();
            }
        }
    }
}
