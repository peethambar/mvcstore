using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
namespace BAL
{
    public class UserRepository : IUserRepository
    {
        DatabaseContext db = new DatabaseContext();
        public UserViewModel ValidateUser(LoginViewModel model)
        {
            User user = db.Users.Where(u => u.Username == model.Username && u.Password == model.Password).FirstOrDefault();

            UserViewModel obj = new UserViewModel();
            if (user != null)
            {
                obj.UserId = user.UserId;
                obj.Username = user.Username;
                obj.Name = user.Name;
                obj.Roles = user.Roles.Select(r => r.Name).ToArray();
            }
            return obj;
        }
    }
}
