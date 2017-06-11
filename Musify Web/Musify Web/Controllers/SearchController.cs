using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Musify_Web.Models;
using Musify_Web.Models.DAO;
using Musify_Web.Models.Repository;

namespace Musify_Web.Controllers
{
    public class SearchController : Controller
    {
        static SqlDataAccessObject sqlDao = new SqlDataAccessObject();
        SqlConnection conn = new SqlConnection(sqlDao.Connectionstring);

        private static SearchDao sDao = new SearchDao();
        private SearchRepository _sr = new SearchRepository(sDao);

        private static ArtistDao aDao = new ArtistDao();
        ArtistRepository _ar = new ArtistRepository(aDao);

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