using System.Collections.Generic;
using Bogus;
using Kpi.Allo.ClientTests.Model.Domain.Login;

namespace Kpi.Allo.ClientTests.TestsData.Storage
{
    public static class UsersStorage
    {
        public static Dictionary<string, UserInformation> Users =>
        new Dictionary<string, UserInformation>
        {
            { "ExistingUser", ExistingUser },
            { "ExistingUserWithInvalidPassword", ExistingUserWithInvalidPassword },
            { "NoExistingUser", NoExistingUser }
        };

        private static UserInformation ExistingUser =>
            new Faker<UserInformation>()
                .RuleFor(u => u.Email, "130102anton@gmail.com")
                .RuleFor(u => u.Password, "nojseap");

        private static UserInformation ExistingUserWithInvalidPassword =>
            new Faker<UserInformation>()
                .RuleFor(u => u.Email, "130102anton@gmail.com")
                .RuleFor(u => u.Password, "invalid");

        private static UserInformation NoExistingUser =>
            new Faker<UserInformation>()
                .RuleFor(u => u.Email, "Invalid@gmail.com")
                .RuleFor(u => u.Password, "Invalid");
    }
}
