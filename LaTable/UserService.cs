using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTable
{
    public class UserService
    {
        public List<User> users = new List<User>
        {
            new User("Надежда", "nadejda", "123"),
            new User("Алексей", "aleksey", "123"),
            new User("Сабина", "sabina", "123"),
            new User("Александр А.", "sanya1", "123"),
            new User("Александр Д.", "sanya2", "123"),
            new User("Алла", "alla", "123"),
            new User("Виктория", "vika", "123"),
            new User("Евгения", "zhenya", "123"),
            new User("Жулдуз", "zhyldyz", "123"),
            new User("Лидия", "lidia", "123"),
            new User("Ольга", "olga", "123"),
        };

        public User Authenticate(string login, string password)
        {
            foreach (var user in users)
            {
                if (user.GetLogin() == login && user.GetPassword() == password)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
