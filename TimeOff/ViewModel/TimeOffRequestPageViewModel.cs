using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Messaging;
using TimeOff.Models;
using TimeOff.ViewModels;
using static TimeOff.Behavior.CalendarBehavior;

namespace TimeOff.ViewModel;


public partial class TimeOffRequestPageViewModel : BaseViewModel
{
    [ObservableProperty]
    private string startTime;

    [ObservableProperty]
    private string endTime;

    [ObservableProperty]
    private string space;


    private List<TimeOffRequest> _timeOffRequests;

    public ObservableCollection<TimeOffRequest> TimeOffRequests { get; set; }

    public ICommand TimeOffRequestingCommand { get; }

    public TimeOffRequestPageViewModel()
	{
        _timeOffRequests = new List<TimeOffRequest>();
        TimeOffRequests = new ObservableCollection<TimeOffRequest>();
        StartTime = "Not Selected";
        EndTime = "Not Selected";
        Space = "                                                    ";
        WeakReferenceMessenger.Default.Register<StartDateChangedMessage>(this, (recipient, message) =>
        {
            StartTime = message.StartDate.ToString("d");
        });
        WeakReferenceMessenger.Default.Register<EndDateChangedMessage>(this, (recipient, message) =>
        {
            Space = "                                                           ";
            EndTime = message.EndDate.ToString("d");
        });
        TimeOffRequestingCommand = new Command(ExecuteTimeOffRequestingCommand);
    }
    private void ExecuteTimeOffRequestingCommand()
    {
        var timeOffRequest = new TimeOffRequest
        {
            StartTime = StartTime,
            EndTime = EndTime
        };

        // Add the new request to the list
        _timeOffRequests.Add(timeOffRequest);

        // Update the ObservableCollection to reflect the changes
        TimeOffRequests.Clear();
        foreach (var request in _timeOffRequests)
        {
            TimeOffRequests.Add(request);
        }
        
        // Reset the start and end times
        StartTime = "Not Selected";
        EndTime = "Not Selected";
    }       

}
	
