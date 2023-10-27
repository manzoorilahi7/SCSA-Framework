using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportingUtils.Reports;

namespace SeleniumCSharpAuto
{
    [TestClass]
    public class TestClassBase
    {

        #region Setup and Cleanup
        
        public TestContext instance;

        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {

        }

        [ClassCleanup]
        public void ClassCleanUp()
        {

        }

        [TestInitialize]
        public void TestInit()
        {
            ExtentReporting.CreateTest(TestContext.TestName);

            BasePage.SeleniumInit(ConfigurationManager.AppSettings["Browser"].ToString());
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            BasePage.driver.Close();
        }
        #endregion

    }
}
