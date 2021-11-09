using Kpi.Allo.ClientTests.Model.Domain.Run;

namespace Kpi.Allo.ClientTests.Platform.Configuration.Run
{
    public class RunSettings : IRunSettings
    {
        public SeleniumGrid SeleniumGrid { get; set; }

        public RunType RunType { get; set; }
    }
}
