using System.Collections.Generic;
using WPFCommon;

namespace WPFTreeView.Model
{
    public class BatchModel : NotifyPropertyChanged
    {
        private string id;
        private bool isSelected = false;
        private bool isExpanded = false;
        private bool isBatchSelected;
        private bool isRenaming = false;
        private bool isDragOver = false;
        private string name;
        private IEnumerable<SingleTemplate> templates;
        private bool isAutoSelect;
        private string info;
        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged("ID");
            }
        }

        public bool IsBatchSelected
        {
            get
            {
                return isBatchSelected;
            }
            set
            {
                isBatchSelected = value;
                OnPropertyChanged("IsBatchSelected");
            }
        }

        public bool IsSelected
        {
            get
            {
                return isSelected;
            }
            set
            {
                isSelected = value;
                OnPropertyChanged("IsSelected");
            }
        }

        public bool IsExpanded
        {
            get
            {
                return isExpanded;
            }
            set
            {
                isExpanded = value;
                OnPropertyChanged("IsExpanded");
            }
        }

        public bool IsRenaming
        {
            get
            {
                return isRenaming;
            }
            set
            {
                isRenaming = value;
                OnPropertyChanged("IsRenaming");
            }
        }
        public bool IsDragOver
        {
            get
            {
                return isDragOver;
            }
            set
            {
                isDragOver = value;
                OnPropertyChanged("IsDragOver");
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public IEnumerable<SingleTemplate> Templates
        {
            get
            {
                return templates;
            }
            set
            {
                templates = value;
                OnPropertyChanged("Templates");
            }
        }
        public bool IsAutoSelect
        {
            get
            {
                return isAutoSelect;
            }
            set
            {
                isAutoSelect = value;
                OnPropertyChanged("IsAutoSelect");
            }
        }
        public string Info
        {
            get
            {
                return info;
            }
            set
            {
                info = value;
                OnPropertyChanged("Info");
            }
        }
        public delegate void BatchSelectChangedHandler(BatchModel self);
        public event BatchSelectChangedHandler OnBatchSelectChanged;
        private void BatchSelectChanged(BatchModel self)
        {
            if (OnBatchSelectChanged != null)
                OnBatchSelectChanged(self);
        }
        public delegate void BatchMouseSelectChangedHandler(BatchModel self);
        public event BatchMouseSelectChangedHandler OnBatchMouseSelect;
        private void BatchMouseSelect(BatchModel self)
        {
            if (OnBatchMouseSelect != null)
                OnBatchMouseSelect(self);
        }
        public void AutoSelectBatch()
        {

        }
    }
}
