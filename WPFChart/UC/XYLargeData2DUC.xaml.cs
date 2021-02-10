using DevExpress.Xpf.Charts;
using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Resources;
using WPFChart.Common;



namespace WPFChart.UC
{
    /// <summary>
    /// XYLargeData2DUC.xaml 的交互逻辑
    /// </summary>
    public partial class XYLargeData2DUC : UserControl
    {
        public XYLargeData2DUC()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty ChartPaletteProperty = DependencyProperty.Register("ChartPalette", typeof(Palette), typeof(XYLargeData2DUC), new PropertyMetadata(OnChartPaletteChanged));

        static void OnChartPaletteChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            XYLargeData2DUC demo = d as XYLargeData2DUC;
            if (demo != null)
                demo.ColorizeSeries();
        }

        const int OthersSeriesIndex = 29;

        SeriesCollection SeriesCollection
        {
            get { return this.chart.Diagram.Series; }
        }
        public Palette ChartPalette
        {
            get { return (Palette)GetValue(ChartPaletteProperty); }
            set { SetValue(ChartPaletteProperty, value); }
        }

        void OnApplicationThemeChanged(DependencyObject sender, ThemeChangedRoutedEventArgs e)
        {
            ColorizeSeries();
        }
        void chart_BoundDataChanged(object sender, RoutedEventArgs e)
        {
            if (SeriesCollection.Count == 0)
                return;
            //int seriesCount = SeriesCollection.Count;
            //ColorizeSeries();
            //for (int i = 0; i < seriesCount; i++)
            //{
            //    LineSeries2D lineSeries = (LineSeries2D)SeriesCollection[i];
            //    DependencyPropertyDescriptor descriptor = DependencyPropertyDescriptor.FromProperty(Series.CheckedInLegendProperty, typeof(Series));
            //    descriptor.AddValueChanged(lineSeries, OnCheckedInLegendChanged);
            //    if (i < OthersSeriesIndex)
            //        SeriesCollection[i].ShowInLegend = false;
            //    else if (i == OthersSeriesIndex)
            //        lineSeries.LegendTextPattern = "Others";
            //    else if (i == SeriesCollection.Count - 1)
            //    {
            //        if (lineSeries != null)
            //        {
            //            if (lineSeries.LineStyle != null)
            //                lineSeries.LineStyle.Thickness = 5;
            //            lineSeries.FirstPoint = new SidePoint() { LabelDisplayMode = SidePointDisplayMode.SeriesPoint };
            //            lineSeries.FirstPoint.Label = new SeriesLabel() { TextPattern = "{V:0.000M km²}" };
            //            lineSeries.LastPoint = new SidePoint() { LabelDisplayMode = SidePointDisplayMode.SeriesPoint };
            //            lineSeries.LastPoint.Label = new SeriesLabel() { TextPattern = "{V:0.000M km²}" };
            //            lineSeries.ActualLabel.TextPattern = "{FullDate:MM/dd/yyyy}\n{V:0.000M km²}";
            //        }
            //    }
            //}
        }

        void ColorizeSeries()
        {
            int seriesCount = SeriesCollection.Count;
            if (ChartPalette == null)
                return;
            Color color = ChartPalette[0];
            for (int i = 0; i < seriesCount; i++)
            {
                LineSeries2D series = (LineSeries2D)SeriesCollection[i];
                Color seriesColor = ColorUtils.ColorizeSeaIceSeries(color, seriesCount - i, DevExpress.Xpf.Core.ApplicationThemeHelper.ApplicationThemeName);
                SolidColorBrush brush = new SolidColorBrush(seriesColor);
                brush.Freeze();
                series.Brush = brush;
            }
        }

        void OnCheckedInLegendChanged(object sender, EventArgs e)
        {
            LineSeries2D series = sender as LineSeries2D;
            if (series == null || SeriesCollection.IndexOf(series) != OthersSeriesIndex)
                return;
            for (int i = 0; i < SeriesCollection.Count; i++)
                if (i < OthersSeriesIndex)
                    SeriesCollection[i].Visible = series.CheckedInLegend;
        }

        void ChartsDemoModule_ModuleLoaded(object sender, RoutedEventArgs e)
        {
            ThemeManager.ApplicationThemeChanged += OnApplicationThemeChanged;
        }

        void ChartsDemoModule_ModuleUnloaded(object sender, RoutedEventArgs e)
        {
            ThemeManager.ApplicationThemeChanged -= OnApplicationThemeChanged;
            foreach (Series series in SeriesCollection)
            {
                DependencyPropertyDescriptor descriptor = DependencyPropertyDescriptor.FromProperty(Series.CheckedInLegendProperty, typeof(Series));
                descriptor.RemoveValueChanged(series, OnCheckedInLegendChanged);
            }
        }
    }

    static class SeaIceAreaDataReader
    {
        public static List<SeaIceAreaDataPoint> ReadDataFromFile()
        {
            List<SeaIceAreaDataPoint> dataSource = new List<SeaIceAreaDataPoint>();
            //StreamResourceInfo info = Application.GetResourceStream(new Uri("/GTS.MaxSign.Browser;component/Data/nsidc_global_nt_final_and_nrt.dat", UriKind.RelativeOrAbsolute));
            StreamResourceInfo info = Application.GetResourceStream(new Uri("pack://application:,,,/Data/nsidc_global_nt_final_and_nrt.dat", UriKind.RelativeOrAbsolute));
            using (StreamReader reader = new StreamReader(info.Stream))
            {
                try
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (line[0] != '1' && line[0] != '2')
                            continue;
                        string[] cells = line.Split(new string[] { ", " }, StringSplitOptions.None);
                        if (cells[3].Trim() == "nan")
                            continue;
                        string year = cells[0].Split('-')[0];
                        double dayOfYear = double.Parse(cells[1], CultureInfo.InvariantCulture);
                        double area = double.Parse(cells[3], CultureInfo.InvariantCulture);
                        dataSource.Add(new SeaIceAreaDataPoint(System.Convert.ToDateTime(cells[0], CultureInfo.InvariantCulture), year, dayOfYear, area));
                    }
                }
                catch
                {
                    throw new Exception("It's impossible to load " + "nsidc_global_nt_final_and_nrt.dat");
                }
            }

            for (int i = 0; i < dataSource.Count; i++)
            {
                int index = -150 + i;
                dataSource[i].Index = index;
            }

            return dataSource;
        }
    }


    public class SeaIceAreaDataPoint
    {
        public DateTime FullDate { get; private set; }
        public string Year { get; private set; }
        public double DayOfYear { get; private set; }
        public double IceArea { get; private set; }
        public int Index { get; set; }
        internal SeaIceAreaDataPoint(DateTime fullDate, string year, double dayOfYear, double iceArea)
        {
            FullDate = fullDate;
            Year = year;
            DayOfYear = dayOfYear;
            IceArea = iceArea;
        }
    }

}
