using System.ComponentModel;

namespace WPFDataGrid.Common
{
    public class NotifyPropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;//属性改变事件

        /// <summary>
        /// 属性改变时触发
        /// </summary>
        /// <param name="propertyName"></param>
        virtual internal protected void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
