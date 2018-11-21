using AutoMapper;
using DataAccess.Contract.Interfaces;
using DA = DataAccess.Contract.Models;
using BL = BusinessLogic.Contract.Models;
using BLI = BusinessLogic.Contract.Interfaces;

namespace BusinessLogic.Services
{
    public class ProductGroupService : BusinessLogicService<BL.ProductGroup, DA.ProductGroup>, BLI.IProductGroupService
    {
        private IProductGroupRepository _repository;
        private IMapper _mapper;

        public ProductGroupService(IProductGroupRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}
