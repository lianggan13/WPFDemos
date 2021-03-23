using WPFCommon;

namespace WPFTreeView.Model
{
    public class SingleTemplate : NotifyPropertyChanged
    {
        private string functionId;
        private string functionName;
        /// <summary>
        /// 官方模板id
        /// </summary>
        private string templateId;
        /// <summary>
        /// 测试项ID
        /// </summary>
        private string testId;
        // 测试配置状态
        private int state;
        // 是否被选中
        private bool isSelected;
        /// <summary>
        /// 是否被勾选
        /// </summary>
        private bool isTemplateSelected;
        /// <summary>
        /// 是否可以被勾选
        /// </summary>
        private bool isEnable = true;
        /// <summary>
        /// 是否失效
        /// </summary>
        private bool isAvailable;
        // 是否拖拽
        private bool isDragOver = false;
        /// <summary>
        /// 模板名字
        /// </summary>
        private string name;
        /// <summary>
        /// 内容
        /// </summary>
        private string content;
        /// <summary>
        /// 仪表id
        /// </summary>
        private string meterId;
        /// <summary>
        /// 对应测试集ID
        /// </summary>
        private string parentBatID;
        /// <summary>
        /// 版本号
        /// </summary>
        private string version;
        /// <summary>
        /// 是否正在重命名
        /// </summary>
        private bool isRenaming;
        /// <summary>
        /// 当勾选模板时，对应的测试集应当被勾选
        /// </summary>
        /// <param name="self"></param>
        /// <param name="isAuto"></param>
        public delegate void SelectedHandler(SingleTemplate self);
        public event SelectedHandler OnSelected;
        private void Selected(SingleTemplate self)
        {
            if (OnSelected != null)
                OnSelected(self);
        }
        public delegate void MouseSelectedHandler(SingleTemplate self);
        public event MouseSelectedHandler OnMouseSelected;
        private void MouseSelected(SingleTemplate self)
        {
            if (OnMouseSelected != null)
                OnMouseSelected(self);
        }
        public string FunctionId
        {
            get
            {
                return functionId;
            }
            set
            {
                functionId = value;
            }
        }
        public string FunctionName
        {
            get
            {
                return functionName;
            }
            set
            {
                functionName = value;
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
                if (isSelected)
                    MouseSelected(this);
                OnPropertyChanged("IsSelected");
            }
        }
        public bool IsTemplateSelected
        {
            get
            {
                return isTemplateSelected;
            }
            set
            {
                isTemplateSelected = value;
                Selected(this);
                OnPropertyChanged("IsTemplateSelected");
            }
        }
        public bool IsEnable
        {
            get
            {
                return isEnable;
            }
            set
            {
                isEnable = value;
                OnPropertyChanged("IsEnable");
            }
        }
        public bool IsAvailable
        {
            get
            {
                return isAvailable;
            }
            set
            {
                isAvailable = value;
                if (!isAvailable)
                    IsEnable = false;
                OnPropertyChanged("IsAvailable");
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

        public string TestId
        {
            get
            {
                return testId;
            }
            set
            {
                testId = value;
                OnPropertyChanged("TestId");
            }
        }

        /// <summary>
        /// 单测试模板配置状态 (0:完成 非0:未完成或有异常)
        /// </summary>
        public int State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                OnPropertyChanged(nameof(state));
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

        public string ParentBatID
        {
            get
            {
                return parentBatID;
            }
            set
            {
                parentBatID = value;
                OnPropertyChanged("ParentBatID");
            }
        }

        public string Version
        {
            get
            {
                return version;
            }
            set
            {
                version = value;
                OnPropertyChanged("Version");
            }
        }
        /// <summary>
        /// 官方模板ID
        /// </summary>
        public string TemplateID
        {
            get
            {
                return templateId;
            }
            set
            {
                templateId = value;
            }
        }

        public string Content { get => content; set => content = value; }

        public string MeterID { get => meterId; set => meterId = value; }
    }
}
