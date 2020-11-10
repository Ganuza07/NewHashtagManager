using Microsoft.EntityFrameworkCore;
using NewHashtagManager.Domain.Entities.Models;

namespace NewHashtagManager.Domain.Context
{
    interface IHashtagContext
    {
        DbSet<Posteo> Posts { get; set; }
        DbSet<User> Users { get; set; }
        int SaveChanges();
    }
}
