using System;
using System.Linq;
using Kpi.Allo.ClientTests.Model.Platform.Locator;
using Kpi.Allo.ClientTests.Model.Platform.WebElements;
using Kpi.Allo.ClientTests.Platform.Element;
using Kpi.Allo.ClientTests.Platform.Waiter;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Allo.ClientTests.Platform.WebElements
{
    public class DropDown : HtmlElement, IDropDown
    {
        [FindBy(How.XPath, "./a")]
        private HtmlButton OpenButton { get; set; }

        [FindBy(How.XPath, ".//div[@class='drop-select-box']")]
        private HtmlElement DropSelectBox { get; set; }

        private HtmlLink[] Options =>
            DropSelectBox.FindAll<HtmlLink>(new Locator(How.XPath, ".//a"))
                .ToArray();

        public string[] GetOptions() =>
            Options.Select(i => i.GetText().Trim()).ToArray();

        public void Choose(string option)
        {
            Open();
            SetValue(option);
        }

        private void Open()
        {
            OpenButton.Click();
            WaitFor.Condition(
                () => DropSelectBox.GetDisplayed(),
                "The 'DropDown' wasn't opened.",
                TimeSpan.FromSeconds(15));
        }

        private void SetValue(string option) =>
            Options.Single(i => i.GetText().Contains(option))
                .Click();
    }
}
