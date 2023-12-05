using MauiSlalomDemo.Services;
using MauiSlalomDemo.ViewModel;
using Microsoft.Extensions.Logging;

namespace MauiSlalomDemo;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddSingleton<TopStoriesService>();
		builder.Services.AddTransient<TopStoriesViewModel>();

		return builder.Build();
	}
}

