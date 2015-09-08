using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureApiApp.Models
{
    public static class UserStore
    {
        private static readonly IList<User> userStore = new List<User>();

        public static void Add(User user) => userStore.Add(user);
        public static IList<User> GetAllUsers() => userStore;
        public static User GetUserByMail(string email) => userStore.FirstOrDefault(u => u.Email == email);
        public static void Remove(User user)
        {
            var foundUser = GetUserByMail(user.Email);
            if (foundUser != null)
            {
                userStore.Remove(foundUser);
            }
        }

        public static void Update(User user)
        {
            Remove(user);
            Add(user);
        }

    }
}
