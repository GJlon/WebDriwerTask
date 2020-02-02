using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebDriverPatterns.Forms
{
    class PageGoogleCloud
    {
        IWebDriver driver;
        WebDriverWait wait;
        By clickElProductsLocator = By.XPath("//a[contains(text(), 'Products')]");
        By clickElSeeAllProductsLocator = By.XPath("//a[@track-metadata-eventdetail='seeAllProducts']");

        public PageGoogleCloud(IWebDriver _driver)
        {
            this.driver = _driver;
            //driver.Navigate().GoToUrl(" https://cloud.google.com/ ");
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(2));
        }

        public PageGoogleCloud ClickEllProducts()
        {
            wait.Until(t => driver.FindElement(clickElProductsLocator));
            driver.FindElement(clickElProductsLocator).Click();

            return this;
        }

        public ProductPageGoogleCloud ClickElSeeAllProducts()
        {
            wait.Until(t => driver.FindElement(clickElSeeAllProductsLocator));
            driver.FindElement(clickElSeeAllProductsLocator).Click();

            return new ProductPageGoogleCloud(driver);
        }
    }
}
