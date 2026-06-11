using KebabGGbab.Localization.Manager;

namespace KebabGGbab.Localization.Samples.Shared.ViewModels.Design
{
    public class DesignSettingsViewModel : SettingsViewModel
    {
        public DesignSettingsViewModel() : base(LocalizationManager.Instance)
        {
        }
    }
}
