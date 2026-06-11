namespace KebabGGbab.Localization.Samples.Shared.ViewModels
{
    public class MainViewModel
    {
        public SettingsViewModel Settings { get; }

        public UserViewModel User { get; }

        public MainViewModel(SettingsViewModel settings, UserViewModel user)
        {
            ArgumentNullException.ThrowIfNull(settings);
            ArgumentNullException.ThrowIfNull(user);

            Settings = settings;
            User = user;
        }
    }
}
