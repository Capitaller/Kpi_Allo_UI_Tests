using Kpi.Allo.ClientTests.Model.Platform.Locator;
using Kpi.Allo.ClientTests.Platform.Element;
using Kpi.Allo.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Allo.ClientTests.UI.Login
{
    public class LoginNameTopElement : HtmlElement
    {
        [FindBy(How.XPath, "//span[@class='label']")]
        public HtmlLabel UserNameLabel { get; set; }
    }
}
