using Kpi.Allo.ClientTests.Model.Domain.Run;

namespace Kpi.Allo.ClientTests.Platform.Configuration.Run
{
    public interface IRunSettings
    {
        SeleniumGrid SeleniumGrid { get; set; }

        RunType RunType { get; set; }
    }
}
