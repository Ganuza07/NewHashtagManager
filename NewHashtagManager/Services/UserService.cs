using Microsoft.EntityFrameworkCore;
using NewHashtagManager.Models;
using NewHashtagManager.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NewHashtagManager.Services
{
    public class UserService : IBaseRepository<User>
    {
        private readonly Context _context;
        public UserService(Context context)
        {
            _context = context;
        }
        public User Add(User entity)
        {
            _context.Users.Add(entity);
            return entity;
        }

        public void Delete(Guid entity)
        {
            var userToDelete = _context.Users.Find(entity);
            _context.Users.Remove(userToDelete);
        }

        public IQueryable<User> GetAll()
        {
            return _context.Users.Include(x => x.PostsList);
        }

        public User GetById(Guid entity)
        {
            var user = _context.Users.Find(entity);
            return user;
        }

        public IEnumerable<User> GetQuery(Func<User, bool> expression)
        {
            return _context.Users.Where(expression);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public User Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
