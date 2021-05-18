using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using WPFItemsControl.Model;

namespace WPFItemsControl
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

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton radBtn = sender as RadioButton;
            string courseName = radBtn.Content.ToString();

            ICollectionView cview = CollectionViewSource.GetDefaultView(this.ccs.ItemsSource);//VM.CourseSeriesList);

            if (courseName == "All")
            {
                cview.Filter = null;
            }
            else
            {
                cview.Filter = new System.Predicate<object>((o) =>
                {
                    return (o as CourseSeriesModel).CourseName == courseName;
                });
            }


        }
    }
}
