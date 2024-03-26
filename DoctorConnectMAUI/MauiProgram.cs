using Microsoft.Extensions.Logging;

namespace DoctorConnectMAUI
{
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
					fonts.AddFont("NotoSans-Bold.ttf", "NotoSansBold");
					fonts.AddFont("NotoSans-Regular.ttf", "NotoSansRegular");
					fonts.AddFont("fontAwesome-webfont.ttf", "FontAwesome");
				});

#if DEBUG
			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}
