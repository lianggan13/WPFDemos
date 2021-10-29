namespace SmartParking.Server.Common
{
    public interface IConfiguration
    {
        string Read(string key);
    }
}
