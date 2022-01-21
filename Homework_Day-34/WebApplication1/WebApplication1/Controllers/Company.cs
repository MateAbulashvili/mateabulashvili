using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.models;
using WebApplication1.services;

using WebApplication1.Exceptions;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Company : ControllerBase
    {
        private IDBProvider<myCompany> _service1;
        public Company(IDBProvider<myCompany> service1)
        {
            
            _service1 = service1;
            service1.Add(new myCompany() { ID = Guid.NewGuid(), Name = "Merrde", Year = 2000 });
            service1.Add(new myCompany() { ID = Guid.NewGuid(), Name = "Nike", Year = 1998 });
        }

        [HttpGet]
        public List<myCompany> getAll()
        {

            return _service1.GetAll();
        }
        [HttpGet("{id}")]
        public List<myCompany> getCompany(Guid id)
        {
            return _service1.GetAll().Where((c) => c.ID == id).ToList();

        }
       
    }
}
