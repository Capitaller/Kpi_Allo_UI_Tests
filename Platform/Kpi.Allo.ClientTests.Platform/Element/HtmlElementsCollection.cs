using System.Collections;
using System.Collections.Generic;
using Kpi.Allo.ClientTests.Model.Platform.Element;
using Kpi.Allo.ClientTests.Model.Platform.Locator;
using Kpi.Allo.ClientTests.Platform.Factory;

namespace Kpi.Allo.ClientTests.Platform.Element
{
    public class HtmlElementsCollection<THtmlElement> : IHtmlElementsCollection<THtmlElement> 
        where THtmlElement : IHtmlElement
    {
        public HtmlElementsCollection(INative parent, Locator locator)
        {
            Parent = parent;
            Locator = locator;
        }

        private INative Parent { get; }

        private Locator Locator { get; }

        IEnumerator IEnumerable.GetEnumerator() =>
            GetEnumerator();

        public IEnumerator<THtmlElement> GetEnumerator()
        {
            var nativeElements = Parent.FindElements(Locator);
            foreach (var nativeElement in nativeElements)
            {
                var htmlElement = ElementFactory.Create<THtmlElement>(Parent, Locator);
                htmlElement.SetNativeElement(nativeElement);
                yield return htmlElement;
            }
        }
    }
}
