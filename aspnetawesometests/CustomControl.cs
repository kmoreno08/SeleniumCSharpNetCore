using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace aspnetawesome
{
    public class CustomControl : DriverHelper
    {

        // Checks if user input stays the same after click from dropdown
        public static void ComboBox(string controlName, string value)
        {
            Console.WriteLine("Entered ComboBox...");
            IWebElement comboControl = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            // Clear text box
            comboControl.Clear();
            // Type in value
            comboControl.SendKeys(value);
            //Click drop down menu of the text value
            Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();

            // Check if user input value is equal to value in text box
            bool comboControlExactString = comboControl.GetAttribute("value").Equals(value);
            // Check if passed/fail with print out
            if (comboControlExactString)
            {
                Console.WriteLine($"Passed with {value}");
                
            } else
            {
                Console.WriteLine($"Failed with {value}");
            }
        }

        
        // Click on buttonGroup and select by text with correct corresponding ajax dropdown
        public static void buttonGroupAjaxDropdownSelectByText(IWebElement buttonGroup, IWebElement ajaxDropdown, string text)
        {
            buttonGroup.Click();
            SelectElement selectAjaxElement = new SelectElement(ajaxDropdown);
            selectAjaxElement.SelectByText(text);

        }
    }
}
