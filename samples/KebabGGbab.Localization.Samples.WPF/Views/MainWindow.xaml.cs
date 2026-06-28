using System.ComponentModel;
using System.Windows;
using KebabGGbab.Localization.Samples.Shared.ViewModels;

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

            InitializeComponent();
        }

        public MainWindow(MainViewModel vm)
        {
            DataContext = vm;
            InitializeComponent();
        }
    }
}