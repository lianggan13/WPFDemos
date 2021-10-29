using Microsoft.EntityFrameworkCore;

namespace SmartParking.Server.DAL.EFCore
{
    public class EFCoreContext : DbContext
    {
        private string strConn = string.Empty;   // SqlServer 数据库连接字符串
        public EFCoreContext(string strConn)
        {
            this.strConn = strConn;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(strConn); // 连接数据库
            base.OnConfiguring(optionsBuilder);
        }
    }
}
