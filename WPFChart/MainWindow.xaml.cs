using DevExpress.Xpf.Core;
using System.Windows;

namespace WPFChart
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string name = Theme.Default.Name;
            ApplicationThemeHelper.ApplicationThemeName = Theme.Default.Name;

        }

        private void StackPanel_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
