using TimeOff.ViewModel;
namespace TimeOff.Cards;

public partial class TimeOffRequestCard : Frame
{
    private TimeOffRequestPageViewModel _timeOffRequestPageViewModel;
    public TimeOffRequestCard(TimeOffRequestPageViewModel timeOffRequestPageViewModel)
	{
		InitializeComponent();
        _timeOffRequestPageViewModel = timeOffRequestPageViewModel;

        // Access the list of time off requests
        var timeOffRequests = _timeOffRequestPageViewModel.TimeOffRequests;

    }
    public TimeOffRequestCard()
    {
        InitializeComponent();
    }

    }