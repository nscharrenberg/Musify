using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Musify_Web.Models;
using Musify_Web.Models.DAO;
using Musify_Web.Models.Repository;
using Musify_Web.Models.ViewModel;

namespace Musify_Web.Controllers
{
    public class SongsController : Controller
    {
        static SqlDataAccessObject sqlDao = new SqlDataAccessObject();
        SqlConnection conn = new SqlConnection(sqlDao.Connectionstring);

        static SongDao songDao = new SongDao();
        SongRepository _sr = new SongRepository(songDao);

        static AlbumDao albumDao = new AlbumDao();
        AlbumRepository _albr = new AlbumRepository(albumDao);

        Exceptions eh = new Exceptions();

        // GET: Songs
        [Route("admin/Songs")]
        public ActionResult AllSongs()
        {
            try
            {
                return View(_sr.GetAllSongs());
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
                return View();
            }
            
        }

        // GET: Songs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Songs/Create
        [Route("admin/Albums/{id}/Songs/Create")]
        public ActionResult Create(int id)
        {
            return View(new Song());
        }

        // POST: Songs/Create
        [Route("admin/Albums/{id}/Songs/Create")]
        [HttpPost]
        public ActionResult Create(int id, Song song)
        {
            try
            {
                Album album = _albr.GetAlbumById(id);

                eh.WriteToFile(song.Name + " / " + song.Duration + @" \ " + album.Name + " " + song.Number);
                Song newSong = new Song(song.Name, song.Number, song.Duration, song.YoutubeUrl, song.SoundcloudUrl, song.ServerUrl, album, song.Created, song.Updated);

                

                _sr.Addsong(newSong);


                return RedirectToAction("Songs", "Album", new {id = id});
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
                return View();
            }
        }

        // GET: Songs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Songs/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Songs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Songs/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
