using System.Windows;
using System.Windows.Controls;

namespace WPFVisualState.View
{
    /// <summary>
    /// LoadingWait.xaml 的交互逻辑
    /// </summary>
    public partial class LoadingWait : UserControl
    {
        public LoadingWait()
        {
            InitializeComponent();

        }


        public double Radius
        {
            get { return (double)GetValue(RadiusProperty); }
            set { SetValue(RadiusProperty, value); }
        }

        public static readonly DependencyProperty RadiusProperty =
            DependencyProperty.Register(nameof(Radius), typeof(double), typeof(LoadingWait), new PropertyMetadata(12.0, new PropertyChangedCallback(Radius_PropertyChangedCallback)));


        private static void Radius_PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }


        public bool Run
        {
            get { return (bool)GetValue(RunProperty); }
            set { SetValue(RunProperty, value); }
        }

        public static readonly DependencyProperty RunProperty =
            DependencyProperty.Register(nameof(Run), typeof(bool), typeof(LoadingWait), new PropertyMetadata(default(bool), new PropertyChangedCallback(Run_PropertyChangedCallback)));


        private static void Run_PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var obj = d as LoadingWait;
            VisualStateManager.GoToState(obj, (bool)e.NewValue ? obj.RunState.Name : obj.StopState.Name, false);
        }
    }
}
