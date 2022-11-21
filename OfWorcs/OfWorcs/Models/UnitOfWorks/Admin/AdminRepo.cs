using Microsoft.EntityFrameworkCore;
using System;

namespace OfWorcs.Models.UnitOfWorks.Admin
{
    public class AdminRepo : IAdminRepo<Product>
    {
        private ProductContext context;
        public AdminRepo(ProductContext context)
        {
            this.context = context;
        }
        public Product Get(int id) => context.Products.Find(id);
        public IEnumerable<Product> GetAll() => context.Products;
        public IDisposable Add(Product entity)
        {
            context.Products.Add(entity);
            return (IDisposable)this;
        }
        public IDisposable Update(Product entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            return (IDisposable)this;
        }
        public IDisposable Delete(Product entity)
        {
            context.Products.Remove(entity);
            return (IDisposable)this;
        }
    }
}
