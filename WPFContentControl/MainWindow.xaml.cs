using System;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using WPFCommon;

namespace WPFContentControl
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
    }

    public class MainVM : NotifyPropertyChanged
    {
        private FrameworkElement mainContent;

        public FrameworkElement MainContent
        {
            get { return mainContent; }
            set { mainContent = value; OnPropertyChanged(); }
        }

        public MainVM()
        {
            NavigateCmd.Execute("Home");
        }
        // RelayCommand Navigate = new RelayCommand(RelayCommand)

        public ICommand NavigateCmd
        {
            get => new RelayCommand<string>((para) =>
            {
                Type tp = Type.GetType($"WPFContentControl.View.{para}Page");
                ConstructorInfo cti = tp.GetConstructor(Type.EmptyTypes);
                this.MainContent = (FrameworkElement)cti.Invoke(null);

            }, (para) => true);
        }
    }
}
