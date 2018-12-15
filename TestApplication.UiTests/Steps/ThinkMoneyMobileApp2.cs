using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestApplication.UiTests.Utils;

namespace TestApplication.UiTests.Steps
{
   
    [Binding]
    public class ThinkMoneyMobileApp2: AppiumBase
    {
        

        [Given(@"I navigate to the test site in my Mobile")]
        public void GivenINavigateToTheTestSiteInMyMobile()
        {
            setup2();
            Assert.IsNotNull(driver.Context);
            driver.Quit();
        }

    }
}
