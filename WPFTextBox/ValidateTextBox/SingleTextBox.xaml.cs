using System.Windows.Controls;
using WPFTextBox.ViewModel;

namespace WPFTextBox.ValidateTextBox
{
    /// <summary>
    /// SingleTextBox.xaml 的交互逻辑
    /// </summary>
    public partial class SingleTextBox : UserControl
    {

        public SingleTextBoxVM VM { get; }
        public SingleTextBox()
        {
            InitializeComponent();
            VM = base.DataContext as SingleTextBoxVM;
        }

        public void Value_ErrorEvent(object sender, ValidationErrorEventArgs e)
        {
            //if (e.Action == ValidationErrorEventAction.Added)
            //    Errors.Add(e.Error);
            //else
            //    Errors.Remove(e.Error);
        }
    }
}
