using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using D = DataAccess.Contract.Models;
using B = BusinessLogic.Contract.Models;
using BI = BusinessLogic.Contract.Interfaces;

namespace WebClient.Controllers
{
    [Route("api/department")]
    [ApiController]
    public class DepartmentController : GenericController<B.Department, D.Department>
    {
        private BI.IDepartmentService _service;

        public DepartmentController(BI.IDepartmentService service) : base(service)
        {
            _service = service;
        }
    }
}