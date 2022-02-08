using OpenQA.Selenium;
using ProjectTestSelenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    public class ContactsPage : BasePage
    {
        public ContactsPage(IWebDriver driver) : base(driver)
        {

        }
        private IWebElement txtHeader => driver.FindElement(By.TagName("h1"));
        public string GetTextFromHeader => txtHeader.Text;
    }
}
