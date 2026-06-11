using KebabGGbab.Localization.Samples.Shared.ViewModels.Design;

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

            DataContext = new DesignMainViewModel();
            InitializeComponent();
        }

        public MainWindow(MainViewModel vm)
        {
            DataContext = vm;
            InitializeComponent();
        }
    }
}