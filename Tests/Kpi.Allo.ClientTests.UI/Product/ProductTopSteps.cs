using Kpi.Allo.ClientTests.Model.Domain.Product;
using Kpi.Allo.ClientTests.Model.Platform.Drivers;
using Kpi.Allo.ClientTests.Platform.Factory;
using Kpi.Allo.ClientTests.UI.Search;

namespace Kpi.Allo.ClientTests.UI.Product
{
    public class ProductTopSteps : IProductTopSteps
    {
        private readonly IWebDriver _webDriver;

        public ProductTopSteps (
            IWebDriver webDriver) 
        {
            _webDriver = webDriver;
        }

        private SearchPage SearchPage => PageFactory.Get<SearchPage>(_webDriver);

        public string GetTitle() =>
            SearchPage.ProductTopElement.ProductHeaderLabel.GetText().Trim();

        public string GetInvalidTitle() =>
            SearchPage.ProductInvalidTopElement.GetText().Trim();
    }
}
