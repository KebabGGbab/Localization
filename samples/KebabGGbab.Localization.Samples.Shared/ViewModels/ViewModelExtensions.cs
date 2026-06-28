using Microsoft.Extensions.DependencyInjection;

namespace KebabGGbab.Localization.Samples.Shared.ViewModels
{
    public static class ViewModelExtensions
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services)
        {
            ArgumentNullException.ThrowIfNull(services);

            return services.AddSingleton<SettingsViewModel>()
                .AddSingleton<MainViewModel>()
                .AddSingleton<UsersViewModel>();
        }
    }
}
