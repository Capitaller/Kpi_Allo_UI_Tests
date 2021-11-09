namespace Kpi.Allo.ClientTests.UI.Search
{
    public interface ISearchElement
    {
        void SetValue (string value);

        void Search ();

        void Search (string value);
    }
}
