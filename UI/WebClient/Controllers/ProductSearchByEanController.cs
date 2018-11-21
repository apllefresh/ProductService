using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Contract.Interfaces;
using Newtonsoft.Json;

namespace WebClient.Controllers
{
    [Route("api/ProductSearchByEan")]
    [ApiController]
    public class ProductSearchByEanController : ControllerBase
    {

        private readonly IProductService _service;

        public ProductSearchByEanController(IProductService service)
        {
            _service = service;
        }

        [HttpGet("{ean}")]
        public async Task<IActionResult> GetItemByEan(string ean)
        {
            try
            {
                var service = await _service.GetItemByEan(ean).ConfigureAwait(false);
                return service == null
                    ? throw new Exception()
                    : Ok(JsonConvert.SerializeObject(service.Name)); 
            }
            catch
            {
                return null;
            }
        }
    }
}