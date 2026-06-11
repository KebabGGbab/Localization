using System.Windows;
using KebabGGbab.Localization.Samples.Shared.ViewModels;

namespace KebabGGbab.Localization.Samples.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(SettingsViewModel vm)
        {
            DataContext = vm;
            InitializeComponent();
        }
    }
}