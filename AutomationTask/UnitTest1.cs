using NUnit.Framework;

namespace AutomationTask
{
    public class Tests
    {
        HomePage homePage;
        string expectedOutput = "Hello World";

        [SetUp]
        public void Setup()
        {
            homePage = new HomePage();

            homePage.NavigateToHomePage();
        }

        [Test]
        public void Test1()
        {
            homePage.ClickOnRunButton();

            Assert.AreEqual(homePage.GetStringFromOutput(), expectedOutput);
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            homePage.ClickOnSaveButton();

            homePage.VerifyLoginWindowAppeared();
            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {
            homePage.Quit();
        }
    }
}
