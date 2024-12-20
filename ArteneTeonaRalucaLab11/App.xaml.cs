using ArteneTeonaRalucaLab11.Data;
namespace ArteneTeonaRalucaLab11
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());

        }
    }
}
