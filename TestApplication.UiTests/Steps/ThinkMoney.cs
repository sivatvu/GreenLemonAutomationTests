using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System.Configuration;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using TestApplication.UiTests.Utils;
using TestApplication.UiTests.Pages;
using System.Linq;

namespace CBT_Example_2
{

    [Binding]
    public class ThinkMoney : Base
    {
        #region given

        [Given(@"I navigate to the test site")]
        public void GivenINavigateToTheTestSite()
        {
            SetUp();
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["ThinkMoney"]);
        }
        #endregion

        #region when 

        [When(@"I enter Username, Password & Re-Type Password")]
        public void WhenIEnterUsernamePasswordRe_TypePassword()
        {
            LoginPage lp = new LoginPage(driver);
            lp.Login();
        }
                       

        [When(@"I enter the First Name")]
        public void WhenIEnterTheFirstName()
        {
            PersonalDetails pd = new PersonalDetails(driver);
            pd.FirstN();
        }

        [When(@"I enter the Surname")]
        public void WhenIEnterTheSurname()
        {
            PersonalDetails pd = new PersonalDetails(driver);
            pd.SecondN();
        }

        [When(@"I enter my Date of Birth")]
        public void WhenIEnterMyDateOfBirth()
        {
            PersonalDetails pd = new PersonalDetails(driver);
            pd.DateOB();
        }

        [When(@"I enter my Telephone Number")]
        public void WhenIEnterMyTelephoneNumber()
        {
            PersonalDetails pd = new PersonalDetails(driver);
            pd.Tele();
        }

        [When(@"I have agreed with the Terms and Conditions")]
        public void WhenIHaveAgreedWithTheTermsAndConditions()
        {
            PersonalDetails pd = new PersonalDetails(driver);
            pd.AgreeTermsandConditions();
        }






        [When(@"I select Employment and Residential Status")]
        public void WhenISelectEmploymentAndResidentialStatus()
        {
            PersonalDetails pd = new PersonalDetails(driver);
            pd.SelectEmploymentandResidential();
        }



        [When(@"I click on Enter")]
        public void WhenIClickOnEnter()
        {
            LoginPage lp = new LoginPage(driver);
            lp.EnterLogin();
            
        }

        [When(@"I select the Title")]
        public void WhenISelectTheTitle()
        {
            
            PersonalDetails pd = new PersonalDetails(driver);
            pd.SelectTitle();
        }



       

        [When(@"I click on YES to set up the credit report")]
        public void WhenIClickOnYESToSetUpTheCreditReport()
        {
            SetupCreditReport scr = new SetupCreditReport(driver);
            scr.SelectYestoSetup();
        }

        [When(@"I login as the test admin")]
        public void WhenILoginAsTheTestAdmin()
        {
            SetupCreditReport scr = new SetupCreditReport(driver);
            scr.LoginC();

        }

        [When(@"I Click on Enter on Personal Details Page")]
        public void WhenIClickOnEnterOnPersonalDetailsPage()
        {
            PersonalDetails pd = new PersonalDetails(driver);
            pd.EnterPD();
        }

        [When(@"I have entered my Gross annual Income")]
        public void WhenIHaveEnteredMyGrossAnnualIncome()
        {
            PersonalDetails pd = new PersonalDetails(driver);
            pd.GrossAnnual();
        }

        [When(@"I enter my address")]
        public void WhenIEnterMyAddress()
        {
            PersonalDetails pd = new PersonalDetails(driver);
            pd.Address();
        }

        [When(@"the month and year I moved in")]
        public void WhenTheMonthAndYearIMovedIn()
        {
            PersonalDetails pd = new PersonalDetails(driver);
            pd.MovedInDates();
        }

        [When(@"I select the correct answers for the authentication questions")]
        public void WhenISelectTheCorrectAnswersForTheAuthenticationQuestions()
        {
            CreditReportAuthentication cra = new CreditReportAuthentication(driver);
            cra.AnswertheQuestions();
        }

        [When(@"I submit the answers by pressing the Enter button")]
        public void WhenISubmitTheAnswersByPressingTheEnterButton()
        {
            CreditReportAuthentication cra = new CreditReportAuthentication(driver);
            cra.SubmittheAnswers();
        }

#endregion

        #region then


        [Then(@"I can verify the credit score")]
        public void ThenICanVerifyTheCreditScore()
        {
            SetupCreditReport scr = new SetupCreditReport(driver);
            scr.CreditScorePage();
        }


        [Then(@"I can verify the Credit Report authentication")]
        public void ThenICanVerifyTheCreditReportAuthentication()
        {
            CreditReportAuthentication cra = new CreditReportAuthentication(driver);
            cra.CRAPage();
        }

        [Then(@"I am on Credit report homepage")]
        public void ThenIAmOnCreditReportHomepage()
        {
            AccountHomePage ahp = new AccountHomePage(driver);
            ahp.CredithomePage();
        }

        [Then(@"I can see my Credit Score")]
        public void ThenICanSeeMyCreditScore()
        {
            AccountHomePage ahp = new AccountHomePage(driver);
            ahp.CreditS();
        }


#endregion
















    }
}
