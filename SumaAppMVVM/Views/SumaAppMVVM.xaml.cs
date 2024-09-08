using SumaAppMVVM.ViewModels;

namespace SumaAppMVVM.Views;

public partial class SumaAppMVVM : ContentPage
{

	private SumaAppViewModel ViewModel;
	public SumaAppMVVM()
	{
		InitializeComponent();
		ViewModel = new SumaAppViewModel();
		BindingContext = ViewModel;
	}
}