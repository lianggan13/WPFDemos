using WPFDataGrid.Common;

namespace WPFDataGrid.Model
{
    public class Angle : NotifyPropertyChanged
    {
        private string start;
        private string end;
        private string step;

        public string Start
        {
            get
            {
                return start;
            }
            set
            {
                start = value;
                OnPropertyChanged("Start");
            }
        }

        public string End
        {
            get
            {
                return end;
            }
            set
            {
                end = value;
                OnPropertyChanged("End");
            }
        }

        public string Step
        {
            get
            {
                return step;
            }
            set
            {
                step = value;
                OnPropertyChanged("Step");
            }
        }


    }
}
