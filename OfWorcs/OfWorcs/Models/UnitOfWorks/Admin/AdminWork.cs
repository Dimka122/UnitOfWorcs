using System;

namespace OfWorcs.Models.UnitOfWorks.Admin
{
    public class AdminWork : IDisposable
    {
        ProductContext productContext;
        private AdminRepo adminRepo;

        public AdminRepo AdminRepo
        {
            get
            {
                if (adminRepo == null)
                    adminRepo = new AdminRepo(productContext);
                return adminRepo;
            }
        }

        public AdminWork()
        {
            productContext = new ProductContext();
        }
        public void Dispose() => GC.SuppressFinalize(this);

    }
}