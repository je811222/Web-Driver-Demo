using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriverDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.google.com";

            var searchBox = driver.FindElement(By.Id("lst-ib"));
            searchBox.SendKeys("cavannas.com");
            searchBox.Submit();

            var cavannasLink = driver.FindElement(By.LinkText("Cavannas"));
            cavannasLink.Click();

        }
    }
}
