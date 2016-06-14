using System.Web.Mvc;
using NUnit.Framework;
using GoHobby.Controllers;

namespace GoHobby.Tests.Controllers {

    [TestFixture]
    public class ProfileControllerTest {

        [Test]
        public void Details() {
            // Arrange
            ProfileController controller = new ProfileController();

            // Act
            ViewResult result = controller.Details() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

    }
}
