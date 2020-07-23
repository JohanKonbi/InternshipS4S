using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Testing
{
    class UITests
    {
        /*IWebDriver driver;

        [TestInitialize]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Url = "";        //TODO add link
        }

        [TestMethod]
        public void ClockIn()       //tries to clockin
        {
            SendKeys("username", "amy");
            SendKeys("password", "1234");

            Click("submit");

            Wait("clockin", 3);

            Click("clockin");
        }

        [TestMethod]
        public void ClockOut()      //tries to clockout
        {
            SendKeys("username", "amy");
            SendKeys("password", "1234");

            Click("submit");

            Wait("clockout", 3);

            Click("clockout");
        }

        [TestMethod]
        public void CantClockOut()  //tries to clockout before clockin
        {
            SendKeys("username", "johan");
            SendKeys("password", "abcd");

            Click("submit");

            Wait("clockout", 3);

            Click("clockout");
            //TODO check if nothing happened
        }

        [TestMethod]
        public void WrongUser()     //cant login
        {
            SendKeys("username", "johan");
            SendKeys("password", "abcd");

            Click("submit");

            string expected = "Username and/or password are incorrect";
            string actual = driver.FindElement(By.CssSelector("word-wrap")).Text;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AskHours()      //??
        {

        }

        [TestCleanup]
        public void EndTest()
        {
            driver.Close();
        }

        public void SendKeys(string id, string keys)
        {
            IWebElement element = driver.FindElement(By.Id(id));
            element.SendKeys(keys);
        }
        public void Click(string id)
        {
            IWebElement element = driver.FindElement(By.Id(id));
            element.Click();
        }
        public void Wait(string id, int max)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(max));
            var con = wait.Until(driver => driver.FindElement(By.Id(id)) != null);
        }*/
    }
}
