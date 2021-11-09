using Kpi.Allo.ClientTests.Model.Platform.WebElements;
using Kpi.Allo.ClientTests.Platform.Element;

namespace Kpi.Allo.ClientTests.Platform.WebElements
{
    public class HtmlLink : HtmlElement, IHtmlLink
    {
        public string GetLink() => GetAttribute("href");

        public new void Click() => base.Click();
    }
}
