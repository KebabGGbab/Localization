using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using KebabGGbab.Localization.Samples.AvaloniaUI.Service.Localization;

namespace KebabGGbab.Localization.Samples.AvaloniaUI
{
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public App()
        {
            ServiceCollection services = new();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
            services.AddViewModels();
            services.AddLocalizationWithResx();
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}