namespace WPFDataGrid.Model
{
    public class Employee //: NotifyPropertyChanged
    {
        //{ Id = 1, Name = "Jim", Salary = 2500.50f });
        private int id;
        private string name;
        private double salary;
        public int ID
        {
            get { return id; }
            set
            {
                id = value;
                // OnPropertyChanged("ID");
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                // OnPropertyChanged("Name");
            }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                salary = value;
                // OnPropertyChanged("Salary");
            }
        }
    }
}
