using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace aspnetawesome
{
    [TestFixture()]
    public class Tests : DriverHelper
    {
       
        [SetUp]
        public void Setup()
        {
           
            Console.WriteLine("Setup...");
            // FireFox Browser
            Driver = new FirefoxDriver();


        }

        [Test]
        public void ComboBoxUserInputMatch()
        {
            // Go to URL
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            // Maximize Window
            Driver.Manage().Window.Maximize();
          
            // From comboBox, check all values if typed equals the value after click from dropdown
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almonds");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Mango");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Papays");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Banana");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Cherry");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Tomato");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Potato");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Cucumber");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Onion");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Carrot");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Celery");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Broccoli");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Artichoke");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Cauliflower");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Lettuce");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Hazelnuts");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Chestnuts");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Walnuts");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Mongongo");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Rice");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Wheat");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Buckwheat");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Oats");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Barley");


            // Button group and according Ajax dropdown (Legumes) //
            IWebElement ajaxDropdown = Driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed"));
            IWebElement legumesButtonGroup = Driver.FindElement(By.XPath("/html/body/form/div[3]/div/div[2]/main/div[1]/div[3]/div[1]/div[2]/div/div/div[2]/div/button[2]"));

            CustomControl.buttonGroupAjaxDropdownSelectByText(legumesButtonGroup, ajaxDropdown, "Tomato");
            CustomControl.buttonGroupAjaxDropdownSelectByText(legumesButtonGroup, ajaxDropdown, "Potato");
            CustomControl.buttonGroupAjaxDropdownSelectByText(legumesButtonGroup, ajaxDropdown, "Cucumber");
            CustomControl.buttonGroupAjaxDropdownSelectByText(legumesButtonGroup, ajaxDropdown, "Onion");
            CustomControl.buttonGroupAjaxDropdownSelectByText(legumesButtonGroup, ajaxDropdown, "Carrot");

            // Button group and according Ajax dropdown (Fruits) //
            IWebElement fruitsButtonGroup = Driver.FindElement(By.XPath("/html/body/form/div[3]/div/div[2]/main/div[1]/div[3]/div[1]/div[2]/div/div/div[2]/div/button[1]"));
            
            CustomControl.buttonGroupAjaxDropdownSelectByText(fruitsButtonGroup, ajaxDropdown, "Mango");
            CustomControl.buttonGroupAjaxDropdownSelectByText(fruitsButtonGroup, ajaxDropdown, "Apple");
            CustomControl.buttonGroupAjaxDropdownSelectByText(fruitsButtonGroup, ajaxDropdown, "Papaya");
            CustomControl.buttonGroupAjaxDropdownSelectByText(fruitsButtonGroup, ajaxDropdown, "Banana");
            CustomControl.buttonGroupAjaxDropdownSelectByText(fruitsButtonGroup, ajaxDropdown, "Cherry");

           

            // Button group and according Ajax dropdown (Vegetables) //
            IWebElement vegetablesButtonGroup = Driver.FindElement(By.XPath("/html/body/form/div[3]/div/div[2]/main/div[1]/div[3]/div[1]/div[2]/div/div/div[2]/div/button[3]"));

            CustomControl.buttonGroupAjaxDropdownSelectByText(vegetablesButtonGroup, ajaxDropdown, "Lettuce");
            CustomControl.buttonGroupAjaxDropdownSelectByText(vegetablesButtonGroup, ajaxDropdown, "Celery");
            CustomControl.buttonGroupAjaxDropdownSelectByText(vegetablesButtonGroup, ajaxDropdown, "Broccoli");
            CustomControl.buttonGroupAjaxDropdownSelectByText(vegetablesButtonGroup, ajaxDropdown, "Artichoke");
            CustomControl.buttonGroupAjaxDropdownSelectByText(vegetablesButtonGroup, ajaxDropdown, "Cauliflower");


            // Button group and according Ajax dropdown (Nuts) //
            IWebElement nutsButtonGroup = Driver.FindElement(By.XPath("/html/body/form/div[3]/div/div[2]/main/div[1]/div[3]/div[1]/div[2]/div/div/div[2]/div/button[4]"));

            CustomControl.buttonGroupAjaxDropdownSelectByText(nutsButtonGroup, ajaxDropdown, "Hazelnuts");
            CustomControl.buttonGroupAjaxDropdownSelectByText(nutsButtonGroup, ajaxDropdown, "Chestnuts");
            CustomControl.buttonGroupAjaxDropdownSelectByText(nutsButtonGroup, ajaxDropdown, "Walnuts");
            CustomControl.buttonGroupAjaxDropdownSelectByText(nutsButtonGroup, ajaxDropdown, "Almonds");
            CustomControl.buttonGroupAjaxDropdownSelectByText(nutsButtonGroup, ajaxDropdown, "Mongongo");


            // Button group and according Ajax dropdown (Grains) //
            IWebElement grainsButtonGroup = Driver.FindElement(By.XPath("/html/body/form/div[3]/div/div[2]/main/div[1]/div[3]/div[1]/div[2]/div/div/div[2]/div/button[5]"));

            CustomControl.buttonGroupAjaxDropdownSelectByText(grainsButtonGroup, ajaxDropdown, "Rice");
            CustomControl.buttonGroupAjaxDropdownSelectByText(grainsButtonGroup, ajaxDropdown, "Wheat");
            CustomControl.buttonGroupAjaxDropdownSelectByText(grainsButtonGroup, ajaxDropdown, "Buckwheat");
            CustomControl.buttonGroupAjaxDropdownSelectByText(grainsButtonGroup, ajaxDropdown, "Oats");
            CustomControl.buttonGroupAjaxDropdownSelectByText(grainsButtonGroup, ajaxDropdown, "Barley");
        }



    }

    

}