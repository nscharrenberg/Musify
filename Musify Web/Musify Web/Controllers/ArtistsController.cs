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
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
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
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
                return View();
            }
        }

        // GET: Genres/Create
        [Route("admin/Artists/Create")]
        public ActionResult Create()
        {

            return View(new Artist());
        }

        // POST: Genres/Create
        [Route("admin/Artists/Create")]
        [HttpPost]
        public ActionResult Create(Artist artist)
        {
            try
            {
                _ar.AddArtist(artist);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
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
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
                return View();
            }
        }

        // POST: Artists/Edit/5
        [Route("admin/Artists/Edit/{id}")]
        [HttpPost]
        public ActionResult Edit(Artist artist)
        {
            try
            {
                _ar.UpdateArtistById(artist);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
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
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
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
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
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
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
                return View();
            }
        }

        // POST: Artists/Details/{id}/Genre
        [Route("admin/Artists/Details/{id}/Genre")]
        [HttpPost]
        public ActionResult AddGenres(ArtistViewModel avm)
        {
            int artist = avm.Artist.Id;
            int genre = avm.SelecterGenre;

            _ar.AddGenreToArtist(artist, genre);
            _ar.SetUpdateTimeForArtistById(avm.Artist);

            return RedirectToAction("Genres", "Artists", artist);

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
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
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
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
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
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
                return View();
            }
        }

    }
}
