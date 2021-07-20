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



            ///  Ajax dropdown - Select By Text
            IWebElement ajaxDropdown = Driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed"));

            CustomControl.SelectByText(ajaxDropdown, "Lettuce");
            CustomControl.SelectByText(ajaxDropdown, "Cauliflower");
            CustomControl.SelectByText(ajaxDropdown, "Artichoke");
            CustomControl.SelectByText(ajaxDropdown, "Broccoli");
            CustomControl.SelectByText(ajaxDropdown, "Celery");
        }

     
        
    }


    
}