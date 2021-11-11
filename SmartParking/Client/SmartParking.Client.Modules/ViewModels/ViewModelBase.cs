using System.Linq;
using Prism.Commands;
using Prism.Regions;
using SmartParking.Client.Common;
using Unity;

namespace SmartParking.Client.Modules.ViewModels
{
    public abstract class ViewModelBase : INavigationAware
    {
        protected IUnityContainer unityContainer;

        protected IRegionManager regionManager;

        public string NavUri { get; set; }
        public virtual string PageTitle { get; set; }
        public bool IsCanClose { get; set; } = true;

        public ViewModelBase(IUnityContainer unityContainer, IRegionManager regionManager)
        {
            this.unityContainer = unityContainer;
            this.regionManager = regionManager;
        }

        /// <summary>
        /// TabItem 关闭
        /// </summary>
        public DelegateCommand<string> CloseCommand
        {
            get => new DelegateCommand<string>(arg =>
            {
                var registration = unityContainer.Registrations.FirstOrDefault(r => r.Name == NavUri);
                string typeName = registration.MappedToType.Name;
                var region = regionManager.Regions[ConstString.MainContentRegion];
                var view = region.Views.FirstOrDefault(v => v.GetType().Name == typeName);
                if (view != null)
                {
                    region.Remove(view);
                }
            });
        }

        #region 导航方法组
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            NavUri = navigationContext.Uri.ToString();
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            // 允许跳转
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }
        #endregion
    }
}
