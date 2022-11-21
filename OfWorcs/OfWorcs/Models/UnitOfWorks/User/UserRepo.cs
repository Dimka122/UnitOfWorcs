using System;

namespace OfWorcs.Models.UnitOfWorks.User
{
    public class UserRepo : IUserRepo<Product>
    {
        private ProductContext context;
        public UserRepo(ProductContext context)
        {
            this.context = context;
        }
        public Product Get(int id) => context.Products.Find(id);
        public IEnumerable<Product> GetAll() => context.Products;
    }
}

