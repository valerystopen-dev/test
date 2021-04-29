using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium;

namespace Task_3
{
    class Chrome_1
    {
        IWebDriver driver;
        string Url = "http://rozklad.kpi.ua/Schedules/ScheduleGroupSelection.aspx";
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(timeout: TimeSpan.FromSeconds(3));
            driver.Url = Url;
        }
        [Test]
        public void TestSearchRozklad()
        {
            IWebElement searchField = driver.FindElement(By.XPath("//*[@id=\"ctl00_MainContent_ctl00_txtboxGroup\"]"));
            searchField.Click();
            searchField.SendKeys(text:"КП-91");
            IWebElement searchButton = driver.FindElement(By.XPath("//*[@id=\"ctl00_MainContent_ctl00_btnShowSchedule\"]"));
            searchButton.Click();
            IWebElement searchLesson = driver.FindElement(By.XPath("//*[@id=\"ctl00_MainContent_FirstScheduleTable\"]/tbody/tr[2]/td[4]/span/a"));
            if (searchLesson.Text.Contains("Компоненти програмної інженерії 2. Якість та тестування програмного забезпечення"))
            {
                Console.Beep();
            }
            System.Threading.Thread.Sleep(timeout: TimeSpan.FromSeconds(5));
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
    class Chrome_2
    {
        IWebDriver driver;
        string Url = "http://google.com/";
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(timeout: TimeSpan.FromSeconds(3));
            driver.Url = Url;
        }
        [Test]
        public void TestSearchEpicenter()
        {
            IWebElement searchField = driver.FindElement(By.Name("q"));
            searchField.SendKeys("Епіцентр");
            searchField.SendKeys(Keys.Enter);

            IWebElement searchTab = driver.FindElement(By.XPath("//*[@id=\"tads\"]/div/div/div/div[1]/a/div[1]"));
            searchTab.Click();

            IWebElement searchInfo = driver.FindElement(By.XPath("/html/body/div[2]/header/div/div[8]/div/div[2]"));
            searchInfo.Click();
            IWebElement searchConracts = driver.FindElement(By.XPath("/html/body/div[2]/header/div/div[8]/div/div[2]/div[2]/a[2]"));
            searchConracts.Click();

            IWebElement searchTime = driver.FindElement(By.XPath("/html/body/main/div[2]/div/section/h3"));
            if (searchTime.Text.Contains("з 07:30 до 22:30"))
            {
                Console.Beep();
            }
            System.Threading.Thread.Sleep(timeout: TimeSpan.FromSeconds(5));
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
    class Chrome_3
    {
        IWebDriver driver;
        string Url = "http://google.com/";
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(timeout: TimeSpan.FromSeconds(3));
            driver.Url = Url;
        }
        [Test]
        public void TestSearchMakeUp()
        {
            IWebElement searchField = driver.FindElement(By.Name("q"));
            searchField.SendKeys("make up");
            searchField.SendKeys(Keys.Enter);

            IWebElement searchTab = driver.FindElement(By.XPath("/html/body/div[7]/div/div[9]/div[1]/div/div[2]/div[2]/div/div/div[1]/div/div/div/div/div/div[1]/a/h3"));
            searchTab.Click();

            IWebElement SearchMakeUp = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/nav/div[4]/ul/li[3]"));
            SearchMakeUp.Click();
            IWebElement SearchFilter = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/div[1]/aside/form/div[2]/div[5]/div/div/ul/li/span"));
            SearchFilter.Click();
            if(SearchFilter.Text.Contains("Не тестировалось на животных"))
            {
                Console.Beep();
            }
            System.Threading.Thread.Sleep(timeout: TimeSpan.FromSeconds(5));
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}