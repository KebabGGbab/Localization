namespace KebabGGbab.Localization.Samples.Shared.ViewModels
{
    public class MainViewModel
    {
        public SettingsViewModel SettingsViewModel { get; }

        public UsersViewModel UsersViewModel { get; }

        public MainViewModel(SettingsViewModel settings, UsersViewModel users)
        {
            ArgumentNullException.ThrowIfNull(settings);
            ArgumentNullException.ThrowIfNull(users);

            SettingsViewModel = settings;
            UsersViewModel = users;
        }
    }
}
