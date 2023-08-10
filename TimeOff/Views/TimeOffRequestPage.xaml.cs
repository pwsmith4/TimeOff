using TimeOff.ViewModel;

namespace TimeOff.Views;

public partial class TimeOffRequestPage : ContentPage
{
	public TimeOffRequestPage(TimeOffRequestPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext=viewModel;
	}
}