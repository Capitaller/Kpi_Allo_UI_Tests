using System;
using Kpi.Allo.ClientTests.Model.Platform.Drivers;
using Kpi.Allo.ClientTests.Model.Platform.Page;
using Kpi.Allo.ClientTests.Platform.Element;

namespace Kpi.Allo.ClientTests.Platform.Factory
{
    public static class PageFactory
    {
        public static TPage Get<TPage>(IWebDriver driver) 
            where TPage : IWebPage
        {
            IWebPage page = (TPage)Activator.CreateInstance(typeof(TPage), driver);
            InitPage(page);
            return (TPage)page;
        }

        private static void InitPage(IWebPage page)
        {
            if (page.GetType().HasUrlAttribute())
            {
                page.Address = page.GetType().GetUrlAttribute().Url;
            }

            ElementFactory.InitProperties(page);
        }
    }
}
