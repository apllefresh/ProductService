using AutoMapper;
using DataAccess.Contract.Interfaces;
using DataAccess.EF;
using DataAccess.Contract.Models;

namespace DataAccess.Repositories
{
    public class DepartmentRepository : DataAccessRepository<Department>, IDepartmentRepository
    {
        private DataAccessContext _context;
        private IMapper _mapper;

        public DepartmentRepository(DataAccessContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
