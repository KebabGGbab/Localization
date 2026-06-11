namespace KebabGGbab.Localization.Samples.AvaloniaUI
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow(MainViewModel vm)
        {
            DataContext = vm;
            InitializeComponent();
        }
    }
}