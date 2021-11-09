using Kpi.Allo.ClientTests.Model.Platform.Locator;
using Kpi.Allo.ClientTests.Platform.Element;
using Kpi.Allo.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Allo.ClientTests.UI.Product
{
    public class ProductTopElement : HtmlElement
    {
        [FindBy(How.XPath, "//div[@class='product-card__content']/a")]
        public HtmlLabel ProductHeaderLabel { get; set; }
    }
}
