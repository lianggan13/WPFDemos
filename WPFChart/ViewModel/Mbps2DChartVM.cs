using DevExpress.Xpf.Charts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Timers;
using System.Windows;
using WPFChart.Common;
using WPFChart.Model;

namespace WPFChart.ViewModel
{
    public class Mbps2DChartVM : NotifyPropertyChanged
    {
        private double freq;

        public double Freq
        {
            get { return freq; }
            set
            {
                freq = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<MbpsPointModel> MbpsPoints { get; set; } = new ObservableCollection<MbpsPointModel>();
        public ObservableCollection<LegendModel> Legends { get; set; } = new ObservableCollection<LegendModel>();
        public Mbps2DChartVM()
        {
        }

        public void SetFreq(double freq)
        {
            this.Freq = freq;
        }

        public void AddMbpsPoint(MbpsPointModel point)
        {
            Application.Current.Dispatcher.Invoke(() =>
           {
               MbpsPoints.Add(point);
           });
        }

        public void AddMbpsPoint(List<MbpsPointModel> points)
        {
            Application.Current.Dispatcher.Invoke(() =>
           {
               points.ForEach(p =>
               {
                   MbpsPoints.Add(p);
               });
           });
        }

        public void ClearMbpsPoint()
        {
            Application.Current.Dispatcher.Invoke(() =>
           {
               MbpsPoints.Clear();
               Legends.Clear();
           });
        }

        Timer timer = new Timer();
        public void StartTest()
        {
            this.ClearMbpsPoint();

            int startPhi = 0;
            int endPhi = 360;
            int stepPhi = 30;
            List<double> phis = new List<double>();
            for (int i = startPhi; i <= endPhi; i += stepPhi)
            {
                phis.Add(i);
            }

            int startPower = -110;
            int endPower = -80;
            Random rand = new Random();
            foreach (var phi in phis)
            {
                for (int i = startPower; i < endPower; i += 5)
                {
                    int power = i;  //rand.Next(-110, -90);
                    int mbps = rand.Next(0, 100);
                    MbpsPointModel point = new MbpsPointModel()
                    {
                        Phi = phi,
                        Power = power,
                        Mbps = mbps
                    };
                    MbpsPoints.Add(point);
                }
            }

            timer.Interval = 1000 * 2;
            timer.Elapsed += (object sender, ElapsedEventArgs e) =>
            {
                //timer.AutoReset = false;
                double phi = phis.ElementAt(rand.Next(phis.Count));
                double power = MbpsPoints.Max(p => p.Power) + 5;
                int mbps = rand.Next(0, 100);
                MbpsPointModel point = new MbpsPointModel()
                {
                    Phi = phi,
                    Power = power,
                    Mbps = mbps
                };
                AddMbpsPoint(point);
            };

            if (timer.Enabled)
            {
                timer.Stop();
            }
            else
            {
                timer.Start();
            }
        }


        public void Series_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.NewStartingIndex != -1)
            {
                if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                {
                    var series = e.NewItems.OfType<LineSeries2D>().FirstOrDefault();
                    var legend = Legends.FirstOrDefault(xl => xl.Name == series.DisplayName);
                    if (legend == null)
                    {
                        LegendModel nlegd = new LegendModel(series);
                        Legends.Add(nlegd);
                        OrderLegend();
                        SetLegendsStyle();
                    }
                    else
                    {
                        legend.Series = series;
                    }
                }
            }
        }

        public void Legend_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            LegendModel m = (sender as FrameworkElement).Tag as LegendModel;
            m.IsChecked = !m.IsChecked;
            SetLegendsStyle();
        }

        private void OrderLegend()
        {
            List<LegendModel> legs = new List<LegendModel>(Legends.OrderBy(l => l.Phi));

            Legends.Clear();
            foreach (var leg in legs)
            {
                Legends.Add(leg);
            }
        }

        public void SetLegendsStyle()
        {
            var legsEnabled = Legends;

            if (legsEnabled.Any(l => l.IsChecked) == true)
            {
                legsEnabled.Where(l => !l.IsChecked).ToList()
                 .ForEach(c =>
                 {
                     c.Series.CrosshairEnabled = false;
                     c.Series.Brush = c.GenerateSeriesBrush(60);
                 });
            }
            else
            {
                legsEnabled.ToList().ForEach(c =>
                {
                    c.Series.CrosshairEnabled = true;
                    c.Series.Brush = null;
                });
            }

            legsEnabled.Where(l => l.IsChecked).ToList().ForEach(lc =>
            {
                lc.IsChecked = true;
                lc.Series.CrosshairEnabled = true;
                lc.Series.Brush = null;
            });
        }
    }
}
