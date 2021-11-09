using Kpi.Allo.ClientTests.Model.Platform.Locator;
using Kpi.Allo.ClientTests.Platform.Element;
using Kpi.Allo.ClientTests.Platform.WebElements;
using OpenQA.Selenium.Support.PageObjects;

namespace Kpi.Allo.ClientTests.UI.Search
{
    public class SearchElement : HtmlElement, ISearchElement
    {
        [FindBy(How.XPath, ".//input[@id='search-form__input']")]
        private HtmlTextBox SearchElementTextBox { get; set; }

        [FindBy(How.XPath, ".//button[contains(@class, 'search-form__submit-button')]")]
        private HtmlButton SearchButton { get; set; }

        public void SetValue(string value)
        {
            SearchElementTextBox.SetText(value);
        }

        public void Search()
        {
            SearchButton.Click();
        }

        public void Search(string value)
        {
            SetValue(value);
            Search();
        }
    }
}
