using Coursework.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Coursework.StepDefinitions
{
    [Binding]
    public class HomepageProductInfoSteps
    {
        [Then(@"I understand what the website is all about")]
        public void ThenIUnderstandWhatTheWebsiteIsAllAbout()
        {
            Assert.IsTrue(Hooks1.driver.FindElement(By.XPath("//h3[text()='Who We Are']")).Displayed);
        }

        [When(@"I click learn more about Giftrete")]
        public void WhenIClickLearnMoreAboutGiftrete()
        {
            Hooks1.driver.FindElement(By.XPath("//a[text()='Learn More About Us']")).Click();
        }


        [Then(@"I can easily choose what to browse")]
        public void ThenICanEasilyChooseWhatToBrowse()
        {
            Assert.IsTrue(Hooks1.driver.FindElement(By.XPath("//a[text()='My Wishlist ']")).Displayed);
        }


        [When(@"I click wishlist banner")]
        public void WhenIClickWishlistBanner()
        {
            Hooks1.driver.FindElement(By.XPath("/html/body/div/header[1]/div/div/div/div[1]/nav/ul/li[4]/a/span")).Click();
        }


        [When(@"I click community banner")]
        public void WhenIClickCommunityBanner()
        {
            Hooks1.driver.FindElement(By.XPath("/html/body/div/header[1]/div/div/div/div[1]/nav/ul/li[3]/a/span")).Click(); 
        }


        [When(@"I click Giftretecycle Banner")]
        public void WhenIClickGiftretecycleBanner()
        {
            Hooks1.driver.FindElement(By.XPath("/html/body/div/header[1]/div/div/div/div[1]/nav/ul/li[2]/a/span")).Click();
        }


        [Given(@"I navigate to giftrete website")]
        public void GivenINavigateToGiftreteWebsite()
        {
            Hooks1.driver.Navigate().GoToUrl("http://www.qa1.giftrt.com");
            Hooks1.driver.Manage().Window.Maximize();
        }
        
        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            Hooks1.driver.FindElement(By.XPath("//span[text()= 'Login']")).Click();
        }
        
        [When(@"I enter my email address")]
        public void WhenIEnterMyEmailAddress()
        {
            Hooks1.driver.FindElement(By.XPath("//input[@id = 'user_email']")).SendKeys("kenst0kes@yahoo.co.uk");
        }
        
        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            Hooks1.driver.FindElement(By.XPath("//input[@id='user_password']")).SendKeys("MyPassword");
        }
        
        [When(@"I click signin")]
        public void WhenIClickSignin()
        {
            Hooks1.driver.FindElement(By.XPath("//input[@id='btn_signin']")).Click();
        }
        
        [When(@"I click the hometab")]
        public void WhenIClickTheHometab()
        {
            //Thread.Sleep(5000);
            //WebDriverWait wait = new WebDriverWait(Hooks1.driver, TimeSpan.FromSeconds(10));
            Hooks1.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Hooks1.driver.FindElement(By.XPath("//a[@class='brdcum']")).Click();
        }
        
        [When(@"I click free items")]
        public void WhenIClickFreeItems()
        {
            Hooks1.driver.FindElement(By.XPath("//a[text()='Learn More About Giftrete-cycle']")).Click();
            Hooks1.driver.FindElement(By.XPath("/html/body/div/header[1]/div/div/div/div[1]/nav/ul/li[1]/a/span")).Click();
        }
        
        [When(@"I click wishlist")]
        public void WhenIClickWishlist()
        {
            Hooks1.driver.FindElement(By.XPath("//a[text()= 'Learn More About Wishlist']")).Click();
            Hooks1.driver.FindElement(By.XPath("/html/body/div/header[1]/div/div/div/div[1]/nav/ul/li[1]/a/span")).Click();
        }
        
        [When(@"I click community")]
        public void WhenIClickCommunity()
        {
            Hooks1.driver.FindElement(By.XPath("//a[text()='Learn More About Community']")).Click();
        }
        
        [Then(@"I have information about the products")]
        public void ThenIHaveInformationAboutTheProducts()
        {
                   
            Assert.IsTrue(Hooks1.driver.FindElement(By.XPath("//p[text()='Joining Community']")).Displayed);
           

        }
    }
}
