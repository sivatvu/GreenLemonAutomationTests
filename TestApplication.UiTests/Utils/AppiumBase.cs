using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.UiTests.Utils
{
    public class AppiumBase
    {
        public string userName = "siva454";
        public string accessKey = "b1az5z4YK9SKiMexsxBU";

        DesiredCapabilities caps = new DesiredCapabilities();

       public AndroidDriver<AndroidElement> driver;

        [SetUp]

        public void setup2()
        {
            caps.SetCapability("browserstack.user", userName);
            caps.SetCapability("browserstack.key", accessKey);
            caps.SetCapability("device", "Google Pixel");
            caps.SetCapability("os_version", "7.1");
            caps.SetCapability("app", "bs://1a845731528d99f5e9fd4fde0441646e05308b54");
            driver = new AndroidDriver<AndroidElement>(new Uri("http://hub-cloud.browserstack.com/wd/hub"), caps);

        }

    }
}
