using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Musify_Web.Models;

namespace Musify_Web.Tests
{
    [TestClass]
    public class AlbumTest
    {
        [TestMethod]
        public void CtorAlbum()
        {
            Album Album = new Album(1, "MyUnitTest", Convert.ToDateTime("2017/03/25"), "img", "thumb", Convert.ToDateTime("2017/04/01"), Convert.ToDateTime("2017/04/05"));

            Assert.AreEqual(1, Album.Id);
            Assert.AreEqual("MyUnitTest", Album.Name);
            Assert.AreEqual("2017/03/25", Album.ReleaseDate.ToString("yyyy/MM/dd"));
            Assert.AreEqual("img", Album.ImageBigUrl);
            Assert.AreEqual("thumb", Album.ImageSmallUrl);
        }

        [TestMethod]
        public void GetAlbumById()
        {
            Album Album = GetAlbumByIdMth(7);

            Assert.AreEqual(7, Album.Id);
            Assert.AreEqual("five7", Album.Name);
            Assert.AreEqual("albumCover7", Album.ImageSmallUrl);
        }

        public Album GetAlbumByIdMth(int id)
        {
            List<Album> Albums = new List<Album>();

            for (int i = 0; i < 10; i++)
            {
                Albums.Add(new Album(i, "five" + i, "albumCover" + i));
            }

            foreach (var Album in Albums)
            {
                if (Album.Id == id)
                {
                    return Album;
                }
            }

            return null;
        }
    }
}
