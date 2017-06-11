using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Musify_Web.Models;

namespace Musify_Web.Tests
{
    [TestClass]
    public class ArtistsTest
    {
        [TestMethod]
        public void CtorArtist()
        {
            Artist Artist = new Artist(1, "MyUnitTest","img", "thumb", "Dit is mijn biografie", Convert.ToDateTime("2017/04/01"), Convert.ToDateTime("2017/04/05"));

            Assert.AreEqual(1, Artist.Id);
            Assert.AreEqual("MyUnitTest", Artist.Name);
            Assert.AreEqual("Dit is mijn biografie", Artist.Biography);
            Assert.AreEqual("img", Artist.ImageBigUrl);
            Assert.AreEqual("thumb", Artist.ImageSmallUrl);
        }

        [TestMethod]
        public void GetArtistById()
        {
            Artist Artist = GetArtistByIdMth(4);

            Assert.AreEqual(4, Artist.Id);
            Assert.AreEqual("henk4", Artist.Name);
            Assert.AreEqual("img4", Artist.ImageSmallUrl);
        }

        public Artist GetArtistByIdMth(int id)
        {
            List<Artist> Artists = new List<Artist>();

            for (int i = 0; i < 10; i++)
            {
                Artists.Add(new Artist(i, "henk" + i, "img" + i));
            }

            foreach (var Artist in Artists)
            {
                if (Artist.Id == id)
                {
                    return Artist;
                }
            }

            return null;
        }
    }
}
