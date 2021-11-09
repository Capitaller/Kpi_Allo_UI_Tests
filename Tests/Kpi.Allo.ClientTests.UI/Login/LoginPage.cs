using Kpi.Allo.ClientTests.Model.Platform.Drivers;
using Kpi.Allo.ClientTests.Model.Platform.Locator;
using Kpi.Allo.ClientTests.Platform.Page;
using Kpi.Allo.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Allo.ClientTests.UI.Login
{
    public class LoginPage : WebPage
    {
        public LoginPage(IWebDriver webDriver)
            : base(webDriver)
        {
        }

        [FindBy(How.XPath, ".//input[@id='auth']")]
        public HtmlTextBox EmailTextBox { get; set; }

        [FindBy(How.XPath, ".//input[@id='v-login-password']")]
        public HtmlTextBox PasswordTextBox { get; set; }

        [FindBy(How.XPath, "//div[@id='customer-login-menu']//button")]
        public HtmlButton LoginMenuButton { get; set; }
    }
}
