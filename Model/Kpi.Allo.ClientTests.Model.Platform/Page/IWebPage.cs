using Kpi.Allo.ClientTests.Model.Platform.Element;

namespace Kpi.Allo.ClientTests.Model.Platform.Page
{
    public interface IWebPage : ISearchable, INative
    {
        string Address { get; set; }

        string Title { get; set; }

        void Open();

        void Refresh();
    }
}
