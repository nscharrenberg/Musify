using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Musify_Web.Models;
using Musify_Web.Repository;
using Musify_Web.Repository.DAO;
using Musify_Web.Repository.Interface;

namespace Musify_Web.Controllers
{
    public class GenresController : Controller
    {
        static SqlDataAccessObject _SqlDAl = new SqlDataAccessObject();
        SqlConnection conn = new SqlConnection(_SqlDAl.Connectionstring);
        static GenreDao genreDao = new GenreDao();
        GenreRepository _gr = new GenreRepository(genreDao);
        Exceptions eh = new Exceptions();
           
        // GET: Genres
        public ActionResult Index()
        {
            try
            {
                Genre[] genreList = _gr.GetAllGenres();


                return View(genreList);
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
                return View();
            }
        }

        // GET: Genres/Details/5
        public ActionResult Details(int id)
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

        // GET: Genres/Create
        public ActionResult Create()
        {
            
            return View(new Genre());
        }

        // POST: Genres/Create
        [HttpPost]
        public ActionResult Create(Genre genre)
        {
            try
            {
                _gr.AddGenre(genre);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
                return View();
            }
            
        }

        // GET: Genres/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

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

        // POST: Genres/Edit/5
        [HttpPost]
        public ActionResult Edit(Genre genre)
        {
            try
            {
                _gr.UpdateGenreById(genre);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message);
                return View();
            }
        }

        // GET: Genres/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

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

        // POST: Genres/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                _gr.DeleteGenreById(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.Message + id);
                return View();
            }
        }
    }
}
