using SmartParking.Server.Common;

namespace SmartParking.Server.DAL.EFCore
{
    public class EFContext : IEFContext
    {
        private IConfiguration configuration;
        public EFContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public EFCoreContext CreateDBContext()
        {
            string strConn = configuration.Read("DBConnectStr");
            return new EFCoreContext(strConn);
        }
    }


}
