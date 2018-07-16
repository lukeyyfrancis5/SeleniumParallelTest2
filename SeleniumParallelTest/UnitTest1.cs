﻿using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumParallelTest
{
    [TestFixture]
    class FireFoxTesting : Hooks
    {
        public FireFoxTesting() : base(BrowserType.Firefox)
        {

        }

        [Test]
        [Parallelizable]
        public void FireFoxGoogleTest()
        {
            
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            System.Threading.Thread.Sleep(10000);
            Driver.FindElement(By.Name("btnG")).Click();
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                "The text selenium does not exist");
        }
    }

    [TestFixture]
    [Parallelizable]
    class ChromeTesting : Hooks 
    {
        public ChromeTesting(BrowserType browser) : base(browser)
        {

        }

        [Test]
        public void ChromeGoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            Driver.FindElement(By.Name("btnG")).Click();
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                "The text ExecuteAutomation does not exist");
        }
    }
}
