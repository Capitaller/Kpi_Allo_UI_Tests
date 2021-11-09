using System.Linq;
using Kpi.Allo.ClientTests.Model.Platform.Locator;
using Kpi.Allo.ClientTests.Model.Platform.WebElements.Mat;
using Kpi.Allo.ClientTests.Platform.Element;
using Kpi.Allo.ClientTests.Platform.Waiter;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Allo.ClientTests.Platform.WebElements.Mat
{
    public class MatSelect : HtmlElement, IMatSelect
    {
        private HtmlElement[] Options =>
            FindAll<HtmlElement>(new Locator(How.XPath, ".//ancestor::body//mat-option"))
                .ToArray();

        public void Open()
        {
            Click();
            WaitFor.Condition(
                () =>
                Options.Any(i => i.GetDisplayed()),
                "No Any mat select options.");
        }

        public void Select(string option) =>
            Options.Single(
                i => i.GetText().Contains(option))
                .Click();

        public string[] GetOptions() =>
            Options.Select(i => i.GetText().Trim())
                .ToArray();
    }
}
