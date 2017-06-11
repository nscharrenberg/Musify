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
using Musify_Web.Repository.Interface;

namespace Musify_Web.Controllers
{
    public class GenresController : Controller
    {
        static SqlDataAccessObject _SqlDAl = new SqlDataAccessObject();
        SqlConnection conn = new SqlConnection(_SqlDAl.Connectionstring);
        static GenreDao genreDao = new GenreDao();
        GenreRepository _gr = new GenreRepository(genreDao);

        private static SearchDao sDao = new SearchDao();
        private SearchRepository _sr = new SearchRepository(sDao);


        Exceptions eh = new Exceptions();
           
        // GET: Genres
        [Route("admin/Genres")]
        public ActionResult Index()
        {
            try
            {
                Genre[] genreList = _gr.GetAllGenres();

                return View(genreList);
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

        // GET: ClientGenres
        [Route("Genres")]
        public ActionResult ClientGenres()
        {
            try
            {
                Genre[] genreList = _gr.GetAllGenres();

                return View(genreList);
            }
            catch (SqlException ex)
            {
                eh.WriteToFile(ex.ToString());
                return RedirectToAction("SqlException", "Error", new { msg = ex.Message });
            }
            catch (NullReferenceException ex)
            {
                eh.WriteToFile(ex.ToString());
                return RedirectToAction("SqlException", "Error", new { msg = ex.Message });
            }
            catch (Exception ex)
            {
                eh.WriteToFile(ex.ToString());
                return View();
            }
        }

        [Route("admin/Genres/Details/{id}")]
        public ActionResult Artists(int id)
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

        // GET: Genres/Create
        [Route("admin/Genres/Create")]
        public ActionResult Create()
        {
            
            return View(new Genre());
        }

        // POST: Genres/Create
        [Route("admin/Genres/Create")]
        [HttpPost]
        public ActionResult Create(Genre genre)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", new Genre());
            }

            try
            {
                _gr.AddGenre(genre);

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

        // GET: Genres/Edit/5
        [Route("admin/Genres/Edit/{id}")]
        public ActionResult Edit(int id)
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

        // POST: Genres/Edit/5
        [Route("admin/Genres/Edit/{id}")]
        [HttpPost]
        public ActionResult Edit(Genre genre)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", genre);
            }

            try
            {
                _gr.UpdateGenreById(genre);

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

        // GET: Genres/Delete/5
        [Route("admin/Genres/Delete/{id}")]
        public ActionResult Delete(int id)
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

        // POST: Genres/Delete/5
        [Route("admin/Genres/Delete/{id}")]
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                _gr.DeleteGenreById(id);
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
                eh.WriteToFile(ex.ToString() + id);
                return View();
            }
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult AutoComplete(string content)
        {
            var result = new List<KeyValuePair<string, string>>();

            IList<SelectListItem> List = new List<SelectListItem>();

            List<Genre> genres = _sr.getGenresSearchResults(content);
            foreach (var item in genres)
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
        public JsonResult GetGenreById(int id)
        {

            return Json(id);

        }
    }
}
