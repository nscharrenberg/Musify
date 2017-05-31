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
        Exceptions eh = new Exceptions();

        // GET: Artists
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

        // GET: Artists/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Genres/Create
        public ActionResult Create()
        {

            return View(new Artist());
        }

        // POST: Genres/Create
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
        public ActionResult Delete(int id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

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
    }
}
