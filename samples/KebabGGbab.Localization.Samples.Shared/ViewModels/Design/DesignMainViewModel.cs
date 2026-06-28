namespace KebabGGbab.Localization.Samples.Shared.ViewModels.Design
{
    public class DesignMainViewModel : MainViewModel
    {
        public DesignMainViewModel() 
            : base(new DesignSettingsViewModel(), new DesignUsersViewModel())
        {
        }
    }
}
