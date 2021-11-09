using Kpi.Allo.ClientTests.Model.Domain.Login;

namespace Kpi.Allo.ClientTests.Domain.Login
{
    public class LoginContext : ILoginContext
    {
        private readonly ILoginSteps _loginSteps;

        public LoginContext (
            ILoginSteps loginSteps)
        {
            _loginSteps = loginSteps;
        }

        public void Login (UserInformation user)
        {
            _loginSteps.OpenLoginPage();
            _loginSteps.SetEmail(user.Email);
            _loginSteps.SetPassword(user.Password);
            _loginSteps.Login();
        }
    }
}
