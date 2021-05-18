using DevExpress.Xpf.Charts;
using GTS.MaxSign.Controls.ViewModel;
using System.Windows.Controls;


namespace GTS.MaxSign.Controls.UC
{
    /// <summary>
    /// Mbps2DChartUC.xaml 的交互逻辑
    /// </summary>
    public partial class Mbps2DChartUC : UserControl
    {
        public Mbps2DChartVM VMChart { get => VM; }
        public Mbps2DChartUC()
        {
            InitializeComponent();
            chart.Diagram.Series.CollectionChanged += VM.Series_CollectionChanged;
        }

        private void diagram_Zoom(object sender, XYDiagram2DZoomEventArgs e)
        {

        }


        private void Legend_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            //VM.Legend_MouseDown(sender, e);
        }

        private void XYDiagram2D_Zoom(object sender, XYDiagram2DZoomEventArgs e)
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
