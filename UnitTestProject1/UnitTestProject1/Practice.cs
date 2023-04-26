using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class Practice
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://adactinhotelapp.com/index.php";

            driver.FindElement(By.Id("username")).SendKeys("admin0812");
            driver.FindElement(By.Id("password")).SendKeys("power123");
            driver.FindElement(By.Id("login")).SendKeys(Keys.Return);

            //Correct Method
            //SelectElement itemSelection;
            //itemSelection = new SelectElement(driver.FindElement(By.Id("location")));
            //itemSelection.SelectByValue("Sydney");

            //Direct Method
            new SelectElement(driver.FindElement(By.Id("location"))).SelectByValue("Sydney");
            new SelectElement(driver.FindElement(By.Id("hotels"))).SelectByValue("Hotel Creek");
            new SelectElement(driver.FindElement(By.Id("room_type"))).SelectByValue("Double");
            driver.FindElement(By.Id("Submit")).Click();
            //driver.Quit();
        }
    }
}
