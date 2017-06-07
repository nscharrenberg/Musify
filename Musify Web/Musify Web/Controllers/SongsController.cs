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
                Album album = _albr.GetAlbumQueryById(id);
                eh.WriteToFile(song.Name + " / " + song.Duration + @" \ " + album.Name + " " + song.Number);
                Song newSong = new Song(song.Name, song.Number, song.Duration, song.YoutubeUrl, song.SoundcloudUrl, song.ServerUrl, album, song.Created, song.Updated);

                

                _sr.Addsong(newSong);

                return RedirectToAction("Songs", "Album", new { id = id});
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
                return View();
            }
        }

        // GET: Songs/Edit/5
        [Route("admin/Albums/{albumId}/Songs/Edit/{songId}")]
        public ActionResult Edit(int albumId, int songId)
        {
            try
            {
                Song song = _sr.GetSongByIdAndAlbum(albumId, songId);
                eh.WriteToFile(song.Id + " " + song.Name + song.Album.Id + " " + albumId + " " + song.Artists.Count);

                return View(song);
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
                return View();
            }
        }

        // POST: Songs/Edit/5
        [Route("admin/Albums/{albumId}/Songs/Edit/{songId}")]
        [HttpPost]
        public ActionResult Edit(Song song)
        {
            try
            {
                _sr.UpdatesongById(song);

                return RedirectToAction("Songs", "Album", new { id = song.Album.Id });
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
                return View();
            }
        }

        // GET: Songs/Delete/5
        [Route("admin/Albums/{albumId}/Songs/Delete/{songId}")]
        public ActionResult Delete(int albumId, int songId)
        {
            try
            {

                Song song = _sr.GetSongByIdAndAlbum(albumId, songId);

                if (song == null)
                {
                    return HttpNotFound();
                }

                return View(song);
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
                return View();
            }
        }

        // POST: Songs/Delete/5
        [Route("admin/Albums/{albumId}/Songs/Delete/{songId}")]
        [HttpPost]
        public ActionResult Delete(int albumId, int songId, FormCollection collection)
        {
            try
            {
                _sr.DeleteSongById(songId);

                return RedirectToAction("Songs", "Album", new { id = albumId });
            }
            catch
            {
                return View();
            }
        }
    }
}
