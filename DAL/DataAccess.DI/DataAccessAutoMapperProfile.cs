using AutoMapper;
using BaseModels = DataAccess.Models;
using ContractModels = DataAccess.Contract.Models;

namespace DataAccess.DI
{
    public class DataAccessAutoMapperProfile : Profile
    {
        public DataAccessAutoMapperProfile()
        {
            CreateMap<BaseModels.Department, ContractModels.Department>()
                    .ReverseMap();
            CreateMap<BaseModels.ProductGroup, ContractModels.ProductGroup>()
                    .ReverseMap();
            CreateMap<BaseModels.Product, ContractModels.Product>()
                    .ReverseMap();
        }
    }
}
