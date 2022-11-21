using System;

namespace OfWorcs.Models.UnitOfWorks.User
{
    public class UserWork : IDisposable
    {
        ProductContext productContext;
        private UserRepo userRepo;

        public UserRepo UserRepo
        {
            get
            {
                if (userRepo == null)
                    userRepo = new UserRepo(productContext);
                return userRepo;
            }
        }

        public UserWork()
        {
            productContext = new ProductContext();
        }
        public void Dispose() => GC.SuppressFinalize(this);

    }
}

