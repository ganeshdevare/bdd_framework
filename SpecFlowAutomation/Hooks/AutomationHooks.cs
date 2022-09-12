using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowAutomation.Hooks
{
    public class AutomationHooks
    {
        public static IWebDriver driver;

        [AfterScenario]
        public void EndBrowser()
        {
            if (driver != null)
            {
                driver.Quit();
            }
    }
    }

    
}
