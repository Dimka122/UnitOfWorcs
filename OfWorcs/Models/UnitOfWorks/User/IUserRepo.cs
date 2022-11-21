using System;

namespace OfWorcs.Models.UnitOfWorks.User
{
    public interface IUserRepo<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}

