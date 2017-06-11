using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Musify_Web.Models;
using Musify_Web.Models.DAO;
using Musify_Web.Models.Repository;
using Musify_Web.Models.ViewModel;
using Musify_Web.Repository;
using Musify_Web.Repository.DAO;

namespace Musify_Web.Controllers
{
    public class ArtistsController : Controller
    {
        static SqlDataAccessObject _SqlDAl = new SqlDataAccessObject();
        SqlConnection conn = new SqlConnection(_SqlDAl.Connectionstring);
        static ArtistDao artistDao = new ArtistDao();
        private ArtistRepository _ar = new ArtistRepository(artistDao);
        
        static GenreDao genreDao = new GenreDao();
        private GenreRepository _gr = new GenreRepository(genreDao);

        private static SearchDao sDao = new SearchDao();
        private SearchRepository _sr = new SearchRepository(sDao);

        Exceptions eh = new Exceptions();

        // GET: Artists
        [Route("admin/Artists/Index")]
        public ActionResult Index()
        {
            try
            {
                Artist[] artistList = _ar.GetAllArtists();

                return View(artistList);
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

        [Route("Genres/Details/{id}")]
        public ActionResult ClientArtists(int id)
        {
            try
            {
                Genre genre = _gr.GetGenreById(id);
                if (genre == null)
                {
                    return HttpNotFound();
                }

                return View(genre);
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

        [Route("admin/Artists/Details/{id}")]
        public ActionResult Genres(int id)
        {
            try
            {
                Artist artist = _ar.GetArtistById(id);
                if (artist == null)
                {
                    return HttpNotFound();
                }

                return View(artist);
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

        // GET: Genres/Create
        [Route("admin/Artists/Create")]
        public ActionResult Create()
        {
            try
            {
                return View(new Artist());
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

        // POST: Genres/Create
        [Route("admin/Artists/Create")]
        [HttpPost]
        public ActionResult Create(Artist artist)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", new Artist());
            }

            try
            {
                _ar.AddArtist(artist);

                return RedirectToAction("Index");
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

        // GET: Artists/Edit/5
        [Route("admin/Artists/Edit/{id}")]
        public ActionResult Edit(int id)
        {
            try
            {
                Artist artist = _ar.GetArtistById(id);

                if (artist == null)
                {
                    return HttpNotFound();
                }
                return View(artist);
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

        // POST: Artists/Edit/5
        [Route("admin/Artists/Edit/{id}")]
        [HttpPost]
        public ActionResult Edit(Artist artist)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", artist);
            }

            try
            {
                _ar.UpdateArtistById(artist);

                return RedirectToAction("Index");
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

        // GET: Artists/Delete/5
        [Route("admin/Artists/Delete/{id}")]
        public ActionResult Delete(int id)
        {
            try
            {

                Artist artist = _ar.GetArtistById(id);

                if (artist == null)
                {
                    return HttpNotFound();
                }

                return View(artist);
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

        // POST: Artists/Delete/5
        [Route("admin/Artists/Delete/{id}")]
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                _ar.DeleteArtistById(id);

                return RedirectToAction("Index");
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

        // GET: Artists/Details/{id}/Genre
        [Route("admin/Artists/Details/{id}/Genre")]
        public ActionResult AddGenres(int id)
        {
            try
            {
                Artist artist = _ar.GetArtistById(id);
                var genres = _gr.GetAllGenres().ToList();
                var pickable = genres.Where(x => artist.Genres.All(x2 => x2.Id != x.Id));

                ArtistViewModel avm = new ArtistViewModel()
                {
                    Artist = artist,
                    Genres = pickable.Select(x => new SelectListItem
                    {
                        Value = x.Id.ToString(),
                        Text = x.Name
                    })
                };

                return View(avm);
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

        // POST: Artists/Details/{id}/Genre
        [Route("admin/Artists/Details/{id}/Genre")]
        [HttpPost]
        public ActionResult AddGenres(ArtistViewModel avm)
        {
            try
            {
                int artist = avm.Artist.Id;
                int genre = avm.SelecterGenre;

                _ar.AddGenreToArtist(artist, genre);
                _ar.SetUpdateTimeForArtistById(avm.Artist);

                return RedirectToAction("Genres", "Artists", artist);
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

        // GET: Artists/Details/{artist}/Genre/Delete/{genre}
        [Route("admin/Artists/Details/{artistId}/Genre/{genreId}")]
        public ActionResult DeleteGenreFromArtist(int artistId, int genreId)
        {
            try
            {

                ArtistGenreViewModel agvm = new ArtistGenreViewModel()
                {
                    Artist = _ar.GetArtistById(artistId),
                    Genre = _gr.GetGenreById(genreId)
                };

                if (agvm.Artist == null || agvm.Genre == null)
                {
                    return HttpNotFound();
                }

                return View(agvm);
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

        // POST: Artists/Details/{artist}/Genre/Delete/{genre}
        [Route("admin/Artists/Details/{artistId}/Genre/{genreId}")]
        [HttpPost]
        public ActionResult DeleteGenreFromArtist(int artistId, int genreId, FormCollection collection)
        {
            try
            {
                _ar.RemoveGenreFromArtist(artistId, genreId);
                _ar.SetUpdateTimeForArtistById(_ar.GetArtistById(artistId));
                return RedirectToAction("Genres", "Artists", new { id = artistId});
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

        [Route("admin/Artists/Albums/{id}")]
        public ActionResult Albums(int id)
        {
            try
            {
                Artist artist = _ar.GetArtistById(id);
                if (artist == null)
                {
                    return HttpNotFound();
                }

                return View(artist);
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

        [Route("Artists/Details/{id}")]
        public ActionResult ClientArtistDetails(int id)
        {
            try
            {
                Artist artist = _ar.GetArtistById(id);
                if (artist == null)
                {
                    return HttpNotFound();
                }

                return View(artist);
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

            List<Artist> artists = _sr.getArtistsSearchResults(content);
            foreach (var item in artists)
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
        public JsonResult GetArtistById(int id)
        {
            Artist artist = _ar.GetArtistById(id);

            return Json(artist);

        }


    }
}
