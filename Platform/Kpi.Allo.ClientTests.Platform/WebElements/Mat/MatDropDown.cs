using Kpi.Allo.ClientTests.Model.Platform.Locator;
using Kpi.Allo.ClientTests.Model.Platform.WebElements.Mat;
using Kpi.Allo.ClientTests.Platform.Element;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Allo.ClientTests.Platform.WebElements.Mat
{
    public class MatDropDown : HtmlElement, IMatDropDown
    {
        [FindBy(How.XPath, ".//mat-select[@id='mat-select-0']")]
        private MatSelect MatSelect { get; set; }

        public void SetValue(string value)
        {
            MatSelect.Open();
            MatSelect.Select(value);
        }

        public string[] GetOptions() =>
            MatSelect.GetOptions();
    }
}
