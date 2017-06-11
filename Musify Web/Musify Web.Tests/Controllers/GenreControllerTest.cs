using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Musify_Web.Controllers;

namespace Musify_Web.Tests.Controllers
{
    [TestClass]
    public class GenreControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            GenresController controller = new GenresController();

            // Act
            ViewResult result = controller.ClientGenres() as ViewResult;

            // Assert
            Assert.AreEqual("Genre Overview", result.ViewName);
        }
    }
}
