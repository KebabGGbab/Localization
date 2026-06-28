using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using KebabGGbab.Localization.Samples.AvaloniaUI.Service.Localization;

namespace KebabGGbab.Localization.Samples.AvaloniaUI
{
    public partial class App : Application
    {
        // null может быть только в Design
        private readonly IServiceProvider _serviceProvider = null!;

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public App()
        {
            if (Design.IsDesignMode)
            {
                return;
            }
            
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
                desktop.MainWindow = Design.IsDesignMode
                    ? new MainWindow()
                    : _serviceProvider.GetRequiredService<MainWindow>();
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}