using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;
using TimeOff.ViewModel;

namespace TimeOff;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.ConfigureSyncfusionCore()
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
        //DI for Views
        builder.Services.AddTransient<MainPage>();

		//DI for ViewModels
        builder.Services.AddTransient<MainPageViewModel>();

        return builder.Build();
	}
}
