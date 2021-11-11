using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using SmartParking.Client.Common;
using SmartParking.Client.Modules.Views;

namespace SmartParking.Client.Modules
{
    public class MainModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            // 添加组件 至 对应区域
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(ConstString.LeftMenuTreeRegion, typeof(TreeMenuView));
            regionManager.RegisterViewWithRegion(ConstString.MainHeaderRegion, typeof(MainHeaderView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<TreeMenuView>();
            containerRegistry.Register<MainHeaderView>();

            containerRegistry.RegisterForNavigation<UserManagementView>();

            containerRegistry.RegisterDialog<UserModifyDialog>();
        }
    }
}
