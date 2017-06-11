using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Musify_Web.Models;
using Musify_Web.Repository;
using Musify_Web.Repository.DAO;

namespace Musify_Web.Tests
{
    [TestClass]
    public class GenresTest
    {
        [TestMethod]
        public void CtorGenre()
        {
            Genre genre =  new Genre(1, "MyUnitTest", "Dit is Mijn unit test", "img", false, Convert.ToDateTime("2017/04/01"), Convert.ToDateTime("2017/04/05"));

            Assert.AreEqual(1, genre.Id);
            Assert.AreEqual("MyUnitTest", genre.Name);
            Assert.AreEqual("Dit is Mijn unit test", genre.Description);
            Assert.AreEqual("img", genre.ImageUrl);
            Assert.AreEqual(false, genre.Public);
        }

        [TestMethod]
        public void GetGenreById()
        {
            Genre genre = GetGenreByIdMth(1);

            Assert.AreEqual(1, genre.Id);
            Assert.AreEqual("soul1", genre.Name);
            Assert.AreEqual("img1", genre.ImageUrl);
        }

        public Genre GetGenreByIdMth(int id)
        {
            List<Genre> genres = new List<Genre>();

            for (int i = 0; i < 10; i++)
            {
                genres.Add(new Genre(i, "soul" + i, "img" + i));
            }

            foreach (var genre in genres)
            {
                if (genre.Id == id)
                {
                    return genre;
                }
            }

            return null;
        }
    }
}
