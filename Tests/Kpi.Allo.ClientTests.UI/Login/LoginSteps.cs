using Kpi.Allo.ClientTests.Model.Domain.Login;
using Kpi.Allo.ClientTests.Model.Platform.Drivers;
using Kpi.Allo.ClientTests.Platform.Configuration.Environment;
using Kpi.Allo.ClientTests.Platform.Factory;

namespace Kpi.Allo.ClientTests.UI.Login
{
    public class LoginSteps : ILoginSteps
    {
        private readonly IWebDriver _webDriver;
        private readonly IEnvironmentConfiguration _environmentConfiguration;

        public LoginSteps(
            IWebDriver webDriver,
            IEnvironmentConfiguration environmentConfiguration)
        {
            _webDriver = webDriver;
            _environmentConfiguration = environmentConfiguration;
        }

        private LoginPage LoginPage => PageFactory.Get<LoginPage>(_webDriver);

        private MainPage MainPage => PageFactory.Get<MainPage>(_webDriver);

        private LoginNameTopElement LoginNameTopElement => MainPage.LoginNameTopElement;

        public void SetEmail(string email)
        {
            LoginPage.EmailTextBox.SetText(email);
        }

        public void SetPassword(string password)
        {
            LoginPage.PasswordTextBox.SetText(password);
        }

        public void Login()
        {
            LoginPage.LoginMenuButton.Click();
        }

        public void OpenLoginPage()
        {
            OpenMainView();
            MainPage.LoginButton.Click();
        }

        public string GetUserName()
        {
            return LoginNameTopElement.UserNameLabel.GetText().Trim();
        }

        public string GetValidationMessage()
        {
            return MainPage.ValidationErrorLabel.GetText().Trim();
        }

        public void OpenMainView() =>
            _webDriver.Get(_environmentConfiguration.EnvironmentUri);
    }
}
