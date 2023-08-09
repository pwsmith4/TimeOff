namespace TimeOff;

using System.Linq.Expressions;
using TimeOff.ViewModel;
public partial class MainPage : ContentPage
{

	public MainPage(MainPageViewModel viewModel)
	{
			InitializeComponent();
			BindingContext = viewModel;		
		
	}

    private void TimeOff_Clicked(object sender, EventArgs e)
    {

    }
}

