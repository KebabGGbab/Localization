namespace KebabGGbab.Localization.Samples.Shared.Models
{
    public sealed class User
    {
        public string Name { get; }

        public User(string name)
        {
            ArgumentNullException.ThrowIfNull(name);

            Name = name;
        }
    }
}
