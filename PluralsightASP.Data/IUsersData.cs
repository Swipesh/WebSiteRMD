using System.Collections;
using System.Collections.Generic;
using PluralsightASP.Core;

namespace PluralsightASP.Data
{
    public interface IUsersData
    {
        IEnumerable<User> GetUsersByName(string name);
        IEnumerable<User> GetAll();
        User GetById(int id);
        User Update(User updatedUser);
        User Add(User newUser);
        User Delete(int id);
        int Commit();
    }
}