namespace Kpi.Allo.ClientTests.Model.Platform.WebElements
{
    public interface IHtmlCheckbox
    {
        void Check();

        void Uncheck();

        void SetValue(bool value);

        bool IsChecked();
    }
}
