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

    private void TimeOffCommand(object sender, EventArgs e)
    {

    }
}

