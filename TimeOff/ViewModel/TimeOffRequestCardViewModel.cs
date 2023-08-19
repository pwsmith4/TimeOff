using CommunityToolkit.Mvvm.Messaging;
using TimeOff.ViewModels;
using static TimeOff.Behavior.CalendarBehavior;

namespace TimeOff.ViewModel;

public partial class TimeOffRequestCardViewModel : BaseViewModel
{
    [ObservableProperty]
    private string startTime;

    [ObservableProperty]
    private string endTime;

    public TimeOffRequestCardViewModel()
	{
        WeakReferenceMessenger.Default.Register<StartDateChangedMessage>(this, (recipient, message) =>
        {
            StartTime = message.StartDate.ToString("d");
        });
    }
}