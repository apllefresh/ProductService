using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using D = DataAccess.Contract.Models;
using B = BusinessLogic.Contract.Models;
using BI = BusinessLogic.Contract.Interfaces;

namespace WebClient.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : GenericController<B.Product, D.Product>
    {
        private BI.IProductService _service;

        public ProductController(BI.IProductService service) : base(service)
        {
            _service = service;
        }
    }
}