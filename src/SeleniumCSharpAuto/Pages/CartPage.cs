using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpAuto
{
    class CartPage : BasePage
    {
        IWebElement removeBtn = driver.FindElement(By.Id("remove-sauce-labs-backpack"));

        internal void RemoveFromCart()
        {
            removeBtn.Click();
        }
    }
}
