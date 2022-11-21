using System;

namespace OfWorcs.Models.UnitOfWorks.Admin
{
    public interface IAdminRepo<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IDisposable Add(T entity);
        IDisposable Update(T entity);
        IDisposable Delete(T entity);
        
    }
}