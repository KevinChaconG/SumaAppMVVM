using SumaAppMVVM.ViewModels;

namespace SumaAppMVVM.Views;

public partial class SumaAppView : ContentView
{
	private SumaAppViewModel ViewModel;
	public SumaAppView()
	{
		InitializeComponent();
		ViewModel = new SumaAppViewModel ViewModel;
		BindingContext = ViewModel;
	}
}