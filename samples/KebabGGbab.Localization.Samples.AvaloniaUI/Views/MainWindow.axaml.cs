namespace KebabGGbab.Localization.Samples.AvaloniaUI
{
    public sealed partial class MainWindow : Window
    {
        // Конструктор для дизайнера
        public MainWindow()
        {
            if (Design.IsDesignMode == false)
            {
                throw new InvalidOperationException();
            }

            InitializeComponent();
        }

        public MainWindow(MainViewModel vm)
        {
            DataContext = vm;
            InitializeComponent();
        }
    }
}