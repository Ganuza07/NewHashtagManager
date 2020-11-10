using NewHashtagManager.Models;
using NewHashtagManager.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NewHashtagManager.Services
{
    public class PosteoService : IBaseRepository<Posteo>
    {
        private readonly Context _context;
        public PosteoService(Context context)
        {
            _context = context;
        }
        public Posteo Add(Posteo entity)
        {
            _context.Posts.Add(entity);
            return entity;
        }

        public void Delete(Guid entity)
        {
            var posteoToDelete = _context.Posts.Find(entity);
            _context.Remove(posteoToDelete);
        }

        public IQueryable<Posteo> GetAll()
        {
            var posteoMapped = _context.Posts.OrderByDescending(x => x.DatePost);
            return posteoMapped;
        }

        public Posteo GetById(Guid entity)
        {
            return _context.Posts.Find(entity);
        }
        public IEnumerable<Posteo> GetQuery(Func<Posteo, bool> expression)
        {
            return _context.Posts.Where(expression);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public Posteo Update(Posteo entity)
        {
            throw new NotImplementedException();
        }
    }
}
