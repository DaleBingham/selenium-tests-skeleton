using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace tests
{
    public class GoogleTest
    {
        private ChromeOptions options = new ChromeOptions();
        private IWebDriver webDriver;

        public GoogleTest(){
            webDriver = new RemoteWebDriver(new Uri("http://127.0.0.1:4444/wd/hub"), 
            options.ToCapabilities());
            options.AddArgument("--ignore-certificate-errors");
            options.AddArgument("--allow-running-insecure-content");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--start-maximized");
        }

        [Fact]
        public void CheckGoogle()
        {
            //Navigate to URL in the test URL environment variable
            webDriver.Navigate().GoToUrl("https:www.google.com");
            
            //Find the Search text box UI Element
            IWebElement element = webDriver.FindElement(By.Name("q"));
            
            //Perform Ops
            element.SendKeys("executeautomation");
            
            //Close the browser
            webDriver.Close();
        }
    }
}
