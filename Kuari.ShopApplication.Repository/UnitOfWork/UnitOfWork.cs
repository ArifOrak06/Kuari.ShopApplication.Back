using Kuari.ShopApplication.Core.UnitOfWork;
using Kuari.ShopApplication.Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.ShopApplication.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShopApplicationContext _context;
        
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
