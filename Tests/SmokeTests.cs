using NUnit.Framework;
using PageObject;
using ProjectTestSelenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class SmokeTests:BaseTest
    {
        [Test]
        public void VerifyPagesHeaders()
        {
            InitPage init = new InitPage(driver);
            ContactsPage contactsPage = new ContactsPage(driver);
            init.ClickContacts();
            string header =  contactsPage.GetTextFromHeader();
            Assert.AreEqual("Контакты", header, $"Header {header} is not an expected");
        }
    }
}
