namespace SmartParking.Server.DAL.EFCore
{
    public interface IEFContext
    {
        EFCoreContext CreateDBContext();
    }
}