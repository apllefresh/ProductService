using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using D = DataAccess.Contract.Models;
using B = BusinessLogic.Contract.Models;
using BI = BusinessLogic.Contract.Interfaces;

namespace WebClient.Controllers
{
    [Route("api/productgroup")]
    [ApiController]
    public class ProductGroupController :  GenericController<B.ProductGroup, D.ProductGroup>
    {
        private BI.IProductGroupService _service;

        public ProductGroupController(BI.IProductGroupService service) : base(service)
        {
            _service = service;
        }
    }
}