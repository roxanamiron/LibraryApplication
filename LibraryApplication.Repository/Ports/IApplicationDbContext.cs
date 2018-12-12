using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Domain.Ports
{
    public interface IApplicationDbContext : IDisposable
    {
        IQueryable<T> Query<T>() where T : class;
    } 
           
    
}
