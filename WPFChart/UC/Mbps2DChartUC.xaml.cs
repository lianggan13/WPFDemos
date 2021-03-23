using DevExpress.Xpf.Charts;
using System.Windows.Controls;

namespace WPFChart.UC
{
    /// <summary>
    /// Mbps2DChartUC.xaml 的交互逻辑
    /// </summary>
    public partial class Mbps2DChartUC : UserControl
    {
        public Mbps2DChartUC()
        {
            InitializeComponent();
            chart.Diagram.Series.CollectionChanged += VM.Series_CollectionChanged;
        }

        private void btnTest_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            VM.StartTest();
        }

        private void diagram_Zoom(object sender, XYDiagram2DZoomEventArgs e)
        {
            XYDiagram2D diagram = (XYDiagram2D)sender;

            if (e.AxisX.ActualWholeRange.ActualMaxValueInternal == e.NewXRange.Max &&
                e.AxisX.ActualWholeRange.ActualMinValueInternal == e.NewXRange.Min)
                diagram.DefaultPane.AxisXScrollBarOptions.Visible = false;
            else
                diagram.DefaultPane.AxisXScrollBarOptions.Visible = true;
        }
    }
}
