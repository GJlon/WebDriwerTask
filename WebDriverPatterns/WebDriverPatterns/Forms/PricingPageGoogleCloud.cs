using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebDriverPatterns.Forms
{
    class PricingPageGoogleCloud
    {
        WebDriverWait wait;
        IWebDriver driver;
        By clickButtonSeePricingLocator = By.XPath("//a[text()='Calculators']");

        public PricingPageGoogleCloud(IWebDriver _driver)
        {
            this.driver = _driver;
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(2));
        }

        public PageCalculator ClickToSeeCalculators()
        {
            wait.Until(t => driver.FindElements(clickButtonSeePricingLocator));
            driver.FindElement(clickButtonSeePricingLocator).Click();

            return new PageCalculator(driver);
        }



    }
}
