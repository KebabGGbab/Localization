using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Windows;
using KebabGGbab.Localization.Exceptions;
using KebabGGbab.Localization.Manager;
using KebabGGbab.Localization.WPF.Resources;

namespace KebabGGbab.Localization.WPF
{
    public sealed class LocalizationListener : INotifyPropertyChanged, IWeakEventListener
    {
        private static readonly CompositeFormat _resourcePlaceholder = CompositeFormat.Parse(Strings.LocalizationListenerPlaceholderFormat);

        public string Key { get; }

        public object Value 
        { 
            get;
            private set
            {
                if (field == value)
                {
                    return;
                }

                field = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public LocalizationListener(string key) 
        {
            ArgumentNullException.ThrowIfNull(key);

            Key = key;
            Value = GetValue();
            // Я бы хотел уйти от Singlton. Это произойдет тогда, когда я решу как лучше передавать ILocalizationManager в расширение xaml
            CurrentUICultureChangedWeakEventManager.AddListener(LocalizationManager.Instance, this);
        }

        public bool ReceiveWeakEvent(Type managerType, object sender, EventArgs e)
        {
            if (managerType == typeof(CurrentUICultureChangedWeakEventManager))
            {
                Value = GetValue();

                return true;
            }

            return false;
        }

        private object GetValue()
        {
            try
            {
                return LocalizationManager.Instance.Localize(Key);
            }
            catch (ResourceNotFoundException ex)
            {
                return string.Format(CultureInfo.InvariantCulture, _resourcePlaceholder, ex.Key);
            }
        }
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}