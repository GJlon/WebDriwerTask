using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebDriverPatterns.Forms
{
    class PageCalculator
    {
        WebDriverWait wait;
        IWebDriver driver;
        IWebElement element;
        By frameLocator = By.XPath("//iframe[@id='myFrame']");
        By numberOfInstancesLocator = By.XPath("//*[@id='input_53']");
        By operatingSystemSoftwareLocator = By.XPath("//div//md-option/div[contains(text(), 'Free: Debian')]");
        By vmClassLocator = By.XPath("//div//md-option[@value='regular' and @id='select_option_68']");
        By machinetypeLocator = By.XPath("//div//md-option/div[contains(text(), 'n1-standard-8')]");
        By addGPUsLocator = By.XPath("//md-card//md-checkbox[@aria-label='Add GPUs']");
        By numberOfGPUsLocator = By.XPath("//div[6]/md-select-menu/md-content/md-option[2]");
        By locatorGPUtype = By.XPath("//div//md-option[@value='NVIDIA_TESLA_V100']");
        By listoflocalSSDLocator = By.XPath("//md-select[@placeholder='Local SSD']//span[1]");
        By localSSDLocator = By.XPath("//div//md-option[@ng-repeat='item in listingCtrl.supportedSsd' and @value='2']");
        By listOfdatacenterLocationLocator = By.XPath("//md-select[@placeholder='Datacenter location']");
        By datacenterLocationLocator = By.XPath("//div//md-option[@value='europe-west3' and @id='select_option_180']");
        By listOfcommittedUsageLocator = By.XPath("//div//md-select[@placeholder='Committed usage']");
        By committedUsageLocator = By.XPath("//md-option[@id='select_option_84']//div[text()='1 Year']");
        By clickButtonEmailEstimateLocator = By.XPath("//div/md-card//form//button[@aria-label='Add to Estimate']");
        By addEmailLocator = By.XPath("//button[@aria-label='Email Estimate']");
        By emailLocator = By.XPath("//input[@id='input_571'");
        By priceLocator = By.XPath("//*[@id='resultBlock']/md-card/md-card-content/div//h2/b");

        public PageCalculator(IWebDriver _driver)
        {
            this.driver = _driver;
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(10));

        }

        public By List_(string text)
        {
            By xpath = By.XPath($"//label[contains(text(), '{text}')]/following-sibling::md-select");

            return xpath;
        }


        public PageCalculator GoToCalculatorFrame()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(frameLocator));
            driver.SwitchTo().Frame("myFrame");

            return this;
        }

        public PageCalculator FillNumberOfInstances()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(numberOfInstancesLocator));
            element = wait.Until(t => driver.FindElement(numberOfInstancesLocator));
            element.FindElement(numberOfInstancesLocator).Click();
            element.SendKeys("4");

            return this;
        }

        public PageCalculator ChooseOperatingSystemSoftware()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(List_("Operating System / Software")));
            element = wait.Until(t => driver.FindElement(List_("Operating System / Software")));
            element.FindElement(List_("Operating System / Software")).Click();
            element.FindElement(operatingSystemSoftwareLocator).Click();

            return this;
        }

        public PageCalculator ChooseVMClass()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(List_("Machine Class")));
            element = wait.Until(t => driver.FindElement(List_("Machine Class")));
            element.FindElement(List_("Machine Class")).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(vmClassLocator));
            element.FindElement(vmClassLocator).Click();

            return this;
        }

        public PageCalculator ChooseMachinetype()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(List_("Machine type")));
            element = wait.Until(t => driver.FindElement(List_("Machine type")));
            element.FindElement(List_("Machine type")).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(machinetypeLocator));
            element = wait.Until(t => driver.FindElement(machinetypeLocator));
            element.FindElement(machinetypeLocator).Click();

            return this;
        }

        public PageCalculator ChooseGPUsType()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(addGPUsLocator));
            element = wait.Until(t => driver.FindElement(addGPUsLocator));
            element.FindElement(addGPUsLocator).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(List_("Number of GPUs")));
            element = wait.Until(t => driver.FindElement(List_("Number of GPUs")));
            element.FindElement(List_("Number of GPUs")).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(numberOfGPUsLocator));
            element.FindElement(numberOfGPUsLocator).Click();
            element.FindElement(numberOfGPUsLocator).SendKeys(Keys.Enter);

            wait.Until(ExpectedConditions.ElementToBeClickable(List_("GPU type")));
            element = wait.Until(t => driver.FindElement(List_("GPU type")));
            element.FindElement(List_("GPU type")).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(locatorGPUtype));
            element.FindElement(locatorGPUtype).Click();
            element.FindElement(locatorGPUtype).SendKeys(Keys.Enter);

            return this;
        }

        public PageCalculator ChooseLocalSSD()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(listoflocalSSDLocator));
            element = wait.Until(t => driver.FindElement(listoflocalSSDLocator));
            element.FindElement(listoflocalSSDLocator).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(localSSDLocator));
            element.FindElement(localSSDLocator).Click();
            element.FindElement(localSSDLocator).SendKeys(Keys.Enter);

            return this;
        }

        public PageCalculator ChooseDatacenterLocation()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(listOfdatacenterLocationLocator));
            element = wait.Until(t => driver.FindElement(listOfdatacenterLocationLocator));
            element.Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(datacenterLocationLocator));
            element = wait.Until(t => driver.FindElement(datacenterLocationLocator));
            element.Click();

            return this;
        }

        public PageCalculator TypeCommittedUsage()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(listOfcommittedUsageLocator));
            element = wait.Until(t => driver.FindElement(listOfcommittedUsageLocator));
            element.Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(committedUsageLocator));
            element = wait.Until(t => driver.FindElement(committedUsageLocator));
            element.Click();

            return this;
        }

        public PageCalculator PressButtonAddToEstimate()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(clickButtonEmailEstimateLocator));
            element = wait.Until(t => driver.FindElement(clickButtonEmailEstimateLocator));
            element.Click();

            return this;
        }

        public string CopyPrice()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(priceLocator));
            element = wait.Until(t => driver.FindElement(priceLocator));
            element.GetAttribute("value");

            return element.GetAttribute("value");
        }

        public PageCalculator AddEmailToForm()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(addEmailLocator));
            element = wait.Until(t => driver.FindElement(addEmailLocator));
            element.FindElement(addEmailLocator).Click();


            return this;
        }

        public PageCalculator InputEmail(string email)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(emailLocator));
            element = wait.Until(t => driver.FindElement(emailLocator));
            element.Click();
            element.SendKeys(email);

            return this;
        }

        public PageCalculator FillInCalculatorPage()
        {
            GoToCalculatorFrame();
            FillNumberOfInstances();
            ChooseOperatingSystemSoftware();
            ChooseVMClass();
            ChooseMachinetype();
            ChooseGPUsType();
            ChooseLocalSSD();
            ChooseDatacenterLocation();
            TypeCommittedUsage();
            PressButtonAddToEstimate();
            AddEmailToForm();

            return this;
        }
    }
}
