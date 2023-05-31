using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;

namespace PageObjects
{
    public class BasePage
    {
        protected AppiumDriver<AndroidElement> driver;
        public BasePage(AppiumDriver<AndroidElement> driver) 
        { 
            this.driver = driver;

         
        }
    }
 }