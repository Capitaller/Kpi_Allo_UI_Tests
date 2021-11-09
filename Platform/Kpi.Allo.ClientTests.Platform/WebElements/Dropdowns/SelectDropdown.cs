using Kpi.Allo.ClientTests.Model.Platform.Locator;
using Kpi.Allo.ClientTests.Platform.Element;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Allo.ClientTests.Platform.WebElements.Dropdowns
{
    public class SelectDropdown : HtmlElement
    {
        [FindBy(How.XPath, ".//et-deposit-payment-method-dropdown")]
        public MethodDropDown MethodDropDown { get; set; }
    }
}
