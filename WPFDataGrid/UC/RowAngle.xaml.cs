using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Controls;
using WPFDataGrid.Model;

namespace WPFDataGrid.UC
{
    /// <summary>
    /// RowAngle.xaml 的交互逻辑
    /// </summary>
    public partial class RowAngle : UserControl
    {
        private ObservableCollection<Employee> m_Employees;
        private List<Angle> listData;
        public RowAngle()
        {
            InitializeComponent();
            m_Employees = new ObservableCollection<Employee>();
            m_Employees.Add(new Employee() { ID = 1, Name = "Jim", Salary = 2500.50f });
            m_Employees.Add(new Employee() { ID = 2, Name = "John", Salary = 2600.50f });
            // dg.ItemsSource = m_Employees;

            listData = new List<Angle>();
            listData.Add(new Angle() { Start = "0", End = "96", Step = "2" });
            dg.ItemsSource = listData;
        }


        private void dg_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {

        }



        private void dg_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {

        }

        private void dg_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            return;
            if (!this.dg.IsFocused)
                WPFDataGrid.Common.Mouse.DoubleClick(System.Windows.Input.MouseButton.Left);

        }



        private void dg_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Trace.WriteLine("dg_MouseLeftButtonDown");
        }
    }
}
