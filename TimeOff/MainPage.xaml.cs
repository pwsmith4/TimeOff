namespace TimeOff;

using System.Linq.Expressions;
using TimeOff.ViewModel;
using TimeOff.Views;

public partial class MainPage : ContentPage
{

	public MainPage(MainPageViewModel viewModel)
	{
			InitializeComponent();
			BindingContext = viewModel;		
		
	}


}

