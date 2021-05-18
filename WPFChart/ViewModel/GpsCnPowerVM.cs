using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WPFChart.Model;
using WPFCommon;

namespace WPFChart.ViewModel
{
    public class GpsCnPowerVM : NotifyPropertyChanged
    {
        private string formula;
        public string Formula
        {
            get { return formula; }
            set { formula = value; OnPropertyChanged(); }
        }

        public ObservableCollection<GpsCnPowerModel> CnPowerPoints { get; set; } = new ObservableCollection<GpsCnPowerModel>();
        public ObservableCollection<GpsCnPowerModel> FittedPoints { get; set; } = new ObservableCollection<GpsCnPowerModel>();

        public GpsCnPowerVM()
        {

        }

        public void AddGpsCnPowerPoint(GpsCnPowerModel point)
        {
            CnPowerPoints.Add(point);
        }

        public void AddGpsCnPowerPoint(List<GpsCnPowerModel> points)
        {
            points.ForEach(p =>
            {
                CnPowerPoints.Add(p);
            });
        }

        public void AddFittedPoint(GpsCnPowerModel point)
        {
            FittedPoints.Add(point);
        }

        public void AddFittedPoint(List<GpsCnPowerModel> points)
        {
            points.ForEach(p =>
            {
                FittedPoints.Add(p);
            });
        }

        public void ClearAll()
        {
            CnPowerPoints.Clear();
            FittedPoints.Clear();
            Formula = null;
        }

        public void TestCode()
        {
            ClearAll();
            if (CnPowerPoints.Count > 0)
            {

            }
            CnPowerPoints.Add(new GpsCnPowerModel(90, -16));
            CnPowerPoints.Add(new GpsCnPowerModel(97.2, -26));
            CnPowerPoints.Add(new GpsCnPowerModel(99, -30));
            CnPowerPoints.Add(new GpsCnPowerModel(101, -33));
            CnPowerPoints.Add(new GpsCnPowerModel(103, -35));
            CnPowerPoints.Add(new GpsCnPowerModel(104.5, -40));
            CnPowerPoints.Add(new GpsCnPowerModel(106, -43));
            CnPowerPoints.Add(new GpsCnPowerModel(107.2, -45));
            CnPowerPoints.Add(new GpsCnPowerModel(110, -47));
            CnPowerPoints.Add(new GpsCnPowerModel(112, -50));
            CnPowerPoints.Add(new GpsCnPowerModel(115.3, -52));
            CnPowerPoints.Add(new GpsCnPowerModel(120, -54));
            CnPowerPoints.Add(new GpsCnPowerModel(130, -56));

            FittedPoints.Add(CnPowerPoints.OrderBy(g => g.Cn).First());
            FittedPoints.Add(CnPowerPoints.OrderBy(g => g.Cn).Last());

            Formula = "f(x)=ax+b";
        }
    }
}
