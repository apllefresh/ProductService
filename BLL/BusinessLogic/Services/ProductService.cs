using AutoMapper;
using DataAccess.Contract.Interfaces;
using DA = DataAccess.Contract.Models;
using BL = BusinessLogic.Contract.Models;
using BLI = BusinessLogic.Contract.Interfaces;
using System.Threading.Tasks;
using System.Linq;

namespace BusinessLogic.Services
{
    public class ProductService : BusinessLogicService<BL.Product, DA.Product>, BLI.IProductService
    {
        private IProductRepository _repository;
        private IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<BL.Product> GetItemByEan(string ean)
        {
            var items = await _repository.Find(p=> p.Ean == ean).ConfigureAwait(false);
            return items.Select(item => _mapper.Map<BL.Product>(item)).FirstOrDefault();
        }
    }
}
