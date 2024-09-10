using SumaAppMVVM.ViewModels;

namespace SumaAppMVVM.Views
{
    public partial class SumaAppMVVM : ContentPage
    {
        public SumaAppMVVM()
        {
            InitializeComponent();
            BindingContext = new SumaAppViewModel();
        }
    }
}
