using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutoSeleniumTrial
{
    public class Tests : DriverHelper
    {


        [SetUp]
        public void Setup()
        {
           
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();
                        
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almonds");
            
            Assert.Pass();
           
        }
    }
}