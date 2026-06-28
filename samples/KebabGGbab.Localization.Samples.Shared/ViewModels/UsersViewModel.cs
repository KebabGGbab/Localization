using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KebabGGbab.Localization.Samples.Shared.Models;

namespace KebabGGbab.Localization.Samples.Shared.ViewModels
{
    public class UsersViewModel : ObservableObject
    {
        private static readonly Random _random = new();

        private readonly ObservableCollection<UserViewModel> _users;

        public ReadOnlyObservableCollection<UserViewModel> Users { get; }

        public IRelayCommand AddUserCommand { get; }

        public IRelayCommand ClearUsersCommand { get; }

        public UsersViewModel()
        {
            _users = [];
            Users = new ReadOnlyObservableCollection<UserViewModel>(_users);
            AddUserCommand = new RelayCommand(AddUser);
            ClearUsersCommand = new RelayCommand(ClearUsers);
        }

        private void AddUser()
        {
            int r = _random.Next(1, 4);

            User user = r switch
            {
                1 => new User("Artem"),
                2 => new User("Olya"),
                _ => new User("Vasya")
            };

            _users.Add(new UserViewModel(user));
        }

        private void ClearUsers()
        {
            _users.Clear();
        }
    }
}