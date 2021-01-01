using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTask2
{
    [TestFixture]
    public class Class1
    {
        IWebDriver driver;
        [SetUp]
        public void beforeTest()
        {
            driver = new ChromeDriver("C:\\webDriver");
            driver.Url = "https://www.seleniumeasy.com/";
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void afterTest()
        {
            driver.Quit();
        }

        [Test]
        public void test1()
        {
            IWebElement searchField = driver.FindElement(By.Id("edit-search-block-form--2"));
            searchField.SendKeys("Maven");
            searchField.SendKeys(Keys.Enter);

            Assert.AreEqual("https://www.seleniumeasy.com/search/node/Maven", driver.Url);
        }

    }
}
