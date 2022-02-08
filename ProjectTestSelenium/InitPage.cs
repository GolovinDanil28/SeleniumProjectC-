using OpenQA.Selenium;
using ProjectTestSelenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    public class InitPage : BasePage
    {
        public InitPage(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement btnLogin => driver.FindElement(By.XPath("//a[@href='/login/']"));

        public void ClickLogin() => btnLogin.Click();
    }
}
