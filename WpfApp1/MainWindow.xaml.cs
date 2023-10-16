using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private bool IsMaximized = false;
        private void Border_MouseLeftBattonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount ==  2) 
            {
                this.WindowState = WindowState.Normal;
                this.Width = 1080;
                this.Width = 720;

                IsMaximized = false;
            }
            else
            {
                this.IsMaximized = WindowState.Maximized;
            }
        }

    }
}
