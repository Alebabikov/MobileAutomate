using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using System.Threading;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Appium.Interfaces;
using System.Drawing;
using OpenQA.Selenium.Appium.Android;

namespace Tests
{
    public class TestBase

    {
        public static AndroidDriver<AndroidElement> driver;

        [SetUp]
        public void Setup()
        {

            AppiumOptions options = new AppiumOptions();
            options.PlatformName = "Android";
            options.AddAdditionalCapability("deviceName", "emulator-5554");
            options.AddAdditionalCapability("platformName", "Android");
            options.AddAdditionalCapability("app", "");

            /// добавить в проект apk и указать его расположение


            Uri url = new Uri("http://127.0.0.1:4723/wd/hub");

            driver = new AndroidDriver<AndroidElement>(url, options);
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


        }

        [TearDown]
        
        public void Cleanup()

        { 
           // driver.CloseApp(); 
        } 

    }
}