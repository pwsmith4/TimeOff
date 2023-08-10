using System.Globalization;
namespace TimeOff;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(TimeOffRequestPage), typeof(TimeOffRequestPage));

	}
}
