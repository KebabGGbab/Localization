using CommunityToolkit.Mvvm.ComponentModel;
using KebabGGbab.Localization.Samples.Shared.Models;

namespace KebabGGbab.Localization.Samples.Shared.ViewModels
{
    public class UserViewModel : ObservableObject
    {
        private readonly User _user;

        public string Name => _user.Name;

        public UserViewModel(User user)
        {
            ArgumentNullException.ThrowIfNull(user);

            _user = user;
        }
    }
}
