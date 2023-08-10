using Microsoft.Maui.Controls;
using TimeOff.Views;

namespace TimeOff.ViewModel;

public partial class MainPageViewModel : ContentView
{
	public MainPageViewModel()
	{
		
	}
	[RelayCommand]
	private async Task TimeOff() {
		await Shell.Current.GoToAsync(nameof(TimeOffRequestPage));
	}

}