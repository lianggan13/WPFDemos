using System.Windows;
using System.Windows.Controls;

namespace WPFComboBox
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmb = sender as ComboBox;

        }

        private void ComboBoxEdit_PopupClosing(object sender, DevExpress.Xpf.Editors.ClosingPopupEventArgs e)
        {
            e.Handled = true;
        }
    }


}
