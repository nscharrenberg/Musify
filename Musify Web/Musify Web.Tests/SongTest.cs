using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Musify_Web.Models;

namespace Musify_Web.Tests
{
    [TestClass]
    public class SongTest
    {
        [TestMethod]
        public void CtorSong()
        {
            Song Song = new Song(1, "SongName", 3, 120, "ytUrl", "scUrl", "sUrl", new Album(5, "snAlbum", "img"), Convert.ToDateTime("2017/03/26"), Convert.ToDateTime("2017/04/01") );

            Assert.AreEqual(1, Song.Id);
            Assert.AreEqual("SongName", Song.Name);
            Assert.AreEqual(3, Song.Number);
            Assert.AreEqual(120, Song.Duration);
            Assert.AreEqual("ytUrl", Song.YoutubeUrl);
            Assert.AreEqual("scUrl", Song.SoundcloudUrl);
            Assert.AreEqual("sUrl", Song.ServerUrl);
            Assert.AreEqual(5, Song.Album.Id);
            Assert.AreEqual("snAlbum", Song.Album.Name);
            Assert.AreEqual("img", Song.Album.ImageSmallUrl);
        }

        [TestMethod]
        public void GetSongById()
        {
            Song Song = GetSongByIdMth(4);

            Assert.AreEqual(4, Song.Id);
            Assert.AreEqual("SongName4", Song.Name);
            Assert.AreEqual(44, Song.Duration);
            Assert.AreEqual("snAlbum", Song.Album.Name);

            Song OtherSong = GetSongByIdMth(13);

            Assert.AreEqual(13, OtherSong.Id);
            Assert.AreEqual("AnothersongName13", OtherSong.Name);
            Assert.AreEqual(83, OtherSong.Duration);
            Assert.AreEqual("bnAlbum", OtherSong.Album.Name);

            Assert.AreNotEqual(Song.Name, OtherSong.Name);
            Assert.AreNotEqual(Song.Album.Name, OtherSong.Album.Name);
        }

        public Song GetSongByIdMth(int id)
        {
            List<Song> Songs = new List<Song>();

            for (int i = 0; i < 10; i++)
            {
                Songs.Add(new Song(i, "SongName" + i, i, 40 + i, "ytUrl" + i, "scUrl" + i, "sUrl" + i, new Album(4, "snAlbum", "img"), Convert.ToDateTime("2017/03/26"), Convert.ToDateTime("2017/04/01")));
            }

            for (int i = 10; i < 15; i++)
            {
                Songs.Add(new Song(i, "AnothersongName" + i, i, 70 + i, "ytUrl" + i, "scUrl" + i, "sUrl" + i, new Album(6, "bnAlbum", "img"), Convert.ToDateTime("2017/03/26"), Convert.ToDateTime("2017/04/01")));
            }

            foreach (var Song in Songs)
            {
                if (Song.Id == id)
                {
                    return Song;
                }
            }

            return null;
        }
    }
}
