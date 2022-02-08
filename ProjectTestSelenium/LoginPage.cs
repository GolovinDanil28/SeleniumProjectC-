using OpenQA.Selenium;
using ProjectTestSelenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    public class LoginPage :BasePage
    {
        public LoginPage(IWebDriver driver): base(driver)
        {

        }

        private IWebElement txtEmail => driver.FindElement(By.XPath("//input[@name='login']"));
        private IWebElement txtPassword => driver.FindElement(By.XPath("//input[@name='password']"));
        private IWebElement btnLogin => driver.FindElement(By.XPath("//input[@value='Войти']"));
        private IWebElement errorMsg => driver.FindElement(By.XPath("//em[@data-name='auth']"));
        public void SendTextToEmail(string text) => txtEmail.SendKeys(text);
        public void SendTextToPassword(string text) => txtPassword.SendKeys(text);
        public void ClickLoginBtn() => btnLogin.Click();
        public string GetErrorMsg() => errorMsg.Text;
    }
}
