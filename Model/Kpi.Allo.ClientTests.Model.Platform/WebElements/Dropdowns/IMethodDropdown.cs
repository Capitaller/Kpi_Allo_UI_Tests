namespace Kpi.Allo.ClientTests.Model.Platform.WebElements.Dropdowns
{
    public interface IMethodDropdown
    {
        void OpenDropdown();

        void Select(string option);

        string[] GetOptions();
    }
}
