using OpenQA.Selenium;
using System;

namespace ProjectTestSelenium
{
    public class BasePage
    {
        protected static IWebDriver driver;

        public BasePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }
        private IWebElement btnContacts => driver.FindElement(By.XPath("//ul[@class='menu site_menu hidden-xs']/li/a[@href='/contacts/']"));
        private IWebElement btnDilivery => driver.FindElement(By.XPath("//ul[@class='menu site_menu hidden-xs']/li/a[@href='/payment-and-delivery/']"));
        private IWebElement btnWarranty => driver.FindElement(By.XPath("//ul[@class='menu site_menu hidden-xs']/li/a[@href='/warranty-and-service/']"));
        private IWebElement btnCertificate => driver.FindElement(By.XPath("//ul[@class='menu site_menu hidden-xs']/li/a[@href='/certificates/']"));
        private IWebElement btnPcBulding => driver.FindElement(By.XPath("//ul[@class='menu site_menu hidden-xs']/li/a[@href='/pc-building/']"));
        private IWebElement btnSale => driver.FindElement(By.XPath("//ul[@class='menu site_menu hidden-xs']/li/a[@href='/sale/']"));
        private IWebElement txtHeader => driver.FindElement(By.TagName("h1"));
        public string GetTextFromHeader() => txtHeader.Text;
        public void ClickContacts() => btnContacts.Click();
        public void ClickDilivery() => btnDilivery.Click();
        public void ClickWarranty() => btnWarranty.Click();
        public void ClickCertificate() => btnCertificate.Click();
        public void ClickBuilding() => btnPcBulding.Click();
        public void ClickSale() => btnSale.Click();
    }
}
