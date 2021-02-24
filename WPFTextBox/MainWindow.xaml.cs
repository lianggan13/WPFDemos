using System;
using System.Windows;

namespace WPFTextBox
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtSingle.VM.AddValidator((string value) =>
            {
                string errorMsg = string.Empty;
                string toolTip = "Input Something";

                if (string.IsNullOrEmpty(value))
                {
                    errorMsg = "Empty Data";
                }

                Tuple<string, string> tp = new Tuple<string, string>(toolTip, errorMsg);
                return tp;
            });


            txtSingle.VM.FillData("TextName", "TextValue",
             preRegex: @"^(^-?(([1-9]{1}[0-9]{0,1})(\.(\d){0,1})?)$)|(^-?([0]{1})(\.(\d){0,1})?$)|(-)$",
             unit: "dbM",
             save: () =>
             {
                 MessageBox.Show("Save Done.");
             });


        }
    }
}
