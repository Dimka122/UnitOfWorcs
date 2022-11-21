using System;
using Microsoft.AspNetCore.Mvc;
using OfWorcs.Models.UnitOfWorks.User;
using OfWorcs.Models;

namespace OfWorcs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        UserWork work;
        public ProductController()
        {
            work = new UserWork();
        }
        [HttpGet]
        public IEnumerable<object> GetAll() => work.UserRepo.GetAll();
        [HttpGet("id")]
        public object GetById(int id) => work.UserRepo.Get(id);
    }
}

