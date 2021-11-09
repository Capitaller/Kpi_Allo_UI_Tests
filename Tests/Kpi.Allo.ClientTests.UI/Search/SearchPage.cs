using Kpi.Allo.ClientTests.Model.Platform.Drivers;
using Kpi.Allo.ClientTests.Model.Platform.Locator;
using Kpi.Allo.ClientTests.Platform.Page;
using Kpi.Allo.ClientTests.UI.Product;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Allo.ClientTests.UI.Search
{
    public class SearchPage : WebPage
    {
        public SearchPage(IWebDriver webDriver)
            : base(webDriver)
        {
        }

        [FindBy(How.XPath, "//div[@class='product-card__content']/a")]
        public ProductTopElement ProductTopElement { get; set; }

        [FindBy(How.XPath, "//p[@class='v-catalog__empty']")]
        public InvalidProductTopElement ProductInvalidTopElement { get; set; }
    }
}
