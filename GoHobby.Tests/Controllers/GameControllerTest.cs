using System.Web.Mvc;
using NUnit.Framework;
using GoHobby.Controllers;

namespace GoHobby.Tests.Controllers {

    [TestFixture]
    public class GameControllerTest {

        [Test]
        public void Index() {
            // Arrange
            GameController controller = new GameController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void About() {
            // Arrange
            GameController controller = new GameController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }
    }
}
