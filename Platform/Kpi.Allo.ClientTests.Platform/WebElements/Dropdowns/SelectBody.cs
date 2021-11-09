using System.Linq;
using Kpi.Allo.ClientTests.Model.Platform.Locator;
using Kpi.Allo.ClientTests.Platform.Element;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Allo.ClientTests.Platform.WebElements.Dropdowns
{
    public class SelectBody : HtmlElement
    {
        public SelectOption[] SelectOptions =>
            FindAll<SelectOption>(new Locator(How.XPath, ".//et-select-body-option"))
                .ToArray();
    }
}
