using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using TimeOff.Views;
using TimeOff.Models;

namespace TimeOff.ViewModel;

public partial class MainPageViewModel : ContentView
{
    public ObservableCollection<TimeOffRequestCardViewModel> TimeOffRequestCards { get; set; }
    public MainPageViewModel()
	{
        TimeOffRequestCards = new ObservableCollection<TimeOffRequestCardViewModel>();

        // Assuming you have a method to fetch or create TimeOffRequest objects
        List<TimeOffRequest> timeOffRequests = FetchTimeOffRequests(); // Implement this method

        // Add your logic to populate TimeOffRequestCards with data from your TimeOffRequest list
        foreach (var timeOffRequest in timeOffRequests)
        {
            var cardViewModel = new TimeOffRequestCardViewModel
            {
                StartTime = timeOffRequest.StartTime,
                EndTime = timeOffRequest.EndTime,
                
            };

            TimeOffRequestCards.Add(cardViewModel);
        }
    }
    private List<TimeOffRequest> FetchTimeOffRequests()
    {
        //Fetch the TimeOffRequests
        return new List<TimeOffRequest>
        {
            new TimeOffRequest { StartTime = "8/20/2023", EndTime = "8/25/2023" },
            new TimeOffRequest { StartTime = "9/05/2023", EndTime = "9/10/2023" },
            new TimeOffRequest { StartTime = "10/04/2023", EndTime = "10/06/2023" },

        };
    }
    [RelayCommand]
	private async Task TimeOff() {
		await Shell.Current.GoToAsync(nameof(TimeOffRequestPage));
	}

}