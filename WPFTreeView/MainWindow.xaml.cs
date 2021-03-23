using System.Collections.ObjectModel;
using System.Windows;
using WPFTreeView.Model;

namespace WPFTreeView
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<BatchModel> BatchCategories { get; set; } = new ObservableCollection<BatchModel>();

        public MainWindow()
        {
            InitializeComponent();
        }


    }
}
