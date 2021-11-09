using Kpi.Allo.ClientTests.Model.Platform.Drivers;
using Kpi.Allo.ClientTests.Model.Platform.Locator;
using Kpi.Allo.ClientTests.Platform.Page;
using Kpi.Allo.ClientTests.Platform.WebElements;
using Kpi.Allo.ClientTests.UI.Login;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Allo.ClientTests.UI
{
    public class MainPage : WebPage
    {
        public MainPage(IWebDriver webDriver) 
            : base(webDriver)
        {
        }

        [FindBy(How.XPath, ".//button[@class='authentication__button--login']")]
        public HtmlButton LoginButton { get; set; }

        [FindBy(How.XPath, ".//div[@class='v-header']")]
        public HeaderSection HeaderSection { get; set; }

        [FindBy(How.XPath, ".//span[@class='label']")]
        public LoginNameTopElement LoginNameTopElement { get; set; }

        [FindBy(How.XPath, ".//div[@class='validation-advice v-validation-error']/div/span")]
        public HtmlLabel ValidationErrorLabel { get; set; }
    }
}
