using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAuthServer.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        //UnitOfWork Toplu savechanges işlemini yapar bu sayede roleback işlemi için ekstra kod yazmaktan kurtuluruz.
        Task SaveChangesAsync();
        void SaveChanges();
    }
}
