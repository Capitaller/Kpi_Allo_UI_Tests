using Kpi.Allo.ClientTests.Model.Domain.Search;
using Kpi.Allo.ClientTests.Model.Platform.Drivers;
using Kpi.Allo.ClientTests.Platform.Factory;

namespace Kpi.Allo.ClientTests.UI.Search
{
    public class SearchSteps : ISearchSteps
    {
        private readonly IWebDriver _webDriver;

        public SearchSteps(
            IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private SearchElement SearchElement => PageFactory.Get<MainPage>(_webDriver).HeaderSection.SearchElement;

        public void Search(string value)
        {
            SearchElement.Search(value);
        }
    }
}
