using AutoMapper;
using DataAccess.Contract.Interfaces;
using DataAccess.EF;
using DataAccess.Contract.Models;

namespace DataAccess.Repositories
{
    public class ProductRepository : DataAccessRepository<Product>, IProductRepository
    {
        private DataAccessContext _context;
        private IMapper _mapper;

        public ProductRepository(DataAccessContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
