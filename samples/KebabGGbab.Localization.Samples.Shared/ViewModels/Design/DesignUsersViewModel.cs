namespace KebabGGbab.Localization.Samples.Shared.ViewModels.Design
{
    public class DesignUsersViewModel : UsersViewModel
    {
        public DesignUsersViewModel()
        {
            for (int i = 0; i < 10; i++)
            {
                AddUserCommand.Execute(null);
            }
        }
    }
}
