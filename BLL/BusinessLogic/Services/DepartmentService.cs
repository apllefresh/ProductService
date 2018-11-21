using AutoMapper;
using DataAccess.Contract.Interfaces;
using DA = DataAccess.Contract.Models;
using BL = BusinessLogic.Contract.Models;
using BLI = BusinessLogic.Contract.Interfaces;

namespace BusinessLogic.Services
{
    public class DepartmentService : BusinessLogicService<BL.Department, DA.Department>, BLI.IDepartmentService
    {
        private IDepartmentRepository _repository;
        private IMapper _mapper;

        public DepartmentService(IDepartmentRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}
