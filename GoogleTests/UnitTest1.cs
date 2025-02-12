using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System;

namespace GoogleTests
{
    public class GoogleTests : Usings
    {
        [Test]
        public void VerifyTitle()
        {
            string expectedTitle = "Google";
            Assert.AreEqual(expectedTitle, driver.Title, "The title is not Google");
        }

        [Test]
        public void CheckGoogleLogo()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement googleLogo = wait.Until(drv => drv.FindElement(By.CssSelector("img[alt='Google']")));

            Assert.IsTrue(googleLogo.Displayed, "Google logo is not visible.");
        }

        [Test]
        public void CheckImagesButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement imagesButton = wait.Until(drv => drv.FindElement(By.LinkText("Изображения")));

            Assert.IsTrue(imagesButton.Displayed, "Images button is not visible.");
        }

        [Test]
        public void CheckGmailShortcut()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement gmailLink = wait.Until(drv => drv.FindElement(By.LinkText("Gmail")));

            Assert.IsTrue(gmailLink.Displayed, "Gmail shortcut is not visible.");
        }

        [Test]
        public void CheckSignInButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement signInButton = wait.Until(drv => drv.FindElement(By.LinkText("Вход")));

            Assert.IsTrue(signInButton.Displayed, "Sign In button is not visible.");
        }
    }
}