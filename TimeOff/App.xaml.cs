namespace TimeOff;

public partial class App : Application
{
	public App()
	{
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NGaF1cWGhIfEx1RHxQdld5ZFRHallYTnNWUj0eQnxTdEZjUX9ZcXNQRGBYWUB/Xw==");
        InitializeComponent();

		MainPage = new AppShell();
	}
}
