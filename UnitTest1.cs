using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace TestProjectAutmation
{
    public class Tests

    {

        IWebDriver driver;
        int job1 = 0;
        int job2 = 0;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]

        public void TestCase1()

        {
            
            driver.Navigate().GoToUrl("https://careers.veeam.com/vacancies");
            driver.Manage().Window.Maximize();
            System.Console.WriteLine("Broswe open and maxmize ");
            Thread.Sleep(2000);
            System.Console.WriteLine("enter search condition");
            IWebElement state = driver.FindElement(By.XPath("//button[contains(text(),'All states')]"));
            JavaScriptClick(state);
            Thread.Sleep(2000);
            IWebElement stateB = driver.FindElement(By.XPath("//a[text()='Texas']"));
            JavaScriptClick(stateB);
            Thread.Sleep(2000);
            IWebElement city = driver.FindElement(By.XPath("//button[contains(text(),'All cities')]"));
            JavaScriptClick(city);
            Thread.Sleep(2000);
            IWebElement cityB = driver.FindElement(By.XPath("//a[text()='New York City']"));
            JavaScriptClick(cityB);
            Thread.Sleep(2000);
            System.Console.WriteLine("click new york");
            IList<IWebElement> selectElements = driver.FindElements(By.XPath("//a[contains(@class, 'card card-md-45 card-no-hover card--shadowed')]"));
            System.Console.WriteLine("Number of Jobs1"  + selectElements.Count);
            job1 = selectElements.Count;



        }
        [Test]

        public void TestCase2()

        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://careers.veeam.com/vacancies");
            driver.Manage().Window.Maximize();
            System.Console.WriteLine("Broswe open and maxmize ");
            Thread.Sleep(2000);
            System.Console.WriteLine("enter search condition");
            IWebElement state = driver.FindElement(By.XPath("//button[contains(text(),'USA')]"));
            IWebElement acceptPopup = driver.FindElement(By.XPath("//button[contains(text(),'USA')]"));
            JavaScriptClick(state);
            Thread.Sleep(2000);
            IWebElement stateB = driver.FindElement(By.XPath("//a[text()='Romania']"));
            JavaScriptClick(stateB);
            Thread.Sleep(2000);
            IWebElement city = driver.FindElement(By.XPath("//button[contains(text(),'All cities')]"));
            JavaScriptClick(city);
            Thread.Sleep(2000);
            IWebElement cityB = driver.FindElement(By.XPath("//a[text()='Bucharest']"));
            JavaScriptClick(cityB);
            Thread.Sleep(2000);
            System.Console.WriteLine("click Bucharest");
            IList<IWebElement> selectElements = driver.FindElements(By.XPath("//a[contains(@class, 'card card-md-45 card-no-hover card--shadowed')]"));
            System.Console.WriteLine("Number of Jobs2" + selectElements.Count);
            job2 = selectElements.Count;



        }

        public void JavaScriptClick(IWebElement element)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", element);
        }






        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}