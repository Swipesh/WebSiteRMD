using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PluralsightASP.Core;

namespace PluralsightASP.Data
{
    public class SqlUsersData : IUsersData
    {

        private readonly PluralsightASPDbContext _dbContext;

        public SqlUsersData(PluralsightASPDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<User> GetUsersByName(string name)
        {
            var query = _dbContext.Users.Where(user => user.Name.StartsWith(name) || string.IsNullOrEmpty(name)).OrderBy(u => u.Name);
            return query;
        }

        public IEnumerable<User> GetAll()
        {
            var query = _dbContext.Users.OrderBy(u => u.Name);
            return query;
        }

        public User GetById(int id)
        {
            return _dbContext.Users.Find(id);
        }

        public User Update(User updatedUser)
        {
            var entity = _dbContext.Users.Attach(updatedUser);
            entity.State = EntityState.Modified;
            return updatedUser;
        }

        public User Add(User newUser)
        {
            _dbContext.Add(newUser);
            return newUser;
        }

        public User Delete(int id)
        {
            var user = GetById(id);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
            }

            return user;
        }

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }
    }
}