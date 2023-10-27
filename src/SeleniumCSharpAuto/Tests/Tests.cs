using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace SeleniumCSharpAuto
{
    [TestClass]
    public class Tests : TestClassBase
    {

        LoginPage loginPage = new LoginPage();

        #region TC01_Login
        /// <summary>
        /// Login with valid user
        /// </summary>
        [TestMethod]
        public void TC01_Login()
        {
            
            loginPage.Login("https://www.saucedemo.com", "standard_user", "secret_sauce");

            string actualMsg = BasePage.driver.FindElement(By.ClassName("app_logo")).Text;

            Assert.AreEqual("Swag Labs", actualMsg, true);

        }
        #endregion

        #region TC02_Login
        /// <summary>
        /// Login with invalid user
        /// </summary>
        [TestMethod]
        public void TC02_Login()
        {
            loginPage.Login("https://www.saucedemo.com", "stduser", "secret_sadadadauce");

            string actualMsg = BasePage.driver.FindElement(By.TagName("h3")).Text;

            Assert.AreEqual("Epic sadface: Username and password do not match any user in this service", actualMsg, true);

        }
        #endregion

        #region TC03_RemoveItemsFromCartCheck
        /// <summary>
        /// Login with invalid user
        /// </summary>
        [TestMethod]
        public void TC03_RemoveItemsFromCartCheck()
        {

            loginPage.Login("https://www.saucedemo.com", "standard_user", "secret_sauce");

            CartPage cartPage = new CartPage();
            cartPage.RemoveFromCart();

            IList<IWebElement> cartItems = BasePage.driver.FindElements(By.ClassName("cart_item"));

            Assert.IsTrue(cartItems.Count == 0);

        }
        #endregion

        #region TC04_LoginDataDriven
        /// <summary>
        /// Login with valid user
        /// </summary>
        [TestMethod]
        [TestCategory("DataDriven")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\DataDrivenTestData.xml", "TC04_LoginDataDriven", DataAccessMethod.Sequential)]
        public void TC04_LoginDataDriven()
        {

            string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["user"].ToString();
            string password = TestContext.DataRow["password"].ToString();

            loginPage.Login(url, user, password);

            string actualMsg = BasePage.driver.FindElement(By.ClassName("app_logo")).Text;

            Assert.AreEqual("Swag Labs", actualMsg, true);

        }
        #endregion


    }
}
