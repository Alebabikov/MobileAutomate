using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class LoginPage : BasePage
    {
        public LoginPage(AndroidDriver<AndroidElement> driver):base(driver)
        {

        }

        private AndroidElement BtnOk => driver.FindElement(By.Id("gr.alphamobilev2.ru:id/bOk"));
        private AndroidElement BtnCancel => driver.FindElement(By.Id("gr.alphamobilev2.ru:id/bCancel"));
        private AndroidElement BtnPermissionAndroidOk => driver.FindElement(By.Id("com.android.permissioncontroller:id/permission_allow_foreground_only_button"));
        private AndroidElement BtnPermissionAndroidAllow => driver.FindElement(By.Id("com.android.permissioncontroller:id/permission_allow_button"));
        private AndroidElement BtnPermissionAndroidCancel => driver.FindElement(By.Id("com.android.permissioncontroller:id/permission_deny_button"));
        private AndroidElement FieldLogin => driver.FindElement(By.Id("gr.alphamobilev2.ru:id/etLogin"));
        private AndroidElement FieldPassword => driver.FindElement(By.Id("gr.alphamobilev2.ru:id/passEdit"));
        private AndroidElement BtnLogin => driver.FindElement(By.Id("gr.alphamobilev2.ru:id/loginButton"));
        private AndroidElement AlphaVersionHeader => driver.FindElement(By.Id("gr.alphamobilev2.ru:id/tvVersion"));



        public void ClickBtnOk() => BtnOk.Click();
        public void ClickBtnCancel() => BtnCancel.Click();
        public void ClickPermissionAndroidOk() => BtnPermissionAndroidOk.Click();
        public void ClickPermissionAndroidAllow() => BtnPermissionAndroidAllow.Click();
        public void ClickPermissionAndroidCancel() => BtnPermissionAndroidCancel.Click();
        public void SendTextToLogin(string text) => FieldLogin.SendKeys(text);
        public void SendTextToPassword(string text) => FieldPassword.SendKeys(text);
        public void ClickBtnLogin() => BtnLogin.Click();
        public string GetAlphaVersionHeader => AlphaVersionHeader.Text;



    }
}
