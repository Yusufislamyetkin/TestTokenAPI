using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyAuthServer.Core.UnitOfWork;

namespace UdemyAuthServer.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        AppDbContext _db;
        public UnitOfWork(AppDbContext db)
        {
            _db = db;
        }

        public void SaveChanges()
        {
            _db.SaveChanges(); 
        }

        public async Task SaveChangesAsync()
        {
           await  _db.SaveChangesAsync();
        }
    }
}
