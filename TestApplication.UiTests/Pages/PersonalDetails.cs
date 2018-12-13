using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace TestApplication.UiTests.Pages
{
    public class PersonalDetails
    {

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Mr.')]")]
        protected IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='First Name']")]
        protected IWebElement FN { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Surname']")]
        protected IWebElement SN { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Date of Birth']")]
        protected IWebElement DOB { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Telephone number']")]
        protected IWebElement TN { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Self Employed')]")]
        protected IWebElement Emp { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Homeowner')]")]
        protected IWebElement ResD { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='submit' and @value='Enter']")]
        protected IWebElement EnterPersonalDetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox'][1]")]
        protected IWebElement Agreed { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='House/Flat number (optional)']")]
        protected IWebElement House { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Postcode']")]
        protected IWebElement PostCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Month']")]
        protected IWebElement MonthMovedIn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Year']")]
        protected IWebElement YearMovedin { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Gross anual income (£)']")]
        protected IWebElement Gross { get; set; }




        private IWebDriver _driver;


        public PersonalDetails(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        
        public void SelectTitle()
        {
            Title.Click();

        }

        public void FirstN()
        {
            FN.SendKeys(ConfigurationManager.AppSettings["Firstname"]);
            


        }
        public void SecondN()
        {
            
            SN.SendKeys(ConfigurationManager.AppSettings["Surname"]);
            
            


        }
        public void DateOB()
        {
           
            DOB.SendKeys(ConfigurationManager.AppSettings["DOB"]);
            


        }
        public void Tele()
        {
          
            TN.SendKeys(ConfigurationManager.AppSettings["Telephonenumber"]);


        }

        public void AgreeTermsandConditions()
        {

            Agreed.Click();
        }

        public void GrossAnnual()
        {

            Gross.SendKeys(ConfigurationManager.AppSettings["GAI"]);
        }



        public void SelectEmploymentandResidential()
        {
            Emp.Click();
            ResD.Click();

        }

        public void EnterPD()
        {

            EnterPersonalDetails.Click();
        }

        public void Address()
        {
            House.SendKeys(ConfigurationManager.AppSettings["House"]);
            PostCode.SendKeys(ConfigurationManager.AppSettings["PCode"]);
           
        }

        public void MovedInDates()
        {
            
            MonthMovedIn.SendKeys(ConfigurationManager.AppSettings["Month"]);
            YearMovedin.SendKeys(ConfigurationManager.AppSettings["Year"]);
        }
    }
}
