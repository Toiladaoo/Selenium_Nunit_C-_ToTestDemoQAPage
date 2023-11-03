using NUnit.Framework;
using System;
using System.Collections;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ExcelDataReader;

namespace TestDemoQA
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void OpenDemoQAPage()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            Assert.That(driver.Title, Is.EqualTo("DEMOQA"));
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }
    }
}