using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestAutomationLab1
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public class Login : Execution
    {

        #region Login
        /// <summary>
        /// This Test Case will Login using Valid Credentials
        /// </summary>
        [TestMethod]
        public void ValidLogin()
        {
            driver.FindElement(By.Id("username")).SendKeys("admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.Id("login")).Click();
        }

        /// <summary>
        /// This Test Case will Check Login Functionality using In valid Credentials
        /// </summary>
        [TestMethod]
        public void InValidLogin()
        {
            driver.FindElement(By.Id("username")).SendKeys("admin123");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.Id("login")).Click();

            string msg = driver.FindElement(By.XPath("//*[@id='login_form']/table/tbody/tr[5]/td[2]/div/b")).Text;
            Console.WriteLine(msg);
            Assert.AreEqual("Invalid Login details or Your Password might have expired. Click here to reset your password", msg);

        }
        #endregion

        #region Search
        #endregion

        [TestMethod]
        public void EmptyLogin()
        {
            //driver.FindElement(By.Id("username")).SendKeys("");
            //driver.FindElement(By.Name("password")).SendKeys("");
            driver.FindElement(By.Id("login")).Click();

            //username_span

            //Enter Username

            Assert.AreNotEqual("Enter Username", driver.FindElement(By.Id("username_span")).Text);
        }
    }
}
