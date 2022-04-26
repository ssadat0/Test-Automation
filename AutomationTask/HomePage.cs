using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace AutomationTask
{
    public class HomePage
    {
        IWebDriver driver;
        
        public HomePage()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        
        public void NavigateToHomePage()
        {
            driver.Navigate().GoToUrl("https://dotnetfiddle.net/");

        }

        public void Quit()
        {
            driver.Quit();

        }

        public void ClickOnRunButton()
        {
            Thread.Sleep(1000);

            driver.FindElement(By.Id("run-button")).Click();
        }

        public string GetStringFromOutput()
        {
            IWebElement outputText = driver.FindElement(By.Id("output"));
            String output = outputText.Text;
            return output;
        }

        public void ClickOnSaveButton()
        {
            Thread.Sleep(1000);

            driver.FindElement(By.Id("save-button")).Click();
        }

        public void VerifyLoginWindowAppeared()
        {
            IWebElement outputText = driver.FindElement(By.Id("Email"));
            String output = outputText.GetAttribute("name");
            //Verifying Login Windown Appeared
            Assert.AreEqual(output, "Email");
        }
    }
}
