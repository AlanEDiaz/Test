using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiRestfull.Services
{
    public interface IUserEntitiesContext : IDisposable
    {
        DbSet<User> Users { get; }
        int SaveChanges();
        void MarkAsModified(User item);
    }
}
