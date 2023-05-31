
using OpenQA.Selenium.Appium.Android;
using PageObjects;

namespace Tests
{
    [TestFixture]
    public class LoginTest : TestBase
    {

        [Test]
        public void PositiveLogin()
        {
            LoginPage login = new LoginPage(driver);
            login.ClickBtnOk();
            login.ClickPermissionAndroidOk();
            login.ClickPermissionAndroidAllow();
            login.ClickBtnOk();
            login.SendTextToLogin(""); 
            /// Указать логин

            login.SendTextToPassword("");
            /// Указать пароль

            login.ClickBtnLogin();
            login.ClickBtnOk();
            string actualError = login.GetAlphaVersionHeader;
            string expectedError = "RU Alpha 2 Mobile v.1.1.34";
            Assert.AreEqual(expectedError, actualError, $"{expectedError} is not equal to {actualError}");











        }
    }
}