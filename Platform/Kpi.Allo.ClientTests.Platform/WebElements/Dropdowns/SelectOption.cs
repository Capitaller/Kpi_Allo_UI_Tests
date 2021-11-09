using Kpi.Allo.ClientTests.Model.Platform.Locator;
using Kpi.Allo.ClientTests.Platform.Element;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Allo.ClientTests.Platform.WebElements.Dropdowns
{
    public class SelectOption : HtmlElement
    {
        [FindBy(How.XPath, ".//span")]
        public HtmlLabel Name { get; set; }
    }
}
