using NUnit.Framework;
using System;
using System.Collections.Generic;
using PageObject;
using System.Threading;

namespace Tests
{
    
    public class LoginTests:BaseTest
    {
        [Test]
        public void NegativeLogin()
        {
            InitPage init = new InitPage(driver);
            LoginPage loginPage = new LoginPage(driver);
            init.ClickLogin();
            loginPage.SendTextToEmail("rfrefrefer.rr");
            loginPage.SendTextToPassword("12312");
            Thread.Sleep(2000);
            loginPage.ClickLoginBtn();
            string errorMassegeText = loginPage.GetErrorMsg();
            string expectedError = "Неправильное имя пользователя или пароль.";
            Assert.AreEqual(errorMassegeText, expectedError);
            Thread.Sleep(2000);

        }
    }
}
