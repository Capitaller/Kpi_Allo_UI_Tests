using FluentAssertions;
using Kpi.Allo.ClientTests.Model.Domain.Login;
using Kpi.Allo.ClientTests.Model.Domain.Product;
using Kpi.Allo.ClientTests.Model.Domain.Search;
using TechTalk.SpecFlow;

namespace Kpi.Allo.ClientTests.Tests.Features
{
    [Binding, Scope(Feature = "Search")]
    public class SearchDefinition
    {
        private readonly ILoginSteps _loginSteps;
        private readonly ISearchSteps _searchSteps;
        private readonly IProductTopSteps _productTopSteps;

        public SearchDefinition (
            ILoginSteps loginSteps,
            ISearchSteps searchSteps,
            IProductTopSteps productTopSteps)
        {
            _loginSteps = loginSteps;
            _searchSteps = searchSteps;
            _productTopSteps = productTopSteps;
        }

        [Given(@"I open main view")]
        public void GivenIOpenMainView ()
        {
            _loginSteps.OpenMainView();
        }

        [When(@"I search '(.*)' value")]
        public void WhenISearchValue (string value)
        {
            _searchSteps.Search(value);
        }

        [Then(@"I see '(.*)' result")]
        public void ThenISeeResults (string expectedValue)
        {
            var actualValue = _productTopSteps.GetTitle();
            actualValue.Should().Be(expectedValue);
        }

        [Then(@"I see not found '(.*)' result")]
        public void ThenISeeNotFoundResults(string expectedValue)
        {
            var actualValue = _productTopSteps.GetInvalidTitle();
            actualValue.Should().Be(expectedValue);
        }
    }
}
