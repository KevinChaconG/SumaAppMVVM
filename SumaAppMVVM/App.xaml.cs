using SumaAppMVVM.ViewModels;
using SumaAppMVVM.Views;

namespace SumaAppMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.SumaAppMVVM());
        }
    }
}
