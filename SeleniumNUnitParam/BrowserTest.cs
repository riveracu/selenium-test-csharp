using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitParam
{
    public class BrowserTest : Hooks
    {


        [Test]
        public void GoogleTest()
        {
            Driver.Navigate().GoToUrl("https://www.adidas.com");
            Driver.FindElement(By.Name("q")).SendKeys("classic");
            System.Threading.Thread.Sleep(5000);
            Driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            Assert.That(Driver.PageSource.Contains("classic"), Is.EqualTo(true), "Error Find Classic Test");



        }

        [Test]
        public void ExecuteAutomationTest()
        {
            Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Driver.FindElement(By.Name("UserName")).SendKeys("admin");
            Driver.FindElement(By.Name("Password")).SendKeys("admin");
            Driver.FindElement(By.Name("Login")).Submit();
            System.Threading.Thread.Sleep(2000);
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                                            "The text selenium doest not exist");

        }


    }
}
