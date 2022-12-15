using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekSiparis.Interfaces
{
    public interface IUser
    {
        List<USER> GetAllUserList();
        List<USER> GetUserWithName(string name);
        USER GetUserWithId(int id);
        List<USER> GetUserWithSurname(string surname);

        void AddUser(USER user);
        void UpdateUser(USER user);

        void DeleteUser(int id);

    }
}
