using Microsoft.Maui.Controls;

namespace TimeOff.ViewModel;

public class MainPageViewModel : ContentView
{
	public MainPageViewModel()
	{
		
	}

    private async Task NavigateToWelcome()
    {
        if (Shell.Current.FlyoutBehavior == FlyoutBehavior.Disabled)
        {
            Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout;
        }
        await Shell.Current.GoToAsync("//WelcomePage");
    }
}