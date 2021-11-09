using Kpi.Allo.ClientTests.Model.Platform.Locator;
using Kpi.Allo.ClientTests.Platform.Element;
using Kpi.Allo.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Allo.ClientTests.UI.Product
{
    public class InvalidProductTopElement : HtmlElement
    {
        [FindBy(How.XPath, "//p[@class='v-catalog__empty']")]
        public HtmlLabel ValidationErrorLabel { get; set; }
    }
}
