using CapMobileWebApp.DAL.Context;
using CapMobileWebApp.DAL.Model;

namespace CapMobileWebApp.Services
{
    public class UserService
    {
        CapRetailContext _capRetailContext;
        public UserService(CapRetailContext capRetailContext)
        {
            _capRetailContext = capRetailContext;
        }

        public UserInfo GetUserInfo(string username, string password)
        {
            return _capRetailContext.UserInfo.FirstOrDefault(e => e.Username == username && e.Apassword == password);
        }
    }
}
