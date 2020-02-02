using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebDriverPatterns.Forms
{
    class ProductPageGoogleCloud
    {
        WebDriverWait wait;
        IWebDriver driver;
        By clickButtonSeePricingLocator = By.XPath("//a[@track-metadata-anchor_text='See Pricing']");

        public ProductPageGoogleCloud(IWebDriver _driver)
        {
            this.driver = _driver;
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(2));
        }

        public PricingPageGoogleCloud ClickButtonSeePricing()
        {
            wait.Until(t => driver.FindElements(clickButtonSeePricingLocator));
            driver.FindElement(clickButtonSeePricingLocator).Click();

            return new PricingPageGoogleCloud(driver);
        }

    }
}
