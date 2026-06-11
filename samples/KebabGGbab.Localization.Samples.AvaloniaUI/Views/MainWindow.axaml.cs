namespace KebabGGbab.Localization.Samples.AvaloniaUI
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow(SettingsViewModel vm)
        {
            DataContext = vm;
            InitializeComponent();
        }
    }
}