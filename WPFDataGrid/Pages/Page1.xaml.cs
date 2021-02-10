using DevExpress.Xpf.Core;
using System.Windows.Controls;

namespace WPFDataGrid.Pages
{
    /// <summary>
    /// Page1.xaml 的交互逻辑
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {

            InitializeComponent();
            this.Loaded += Page1_Loaded;



        }

        private void Page1_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            ApplicationThemeHelper.ApplicationThemeName = DevExpress.Xpf.Core.Theme.Office2019ColorfulFullName;
        }
    }
}
