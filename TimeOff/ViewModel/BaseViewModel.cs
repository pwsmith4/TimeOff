namespace TimeOff.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    public bool isBusy;

    [ObservableProperty]
    public string title;

    public bool IsNotBusy => !IsNotBusy;

    public BaseViewModel()
    {
    }
}

