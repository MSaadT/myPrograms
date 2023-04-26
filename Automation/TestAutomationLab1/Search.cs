using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestAutomationLab1
{
    [TestClass]
    public class Search : Execution
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://adactinhotelapp.com/";
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("username")).SendKeys("admin");
            driver.FindElement(By.Id("username")).SendKeys("admin");

            driver.FindElement(By.Name("password")).SendKeys("admin123");

            driver.FindElement(By.Id("login")).Click();

            driver.FindElement(By.LinkText("Click Here")).Click();
            driver.FindElement(By.PartialLinkText("Click")).Click();
            //driver.FindElement(By.("Here")).Click();

            driver.Quit();
            //username
            //name = password
            //login
        }
        [TestMethod]
        public void TestMethod2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://adactinhotelapp.com/";
            //Maximize

            driver.FindElement(By.Id("username")).SendKeys("admin");

            driver.FindElement(By.Name("password")).SendKeys("admin123");

            driver.FindElement(By.Id("login")).Click();

            //username
            //name = password
            //login
        }
        [TestMethod]
        public void TestMethod3()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://adactinhotelapp.com/";
            //Maximize

            driver.FindElement(By.Id("username")).SendKeys("admin");

            driver.FindElement(By.Name("password")).SendKeys("admin123");

            driver.FindElement(By.Id("login")).Click();

            //username
            //name = password
            //login
        }
        [TestMethod]
        public void TestMethod4()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://adactinhotelapp.com/";
            //Maximize

            driver.FindElement(By.Id("username")).SendKeys("admin");

            driver.FindElement(By.Name("password")).SendKeys("admin123");

            driver.FindElement(By.Id("login")).Click();

            //username
            //name = password
            //login
        }
        [TestMethod]
        public void TestMethod5()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://adactinhotelapp.com/";
            //Maximize

            driver.FindElement(By.Id("username")).SendKeys("admin");

            driver.FindElement(By.Name("password")).SendKeys("admin123");

            driver.FindElement(By.Id("login")).Click();

            //username
            //name = password
            //login
        }
        [TestMethod]
        public void TestMethod6()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://adactinhotelapp.com/";
            //Maximize

            driver.FindElement(By.Id("username")).SendKeys("admin");

            driver.FindElement(By.Name("password")).SendKeys("admin123");

            driver.FindElement(By.Id("login")).Click();

            //username
            //name = password
            //login
        }
    }
}
