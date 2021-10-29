namespace SmartParking.Server.Service
{
    interface ILoginService : IBaseService
    {
        bool Login(string userName, string password);
    }
}
