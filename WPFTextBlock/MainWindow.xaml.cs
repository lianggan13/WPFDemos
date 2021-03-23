using System.Linq;
using System.Timers;
using System.Windows;

namespace WPFTextBlock
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 800;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            //ColorAnimationUsingKeyFrames colorAnimation = new ColorAnimationUsingKeyFrames();

            //ColorAnimation colorAnimation = new ColorAnimation(ColorAnimation)


            //Storyboard storyBoard = new Storyboard();
            //var animation = distance > 0 ? CollapseAnimation : ExpandAnimation;
            //storyBoard.Children.Add(animation);

            //Storyboard.SetTargetName(animation, txtPoints.Name);
            ////Storyboard.SetTarget(animation, hitInfo.SeriesPoint);
            //Storyboard.SetTargetProperty(animation, new PropertyPath(TextBlock.ForegroundProperty));
            //storyBoard.Begin();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                if (txtPoints.Text.Count() <= 6)
                {
                    txtPoints.Text += ".";
                }
                else
                {
                    txtPoints.Text = string.Empty;
                }

            });


        }
    }
}
