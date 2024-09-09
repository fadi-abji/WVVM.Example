using System.Windows;
using WVVM.WPF.ModelViews;

namespace WVVM.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new PersonViewModel(); // Set ViewModel as DataContext
        }
    }
}