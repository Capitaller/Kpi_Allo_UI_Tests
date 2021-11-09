using Kpi.Allo.ClientTests.Model.Platform.Element;

namespace Kpi.Allo.ClientTests.Model.Platform.WebElements
{
    public interface IHtmlTextElement : IHtmlElement
    {
        void SetText(string text);

        string GetValue();

        string GetPlaceholder();
    }
}
