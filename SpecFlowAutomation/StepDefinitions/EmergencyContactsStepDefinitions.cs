using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowAutomation.Hooks;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowAutomation.StepDefinitions
{
    [Binding]
    public class EmergencyContactsStepDefinitions
    {
        string name;
        [When(@"I click on My Info")]
        public void WhenIClickOnMyInfo()
        {
            AutomationHooks.driver.FindElement(By.XPath("//span[text()='My Info']")).Click();
        }

        [When(@"I click on Emergency Contacts")]
        public void WhenIClickOnEmergencyContacts()
        {
            AutomationHooks.driver.FindElement(By.XPath("//a[text()='Emergency Contacts']")).Click();
        }

        [When(@"I click on Add")]
        public void WhenIClickOnAdd()
        {
            AutomationHooks.driver.FindElement(By.XPath("//h6[text()='Assigned Emergency Contacts']/following::button")).Click();
        }

        [When(@"I fill the add emergency contact section")]
        public void WhenIFillTheAddEmergencyContactSection(Table table)
        {
            name = table.Rows[0]["name"];
            string relationship = table.Rows[0]["relationship"];
            string home_telephone = table.Rows[0]["home_telephone"];
            string mobile = table.Rows[0]["mobile"];
            string work_telephone = table.Rows[0]["work_telephone"];

            AutomationHooks.driver.FindElement(By.XPath("//label[contains(text(),'Name')]/following::input")).SendKeys(name);
            AutomationHooks.driver.FindElement(By.XPath("//label[contains(text(),'Relationship')]/following::input")).SendKeys(relationship);
            AutomationHooks.driver.FindElement(By.XPath("//label[contains(text(),'Home Telephone')]/following::input")).SendKeys(home_telephone);
            AutomationHooks.driver.FindElement(By.XPath("//label[contains(text(),'Mobile')]/following::input")).SendKeys(mobile);
            AutomationHooks.driver.FindElement(By.XPath("//label[contains(text(),'Work Telephone')]/following::input")).SendKeys(work_telephone);

        }

        [When(@"I click on save emergency contact")]
        public void WhenIClickOnSaveEmergencyContact()
        {
            AutomationHooks.driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        [Then(@"I should see add emergency contact record under assigned emergency contacts")]
        public void ThenIShouldSeeAddEmergencyContactRecordUnderAssignedEmergencyContacts()
        {

        }
    }
}
