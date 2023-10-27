using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpAuto
{
    class LoginPage : BasePage
    {


        public void Login(string url, string userName, string password)
        {
            driver.Url = url;

            driver.FindElement(By.Id("user-name")).SendKeys(userName);
            driver.FindElement(By.Id("password")).SendKeys(password);
            driver.FindElement(By.Id("login-button")).Click();

        }
    }
}
