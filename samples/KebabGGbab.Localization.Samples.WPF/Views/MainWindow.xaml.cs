using System.ComponentModel;
using System.Windows;
using KebabGGbab.Localization.Samples.Shared.ViewModels;
using KebabGGbab.Localization.Samples.Shared.ViewModels.Design;

namespace KebabGGbab.Localization.Samples.WPF
{
    public partial class MainWindow : Window
    {
        // Конструктор для дизайнера
        public MainWindow()
        {
            if (DesignerProperties.GetIsInDesignMode(this))
            {
                throw new InvalidOperationException();
            }

            DataContext = new DesignSettingsViewModel();
            InitializeComponent();
        }

        public MainWindow(SettingsViewModel vm)
        {
            DataContext = vm;
            InitializeComponent();
        }
    }
}