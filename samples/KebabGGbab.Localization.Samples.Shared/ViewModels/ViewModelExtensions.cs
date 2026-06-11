using KebabGGbab.Localization.Samples.Shared.Models;
using Microsoft.Extensions.DependencyInjection;

namespace KebabGGbab.Localization.Samples.Shared.ViewModels
{
    public static class ViewModelExtensions
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services)
        {
            ArgumentNullException.ThrowIfNull(services);

            return services.AddSingleton((s) => new UserViewModel(new User("MyUser")))
                .AddSingleton<SettingsViewModel>()
                .AddSingleton<MainViewModel>();
        }
    }
}
