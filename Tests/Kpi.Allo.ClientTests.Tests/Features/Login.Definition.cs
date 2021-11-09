using FluentAssertions;
using Kpi.Allo.ClientTests.Model.Domain.Login;
using Kpi.Allo.ClientTests.TestsData.Storage;
using TechTalk.SpecFlow;

namespace Kpi.Allo.ClientTests.Tests.Features
{
    [Binding, Scope(Feature = "Login")]
    public class LoginDefinition
    {
        private readonly ILoginSteps _loginSteps;
        private UserInformation _userInformation;

        public LoginDefinition(
            ILoginSteps loginSteps)
        {
            _loginSteps = loginSteps;
        }

        [Given(@"I have '(.*)' user")]
        public void GivenIHaveExistingUser(string entityName)
        {
            _userInformation = UsersStorage.Users[entityName];
        }

        [Given(@"I set login")]
        public void GivenISetLogin()
        {
            _loginSteps.OpenLoginPage();
            _loginSteps.SetEmail(_userInformation.Email);
        }

        [Given(@"I set password")]
        public void WhenISearchValue()
        {
            _loginSteps.SetPassword(_userInformation.Password);
        }

        [When(@"I login to app")]
        public void WhenILoginToApp()
        {
            _loginSteps.Login();
        }

        [Then(@"I see '(.*)' user")]
        public void ThenISeeResult(string expectedValue)
        {
            var actualValue = _loginSteps.GetUserName();
            actualValue.Should().Be(expectedValue);
        }

        [Then(@"I see invalid '(.*)' user")]
        public void ThenISeeInvalidResult(string expectedValue)
        {
            var actualValue = _loginSteps.GetValidationMessage();
            actualValue.Should().Be(expectedValue);
        }
    }
}
