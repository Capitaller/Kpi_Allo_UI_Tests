using Kpi.Allo.ClientTests.Model.Platform.Locator;
using Kpi.Allo.ClientTests.Platform.Element;
using Kpi.Allo.ClientTests.UI.Search;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Allo.ClientTests.UI
{
    public class HeaderSection : HtmlElement
    {
        [FindBy(How.XPath, "//div[@class='search-form search__form']")]
        public SearchElement SearchElement { get; set; }
    }
}
