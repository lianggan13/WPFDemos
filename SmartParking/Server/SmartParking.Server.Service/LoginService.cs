using System.Linq;
using SmartParking.Server.DAL.EFCore;
using SmartParking.Server.Model;

namespace SmartParking.Server.Service
{
    public class LoginService : BaseService, ILoginService
    {
        public LoginService(IEFContext ef) : base(ef)
        {

        }

        public bool Login(string userName, string password)
        {
            IQueryable<SysUser> users = Query<SysUser>(u => u.UserName == userName && u.Password == password);
            return users.Count() == 1;
        }
    }
}