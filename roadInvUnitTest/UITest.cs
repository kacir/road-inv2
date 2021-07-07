using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using Xunit;


namespace roadInvUnitTest
{

    class UITest
    {
        private string _websiteURL = "";
        private RemoteWebDriver _browserDriver;
        //public TestContext TestContext { get; set; }


        //public void Initialize()
        //{
        //    _websiteURL = (string)TestContext.Properties["webAppUrl"];
        //}


        public void CreateRoadway(string county, string route, string section, string direction, string district)
        {
            _browserDriver = new ChromeDriver();
            _browserDriver.Manage().Window.Maximize();
            _browserDriver.Navigate().GoToUrl(_websiteURL + "index/new_segment");
            _browserDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            _browserDriver.FindElementById("County").SendKeys(county);
            _browserDriver.FindElementById("Route").SendKeys(route);
            _browserDriver.FindElementById("Section").SendKeys(section);
            _browserDriver.FindElementById("Direction").SendKeys(direction);
            _browserDriver.FindElementById("District").SendKeys(district);

            
        }
    }
}
